import {Component, Inject, OnInit} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Pagination} from "../../models/pagination";
import {CineplusDataSource} from "../../models/cineplusDataSource";
import {DataSourceConf} from "../../models/dataSourceConf";
import {Movie} from "../../models/movie";
import {OwlOptions} from "ngx-owl-carousel-o";
import {faStar} from "@fortawesome/free-solid-svg-icons";

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: [
    './home.component.css'
  ]
})
export class HomeComponent {

  public movieData: CineplusDataSource<Movie>;
  faStar = faStar

  owlConfig: OwlOptions = {
    loop: true,
    mouseDrag: true,
    touchDrag: false,
    pullDrag: false,
    dots: false,
    navSpeed: 700,
    autoplay: true,
    autoplayHoverPause: true,
    navText: ['', ''],
    responsive: {
      0: {
        items: 1
      },
      400: {
        items: 2
      },
      740: {
        items: 3
      },
      940: {
        items: 4
      }
    },
    nav: true
  }

  pics = ['assets/pulp-fiction.jpg', 'assets/forrestgump.jpg', "assets/titanic.jpg", "assets/endgame.jpg"]

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    let movieSourceConf: DataSourceConf = new DataSourceConf();
    movieSourceConf.endPoint = baseUrl + 'api/movie';
    let moviePagination: Pagination<Movie> = new Pagination();
    moviePagination.pageSize = 50;
    this.movieData = new CineplusDataSource<Movie>(http, movieSourceConf, moviePagination);
    this.movieData.refresh();
  }

  parseDuration(duration: number) {
    return Math.floor(duration / 60) + ":" + duration % 60
  }

  picsFromMovie(movie: Movie) {
    if(movie.imageUrl)
      return movie.imageUrl
    return "assets/no_image.jpg"
  }
}
