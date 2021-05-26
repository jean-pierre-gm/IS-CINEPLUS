import {Component, Inject, OnInit} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Pagination} from "../../models/pagination";
import {CineplusDataSource} from "../../models/cineplusDataSource";
import {DataSourceConf} from "../../models/dataSourceConf";
import {Movie} from "../../models/movie";

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: [
    './home.component.css'
  ]
})
export class HomeComponent {

  public movieData: CineplusDataSource<Movie>;
  slides: string [] = ['./assets/titanic.jpg' ]
  current = 0;

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    let movieSourceConf: DataSourceConf = new DataSourceConf();
    movieSourceConf.endPoint = baseUrl + 'api/movie';
    let moviePagination: Pagination<Movie> = new Pagination();
    this.movieData = new CineplusDataSource<Movie>(http, movieSourceConf, moviePagination);
    this.movieData.refresh();
  }

  getSlide() {
    return this.slides[0];
  }

  getPrev() {
    this.current--;
    if(this.current === -1){
      if(this.movieData.hasPrevious)
        this.movieData.previousPage();
      else
        this.movieData.setPage(this.movieData.totalPages);
      this.current = this.movieData.result.length - 1;
    }
    this.getSlide();
  }

  getNext() {
    console.log(this.movieData.result)
    this.current++;
    if(this.current === this.movieData.result.length){
      if(this.movieData.hasNext)
        this.movieData.nextPage();
      else
        this.movieData.setPage(1);
      this.current = 0;
    }
    console.log(this.movieData.result[this.current])
    this.getSlide();
  }

  getTitle(){
    console.log(this.movieData.result)
    return this.movieData.result[this.current].movieName;
  }
}
