import {Component, Inject, OnInit} from '@angular/core';
import {FormControl, Validators} from "@angular/forms";
import {MyErrorStateMatcher} from "../../../seat-reservation/seat-reservation.component";
import {Movie} from "../../../../models/movie";
import {Actor} from "../../../../models/actor";
import {Genre} from "../../../../models/genre";
import {HttpClient} from "@angular/common/http";
import {MatSnackBar} from "@angular/material/snack-bar";
import {ChartDataSets, ChartOptions, ChartType} from "chart.js";
import {Label} from "ng2-charts";
import * as moment from "moment";

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
  public barChartLabels: Label[] = ['2006', '2007', '2008', '2009', '2010', '2011', '2012'];
  public barChartType: ChartType = 'bar';
  public barChartLegend = true;
  public barChartPlugins = [];

  public barChartData: ChartDataSets[] = [
    { data: [65, 59, 80, 81, 56, 55, 40], label: 'Series A' },
    { data: [28, 48, 40, 19, 86, 27, 90], label: 'Series B' }
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
    let params = "?start=" + start + "&end=" + end
    this.http.get<Movie>(this.baseUrl + "api/statistics/top/movie" + params).subscribe(
      movie => {
        if(movie == null){
          this._snackBar.open("No reproductions in this time", '', {'duration': 2000})
          return
        }
        this.movie = movie
        this.http.get<string[]>(this.baseUrl + "api/statistics/top/director" + params, ).subscribe(
          director => {
            this.director = director[0]
            this.http.get<Actor>(this.baseUrl + "api/statistics/top/actor" + params).subscribe(
              actor => {
                this.actor = actor
                this.http.get<Genre>(this.baseUrl + "api/statistics/top/genre" + params).subscribe(
                  genre => {
                    this.genre = genre
                    this.show = true
                  }
                )
              }
            )
          }
        )
      }
    )
  }
}
