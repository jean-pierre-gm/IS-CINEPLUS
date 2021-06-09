import {Component, Inject, OnInit} from '@angular/core';
import {CineplusDataSource} from "../../../models/cineplusDataSource";
import {HttpClient} from "@angular/common/http";
import {DataSourceConf} from "../../../models/dataSourceConf";
import {faEdit, faPlus, faEye, faEyeSlash} from "@fortawesome/free-solid-svg-icons";
import {MatDialog} from "@angular/material/dialog";
import {Sort} from "@angular/material/sort";
import {PersonalDiscount} from "../../../models/personalDiscount";
import {CreatePersonalDiscountComponent} from "./create-personalDiscount/create-personalDiscount.component";

@Component({
  selector: 'app-manage-personalDiscounts',
  templateUrl: './manage-personalDiscounts.component.html',
  styleUrls: ['./manage-personalDiscounts.component.css']
})
export class ManagePersonalDiscountsComponent implements OnInit {

  personalDiscount: PersonalDiscount;

  personalDiscountsDataSource: CineplusDataSource<PersonalDiscount>;
  propColumns: string[] = ["name", "discount", "description"]
  sortColumns: boolean[] = [true, false, true]
  get displayedColumns(): string[] { return this.propColumns.concat(["Disable", "Actions"])}
  showDisableds: boolean;

  faEdit = faEdit
  faPlus = faPlus
  faEye = faEye
  faEyeSlash = faEyeSlash

  constructor(private http: HttpClient,
              @Inject('BASE_URL') private baseUrl: string,
              public dialog: MatDialog
  ) {

    let dsConf = new DataSourceConf();
    dsConf.endPoint = baseUrl + 'api/personaldiscount'
    this.personalDiscountsDataSource = new CineplusDataSource<PersonalDiscount>(http, dsConf);
    this.personalDiscountsDataSource.refresh()
    this.showDisableds = false;
  }

  ngOnInit() {
  }

  admitDisabled()
  {
    this.personalDiscountsDataSource.httpParams =
      this.personalDiscountsDataSource.httpParams.set('admitDisabledDiscounts',
        this.showDisableds ? 'false' : 'true')
    this.showDisableds = !this.showDisableds;
    this.personalDiscountsDataSource.refresh();
  }

  changeEnable(personalDiscount) {
    personalDiscount.enable = !personalDiscount.enable;

    this.http.put(this.baseUrl + 'api/personaldiscount/' + personalDiscount.id,
      personalDiscount).toPromise()
      .then(response => {
          console.log(response);
          this.personalDiscountsDataSource.refresh();
        }
      );
  }

  editPagination($event) {
    console.log($event)
    this.personalDiscountsDataSource.currentPagination.pageSize = $event.pageSize;
    this.personalDiscountsDataSource.setPage($event.pageIndex + 1);
  }

  applyFilter(input: string) {
    if (input !== '') {
      this.personalDiscountsDataSource.filter('name', input);
    } else {
      this.personalDiscountsDataSource.undoFilters();
    }
  }

  openDialog(element: PersonalDiscount): void {
    let edit: boolean = true
    if (!element) {
      element = new PersonalDiscount();
      edit = false;
    } else {
      element = { ...element }
    }

    const dialogRef = this.dialog.open(CreatePersonalDiscountComponent, {
      width: '250px',
      data: {personalDiscount: element, edit: edit}
    });

    dialogRef.afterClosed().subscribe(result => {
      if (!result) {
        console.log('The dialog was closed with cancel button');
      } else {
        console.log('The dialog was closed with ok button');
        this.personalDiscount = result;
        if (edit) {
          this.http.put('api/personaldiscount/' + this.personalDiscount.id,
            this.personalDiscount).subscribe(dateDiscount => {
              console.log(dateDiscount);
            this.personalDiscountsDataSource.refresh();
          });
        } else {
          this.http.post('api/personaldiscount', this.personalDiscount).subscribe(dateDiscount => {
            console.log(dateDiscount);
            this.personalDiscountsDataSource.refresh();
          });
        }
      }
    });
  }

  sortTable($event: Sort) {
    this.personalDiscountsDataSource.currentPagination.currentPage = 1;
    if ($event.active == "" || !$event.active || $event.direction == "") {
      this.personalDiscountsDataSource.undoOrder();
    } else {
      this.personalDiscountsDataSource.orderBy($event.active, $event.direction == "asc");
    }
  }
}
