import {Component, Inject, Input, OnInit} from '@angular/core';
import {GroupByDate} from "../../../../models/groupByDate";
import {CineplusDataSource} from "../../../../models/cineplusDataSource";
import {HttpClient} from "@angular/common/http";
import {DataSourceConf} from "../../../../models/dataSourceConf";
import {Pagination} from "../../../../models/pagination";
import {MatOptionSelectionChange} from "@angular/material/core";
import * as moment from "moment";
import {ChartDataSets, ChartOptions} from "chart.js";
import {Label} from "ng2-charts";

@Component({
  selector: 'app-manage-statistics-score',
  templateUrl: './manage-statistics-score.component.html',
  styleUrls: ['./manage-statistics-score.component.css']
})
export class ManageStatisticsScoreComponent implements OnInit {


  filterTimeOptions = ["Last 30 days", "Last 12 months", "Last 5 years"]
  activeTimeOption: string


  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
  }

  ngOnInit() {
  }

  setTimeSearch($event: MatOptionSelectionChange, option){
    if(!$event.source.selected)
      return
    this.activeTimeOption = option
    this.buildGraph()
  }

  formatNumber(num: number){
    if(num < 10)
      return "0" + num.toString()
    else
      return num.toString()
  }

  buildGraph(){
    let array = Array<Array<number>>()
    let labels = Array<string>()
    this.lineChartLabels = []
    if(this.activeTimeOption == this.filterTimeOptions[0]) {
      for (let i = 0; i < 10; i++) {
        array[i] = Array<number>()
        let maxScore = i == 9 ? 10 : i + 0.9
        this.http.get<Pagination<GroupByDate>>(this.baseUrl + "api/statistics/score/day?minScore=" + i + "&maxScore=" + maxScore + "&PageSize=30").subscribe(
          response => {
            let date = moment().subtract(29, 'days')
            for (let j = 0; j < 30; j++) {
              if(i == 0)
                this.lineChartLabels.push(this.formatNumber(date.date()) + "-" + this.formatNumber(date.month() + 1) + "-" + date.year().toString())
              let found = false
              for (let k = 0; k < response.result.length; k++) {
                let actualDate = new Date(response.result[k].key)
                if (date.date() == actualDate.getDate() &&
                  date.year() == actualDate.getFullYear() &&
                  date.month() == actualDate.getMonth()) {
                  array[i].push(response.result[k].count)
                  found = true
                }
              }
              if (!found) {
                array[i].push(0)
              }
              date = date.add(1, 'days')
            }

          }
        )
        labels.push("[" + i.toString() + "," + maxScore.toString() + "]")
      }
    }
    if(this.activeTimeOption == this.filterTimeOptions[1]) {
      for (let i = 0; i < 10; i++) {
        array[i] = Array<number>()
        let maxScore = i == 9 ? 10 : i + 0.9
        this.http.get<Pagination<GroupByDate>>(this.baseUrl + "api/statistics/score/month?minScore=" + i + "&maxScore=" + maxScore + "&PageSize=12").subscribe(
          response => {
            let date = moment().subtract(11, 'months')
            for (let j = 0; j < 12; j++) {
              if(i == 0)
                this.lineChartLabels.push(this.formatNumber(date.month() + 1) + "-" + date.year().toString())
              let found = false
              for (let k = 0; k < response.result.length; k++) {
                let actualDate = new Date(response.result[k].key)
                if (date.year() == actualDate.getFullYear() &&
                  date.month() == actualDate.getMonth()) {
                  array[i].push(response.result[k].count)
                  found = true
                }
              }
              if (!found) {
                array[i].push(0)
              }
              date = date.add(1, 'months')
            }
          }
        )
        labels.push("[" + i.toString() + "," + maxScore.toString() + "]")
      }
    }
    if(this.activeTimeOption == this.filterTimeOptions[2]) {
      for (let i = 0; i < 10; i++) {
        array[i] = Array<number>()
        let maxScore = i == 9 ? 10 : i + 0.9
        this.http.get<Pagination<GroupByDate>>(this.baseUrl + "api/statistics/score/year?minScore=" + i + "&maxScore=" + maxScore + "&PageSize=5").subscribe(
          response => {
            let date = moment().subtract(4, 'years')
            for (let j = 0; j < 5; j++) {
              if(i == 0)
                this.lineChartLabels.push(date.year().toString())
              let found = false
              for (let k = 0; k < response.result.length; k++) {
                let actualDate = new Date(response.result[k].key)
                if (date.year() == actualDate.getFullYear()) {
                  array[i].push(response.result[k].count)
                  found = true
                }
              }
              if (!found) {
                array[i].push(0)
              }
              date = date.add(1, 'years')
            }
          }
        )
        labels.push("[" + i.toString() + "," + maxScore.toString() + "]")
      }
    }
    if(this.lineChartData.length == 0)
      for(let i = 0; i < 10; i++)
        this.lineChartData.push({data: array[i], label: labels[i]})
    else {
      for(let i = 0; i < 10; i++) {
        this.lineChartData[i].data = array[i]
        this.lineChartData[i].label = labels[i]
      }
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

  lineChartLegend = true;

  lineChartType = 'line';

  lineChartPlugins = [];
}
