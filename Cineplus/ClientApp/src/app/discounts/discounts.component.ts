import {Component, Inject, OnDestroy, OnInit} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {DateDiscount} from "../../models/dateDiscount";
import {CineplusDataSource} from "../../models/cineplusDataSource";
import {ActivatedRoute} from "@angular/router";
import {DataSourceConf} from "../../models/dataSourceConf";


@Component({
  selector: 'app-discounts',
  templateUrl: './discounts.component.html',
  styleUrls: ['./discounts.component.css']
})
export class DiscountsComponent implements OnInit, OnDestroy {

  discountsDataSource: CineplusDataSource<DateDiscount>;
  displayedColumns: string[] = ['description', 'discount', 'date'];

  constructor(private http: HttpClient,
              @Inject('BASE_URL') private baseUrl: string,
              private route: ActivatedRoute
  ) {
    let dsDateConf = new DataSourceConf();
    dsDateConf.endPoint = baseUrl + 'api/datediscount'
    this.discountsDataSource = new CineplusDataSource<DateDiscount>(http, dsDateConf);
    this.discountsDataSource.refresh()
  }

  ngOnInit() {
  }

  ngOnDestroy() {
  }

  applyFilter($event: KeyboardEvent) {

  }

  editPagination($event) {
    console.log($event)
    this.discountsDataSource.currentPagination.pageSize = $event.pageSize;
    this.discountsDataSource.setPage($event.pageIndex + 1);
  }
}
