import {Component, Inject, OnInit} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {ActivatedRoute} from "@angular/router";
import {Reproduction} from "../../models/reproduction";
import {Theater} from "../../models/theater";
import {Ticket} from "../../models/ticket";
import {FormControl, FormGroupDirective, NgForm, Validators} from "@angular/forms";
import {ErrorStateMatcher} from "@angular/material/core";


export class MyErrorStateMatcher implements ErrorStateMatcher {
  isErrorState(control: FormControl | null, form: FormGroupDirective | NgForm | null): boolean {
    const isSubmitted = form && form.submitted;
    return !!(control && control.invalid && (control.dirty || control.touched || isSubmitted));
  }
}

@Component({
  selector: 'app-seat-reservation',
  templateUrl: './seat-reservation.component.html',
  styleUrls: ['./seat-reservation.component.css']
})
export class SeatReservationComponent implements OnInit {
  reproduction: Reproduction;
  theater: Theater;
  seats: string[][];
  soldTickets: Ticket[];
  checked = [];
  ticketsFormControl = new FormControl('', [
    Validators.required,
    Validators.min(1),
  ]);
  matcher = new MyErrorStateMatcher();

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private route: ActivatedRoute) {
    let id: string = ""
    this.route.queryParams.subscribe(params => {
      id = params.reproduction
    })
    this.http.get<Reproduction>(baseUrl + 'api/reproduction/' + id).subscribe(
      result => {
        this.reproduction = result
        this.http.get<Theater>(baseUrl + 'api/theater/' + this.reproduction.theaterId).subscribe(
          result => {
            this.theater = result
            this.http.get<Ticket[]>(baseUrl + 'api/ticket/' + this.reproduction.id).subscribe(result => {
              this.soldTickets = result

              this.ticketsFormControl.setValidators(Validators.compose([this.ticketsFormControl.validator, Validators.max(this.theater.columns * this.theater.rows - this.soldTickets.length)]))
              this.ticketsFormControl.updateValueAndValidity();

              this.seats = Array<Array<string>>(Array<string>(this.theater.rows))
              for (let i: number = 0; i < this.theater.rows; i++) {
                this.seats[i] = Array<string>(this.theater.columns)
                for (let j: number = 0; j < this.theater.columns; j++)
                  this.seats[i][j] = `${i}:${j}`
              }
              for (const ticket of this.soldTickets) {
                this.seats[ticket.seat.row][ticket.seat.column] = "0"
              }
            })
          })
      }
      , error => console.log(error))
  }

  ngOnInit() {
  }

  formatLabel(value: number) {
    return value;
  }


  onChange() {

    if (this.ticketsFormControl.value < 0 || this.ticketsFormControl.value > this.theater.columns * this.theater.rows - this.soldTickets.length) {
      for (const checkedElement of this.checked) {
        checkedElement.checked = false
      }
      this.checked = []
      return
    }
    let offset: number = this.ticketsFormControl.value - this.checked.length
    let validSeats = Array.from(document.getElementById("seats").querySelectorAll("input")).filter(it => {
      return it.id != "0" && it.checked == false
    })
    if (offset > 0) {
      for (let j = 0; j < offset; j++) {
        let s = Math.floor(Math.random() * (validSeats.length - 1));
        let elem = <any>validSeats.splice(s, 1)[0]
        this.checked.push(elem)
        elem.checked = true
      }
    } else if (offset < 0) {
      for (let j = 0; j < Math.abs(offset); j++) {
        let elem = this.checked.pop()
        elem.checked = false
      }
    }
  }
}

