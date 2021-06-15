import {Component, Inject, OnInit} from '@angular/core';
import {CineplusDataSource} from "../../../models/cineplusDataSource";
import {HttpClient} from "@angular/common/http";
import {DataSourceConf} from "../../../models/dataSourceConf";
import {MatDialog} from "@angular/material/dialog";
import {Ticket} from "../../../models/ticket";
import {formatDate} from "@angular/common";
import {CancelationFormComponent} from "./cancelation-form/cancelation-form.component";

@Component({
  selector: 'app-purchase-history',
  templateUrl: './purchase-history.component.html',
  styleUrls: ['./purchase-history.component.css']
})
export class PurchaseHistoryComponent implements OnInit {

  orderDataSource: CineplusDataSource<Ticket[]>;
  propColumns: string[] = ['movie', 'theater', 'seat']
  allColumns: string[] = this.propColumns.concat('price')

  formatDate = formatDate

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

  cancelOrder(i: number)
  {
    const dialogRef = this.dialog.open(CancelationFormComponent, {
      width: '250px'
    });

    dialogRef.afterClosed().subscribe(result => {
      if (!result) {
        console.log('The dialog was closed with cancel button');
      } else {
        console.log('The dialog was closed with ok button');

        let orderId = this.orderDataSource.result[i][0].orderId;
        this.http.delete(this.baseUrl + 'api/ticket/order/' + orderId).subscribe(order => {
          console.log(order);
          this.orderDataSource.refresh();
        });
      }
    })
  }

  calculatePrice(i: number)
  {
    let sum = 0;
    let prop = (this.orderDataSource.result[i][0].price == 0) ? 'pointsPrice' : 'price';

    for(let j = 0; j < this.orderDataSource.result[i].length; j++)
      sum += this.orderDataSource.result[i][j][prop];

    return (prop == 'price' ? "Price: $" : "Points: ") + sum;
  }

  hasBeenShown(i: number)
  {
    let actualDate = new Date();
    let startDate = new Date(this.orderDataSource.result[i][0].reproduction.startTime);

    return startDate.valueOf() - actualDate.valueOf() < 0;
  }

  canCancel(i: number)
  {
    let actualDate = new Date();
    let startDate = new Date(this.orderDataSource.result[i][0].reproduction.startTime);

    return 7200000 < startDate.valueOf() - actualDate.valueOf();
  }

  log(element)
  {
    console.log("LOG")
    console.log(element)
  }
}
