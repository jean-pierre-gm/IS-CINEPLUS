import {Component, ElementRef, Inject, OnInit, ViewChild} from '@angular/core';
import {MAT_DIALOG_DATA, MatDialogRef} from "@angular/material/dialog";
import {Movie} from "../../../../models/movie";
import {Genre} from "../../../../models/genre";
import {CineplusDataSource} from "../../../../models/cineplusDataSource";
import {HttpClient} from "@angular/common/http";
import {DataSourceConf} from "../../../../models/dataSourceConf";
import {AbstractControl, Form, FormControl, FormGroup, ValidationErrors, ValidatorFn, Validators} from "@angular/forms";
import {Pagination} from "../../../../models/pagination";
import {COMMA, ENTER} from '@angular/cdk/keycodes';
import {Actor} from "../../../../models/actor";
import {MatAutocomplete, MatAutocompleteSelectedEvent} from "@angular/material/autocomplete";


@Component({
  selector: 'app-create-movie',
  templateUrl: './create-movie.component.html',
  styleUrls: ['./create-movie.component.css']
})
export class CreateMovieComponent implements OnInit {

  public edit = this.data.edit
  public movie = this.data.movie
  public genreDataSource: CineplusDataSource<Genre>;
  public autocompleteControl: FormControl = new FormControl("",
    [Validators.required, this.genreValidator()]);
  public nameControl: FormControl = new FormControl('',
    [Validators.required]);
  public directorControl: FormControl = new FormControl('',
    [Validators.required])
  public durationControl: FormControl = new FormControl('',
    [Validators.required, Validators.min(1)])
  public scoreControl: FormControl = new FormControl('',
    [Validators.required, Validators.min(0), Validators.max(10)])
  public imageControl: FormControl = new FormControl('',
    [Validators.required])
  public descriptionControl: FormControl = new FormControl('',
    [Validators.required])
  private controls: FormGroup = new FormGroup({
    "name": this.nameControl,
    "director": this.directorControl,
    "duration": this.durationControl,
    "score": this.scoreControl,
    "autocomplete": this.autocompleteControl
  })

  visible = true;
  selectable = true;
  removable = true;
  addOnBlur = true;
  separatorKeysCodes: number[] = [ENTER, COMMA];
  actorFormControl = new FormControl();
  actorDataSource: CineplusDataSource<Actor>;

  @ViewChild('actorInput', {static: false}) actorInput: ElementRef<HTMLInputElement>;
  @ViewChild('autoActor', {static: false}) autoActor: MatAutocomplete;

  constructor(
    private httpClient: HttpClient,
    public dialogRef: MatDialogRef<CreateMovieComponent>,
    @Inject(MAT_DIALOG_DATA) public data: { movie: Movie, edit: boolean }) {

    let genreConf = new DataSourceConf();
    genreConf.endPoint = 'api/genre';
    let genrePagination = new Pagination<Genre>();
    genrePagination.pageSize = 20;
    this.genreDataSource = new CineplusDataSource<Genre>(httpClient, genreConf, genrePagination);

    let actorConf = new DataSourceConf();
    actorConf.endPoint = 'api/actor';
    let actorPagination = new Pagination<Actor>();
    actorPagination.pageSize = 20;
    this.actorDataSource = new CineplusDataSource<Actor>(httpClient, actorConf, actorPagination);
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

  ngOnInit() {
    this.movie.actors = []
    if (this.movie.genre) {
      this.autocompleteControl.setValue(this.movie.genre.genreName)
    }

    if(this.edit){
      let castConf = new DataSourceConf();
      castConf.endPoint = 'api/actor/movie/' + this.movie.id;
      console.log(castConf.endPoint)
      let castPagination = new Pagination<Actor>();
      castPagination.pageSize = 50;
      let castDataSource = new CineplusDataSource<Actor>(this.httpClient, castConf, castPagination);
      castDataSource.refresh().add(() =>{
        for (let i = 0; i < castDataSource.result.length; i++) {
          this.movie.actors.push(castDataSource.result[i])
        }
      })
    }

    this.actorFormControl.valueChanges.subscribe(value => {
      if (value == "" || !value) {
        this.actorDataSource.undoFilters();
      } else {
        this.actorDataSource.filter("name", value)
      }
    })

    this.autocompleteControl.valueChanges.subscribe(value => {
      console.log(value)
      if (value == "" || !value) {
        this.genreDataSource.undoFilters();
      } else {
        this.genreDataSource.filter("name", value).add(() => {
          for (let genre of this.genreDataSource.result) {
            if (genre.genreName == value) {
              this.movie.genre = genre;
              this.autocompleteControl.setValue(value, {emitEvent: false});
              return;
            }
          }
        })
      }
    })
  }

  genreValidator(): ValidatorFn {
    return (control: AbstractControl): ValidationErrors | null => {
      return this.movie.genre && this.movie.genre.genreName == control.value ? null : {'genreNotSelected': {value: control.value}};
    };
  }

  onSubmitClick() {
    if (this.controls.valid) {
      this.dialogRef.close(this.movie);
    } else {
      console.log(this.controls.errors)
    }
  }

  remove(actor: Actor): void {
    const index = this.movie.actors.indexOf(actor);

    if (index >= 0) {
      this.movie.actors.splice(index, 1);
    }
  }

  selected(event: MatAutocompleteSelectedEvent): void {
    let belong = false

    for (let i = 0; i < this.movie.actors.length; i++)
      if(this.movie.actors[i].id == event.option.value['id'])
        belong = true

    if(!belong)
      this.movie.actors.push(event.option.value);

    this.actorInput.nativeElement.value = '';
    this.actorFormControl.setValue(null);
  }
}
