import {Component, Inject, OnInit} from '@angular/core';
import {CineplusDataSource} from "../../../../models/cineplusDataSource";
import {Genre} from "../../../../models/genre";
import {AbstractControl, FormControl, FormGroup, ValidationErrors, ValidatorFn, Validators} from "@angular/forms";
import {HttpClient} from "@angular/common/http";
import {MAT_DIALOG_DATA, MatDialogRef} from "@angular/material/dialog";
import {Movie} from "../../../../models/movie";
import {DataSourceConf} from "../../../../models/dataSourceConf";
import {Pagination} from "../../../../models/pagination";

@Component({
  selector: 'app-create-genre',
  templateUrl: './create-genre.component.html',
  styleUrls: ['./create-genre.component.css']
})
export class CreateGenreComponent implements OnInit {

  public edit = this.data.edit
  public movie = this.data.genre
  public nameControl: FormControl = new FormControl('',
    [Validators.required]);
  public descriptionControl: FormControl = new FormControl('',
    [Validators.required])
  private controls: FormGroup = new FormGroup({
    "name": this.nameControl,
    "description": this.descriptionControl
  })

  constructor(
    private httpClient: HttpClient,
    public dialogRef: MatDialogRef<CreateGenreComponent>,
    @Inject(MAT_DIALOG_DATA) public data: {genre: Genre, edit: boolean}) {
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

  ngOnInit() {
  }

  onSubmitClick() {
    if (this.controls.valid) {
      this.dialogRef.close(this.movie);
    } else {
      console.log(this.controls.errors)
    }
  }
}
