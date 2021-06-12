import {Component, Inject, OnInit} from '@angular/core';
import {CineplusDataSource} from "../../../models/cineplusDataSource";
import {HttpClient} from "@angular/common/http";
import {DataSourceConf} from "../../../models/dataSourceConf";
import {MatDialog} from "@angular/material/dialog";
import {Ticket} from "../../../models/ticket";
import {TitleCasePipe} from "@angular/common";

@Component({
  selector: 'app-purchase-history',
  templateUrl: './purchase-history.component.html',
  styleUrls: ['./purchase-history.component.css']
})
export class PurchaseHistoryComponent implements OnInit {

  orderDataSource: CineplusDataSource<Ticket[]>;
  propColumns: string[] = ['movie', 'teather', 'seat']
  allColumns: string[] = this.propColumns.concat('price')

  constructor(private http: HttpClient,
              @Inject('BASE_URL') private baseUrl: string,
              public dialog: MatDialog
  ) {

    let dsConf = new DataSourceConf();
    dsConf.endPoint = baseUrl + 'api/ticket/order'
    this.orderDataSource = new CineplusDataSource<Ticket[]>(http, dsConf);
    this.orderDataSource.refresh()
  }

  ngOnInit() {
  }

  editPagination($event) {
    console.log($event)
    this.orderDataSource.currentPagination.pageSize = $event.pageSize;
    this.orderDataSource.setPage($event.pageIndex + 1);
  }

  calculatePrice(i: number)
  {
    let sum = 0;
    let prop = (this.orderDataSource.result[i][0].price == 0) ? 'pointsPrice' : 'price';

    for(let j = 0; j < this.orderDataSource.result[i].length; j++)
      sum += this.orderDataSource.result[i][j][prop];

    return (prop == 'price' ? "Price: $" : "Points: ") + sum;
  }

  canCancel(i: number)
  {
    let actualDate = new Date();
    let startDate = this.orderDataSource.result[i][0].reproduction.startTime;

    if(startDate < actualDate)
      return -1;

    if(startDate.valueOf() - actualDate.valueOf() < 7200000)
      return 0;

    return 1;
  }

  log(element)
  {
    console.log("LOG")
    console.log(element)
  }
}
