import {Component, Inject, OnInit} from '@angular/core';
import {Movie} from "../../../models/movie";
import {CineplusDataSource} from "../../../models/cineplusDataSource";
import {HttpClient} from "@angular/common/http";
import {MatDialog} from "@angular/material/dialog";
import {DataSourceConf} from "../../../models/dataSourceConf";
import {CreateMovieComponent} from "../../manage/manage-movies/create-movie/create-movie.component";
import {Sort} from "@angular/material/sort";
import {animate, state, style, transition, trigger} from "@angular/animations";

@Component({
  selector: 'app-list-movies',
  templateUrl: './list-movies.component.html',
  styleUrls: ['./list-movies.component.css'],
  animations: [
    trigger('detailExpand', [
      state('collapsed', style({height: '0px', minHeight: '0'})),
      state('expanded', style({height: '*'})),
      transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ],
})
export class ListMoviesComponent implements OnInit {
  expandedElement: Movie | null;

  movieDataSource: CineplusDataSource<Movie>;
  propColumns: string[] = ["name", "director", "genre", "duration", "score"]
  sortColumns: boolean[] = [true, false, false, false, true]
  get displayedColumns(): string[] { return this.propColumns.concat("Actions")}

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

  sortTable($event: Sort) {
    this.movieDataSource.currentPagination.currentPage = 1;
    if ($event.active == "" || !$event.active || $event.direction == "") {
      this.movieDataSource.undoOrder();
    } else {
      this.movieDataSource.orderBy($event.active, $event.direction == "asc");
    }
  }

}
