import {Component, Inject, OnInit} from '@angular/core';
import {FormControl, Validators} from "@angular/forms";
import {MyErrorStateMatcher} from "../../../seat-reservation/seat-reservation.component";
import {Movie} from "../../../../models/movie";
import {Actor} from "../../../../models/actor";
import {Genre} from "../../../../models/genre";
import {HttpClient, HttpParams} from "@angular/common/http";
import {MatSnackBar} from "@angular/material/snack-bar";
import {ChartDataSets, ChartOptions, ChartType} from "chart.js";
import {Label} from "ng2-charts";
import {DataSourceConf} from "../../../../models/dataSourceConf";
import {Pagination} from "../../../../models/pagination";
import {CineplusDataSource} from "../../../../models/cineplusDataSource";

@Component({
  selector: 'app-manage-statistics-range',
  templateUrl: './manage-statistics-range.component.html',
  styleUrls: ['./manage-statistics-range.component.css']
})
export class ManageStatisticsRangeComponent implements OnInit {

  startTimeFormControl = new FormControl('', [Validators.required])
  endTimeFormControl = new FormControl('', [Validators.required])

  matcher = new MyErrorStateMatcher()

  show = false
  movie: Movie
  director: string
  actor: Actor
  genre: Genre

  public barChartOptions: ChartOptions = {
    responsive: true,
  };
  public barChartLabels: Label[] = [];
  public barChartType: ChartType = 'bar';
  public barChartLegend = true;
  public barChartPlugins = [];

  public barChartData: ChartDataSets[] = [
  ];


  constructor(private http: HttpClient, private _snackBar: MatSnackBar, @Inject('BASE_URL') private baseUrl: string) { }

  ngOnInit() {
    this.startTimeFormControl.reset()
    this.endTimeFormControl.reset()
  }

  formatNumber(num: number){
    if(num < 10)
      return "0" + num.toString()
    else
      return num.toString()
  }

  search() {
    if (!this.startTimeFormControl.valid)
      return
    if (!this.endTimeFormControl.valid)
      return
    let startDate = new Date(this.startTimeFormControl.value)
    let endDate = new Date(this.endTimeFormControl.value)
    let start = this.formatNumber(startDate.getMonth() + 1) + "-" + this.formatNumber(startDate.getDate()) + "-" + startDate.getFullYear()
    let end = this.formatNumber(endDate.getMonth() + 1) + "-" + this.formatNumber(endDate.getDate()) + "-" + endDate.getFullYear()

    let dataSourceConf: DataSourceConf = new DataSourceConf();
    dataSourceConf.endPoint = this.baseUrl + "api/statistics/top/movie"
    let dataPagination: Pagination<any> = new Pagination();
    dataPagination.pageSize = 5;
    let dataSource = new CineplusDataSource<any>(this.http, dataSourceConf,
      dataPagination, new HttpParams().set("start", start).set("end", end));
    dataSource.refresh().add(()=>{
      if(dataSource.result == null || dataSource.result.length == 0) {
        this._snackBar.open("No movies seen in that period", "", {"duration": 2000})
        return
      }
      let data = Array<number>()
      let labels = Array<string>()
      for (let i = 0; i < dataSource.result.length; i++) {
        data.push(dataSource.result[i]["count"])
        labels.push(dataSource.result[i]["key"])
      }

      if(this.barChartData.length == 0){
        this.barChartData.push({data:data, label: "Seen"})
        this.barChartLabels.push(labels)
      }
      else{
        this.barChartData[0].data = data
        this.barChartLabels[0] = labels
      }
    })
  }
}
