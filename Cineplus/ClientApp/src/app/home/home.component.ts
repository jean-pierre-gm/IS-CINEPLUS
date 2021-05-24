import {Component, Inject} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Movie} from "../../models/movie";
import {Genre} from "../../models/genre";
import {Pagination} from "../../models/pagination";
import {CineplusDataSource} from "../../models/cineplusDataSource";
import {DataSourceConf} from "../../models/dataSourceConf";
import {Reproduction} from "../../models/reproduction";
import {min} from "rxjs/operators";

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {

  public movies: Movie[];
  public newGenre: Genre = new Genre();
  public genres: Genre[];
  public newMovie: Movie = new Movie();
  private moviesPagination: Pagination<Movie>;
  public movieDataSource: CineplusDataSource<Movie>;

  public reprData: CineplusDataSource<Reproduction>;
  slides: string [] = ['./assets/titanic.jpg' ]
  current = 0;

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    let dataSourceConf: DataSourceConf = new DataSourceConf();
    dataSourceConf.endPoint = baseUrl + 'api/movie';
    let pagination: Pagination<Movie> = new Pagination();
    pagination.pageSize = 2;
    this.movieDataSource = new CineplusDataSource<Movie>(http, dataSourceConf, pagination);
    this.movieDataSource.orderBy('name');
    let reprSourceConf: DataSourceConf = new DataSourceConf();
    reprSourceConf.endPoint = baseUrl + 'api/reproduction/date';
    let reprPagination: Pagination<Reproduction> = new Pagination();
    reprPagination.pageSize = 10;
    this.reprData = new CineplusDataSource<Reproduction>(http, reprSourceConf, reprPagination);
    let v: Date = new Date();
    let date: string = (v.getMonth() + 1).toString() + "-" + v.getDate().toString() + "-" + v.getFullYear().toString();
    this.reprData.httpParams = this.reprData.httpParams.set("date", date);
    this.reprData.refresh();
    console.log(this.reprData.result)
    this.loadGenres();
  }

  getSlide() {
    return this.slides[0];
  }

  getPrev() {
    this.current--;
    if(this.current === -1){
      if(this.reprData.hasPrevious)
        this.reprData.previousPage();
      else
        this.reprData.setPage(this.reprData.totalPages);
      this.current = this.reprData.result.length - 1;
    }
    this.getSlide();
  }

  getNext() {
    console.log(this.reprData.result)
    this.current++;
    if(this.current === this.reprData.result.length){
      if(this.reprData.hasNext)
        this.reprData.nextPage();
      else
        this.reprData.setPage(1);
      this.current = 0;
    }
    console.log(this.reprData.result[this.current])
    this.getSlide();
  }

  getTitle(){
    return this.reprData.result[this.current].movie.movieName;
  }

  getDate(){
    console.log(this.reprData.result[this.current].startTime)
    let date = new Date(this.reprData.result[this.current].startTime)
    let hours: string = date.getHours().toString()
    if(hours.length == 1)
      hours = "0" + hours
    let minutes: string = date.getMinutes().toString()
    if(minutes.length == 1)
      minutes = "0" + minutes
    return hours + ":" + minutes
  }

  loadGenres() {
    this.http.get<Genre[]>(this.baseUrl + 'api/genre/').subscribe(genres => {
      this.genres = genres;
    }, error => console.log(error));
  }

  AddGenre() {
    console.log("SUBMIT")
    if (!this.newGenre.genreName || !this.newGenre.description){
      console.log('ERROR')
      return;
    }
    this.http.post<Genre>(this.baseUrl + 'api/genre', this.newGenre).subscribe(genre => {
      this.newGenre = new Genre();
      this.loadGenres();
    }, error => console.log(error))
  }

  AddMovie() {
    console.log("SUBMIT")
    if ((!this.newMovie.genre && !this.newMovie['genreId']) ||
      !this.newMovie.movieName ||
      !this.newMovie.director ||
      !this.newMovie.score ||
      !this.newMovie.duration){
      console.log('ERROR')
      return;
    }
    console.log(this.newMovie)
    this.http.post<Genre>(this.baseUrl + 'api/movie', this.newMovie).subscribe(movie => {
      this.newMovie = new Movie();
      this.movieDataSource.refresh()
    }, error => console.log(error))
  }

  setNewMovieGenre($event, genre) {
    if ($event.source.selected){
      this.newMovie.genre = genre
      }
    }
}
