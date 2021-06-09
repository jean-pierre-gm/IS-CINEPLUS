import {Component, Inject, OnInit} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Movie} from "../../../models/movie";
import {CineplusDataSource} from "../../../models/cineplusDataSource";
import {Settings} from "../../../models/Settings";
import {DataSourceConf} from "../../../models/dataSourceConf";
import {Pagination} from "../../../models/pagination";
import {Sort} from "@angular/material/sort";
import {MatSnackBar} from "@angular/material/snack-bar";
import {MatTableDataSource} from "@angular/material/table";

@Component({
  selector: 'app-manage-carousel',
  templateUrl: './manage-carousel.component.html',
  styleUrls: ['./manage-carousel.component.css']
})
export class ManageCarouselComponent implements OnInit {

  settings: Settings[];
  manual: MatTableDataSource<Movie>;
  allMovies: CineplusDataSource<Movie>;

  selected: Settings;

  displayedColumns: string[] = ["Name", "Score", "Select"]


  propColumns: string[] = ["name", "director", "genre", "duration", "score"]
  sortColumns: boolean[] = [true, false, false, false, true]
  get allDisplayedColumns(): string[] { return this.propColumns.concat("select")}

  constructor(private http: HttpClient, private _snackBar: MatSnackBar, @Inject('BASE_URL') private baseUrl: string) {
    this.http.get<Settings[]>(baseUrl + "api/settings/display")
      .subscribe(response => {
        this.settings = response
        for(let i = 0; i < this.settings.length; i++)
          if(this.settings[i].active)
            this.selected = this.settings[i]
      })
    this.http.get<Movie[]>(baseUrl + "api/movie/display/all?name=Manual")
      .subscribe(response => this.manual = new MatTableDataSource<Movie>(response))

    let allMovieSourceConf: DataSourceConf = new DataSourceConf();
    allMovieSourceConf.endPoint = baseUrl + 'api/movie'
    let allMoviePagination: Pagination<Movie> = new Pagination();
    allMoviePagination.pageSize = 5;
    this.allMovies = new CineplusDataSource<Movie>(http, allMovieSourceConf, allMoviePagination);
  }

  ngOnInit() {
  }

  editPagination($event) {
    this.allMovies.currentPagination.pageSize = $event.pageSize;
    this.allMovies.setPage($event.pageIndex + 1);
  }

  optionSelected($event){
    this.selected = $event.value
  }

  submit(){
    if(this.selected.name != "Manual") {
      this.http.put(this.baseUrl + "api/settings/display", this.selected).subscribe()
      this._snackBar.open("Carousel settings changed", "", {'duration': 2000})
    }
    else
      return
  }

  sortTable($event: Sort) {
    this.allMovies.currentPagination.currentPage = 1;
    if ($event.active == "" || !$event.active || $event.direction == "") {
      this.allMovies.undoOrder();
    } else {
      this.allMovies.orderBy($event.active, $event.direction == "asc");
    }
  }

  select(element){
    if(!this.isActive(element)){
      if(this.manual.data.length == 10){
        this._snackBar.open("Only 10 movies can be displayed", "", {'duration': 2000})
        this.manual = new MatTableDataSource<Movie>(this.manual.data)
      }
      else{
        let temp = this.manual.data
        temp.push(element)
        this.manual = new MatTableDataSource<Movie>(temp)
      }
    }
    else {
      let temp = Array<Movie>();
      for (let i = 0; i < this.manual.data.length; i++) {
        if(this.manual.data[i].id != element['id'])
          temp.push(this.manual.data[i])
      }
      this.manual = new MatTableDataSource<Movie>(temp)
    }
  }

  selectManual(element){
    let temp = Array<Movie>();
    for (let i = 0; i < this.manual.data.length; i++) {
      if(this.manual.data[i].id != element['id'])
        temp.push(this.manual.data[i])
    }
    this.manual = new MatTableDataSource<Movie>(temp)
  }

  isActive(element){
    for(let i = 0; i < this.manual.data.length; i++)
      if(element['id'] == this.manual.data[i].id) {
        return true
      }
    return false
  }
}
