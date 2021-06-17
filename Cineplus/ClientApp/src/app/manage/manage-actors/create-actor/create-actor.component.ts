import {Component, Inject, OnInit} from '@angular/core';
import {CineplusDataSource} from "../../../../models/cineplusDataSource";
import {Genre} from "../../../../models/genre";
import {AbstractControl, FormControl, FormGroup, ValidationErrors, ValidatorFn, Validators} from "@angular/forms";
import {HttpClient} from "@angular/common/http";
import {MAT_DIALOG_DATA, MatDialogRef} from "@angular/material/dialog";
import {Movie} from "../../../../models/movie";
import {DataSourceConf} from "../../../../models/dataSourceConf";
import {Pagination} from "../../../../models/pagination";
import {Actor} from "../../../../models/actor";

@Component({
  selector: 'app-create-actor',
  templateUrl: './create-actor.component.html',
  styleUrls: ['./create-actor.component.css']
})
export class CreateActorComponent implements OnInit {

  public edit = this.data.edit
  public actor = this.data.actor
  public nameControl: FormControl = new FormControl('',
    [Validators.required]);
  private controls: FormGroup = new FormGroup({
    "name": this.nameControl
  })

  constructor(
    private httpClient: HttpClient,
    public dialogRef: MatDialogRef<CreateActorComponent>,
    @Inject(MAT_DIALOG_DATA) public data: {actor: Actor, edit: boolean}) {
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

  ngOnInit() {
  }

  onSubmitClick() {
    if (this.controls.valid) {
      this.dialogRef.close(this.actor);
    } else {
      console.log(this.controls.errors)
    }
  }

}
