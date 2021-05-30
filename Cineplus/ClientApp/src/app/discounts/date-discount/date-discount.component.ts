import {Component, Inject, OnDestroy, OnInit} from '@angular/core';
import {HttpClient, HttpParams} from "@angular/common/http";
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
  displayedColumns: string[] = ['description', 'discount', 'date'];
  displayedElements: string[] = ['description', 'discount', 'date', 'modify', 'delete']
  newDateDiscount : DateDiscount;

  constructor(private http: HttpClient,
              @Inject('BASE_URL') private baseUrl: string,
              private route: ActivatedRoute
  ) {
    let dsConf = new DataSourceConf();
    dsConf.endPoint = baseUrl + 'api/datediscount'
    this.discountsDataSource = new CineplusDataSource<DateDiscount>(http, dsConf);
    this.discountsDataSource.refresh()

    this.newDateDiscount = new DateDiscount();
  }

  ngOnInit() {
  }

  ngOnDestroy() {
  }

  applyFilter($event: KeyboardEvent) {

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
    }
  }

  deleteDiscount($event: MouseEvent, dateDiscountId) {
    console.log($event)
    let httpParams = new HttpParams().set('id', dateDiscountId);
    this.http.delete(this.baseUrl + 'api/datediscount' + '?' + httpParams.toString(), {}).toPromise()
      .then(response => {
          this.discountsDataSource.refresh();
        }
      );
  }

  enableModify($event: MouseEvent, elementId) {
    let list = [document.getElementById('Ldescription' + elementId),
                document.getElementById('Idescription' + elementId),
                document.getElementById('Ldiscount' + elementId),
                document.getElementById('Idiscount' + elementId),
                document.getElementById('Ldate' + elementId),
                document.getElementById('Idate' + elementId),
                document.getElementById('M' + elementId),
                document.getElementById('U' + elementId)]

    for (let i = 0; i < 8; i++) {
      list[i].hidden = !list[i].hidden;
    }
  }

  editDiscount($event: MouseEvent, discount) {
    console.log($event)

    if(this.newDateDiscount.description != "" && isDate(new Date(this.newDateDiscount.date)) &&
      isNumeric(this.newDateDiscount.discount))
    {
      this.http.post(this.baseUrl + 'api/datediscount', discount).toPromise()
        .then(response => {
            this.discountsDataSource.refresh();
          }
        );
    }

    this.enableModify($event, discount.id)
  }

  resetNewDiscount($event: MouseEvent)
  {
    console.log($event)
    this.newDateDiscount = new DateDiscount();
  }

  editPagination($event) {
    console.log($event)
    this.discountsDataSource.currentPagination.pageSize = $event.pageSize;
    this.discountsDataSource.setPage($event.pageIndex + 1);
  }

}
