import {Component, Inject, OnInit} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {DataSourceConf} from "../../../../models/dataSourceConf";
import {Pagination} from "../../../../models/pagination";
import {Movie} from "../../../../models/movie";
import {CineplusDataSource} from "../../../../models/cineplusDataSource";
import {MatOptionSelectionChange} from "@angular/material/core";
import {GroupByDate} from "../../../../models/groupByDate";
import * as moment from "moment";
import {ChartDataSets, ChartOptions} from "chart.js";
import {Color, Label} from "ng2-charts";

@Component({
  selector: 'app-manage-statistics-movies',
  templateUrl: './manage-statistics-movies.component.html',
  styleUrls: ['./manage-statistics-movies.component.css']
})
export class ManageStatisticsMoviesComponent implements OnInit {

  data: GroupByDate[]
  currentMovie: Movie
  displayedColumns = ["Name"]

  filterTimeOptions = ["Last 30 days", "Last 12 months", "Last 5 years"]
  activeTimeOption: string

  movies: CineplusDataSource<Movie>

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    let moviesSourceConf: DataSourceConf = new DataSourceConf();
    moviesSourceConf.endPoint = this.baseUrl + 'api/movie'
    let moviesPagination: Pagination<Movie> = new Pagination();
    moviesPagination.pageSize = 5;
    this.movies = new CineplusDataSource<Movie>(this.http, moviesSourceConf, moviesPagination);
    this.movies.refresh()
  }

  ngOnInit() {
  }

  editPagination($event) {
    this.movies.currentPagination.pageSize = $event.pageSize;
    this.movies.setPage($event.pageIndex + 1);
  }

  setTimeSearch($event: MatOptionSelectionChange, option){
    if(!$event.source.selected)
      return
    this.activeTimeOption = option
    if(this.currentMovie)
      this.buildGraph(this.currentMovie)
  }

  formatNumber(num: number){
    if(num < 10)
      return "0" + num.toString()
    else
      return num.toString()
  }

  buildGraph(movie: Movie){
    this.currentMovie = movie
    if(this.activeTimeOption == this.filterTimeOptions[0]) {
      this.http.get<Pagination<GroupByDate>>(this.baseUrl + "api/statistics/day/" + movie.id + "?PageSize=30").subscribe(
        response => {
          this.data = response.result
          this.lineChartData.pop()
          this.lineChartLabels = []
          let date = moment().subtract(29, 'days')
          let array = Array<number>()
          for (let i = 0; i < 30; i++) {
            this.lineChartLabels.push(this.formatNumber(date.date()) + "-" + this.formatNumber(date.month() + 1) + "-" + date.year().toString())
            let found = false
            for (let j = 0; j < this.data.length; j++) {
              let actualDate = new Date(this.data[j].key)
              if (date.date() == actualDate.getDate() &&
                date.year() == actualDate.getFullYear() &&
                date.month() == actualDate.getMonth()) {
                array.push(this.data[j].count)
                found = true
              }
            }
            if (!found) {
              array.push(0)
            }
            date = date.add(1, 'days')
          }
          this.lineChartData.push({data: array, label: movie.movieName})
        }
      )
    }
    if(this.activeTimeOption == this.filterTimeOptions[1]) {
      this.http.get<Pagination<GroupByDate>>(this.baseUrl + "api/statistics/month/" + movie.id + "?PageSize=12").subscribe(
        response => {
          this.data = response.result
          this.lineChartData.pop()
          this.lineChartLabels = []
          let date = moment().subtract(11, 'months')
          let array = Array<number>()
          for (let i = 0; i < 12; i++) {
            this.lineChartLabels.push(this.formatNumber(date.month() + 1) + "-" + date.year().toString())
            let found = false
            for (let j = 0; j < this.data.length; j++) {
              let actualDate = new Date(this.data[j].key)
              if (date.year() == actualDate.getFullYear() &&
                date.month() == actualDate.getMonth()) {
                array.push(this.data[j].count)
                found = true
              }
            }
            if (!found) {
              array.push(0)
            }
            date = date.add(1, 'months')
          }
          this.lineChartData.push({data: array, label: movie.movieName})
        }
      )
    }
    if(this.activeTimeOption == this.filterTimeOptions[2]) {
      this.http.get<Pagination<GroupByDate>>(this.baseUrl + "api/statistics/year/" + movie.id + "?PageSize=5").subscribe(
        response => {
          this.data = response.result
          this.lineChartData.pop()
          this.lineChartLabels = []
          let date = moment().subtract(4, 'years')
          let array = Array<number>()
          for (let i = 0; i < 5; i++) {
            this.lineChartLabels.push(date.year().toString())
            let found = false
            for (let j = 0; j < this.data.length; j++) {
              let actualDate = new Date(this.data[j].key)
              if (date.year() == actualDate.getFullYear()) {
                array.push(this.data[j].count)
                found = true
              }
            }
            if (!found) {
              array.push(0)
            }
            date = date.add(1, 'years')
          }
          this.lineChartData.push({data: array, label: movie.movieName})
        }
      )
    }
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
