import {Component, Inject, OnInit} from '@angular/core';
import {CineplusDataSource} from "../../../models/cineplusDataSource";
import {HttpClient} from "@angular/common/http";
import {DataSourceConf} from "../../../models/dataSourceConf";
import {MatDialog} from "@angular/material/dialog";
import {Ticket} from "../../../models/ticket";
import {Order} from "../../../models/order";

@Component({
  selector: 'app-purchase-history',
  templateUrl: './purchase-history.component.html',
  styleUrls: ['./purchase-history.component.css']
})
export class PurchaseHistoryComponent implements OnInit {

  orderDataSource: CineplusDataSource<Order>;
  panelOpenState: boolean;

  falseorderDataSource: Order[];

  constructor(private http: HttpClient,
              @Inject('BASE_URL') private baseUrl: string,
              public dialog: MatDialog
  ) {

    let dsConf = new DataSourceConf();
    dsConf.endPoint = baseUrl + 'api/ticket/order'
    //this.orderDataSource = new CineplusDataSource<Order>(http, dsConf);
    //this.orderDataSource.refresh()

    this.falseorderDataSource = [new Order(), new Order(), new Order()]
  }

  ngOnInit() {
  }

  editPagination($event) {
    console.log($event)
    this.orderDataSource.currentPagination.pageSize = $event.pageSize;
    this.orderDataSource.setPage($event.pageIndex + 1);
  }
}
