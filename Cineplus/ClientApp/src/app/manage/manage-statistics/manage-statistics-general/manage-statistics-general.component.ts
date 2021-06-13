import {Component, Inject, Input, OnInit} from '@angular/core';
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
  selector: 'app-manage-statistics-general',
  templateUrl: './manage-statistics-general.component.html',
  styleUrls: ['./manage-statistics-general.component.css']
})
export class ManageStatisticsGeneralComponent implements OnInit {


  data: GroupByDate[]
  current: any
  displayedColumns = ["Name"]

  filterTimeOptions = ["Last 30 days", "Last 12 months", "Last 5 years"]
  activeTimeOption: string

  dataSource: CineplusDataSource<any>

  @Input()
  getAllEndpoint: string
  @Input()
  getCountEndpoint: string
  @Input()
  name: string
  @Input()
  text: string

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
  }

  ngOnInit() {
    let dataSourceConf: DataSourceConf = new DataSourceConf();
    dataSourceConf.endPoint = this.baseUrl + this.getAllEndpoint
    let dataPagination: Pagination<any> = new Pagination();
    dataPagination.pageSize = 5;
    this.dataSource = new CineplusDataSource<any>(this.http, dataSourceConf, dataPagination);
    this.dataSource.refresh()
  }

  editPagination($event) {
    this.dataSource.currentPagination.pageSize = $event.pageSize;
    this.dataSource.setPage($event.pageIndex + 1);
  }

  setTimeSearch($event: MatOptionSelectionChange, option){
    if(!$event.source.selected)
      return
    this.activeTimeOption = option
    if(this.current)
      this.buildGraph(this.current)
  }

  formatNumber(num: number){
    if(num < 10)
      return "0" + num.toString()
    else
      return num.toString()
  }

  buildGraph(current: any){
    this.current = current
    if(this.activeTimeOption == this.filterTimeOptions[0]) {
      this.http.get<Pagination<GroupByDate>>(this.baseUrl + this.getCountEndpoint + "/day/" + this.getCurrentId() + "?PageSize=30").subscribe(
        response => {
          console.log(response)
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
          this.lineChartData.push({data: array, label: this.getName(this.current)})
        }
      )
    }
    if(this.activeTimeOption == this.filterTimeOptions[1]) {
      this.http.get<Pagination<GroupByDate>>(this.baseUrl + this.getCountEndpoint + "/month/" + this.getCurrentId() + "?PageSize=12").subscribe(
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
          this.lineChartData.push({data: array, label: this.getName(this.current)})
        }
      )
    }
    if(this.activeTimeOption == this.filterTimeOptions[2]) {
      this.http.get<Pagination<GroupByDate>>(this.baseUrl + this.getCountEndpoint + "/year/" + this.getCurrentId() + "?PageSize=5").subscribe(
        response => {
          this.data = response.result
          this.lineChartData = []
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
          this.lineChartData.push({data: array, label: this.getName(this.current)})
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

  getName(element){
    if(!this.name || this.name == "")
      return element
    return element[this.name]
  }

  getCurrentId(){
    if(!this.name || this.name == "")
      return this.current
    return this.current['id']
  }

}
