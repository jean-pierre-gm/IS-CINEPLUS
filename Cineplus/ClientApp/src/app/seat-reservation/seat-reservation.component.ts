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
  seats: number[][];
  tickets:Ticket[];
  checked = [];
  ticketsFormControl = new FormControl('', [
    Validators.required,
    Validators.min(1),
  ]);
  matcher = new MyErrorStateMatcher();

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private route: ActivatedRoute) {
    let id: string = ""
    this.route.queryParams.subscribe(params => {id = params.reproduction})
    this.http.get<Reproduction>(baseUrl + 'api/reproduction/'  + id).subscribe(
      result => {
        this.reproduction = result
        this.http.get<Theater>(baseUrl + 'api/theater/' + this.reproduction.theaterId).subscribe(
          result => {
            this.theater = result
            this.http.get<Ticket[]>(baseUrl + 'api/ticket/' + this.reproduction.id).subscribe(result =>{
              this.tickets = result

              this.ticketsFormControl.setValidators(Validators.compose([this.ticketsFormControl.validator , Validators.max(this.tickets.length)]))
              this.ticketsFormControl.updateValueAndValidity();

              this.seats = Array<Array<number>>(Array<number>(this.theater.rows))
              for (let i: number = 0; i < this.theater.rows; i++) {
                this.seats[i] = Array<number>(this.theater.columns)
                for (let j: number = 0; j < this.theater.columns; j++)
                  this.seats[i][j] = 0
              }
              for (const ticket of this.tickets) {
                this.seats[ticket.seat.row][ticket.seat.column] = ticket.id
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

  onLoad(){
    let i =Math.floor(Math.random() * (this.tickets.length-1));
    let t:Ticket = this.tickets[i]
    let elm = document.getElementById(t.id.toString())
    //elm.checked = true
    this.checked.push(elm)
  }

  onChange(){
    let tmp:Ticket[] = [];
    for (const checkedElement of this.checked) {
      checkedElement.checked = false
    }
    this.checked = []

    if (this.ticketsFormControl.value >= this.tickets.length)
      return

    for (let j = 0; j < this.ticketsFormControl.value; j++) {
      let i =Math.floor(Math.random() * (this.tickets.length-1));
      let t:Ticket = this.tickets[i]
      tmp.push(t)
      this.tickets.splice(i,1)
      let elm = document.getElementById(t.id.toString())
      //elm.checked = true
      this.checked.push(elm)
    }
    this.tickets= this.tickets.concat(tmp)
  }
}

