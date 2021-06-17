import {Component, Inject, OnInit} from '@angular/core';
import {GroupByDate} from "../../../../models/groupByDate";
import {HttpClient} from "@angular/common/http";
import {Pagination} from "../../../../models/pagination";
import {MatOptionSelectionChange} from "@angular/material/core";
import * as moment from "moment";
import {ChartDataSets, ChartOptions} from "chart.js";
import {Color, Label} from "ng2-charts";

@Component({
  selector: 'app-manage-statistics-countries',
  templateUrl: './manage-statistics-countries.component.html',
  styleUrls: ['./manage-statistics-countries.component.css']
})
export class ManageStatisticsCountriesComponent implements OnInit {

  dataCU: GroupByDate[]
  dataFO: GroupByDate[]

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
    this.lineChartLabels = []
    let arrayCuban = Array<number>()
    let arrayForeigner = Array<number>()
    if(this.activeTimeOption == this.filterTimeOptions[0]) {
      this.http.get<Pagination<GroupByDate>>(this.baseUrl + "api/statistics/cuban/day?PageSize=30").subscribe(
        responseCuban => {
          this.http.get<Pagination<GroupByDate>>(this.baseUrl + "api/statistics/foreigner/day?PageSize=30").subscribe(
            responseForeigner => {
              this.dataCU = responseCuban.result
              this.dataFO = responseForeigner.result
              let date = moment().subtract(29, 'days')
              for (let i = 0; i < 30; i++) {
                this.lineChartLabels.push(this.formatNumber(date.date()) + "-" + this.formatNumber(date.month() + 1) + "-" + date.year().toString())
                let foundCU = false
                for (let j = 0; j < this.dataCU.length; j++) {
                  let actualDate = new Date(this.dataCU[j].key)
                  if (date.date() == actualDate.getDate() &&
                    date.year() == actualDate.getFullYear() &&
                    date.month() == actualDate.getMonth()) {
                    arrayCuban.push(this.dataCU[j].count)
                    foundCU = true
                  }
                }
                let foundFO = false
                for (let j = 0; j < this.dataFO.length; j++) {
                  let actualDate = new Date(this.dataFO[j].key)
                  if (date.date() == actualDate.getDate() &&
                    date.year() == actualDate.getFullYear() &&
                    date.month() == actualDate.getMonth()) {
                    arrayForeigner.push(this.dataFO[j].count)
                    foundFO = true
                  }
                }
                if (!foundCU)
                  arrayCuban.push(0)
                if (!foundFO)
                  arrayForeigner.push(0)
                date = date.add(1, 'days')
              }
            }
          )
        }
      )
    }
    if(this.activeTimeOption == this.filterTimeOptions[1]) {
      this.http.get<Pagination<GroupByDate>>(this.baseUrl + "api/statistics/cuban/month?PageSize=12").subscribe(
        responseCuban => {
          this.http.get<Pagination<GroupByDate>>(this.baseUrl + "api/statistics/foreigner/month?PageSize=12").subscribe(
            responseForeigner => {
              this.dataCU = responseCuban.result
              this.dataFO = responseForeigner.result
              let date = moment().subtract(11, 'months')
              for (let i = 0; i < 12; i++) {
                this.lineChartLabels.push(this.formatNumber(date.month() + 1) + "-" + date.year().toString())
                let foundCU = false
                for (let j = 0; j < this.dataCU.length; j++) {
                  let actualDate = new Date(this.dataCU[j].key)
                  if (date.year() == actualDate.getFullYear() &&
                    date.month() == actualDate.getMonth()) {
                    arrayCuban.push(this.dataCU[j].count)
                    foundCU = true
                  }
                }
                let foundFO = false
                for (let j = 0; j < this.dataFO.length; j++) {
                  let actualDate = new Date(this.dataFO[j].key)
                  if (date.year() == actualDate.getFullYear() &&
                    date.month() == actualDate.getMonth()) {
                    arrayForeigner.push(this.dataFO[j].count)
                    foundFO = true
                  }
                }
                if (!foundCU)
                  arrayCuban.push(0)
                if (!foundFO)
                  arrayForeigner.push(0)
                date = date.add(1, 'months')
              }
            }
          )
        }
      )
    }
    if(this.activeTimeOption == this.filterTimeOptions[2]) {
      this.http.get<Pagination<GroupByDate>>(this.baseUrl + "api/statistics/cuban/year?PageSize=5").subscribe(
        responseCuban => {
          this.http.get<Pagination<GroupByDate>>(this.baseUrl + "api/statistics/foreigner/year?PageSize=5").subscribe(
            responseForeigner => {
              this.dataCU = responseCuban.result
              this.dataFO = responseForeigner.result
              let date = moment().subtract(4, 'years')
              for (let i = 0; i < 5; i++) {
                this.lineChartLabels.push(date.year().toString())
                let foundCU = false
                for (let j = 0; j < this.dataCU.length; j++) {
                  let actualDate = new Date(this.dataCU[j].key)
                  if (date.year() == actualDate.getFullYear()) {
                    arrayCuban.push(this.dataCU[j].count)
                    foundCU = true
                  }
                }
                let foundFO = false
                for (let j = 0; j < this.dataFO.length; j++) {
                  let actualDate = new Date(this.dataFO[j].key)
                  if (date.year() == actualDate.getFullYear()) {
                    arrayForeigner.push(this.dataFO[j].count)
                    foundFO = true
                  }
                }
                if (!foundCU)
                  arrayCuban.push(0)
                if (!foundFO)
                  arrayForeigner.push(0)
                date = date.add(1, 'years')
              }
            }
          )
        }
      )
    }

    if (this.lineChartData.length == 0) {
      this.lineChartData.push({data: arrayCuban, label: "Cuban"})
      this.lineChartData.push({data: arrayForeigner, label: "Foreigner"})
    } else {
      this.lineChartData[0].data = arrayCuban
      this.lineChartData[1].data = arrayForeigner
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
    },
    { // blue
      backgroundColor: 'rgba(0,0,255,0.3)',
      borderColor: 'blue',
    }
  ];

  lineChartLegend = true;

  lineChartType = 'line';

  lineChartPlugins = [];
}
