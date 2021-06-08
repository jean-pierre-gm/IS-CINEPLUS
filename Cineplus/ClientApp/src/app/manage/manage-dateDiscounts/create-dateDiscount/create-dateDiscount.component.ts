import {Component, Inject, OnInit} from '@angular/core';
import {MAT_DIALOG_DATA, MatDialogRef} from "@angular/material/dialog";
import {CineplusDataSource} from "../../../../models/cineplusDataSource";
import {HttpClient} from "@angular/common/http";
import {DataSourceConf} from "../../../../models/dataSourceConf";
import {AbstractControl, Form, FormControl, FormGroup, ValidationErrors, ValidatorFn, Validators} from "@angular/forms";
import {Pagination} from "../../../../models/pagination";
import {DateDiscount} from "../../../../models/dateDiscount";
import {isDate, isNumeric} from "rxjs/internal-compatibility";

@Component({
  selector: 'app-create-dateDiscount',
  templateUrl: './create-dateDiscount.component.html',
  styleUrls: ['./create-dateDiscount.component.css']
})
export class CreateDateDiscountComponent implements OnInit {

  public edit = this.data.edit
  public dateDiscount = this.data.dateDiscount

  public descriptionControl: FormControl = new FormControl('',
    [Validators.required]);
  public discountControl: FormControl = new FormControl('',
    [Validators.required, Validators.min(0.1), Validators.max(100)])
  public dateControl: FormControl = new FormControl('',
    [Validators.required])
  private controls: FormGroup = new FormGroup({
    "description": this.descriptionControl,
    "discount": this.discountControl,
    "date": this.dateControl,
  })

  constructor(
    private httpClient: HttpClient,
    public dialogRef: MatDialogRef<CreateDateDiscountComponent>,
    @Inject(MAT_DIALOG_DATA) public data: {dateDiscount: DateDiscount, edit: boolean}) {
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

  ngOnInit() {
  }

  onSubmitClick() {
    if (this.controls.valid) {
      this.dialogRef.close(this.dateDiscount);
    } else {
      console.log(this.controls.errors)
    }
  }
}
