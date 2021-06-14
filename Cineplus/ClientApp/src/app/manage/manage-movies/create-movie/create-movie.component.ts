import {Component, Inject, OnInit} from '@angular/core';
import {MAT_DIALOG_DATA, MatDialogRef} from "@angular/material/dialog";
import {Movie} from "../../../../models/movie";
import {Genre} from "../../../../models/genre";
import {CineplusDataSource} from "../../../../models/cineplusDataSource";
import {HttpClient} from "@angular/common/http";
import {DataSourceConf} from "../../../../models/dataSourceConf";
import {AbstractControl, Form, FormControl, FormGroup, ValidationErrors, ValidatorFn, Validators} from "@angular/forms";
import {Pagination} from "../../../../models/pagination";

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

  constructor(
    private httpClient: HttpClient,
    public dialogRef: MatDialogRef<CreateMovieComponent>,
    @Inject(MAT_DIALOG_DATA) public data: {movie: Movie, edit: boolean}) {

    let conf = new DataSourceConf();
    conf.endPoint = 'api/genre';
    let pagination = new Pagination<Genre>();
    pagination.pageSize = 20;
    this.genreDataSource = new CineplusDataSource<Genre>(httpClient, conf, pagination);
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

  ngOnInit() {
    if (this.movie.genre) {
      this.autocompleteControl.setValue(this.movie.genre.genreName)
    }

    this.autocompleteControl.valueChanges.subscribe(value => {
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
      return this.movie.genre && this.movie.genre.genreName == control.value ? null : {'genreNotSelected': { value: control.value }};
    };
  }

  onSubmitClick() {
    if (this.controls.valid) {
      this.dialogRef.close(this.movie);
    } else {
      console.log(this.controls.errors)
    }
  }
}
