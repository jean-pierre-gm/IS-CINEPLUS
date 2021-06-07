import {Component, Inject, OnDestroy, OnInit} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {DateDiscount} from "../../../models/dateDiscount";
import {CineplusDataSource} from "../../../models/cineplusDataSource";
import {ActivatedRoute} from "@angular/router";
import {DataSourceConf} from "../../../models/dataSourceConf";
import {isDate, isNumeric} from "rxjs/internal-compatibility";

@Component({
  selector: 'app-date-discount',
  templateUrl: './date-discount.component.html',
  styleUrls: ['./date-discount.component.css']
})
export class DateDiscountComponent implements OnInit, OnDestroy {

  discountsDataSource: CineplusDataSource<DateDiscount>;
  newDateDiscount : DateDiscount;
  modify: boolean[];

  constructor(private http: HttpClient,
              @Inject('BASE_URL') private baseUrl: string,
              private route: ActivatedRoute
  ) {
    let dsConf = new DataSourceConf();
    dsConf.endPoint = baseUrl + 'api/datediscount'
    this.discountsDataSource = new CineplusDataSource<DateDiscount>(http, dsConf);
    this.discountsDataSource.refresh()

    this.modify = new Array(100)
    this.newDateDiscount = new DateDiscount();
  }

  ngOnInit() {
  }

  ngOnDestroy() {
  }

  applyFilter($event: KeyboardEvent) {

  }

  changeEnables(i) {
    this.modify[i] = !this.modify[i];
  }

  resetNewDiscount()
  {
    this.newDateDiscount = new DateDiscount();
  }

  addDiscount($event: MouseEvent) {
    console.log($event)

    if(this.newDateDiscount.description != "" && isDate(new Date(this.newDateDiscount.date)) &&
      isNumeric(this.newDateDiscount.discount))
    {
      this.http.post(this.baseUrl + 'api/datediscount', this.newDateDiscount).toPromise()
        .then(response => {
            this.discountsDataSource.refresh();
          }
        );

      this.newDateDiscount = new DateDiscount();
    }
  }

  editDiscount($event: MouseEvent, discount, index) {
    console.log($event)

    if(discount.description != "" && isDate(new Date(discount.date)) &&
      isNumeric(discount.discount))
    {
      this.http.post(this.baseUrl + 'api/datediscount', discount).toPromise()
        .then(response => {
            this.discountsDataSource.refresh();
          }
        );
    }

    this.changeEnables(index)
  }

  deleteDiscount($event: MouseEvent, discount) {
    console.log($event)

    discount.enabled = !discount.enable;

    this.http.post(this.baseUrl + 'api/datediscount', discount).toPromise()
      .then(response => {
          this.discountsDataSource.refresh();
        }
      );
  }

  editPagination($event) {
    console.log($event)
    this.discountsDataSource.currentPagination.pageSize = $event.pageSize;
    this.discountsDataSource.setPage($event.pageIndex + 1);
    this.modify = new Array(100)
  }
}
