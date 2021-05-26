import {Component, Inject, OnDestroy, OnInit} from '@angular/core';
import {HttpClient, HttpParams} from "@angular/common/http";
import {DateDiscount} from "../../../models/date-discount";
import {faUser} from "@fortawesome/free-solid-svg-icons";
import {CineplusDataSource} from "../../../models/cineplusDataSource";
import {ActivatedRoute} from "@angular/router";
import {DataSourceConf} from "../../../models/dataSourceConf";
import {MatCheckboxChange} from "@angular/material/checkbox";
import {Role} from "../../../models/role";
import {Pagination} from "../../../models/pagination";
import {IUser} from "../../../api-authorization/authorize.service";
import {User} from "../../../models/user";
import {UserWithRoles} from "../../../models/userWithRoles";

@Component({
  selector: 'app-date-discount',
  templateUrl: './date-discount.component.html',
  //styleUrls: ['./role-list.component.css']
})
export class DateDiscountComponent implements OnInit, OnDestroy {

  discountsDataSource: CineplusDataSource<DateDiscount>;
  displayedColumns: string[] = ['description', 'discount', 'date'];
  faUser = faUser

  constructor(private http: HttpClient,
              @Inject('BASE_URL') private baseUrl: string,
              private route: ActivatedRoute
  ) {
    let dsConf = new DataSourceConf();
    dsConf.endPoint = baseUrl + 'api/datediscount'
    this.discountsDataSource = new CineplusDataSource<DateDiscount>(http, dsConf);
    this.discountsDataSource.refresh()
  }

  ngOnInit() {
  }

  ngOnDestroy() {
  }

  applyFilter($event: KeyboardEvent) {

  }

  editDiscount($event: MatCheckboxChange, discount, discountId) {
    let httpParams = new HttpParams().set('discountId', discountId);
    this.http.post(this.baseUrl + 'api/datediscount/' + discount + '?' + httpParams.toString(), {}).toPromise()
      .then(response => {
          this.discountsDataSource.refresh();
        }
      );
  }

  editPagination($event) {
    console.log($event)
    this.discountsDataSource.currentPagination.pageSize = $event.pageSize;
    this.discountsDataSource.setPage($event.pageIndex + 1);
  }
}
