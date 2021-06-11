import {Component, Inject, OnInit} from '@angular/core';
import {GroupByDate} from "../../../models/groupByDate";
import {HttpClient} from "@angular/common/http";
import {Pagination} from "../../../models/pagination";
import {ChartDataSets, ChartOptions} from "chart.js";
import {Color, Label} from "ng2-charts";
import {Movie} from "../../../models/movie";
import {CineplusDataSource} from "../../../models/cineplusDataSource";
import {DataSourceConf} from "../../../models/dataSourceConf";
import * as moment from 'moment';

@Component({
  selector: 'app-manage-statistics',
  templateUrl: './manage-statistics.component.html',
  styleUrls: ['./manage-statistics.component.css']
})
export class ManageStatisticsComponent implements OnInit {

  data: GroupByDate[]
  displayedColumns = ["Name"]

  movies: CineplusDataSource<Movie>

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    let moviesSourceConf: DataSourceConf = new DataSourceConf();
    moviesSourceConf.endPoint = baseUrl + 'api/movie'
    let moviesPagination: Pagination<Movie> = new Pagination();
    moviesPagination.pageSize = 5;
    this.movies = new CineplusDataSource<Movie>(http, moviesSourceConf, moviesPagination);
    this.movies.refresh()
  }

  ngOnInit() {
  }

  editPagination($event) {
    this.movies.currentPagination.pageSize = $event.pageSize;
    this.movies.setPage($event.pageIndex + 1);
  }

  buildGraph(movie: Movie){
    this.http.get<Pagination<GroupByDate>>(this.baseUrl + "api/statistics/day/" + movie.id + "?PageSize=30").subscribe(
      response => {
        this.data = response.result
        this.lineChartData.pop()
        this.lineChartLabels = []
        let date = moment().subtract(30, 'days')
        let array = Array<number>()
        for (let i = 0; i <= 30; i++) {
          this.lineChartLabels.push(date.calendar())
          date = date.add(1, 'days')
          let found = false
          for(let j = 0; j < this.data.length; j++) {
            let actualDate = new Date(this.data[j].key)
            if (date.date() == actualDate.getDate() &&
              date.year() == actualDate.getFullYear() &&
              date.month() == actualDate.getMonth()) {
              array.push(this.data[j].count)
              found = true
            }
          }
          if(!found){
            array.push(0)
          }
        }
        this.lineChartData.push({data: array, label: movie.movieName})
      }
    )
  }

  lineChartData: ChartDataSets[] = [];

  lineChartLabels: Label[] = [];

  lineChartOptions: ChartOptions = {
    responsive: true,
    scales:{
      yAxes:[{
        ticks:{
          precision:0
        }
      }]
    }
  };

  lineChartColors: Color[] = [
    { // red
      backgroundColor: 'rgba(255,0,0,0.3)',
      borderColor: 'red',
    }
  ];

  lineChartLegend = true;

  lineChartType = 'line';

  lineChartPlugins = [];
}
