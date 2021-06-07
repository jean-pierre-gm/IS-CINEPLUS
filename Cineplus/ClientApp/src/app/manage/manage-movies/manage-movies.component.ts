import {Component, Inject, OnInit} from '@angular/core';
import {CineplusDataSource} from "../../../models/cineplusDataSource";
import {Movie} from "../../../models/movie";
import {HttpClient} from "@angular/common/http";
import {ActivatedRoute} from "@angular/router";
import {DataSourceConf} from "../../../models/dataSourceConf";
import {faEdit, faPlus, faPlusCircle, faPlusSquare} from "@fortawesome/free-solid-svg-icons";
import {MatDialog} from "@angular/material/dialog";
import {CreateMovieComponent} from "./create-movie/create-movie.component";
import {Pagination} from "../../../models/pagination";
import {Genre} from "../../../models/genre";
import {Sort} from "@angular/material/sort";

@Component({
  selector: 'app-manage-movies',
  templateUrl: './manage-movies.component.html',
  styleUrls: ['./manage-movies.component.css']
})
export class ManageMoviesComponent implements OnInit {

  movie: Movie;

  movieDataSource: CineplusDataSource<Movie>;
  propColumns: string[] = ["name", "director", "genre", "duration", "score"]
  sortColumns: boolean[] = [true, false, false, false, true]
  get displayedColumns(): string[] { return this.propColumns.concat("Actions")}

  faEdit = faEdit
  faPlus = faPlus

  constructor(private http: HttpClient,
              @Inject('BASE_URL') private baseUrl: string,
              public dialog: MatDialog
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
      width: '250px',
      data: {movie: element, edit: edit}
    });

    dialogRef.afterClosed().subscribe(result => {
      if (!result) {
        console.log('The dialog was closed with cancel button');
      } else {
        console.log('The dialog was closed with ok button');
        this.movie = result;
        if (edit) {
          this.http.put('api/movie/' + this.movie.id, this.movie).subscribe(movie => {
            this.movieDataSource.refresh();
          });
        } else {
          this.http.post('api/movie', this.movie).subscribe(movie => {
            this.movieDataSource.refresh();
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
