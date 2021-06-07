import {Component, Inject, OnInit} from '@angular/core';
import {CineplusDataSource} from "../../../models/cineplusDataSource";
import {HttpClient, HttpParams} from "@angular/common/http";
import {DataSourceConf} from "../../../models/dataSourceConf";
import {faEdit, faPlus} from "@fortawesome/free-solid-svg-icons";
import {MatDialog} from "@angular/material/dialog";
import {Pagination} from "../../../models/pagination";
import {Sort} from "@angular/material/sort";
import {DateDiscount} from "../../../models/dateDiscount";
import {CreateDateDiscountComponent} from "./create-dateDiscount/create-dateDiscount.component";

@Component({
  selector: 'app-manage-dateDiscounts',
  templateUrl: './manage-dateDiscounts.component.html',
  styleUrls: ['./manage-dateDiscounts.component.css']
})
export class ManageDateDiscountsComponent implements OnInit {

  dateDiscount: DateDiscount;

  dateDiscountsDataSource: CineplusDataSource<DateDiscount>;
  propColumns: string[] = ["description", "discount", "date"]
  sortColumns: boolean[] = [false, true, true]
  get displayedColumns(): string[] { return this.propColumns.concat("Actions")}

  faEdit = faEdit
  faPlus = faPlus

  constructor(private http: HttpClient,
              @Inject('BASE_URL') private baseUrl: string,
              public dialog: MatDialog
  ) {

    let dsConf = new DataSourceConf();
    dsConf.endPoint = baseUrl + 'api/datediscount'
    let httpParams = new HttpParams().set('admitDisabledDiscounts', 'false');
    this.dateDiscountsDataSource = new CineplusDataSource<DateDiscount>(http, dsConf, null, httpParams);
    this.dateDiscountsDataSource.refresh()

  }

  ngOnInit() {
  }

  editPagination($event) {
    console.log($event)
    this.dateDiscountsDataSource.currentPagination.pageSize = $event.pageSize;
    this.dateDiscountsDataSource.setPage($event.pageIndex + 1);
  }

  applyFilter(input: string) {
    if (input !== '') {
      this.dateDiscountsDataSource.filter('date', input);
    } else {
      this.dateDiscountsDataSource.undoFilters();
    }
  }

  openDialog(element: DateDiscount): void {
    let edit: boolean = true
    if (!element) {
      element = new DateDiscount();
      edit = false;
    } else {
      element = { ...element }
    }

    const dialogRef = this.dialog.open(CreateDateDiscountComponent, {
      width: '250px',
      data: {dateDiscount: element, edit: edit}
    });

    dialogRef.afterClosed().subscribe(result => {
      if (!result) {
        console.log('The dialog was closed with cancel button');
      } else {
        console.log('The dialog was closed with ok button');
        this.dateDiscount = result;
        if (edit) {
          this.http.put('api/datediscount/' + this.dateDiscount.id,
            this.dateDiscount).subscribe(dateDiscount => {
            this.dateDiscountsDataSource.refresh();
          });
        } else {
          this.http.post('api/datediscount', this.dateDiscount).subscribe(dateDiscount => {
            this.dateDiscountsDataSource.refresh();
          });
        }
      }
    });
  }

  sortTable($event: Sort) {
    this.dateDiscountsDataSource.currentPagination.currentPage = 1;
    if ($event.active == "" || !$event.active || $event.direction == "") {
      this.dateDiscountsDataSource.undoOrder();
    } else {
      this.dateDiscountsDataSource.orderBy($event.active, $event.direction == "asc");
    }
  }
}
