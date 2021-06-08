import {AfterContentInit, AfterViewChecked, AfterViewInit, Component, Inject, OnInit} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {ActivatedRoute} from "@angular/router";
import {Reproduction} from "../../models/reproduction";
import {Theater} from "../../models/theater";
import {Ticket} from "../../models/ticket";
import {FormControl, FormGroupDirective, NgForm, Validators} from "@angular/forms";
import {ErrorStateMatcher} from "@angular/material/core";
import {MatTableDataSource} from '@angular/material/table';
import {animate, state, style, transition, trigger} from '@angular/animations';
import {Seat} from "../../models/seat";

class TicketReserve {
  constructor(finalPrice: string, discount: any[] = [], row: number, col: number, htmlSeat: HTMLInputElement) {
    this.finalPrice = finalPrice
    this.htmlSeat = htmlSeat;
    this.originalPrice = TicketReserve.staticReprod.price
    let seat: Seat = new Seat();
    seat.row = row
    seat.column = col
    seat.theaterId = TicketReserve.staticReprod.theaterId
    this.seat = seat
  }

  seat: Seat = null
  static staticReprod: Reproduction = null;
  originalPrice: number;
  finalPrice: string;
  discount: string = "0";

  htmlSeat: HTMLInputElement;

  getAsTicket() {
    let tck: Ticket = new Ticket()
    tck.seat = this.seat
    tck.reproductionId = TicketReserve.staticReprod.id
    return tck
  }

}

export class MyErrorStateMatcher implements ErrorStateMatcher {
  isErrorState(control: FormControl | null, form: FormGroupDirective | NgForm | null): boolean {
    const isSubmitted = form && form.submitted;
    return !!(control && control.invalid && (control.dirty || control.touched || isSubmitted));
  }
}

@Component({
  selector: 'app-seat-reservation',
  templateUrl: './seat-reservation.component.html',
  styleUrls: ['./seat-reservation.component.css'],
  animations: [
    trigger('detailExpand', [
      state('collapsed', style({height: '0px', minHeight: '0'})),
      state('expanded', style({height: '*'})),
      transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ],
})


export class SeatReservationComponent implements AfterViewChecked {
  reproduction: Reproduction;
  theater: Theater;
  seats: string[][];
  soldTickets: Ticket[];
  marked: TicketReserve[] = [];
  dataSource = new MatTableDataSource<any>([]);
  columnsToDisplay: string[] = ['seat', 'originalPrice', 'discount', 'finalPrice'];
  expandedElement: TicketReserve | null;

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
        TicketReserve.staticReprod = this.reproduction

        this.http.get<Theater>(baseUrl + 'api/theater/' + this.reproduction.theaterId).subscribe(
          result => {
            this.theater = result
            this.http.get<Ticket[]>(baseUrl + 'api/ticket/' + this.reproduction.id).subscribe(result => {
              this.soldTickets = result
              this.initSeats()
            })
          })
      }
      , error => console.log(error))
  }


  ngAfterViewChecked(): void {
  }

  initSeats(){
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
  }

  submit() {
    let id: string = ""
    this.route.queryParams.subscribe(params => {
      id = params.reproduction
    })
    this.http.post<Ticket[]>(this.baseUrl + 'api/ticket/', this.marked.map((ticketReserve) => {
      return ticketReserve.getAsTicket()
    })).subscribe(result => {
      this.http.get<Ticket[]>(this.baseUrl + 'api/ticket/' + this.reproduction.id).subscribe(result => {
        this.soldTickets = result
        this.initSeats()
        this.marked = []
    },error => console.log(error));
  })
  }

  seatClick(event) {
    let elem = event.target
    if (elem.checked) {
      let ij = elem.id.split(":").map(Number)
      this.marked.push(new TicketReserve("0", ["0"], ij[0], ij[1], elem))
    } else {
      this.marked.splice(this.marked.findIndex((element, index, array) => element.htmlSeat == elem), 1)
    }
    this.ticketsFormControl.setValue(this.marked.length > 0 ? this.marked.length : "")
    this.dataSource.data = this.marked
  }

  onChange() {

    if (isNaN(this.ticketsFormControl.value) || this.ticketsFormControl.value < 0 || this.ticketsFormControl.value > this.theater.columns * this.theater.rows - this.soldTickets.length) {
      for (const ticketReserve of this.marked) {
        ticketReserve.htmlSeat.checked = false
      }
      this.marked = []
      return
    }
    let offset: number = this.ticketsFormControl.value - this.marked.length
    let validSeats = Array.from(document.getElementById("seats").querySelectorAll("input")).filter(it => {
      return it.id != "0" && it.checked == false
    })
    if (offset > 0) {
      for (let j = 0; j < offset; j++) {
        let s = Math.floor(Math.random() * (validSeats.length - 1));
        let elem = <any>validSeats.splice(s, 1)[0]
        let ij = elem.id.split(":").map(Number)
        this.marked.push(new TicketReserve("0", ["0"], ij[0], ij[1], elem))
        elem.checked = true
      }
    } else if (offset < 0) {
      for (let j = 0; j < Math.abs(offset); j++) {
        let elem = this.marked.pop()
        elem.htmlSeat.checked = false
      }
    }
    this.dataSource.data = this.marked
  }
}

