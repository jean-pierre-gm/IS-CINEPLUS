import {Component, Inject, OnInit} from '@angular/core';
import {MAT_DIALOG_DATA, MatDialogRef} from "@angular/material/dialog";
import {CineplusDataSource} from "../../../../models/cineplusDataSource";
import {HttpClient, HttpParams} from "@angular/common/http";
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
  public validDate = true

  public descriptionControl: FormControl = new FormControl('',
    [Validators.required]);
  public discountControl: FormControl = new FormControl('',
    [Validators.required, Validators.min(0.1), Validators.max(100)])
  public dateControl: FormControl = new FormControl('',
    [Validators.required, this.dateValidator()])
  private controls: FormGroup = new FormGroup({
    "description": this.descriptionControl,
    "discount": this.discountControl,
    "date": this.dateControl
  })

  constructor(
    private httpClient: HttpClient,
    public dialogRef: MatDialogRef<CreateDateDiscountComponent>,
    @Inject('BASE_URL') private baseUrl: string,
    @Inject(MAT_DIALOG_DATA) public data: {dateDiscount: DateDiscount, edit: boolean}) {
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

  ngOnInit() {
    if (this.dateDiscount) {
      this.dateControl.setValue(this.dateDiscount.date)
      this.validDate = true;
    }

    this.dateControl.valueChanges.subscribe(value => {
      if (value == "" || !value) {
        this.validDate = true;
      } else {
        if(isDate(value)) {
          if (!this.edit) {
            let date = new Date(value);
            this.httpClient.get(this.baseUrl + 'api/datediscount/' + date.getDate() + '-' + (date.getMonth() + 1), {}).toPromise()
              .then(response => {
                  this.validDate = false;
                },
                error => {
                  this.validDate = true;
                });
          }
        }
      }
    })
  }

  onSubmitClick() {
    if (this.controls.valid) {
      this.dialogRef.close(this.dateDiscount);
    } else {
      console.log(this.controls.errors)
    }
  }

  dateValidator(): ValidatorFn {
    return (control: AbstractControl): ValidationErrors | null => {
      return this.validDate ? null : {'This date is already taked': {value: control.value}};
    };
  }
}
