import {Component, Inject, OnInit} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {ActivatedRoute} from "@angular/router";
import {Reproduction} from "../../models/reproduction";
import {Theater} from "../../models/theater";

@Component({
  selector: 'app-seat-reservation',
  templateUrl: './seat-reservation.component.html',
  styleUrls: ['./seat-reservation.component.css']
})
export class SeatReservationComponent implements OnInit {

  reproduction: Reproduction;
  theater: Theater;
  seats: number[][];

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private route: ActivatedRoute) {
    let id: string = ""
    this.route.queryParams.subscribe(params => {id = params.reproduction})
    this.http.get<Reproduction>(baseUrl + 'api/reproduction/'  + id).subscribe(
      result => {
        this.reproduction = result
        this.http.get<Theater>(baseUrl + 'api/theater/' + this.reproduction.theaterId).subscribe(
          result => {
            this.theater = result
            this.seats = Array<Array<number>>(Array<number>(this.theater.rows))
            for (let i: number = 0; i < this.theater.rows; i++) {
              this.seats[i] = Array<number>(this.theater.columns)
              for (let j: number = 0; j < this.theater.columns; j++)
                this.seats[i][j] = 0
            }
          })
      }
      , error => console.log(error))
  }

  ngOnInit() {
  }

}
