import {Component, Inject, OnInit} from '@angular/core';
import {CineplusDataSource} from "../../../models/cineplusDataSource";
import {HttpClient} from "@angular/common/http";
import {DataSourceConf} from "../../../models/dataSourceConf";
import {faEdit, faPlus, faEye, faEyeSlash} from "@fortawesome/free-solid-svg-icons";
import {MatDialog} from "@angular/material/dialog";
import {Sort} from "@angular/material/sort";
import {DateDiscount} from "../../../models/dateDiscount";
import {CreateDateDiscountComponent} from "./create-dateDiscount/create-dateDiscount.component";
import {formatDate} from "@angular/common";

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
  get displayedColumns(): string[] { return this.propColumns.concat(["Disable", "Actions"])}
  showDisableds: boolean;

  formatDate = formatDate

  faEdit = faEdit
  faPlus = faPlus
  faEye = faEye
  faEyeSlash = faEyeSlash

  constructor(private http: HttpClient,
              @Inject('BASE_URL') private baseUrl: string,
              public dialog: MatDialog
  ) {

    let dsConf = new DataSourceConf();
    dsConf.endPoint = baseUrl + 'api/datediscount'
    this.dateDiscountsDataSource = new CineplusDataSource<DateDiscount>(http, dsConf);
    this.dateDiscountsDataSource.refresh()
    this.showDisableds = false;
  }

  ngOnInit() {
  }

  admitDisabled()
  {
    this.dateDiscountsDataSource.httpParams =
      this.dateDiscountsDataSource.httpParams.set('admitDisabledDiscounts',
        this.showDisableds ? 'false' : 'true')
    this.showDisableds = !this.showDisableds;
    this.dateDiscountsDataSource.refresh();
  }

  changeEnable(dateDiscount) {
    dateDiscount.enable = !dateDiscount.enable;

    this.http.put(this.baseUrl + 'api/datediscount/' + dateDiscount.id,
      dateDiscount).toPromise()
      .then(response => {
          console.log(response);
          this.dateDiscountsDataSource.refresh();
        }
      );
  }

  editPagination($event) {
    console.log($event)
    this.dateDiscountsDataSource.currentPagination.pageSize = $event.pageSize;
    this.dateDiscountsDataSource.setPage($event.pageIndex + 1);
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
            console.log(dateDiscount);
            this.dateDiscountsDataSource.refresh();
          });
        } else {
          this.http.post('api/datediscount', this.dateDiscount).subscribe(dateDiscount => {
            console.log(dateDiscount);
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
