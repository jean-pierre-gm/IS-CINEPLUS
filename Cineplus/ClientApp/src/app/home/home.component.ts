import {Component, Inject} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Movie} from "../../models/movie";
import {Genre} from "../../models/genre";
import {Pagination} from "../../models/pagination";
import {CineplusDataSource} from "../../models/cineplusDataSource";
import {DataSourceConf} from "../../models/dataSourceConf";

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

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    let dataSourceConf: DataSourceConf = new DataSourceConf();
    dataSourceConf.endPoint = baseUrl + 'api/movie'
    let pagination: Pagination<Movie> = new Pagination();
    pagination.pageSize = 2
    this.movieDataSource = new CineplusDataSource<Movie>(http, dataSourceConf, pagination);
    this.movieDataSource.orderBy('name')
    this.loadGenres()
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
