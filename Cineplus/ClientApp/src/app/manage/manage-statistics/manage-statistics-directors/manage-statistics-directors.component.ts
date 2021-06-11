import {Component, Inject, OnInit} from '@angular/core';
import {GroupByDate} from "../../../../models/groupByDate";
import {CineplusDataSource} from "../../../../models/cineplusDataSource";
import {HttpClient} from "@angular/common/http";
import {DataSourceConf} from "../../../../models/dataSourceConf";
import {Pagination} from "../../../../models/pagination";
import {MatOptionSelectionChange} from "@angular/material/core";
import * as moment from "moment";
import {ChartDataSets, ChartOptions} from "chart.js";
import {Color, Label} from "ng2-charts";

@Component({
  selector: 'app-manage-statistics-directors',
  templateUrl: './manage-statistics-directors.component.html',
  styleUrls: ['./manage-statistics-directors.component.css']
})
export class ManageStatisticsDirectorsComponent implements OnInit {

  data: GroupByDate[]
  currentDirector: string
  displayedColumns = ["Name"]

  filterTimeOptions = ["Last 30 days", "Last 12 months", "Last 5 years"]
  activeTimeOption: string

  directors: CineplusDataSource<string>

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    let directorSourceConf: DataSourceConf = new DataSourceConf();
    directorSourceConf.endPoint = this.baseUrl + 'api/statistics/directors'
    let directorPagination: Pagination<string> = new Pagination();
    directorPagination.pageSize = 5;
    this.directors = new CineplusDataSource<string>(this.http, directorSourceConf, directorPagination);
    this.directors.refresh()
  }

  ngOnInit() {
  }

  editPagination($event) {
    this.directors.currentPagination.pageSize = $event.pageSize;
    this.directors.setPage($event.pageIndex + 1);
  }

  setTimeSearch($event: MatOptionSelectionChange, option){
    if(!$event.source.selected)
      return
    this.activeTimeOption = option
    if(this.currentDirector)
      this.buildGraph(this.currentDirector)
  }

  formatNumber(num: number){
    if(num < 10)
      return "0" + num.toString()
    else
      return num.toString()
  }

  buildGraph(director: string){
    this.currentDirector = director
    if(this.activeTimeOption == this.filterTimeOptions[0]) {
      this.http.get<Pagination<GroupByDate>>(this.baseUrl + "api/statistics/directors/day/" + director + "?PageSize=30").subscribe(
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
          this.lineChartData.push({data: array, label: director})
        }
      )
    }
    if(this.activeTimeOption == this.filterTimeOptions[1]) {
      this.http.get<Pagination<GroupByDate>>(this.baseUrl + "api/statistics/directors/month/" + director + "?PageSize=12").subscribe(
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
          this.lineChartData.push({data: array, label: director})
        }
      )
    }
    if(this.activeTimeOption == this.filterTimeOptions[2]) {
      this.http.get<Pagination<GroupByDate>>(this.baseUrl + "api/statistics/directors/year/" + director + "?PageSize=5").subscribe(
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
          this.lineChartData.push({data: array, label: director})
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
