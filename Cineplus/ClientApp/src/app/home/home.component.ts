import {Component, Inject} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Movie} from "../../models/movie";
import {Genre} from "../../models/genre";
import {Pagination} from "../../models/pagination";

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

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    this.loadMovies()
    this.loadGenres()
  }

  loadMovies() {
    this.http.get<Pagination<Movie>>(this.baseUrl + 'api/movie/').subscribe(movies => {
      this.moviesPagination = movies;
      this.movies = movies.result;
    }, error => console.log(error));
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
      this.loadMovies();
    }, error => console.log(error))
  }

  setNewMovieGenre($event, genre) {
    if ($event.source.selected){
      this.newMovie.genre = genre
      }
    }
}
