import {Component, Inject, OnInit} from '@angular/core';
import {CineplusDataSource} from "../../../models/cineplusDataSource";
import {HttpClient} from "@angular/common/http";
import {MatDialog} from "@angular/material/dialog";
import {DataSourceConf} from "../../../models/dataSourceConf";
import {CreateMovieComponent} from "../manage-movies/create-movie/create-movie.component";
import {faEdit, faPlus} from "@fortawesome/free-solid-svg-icons";
import {Sort} from "@angular/material/sort";
import {Actor} from "../../../models/actor";
import {CreateActorComponent} from "./create-actor/create-actor.component";

@Component({
  selector: 'app-manage-actors',
  templateUrl: './manage-actors.component.html',
  styleUrls: ['./manage-actors.component.css']
})
export class ManageActorsComponent implements OnInit {

  actor: Actor;

  actorDataSource: CineplusDataSource<Actor>;
  propColumns: string[] = ["name"]
  sortColumns: boolean[] = [true]
  get displayedColumns(): string[] { return this.propColumns.concat("Actions")}

  faEdit = faEdit
  faPlus = faPlus

  constructor(private http: HttpClient,
              @Inject('BASE_URL') private baseUrl: string,
              public dialog: MatDialog
  ) {

    let dsConf = new DataSourceConf();
    dsConf.endPoint = baseUrl + 'api/actor'
    this.actorDataSource = new CineplusDataSource<Actor>(http, dsConf);
    this.actorDataSource.refresh()

  }

  ngOnInit() {
  }

  editPagination($event) {
    console.log($event)
    this.actorDataSource.currentPagination.pageSize = $event.pageSize;
    this.actorDataSource.setPage($event.pageIndex + 1);
  }

  applyFilter(input: string) {
    if (input !== '') {
      this.actorDataSource.filter('name', input);
    } else {
      this.actorDataSource.undoFilters();
    }
  }

  openDialog(element: Actor): void {
    let edit: boolean = true
    if (!element) {
      element = new Actor();
      edit = false;
    } else {
      element = { ...element }
    }

    const dialogRef = this.dialog.open(CreateActorComponent, {
      width: '250px',
      data: {actor: element, edit: edit}
    });

    dialogRef.afterClosed().subscribe(result => {
      if (!result) {
        console.log('The dialog was closed with cancel button');
      } else {
        console.log('The dialog was closed with ok button');
        this.actor = result;
        if (edit) {
          this.http.put('api/actor/' + this.actor.id, this.actor).subscribe(actor => {
            this.actorDataSource.refresh();
          });
        } else {
          this.http.post('api/actor', this.actor).subscribe(actor => {
            this.actorDataSource.refresh();
          });
        }
      }
    });
  }

  sortTable($event: Sort) {
    this.actorDataSource.currentPagination.currentPage = 1;
    if ($event.active == "" || !$event.active || $event.direction == "") {
      this.actorDataSource.undoOrder();
    } else {
      this.actorDataSource.orderBy($event.active, $event.direction == "asc");
    }
  }

}
