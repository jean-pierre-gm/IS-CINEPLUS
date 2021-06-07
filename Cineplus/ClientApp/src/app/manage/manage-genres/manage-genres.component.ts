import {Component, Inject, OnInit} from '@angular/core';
import {Movie} from "../../../models/movie";
import {CineplusDataSource} from "../../../models/cineplusDataSource";
import {HttpClient} from "@angular/common/http";
import {MatDialog} from "@angular/material/dialog";
import {DataSourceConf} from "../../../models/dataSourceConf";
import {CreateMovieComponent} from "../manage-movies/create-movie/create-movie.component";
import {Sort} from "@angular/material/sort";
import {faEdit, faPlus} from "@fortawesome/free-solid-svg-icons";
import {Genre} from "../../../models/genre";
import {CreateGenreComponent} from "./create-genre/create-genre.component";

@Component({
  selector: 'app-manage-genres',
  templateUrl: './manage-genres.component.html',
  styleUrls: ['./manage-genres.component.css']
})
export class ManageGenresComponent implements OnInit {

  genre: Genre;

  genreDataSource: CineplusDataSource<Genre>;
  propColumns: string[] = ["name", "description"]
  sortColumns: boolean[] = [true, false]
  get displayedColumns(): string[] { return this.propColumns.concat("Actions")}

  faEdit = faEdit
  faPlus = faPlus

  constructor(private http: HttpClient,
              @Inject('BASE_URL') private baseUrl: string,
              public dialog: MatDialog
  ) {

    let dsConf = new DataSourceConf();
    dsConf.endPoint = baseUrl + 'api/genre'
    this.genreDataSource = new CineplusDataSource<Genre>(http, dsConf);
    this.genreDataSource.refresh()

  }

  ngOnInit() {
  }

  editPagination($event) {
    console.log($event)
    this.genreDataSource.currentPagination.pageSize = $event.pageSize;
    this.genreDataSource.setPage($event.pageIndex + 1);
  }

  applyFilter(input: string) {
    if (input !== '') {
      this.genreDataSource.filter('name', input);
    } else {
      this.genreDataSource.undoFilters();
    }
  }

  openDialog(element: Genre): void {
    let edit: boolean = true
    if (!element) {
      element = new Genre();
      edit = false;
    } else {
      element = { ...element }
    }

    const dialogRef = this.dialog.open(CreateGenreComponent, {
      width: '250px',
      data: {genre: element, edit: edit}
    });

    dialogRef.afterClosed().subscribe(result => {
      if (!result) {
        console.log('The dialog was closed with cancel button');
      } else {
        console.log('The dialog was closed with ok button');
        this.genre = result;
        if (edit) {
          this.http.put('api/genre/' + this.genre.id, this.genre).subscribe(movie => {
            this.genreDataSource.refresh();
          });
        } else {
          this.http.post('api/genre', this.genre).subscribe(movie => {
            this.genreDataSource.refresh();
          });
        }
      }
    });
  }

  sortTable($event: Sort) {
    this.genreDataSource.currentPagination.currentPage = 1;
    if ($event.active == "" || !$event.active || $event.direction == "") {
      this.genreDataSource.undoOrder();
    } else {
      this.genreDataSource.orderBy($event.active, $event.direction == "asc");
    }
  }

}
