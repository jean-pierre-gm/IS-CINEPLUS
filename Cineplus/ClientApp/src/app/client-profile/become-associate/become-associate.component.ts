import {Component, Inject, OnInit} from '@angular/core';
import {FormControl, FormGroup, Validators} from "@angular/forms";
import {HttpClient} from "@angular/common/http";
import {MAT_DIALOG_DATA, MatDialogRef} from "@angular/material/dialog";
import {Genre} from "../../../models/genre";
import {Associate} from "../../../models/associate";
import {NotificationService} from "../../notification.service";

@Component({
  selector: 'app-become-associate',
  templateUrl: './become-associate.component.html',
  styleUrls: ['./become-associate.component.css']
})
export class BecomeAssociateComponent implements OnInit {

  public associate: Associate = new Associate();

  public nameControl: FormControl = new FormControl('',
    [Validators.required]);
  public lastNameControl: FormControl = new FormControl('',
    [Validators.required])
  public phoneControl: FormControl = new FormControl('',
    [Validators.required,Validators.pattern(/([\d]+-?)+/)])
  public addressControl: FormControl = new FormControl('',
    [Validators.required])
  private controls: FormGroup = new FormGroup({
    "name": this.nameControl,
    "lastName": this.lastNameControl,
    "address": this.addressControl,
    "phone": this.phoneControl
  })

  constructor(
    private notificationService: NotificationService,
    private httpClient: HttpClient,
    public dialogRef: MatDialogRef<BecomeAssociateComponent>) {
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

  ngOnInit() {
  }

  onSubmitClick() {
    if (this.controls.valid) {
      this.dialogRef.close(this.associate);
    } else {
      console.log(this.controls.errors)
    }
  }

}
