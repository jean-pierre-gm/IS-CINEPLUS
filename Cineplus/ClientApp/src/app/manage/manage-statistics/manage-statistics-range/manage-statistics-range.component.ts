import {Component, Inject, OnInit} from '@angular/core';
import {FormControl, Validators} from "@angular/forms";
import {MyErrorStateMatcher} from "../../../seat-reservation/seat-reservation.component";
import {Movie} from "../../../../models/movie";
import {Actor} from "../../../../models/actor";
import {Genre} from "../../../../models/genre";
import {HttpClient} from "@angular/common/http";
import {MatSnackBar} from "@angular/material/snack-bar";

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


  constructor(private http: HttpClient, private _snackBar: MatSnackBar, @Inject('BASE_URL') private baseUrl: string) { }

  ngOnInit() {
    this.startTimeFormControl.reset()
    this.endTimeFormControl.reset()
  }

  search() {
    if (!this.startTimeFormControl.valid)
      return
    if (!this.endTimeFormControl.valid)
      return
    let params = "?start=" + this.startTimeFormControl.value.toString() + "&end=" + this.endTimeFormControl.value
    console.log(this.baseUrl + "api/statistics/top/movie" + params)
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
