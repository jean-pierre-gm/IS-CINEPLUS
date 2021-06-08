import {Component, Inject, OnInit} from '@angular/core';
import {MAT_DIALOG_DATA, MatDialogRef} from "@angular/material/dialog";
import {CineplusDataSource} from "../../../../models/cineplusDataSource";
import {HttpClient} from "@angular/common/http";
import {PersonalDiscount} from "../../../../models/personalDiscount";
import {DataSourceConf} from "../../../../models/dataSourceConf";
import {AbstractControl, Form, FormControl, FormGroup, ValidationErrors, ValidatorFn, Validators} from "@angular/forms";
import {Pagination} from "../../../../models/pagination";
import {DateDiscount} from "../../../../models/dateDiscount";
import {isDate, isNumeric} from "rxjs/internal-compatibility";

@Component({
  selector: 'app-create-personalDiscount',
  templateUrl: './create-personalDiscount.component.html',
  styleUrls: ['./create-personalDiscount.component.css']
})
export class CreatePersonalDiscountComponent implements OnInit {

  public edit = this.data.edit
  public personalDiscount = this.data.personalDiscount

  public nameControl: FormControl = new FormControl('',
    [Validators.required]);
  public descriptionControl: FormControl = new FormControl('',
    [Validators.required]);
  public discountControl: FormControl = new FormControl('',
    [Validators.required, Validators.min(0.1), Validators.max(100)])
  private controls: FormGroup = new FormGroup({
    "description": this.descriptionControl,
    "discount": this.discountControl,
    "name": this.nameControl,
  })

  constructor(
    private httpClient: HttpClient,
    public dialogRef: MatDialogRef<CreatePersonalDiscountComponent>,
    @Inject(MAT_DIALOG_DATA) public data: {personalDiscount: PersonalDiscount, edit: boolean}) {
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

  ngOnInit() {
  }

  onSubmitClick() {
    if (this.controls.valid) {
      this.dialogRef.close(this.personalDiscount);
    } else {
      console.log(this.controls.errors)
    }
  }
}
