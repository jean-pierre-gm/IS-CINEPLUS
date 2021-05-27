import {Component, Inject, OnInit} from '@angular/core';
import {CineplusDataSource} from "../../models/cineplusDataSource";
import {Reproduction} from "../../models/reproduction";
import {HttpClient, HttpParams} from "@angular/common/http";
import {ActivatedRoute} from "@angular/router";
import {DataSourceConf} from "../../models/dataSourceConf";
import {Pagination} from "../../models/pagination";
import {Movie} from "../../models/movie";

@Component({
  selector: 'app-movie-reproduction',
  templateUrl: './movie-reproduction.component.html',
  styleUrls: ['./movie-reproduction.component.css']
})
export class MovieReproductionComponent implements OnInit {

  reproductionData: CineplusDataSource<Reproduction>
  displayedColumns: string[] = ['theaterId', 'startTime', 'availSeats'];

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private route: ActivatedRoute) {
    let id: string = ""
    this.route.queryParams.subscribe(params => {id = params.movie})
    let reproductionSourceConf: DataSourceConf = new DataSourceConf()
    reproductionSourceConf.endPoint = baseUrl + 'api/reproduction'
    let reproductionPagination: Pagination<Reproduction> = new Pagination()
    this.reproductionData = new CineplusDataSource<Reproduction>(http, reproductionSourceConf, reproductionPagination)
    this.reproductionData.httpParams = this.reproductionData.httpParams.set('movieId', id)
    this.reproductionData.refresh()
  }

  ngOnInit() {
  }

  editPagination($event) {
    console.log($event)
    this.reproductionData.currentPagination.pageSize = $event.pageSize;
    this.reproductionData.setPage($event.pageIndex + 1);
  }
}
