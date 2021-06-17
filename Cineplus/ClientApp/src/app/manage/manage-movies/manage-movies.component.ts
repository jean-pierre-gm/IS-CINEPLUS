import {Component, Inject, OnInit} from '@angular/core';
import {CineplusDataSource} from "../../../models/cineplusDataSource";
import {Movie} from "../../../models/movie";
import {HttpClient} from "@angular/common/http";
import {DataSourceConf} from "../../../models/dataSourceConf";
import {faEdit, faPlus, faPlusCircle, faPlusSquare} from "@fortawesome/free-solid-svg-icons";
import {MatDialog} from "@angular/material/dialog";
import {CreateMovieComponent} from "./create-movie/create-movie.component";
import {Sort} from "@angular/material/sort";
import {animate, state, style, transition, trigger} from "@angular/animations";
import {NotificationService} from "../../notification.service";

@Component({
  selector: 'app-manage-movies',
  templateUrl: './manage-movies.component.html',
  styleUrls: ['./manage-movies.component.css'],
  animations: [
    trigger('detailExpand', [
      state('collapsed', style({height: '0px', minHeight: '0'})),
      state('expanded', style({height: '*'})),
      transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ],
})
export class ManageMoviesComponent implements OnInit {

  movie: Movie;

  expandedElement: Movie | null;

  movieDataSource: CineplusDataSource<Movie>;
  propColumns: string[] = ["name", "director", "genre", "duration", "score"]
  sortColumns: boolean[] = [true, false, false, false, true]
  get displayedColumns(): string[] { return this.propColumns.concat("Actions")}

  faEdit = faEdit
  faPlus = faPlus

  constructor(private http: HttpClient,
              @Inject('BASE_URL') private baseUrl: string,
              public dialog: MatDialog,
              private notificationService: NotificationService
  ) {

    let dsConf = new DataSourceConf();
    dsConf.endPoint = baseUrl + 'api/movie'
    this.movieDataSource = new CineplusDataSource<Movie>(http, dsConf);
    this.movieDataSource.refresh()

  }

  ngOnInit() {
  }

  editPagination($event) {
    console.log($event)
    this.movieDataSource.currentPagination.pageSize = $event.pageSize;
    this.movieDataSource.setPage($event.pageIndex + 1);
  }

  applyFilter(input: string) {
    if (input !== '') {
      this.movieDataSource.filter('name', input);
    } else {
      this.movieDataSource.undoFilters();
    }
  }

  openDialog(element: Movie): void {
    let edit: boolean = true
    if (!element) {
      element = new Movie();
      edit = false;
    } else {
      element = { ...element }
    }

    const dialogRef = this.dialog.open(CreateMovieComponent, {
      width: '350px',
      data: {movie: element, edit: edit}
    });

    dialogRef.afterClosed().subscribe(result => {
      if (!result) {
        console.log('The dialog was closed with cancel button');
      } else {
        console.log('The dialog was closed with ok button');
        this.movie = result;
        let cast = this.movie.actors
        if (edit) {
          this.http.put<Movie>('api/movie/' + this.movie.id, this.movie).subscribe(movie => {
            this.movieDataSource.refresh();
            this.http.put('api/actor/cast/' + movie.id, cast).subscribe()
            this.notificationService.success$.next("Movie successfully updated.");
          }, error => {
            this.notificationService.error$.next("Error creating movie.");
          });
        } else {
          this.http.post<Movie>('api/movie', this.movie).subscribe(movie => {
            this.movieDataSource.refresh();
            this.http.post('api/actor/cast/' + movie.id, cast).subscribe()
            this.notificationService.success$.next("Movie successfully created.");
          }, error => {
            this.notificationService.error$.next("Error updating movie.");
          });
        }
      }
    });
  }

  sortTable($event: Sort) {
    this.movieDataSource.currentPagination.currentPage = 1;
    if ($event.active == "" || !$event.active || $event.direction == "") {
      this.movieDataSource.undoOrder();
    } else {
      this.movieDataSource.orderBy($event.active, $event.direction == "asc");
    }
  }
}
