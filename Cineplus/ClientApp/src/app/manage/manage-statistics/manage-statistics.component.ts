import {Component, Inject, OnInit} from '@angular/core';
import {GroupByDate} from "../../../models/groupByDate";
import {HttpClient} from "@angular/common/http";
import {Pagination} from "../../../models/pagination";
import {ChartDataSets, ChartOptions} from "chart.js";
import {Color, Label} from "ng2-charts";
import {Movie} from "../../../models/movie";
import {CineplusDataSource} from "../../../models/cineplusDataSource";
import {DataSourceConf} from "../../../models/dataSourceConf";

@Component({
  selector: 'app-manage-statistics',
  templateUrl: './manage-statistics.component.html',
  styleUrls: ['./manage-statistics.component.css']
})
export class ManageStatisticsComponent implements OnInit {

  data: GroupByDate[]
  currentMovie: Movie
  displayedColumns = ["Name"]

  filterByOptions = ["Movie", "Director", "Genre", "Actor", "Country"]
  activeOption: string

  filterTimeOptions = ["Last 30 days", "Last 12 months", "Last 5 years"]
  activeTimeOption: string

  movies: CineplusDataSource<Movie>

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {

  }

  ngOnInit() {
  }

  setSearch($event, option){
    if(!$event.source.selected)
      return
    this.activeOption = option
  }
}
