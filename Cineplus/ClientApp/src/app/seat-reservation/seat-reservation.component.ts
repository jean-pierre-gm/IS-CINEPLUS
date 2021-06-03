import {AfterContentInit, AfterViewChecked, AfterViewInit, Component, Inject, OnInit} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {ActivatedRoute} from "@angular/router";
import {Reproduction} from "../../models/reproduction";
import {Theater} from "../../models/theater";
import {Ticket} from "../../models/ticket";
import {FormControl, FormGroupDirective, NgForm, Validators} from "@angular/forms";
import {ErrorStateMatcher} from "@angular/material/core";
import {MatTableDataSource} from '@angular/material/table';


class TicketReserve{
  constructor(originalPrice:string,finalPrice:string,discount:string,col:number,row:number,htmlSeat:HTMLInputElement) {
    this.originalPrice = originalPrice
    this.finalPrice=finalPrice
    this.discount=discount;
    this.col=col;
    this.row=row;
    this.htmlSeat=htmlSeat;
  }

  originalPrice:string;
  finalPrice:string;
  discount:string;
  col:number;
  row:number;
  htmlSeat:HTMLInputElement;

  getSerializable(){
    return {"col":this.col,"row":this.row}
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
  styleUrls: ['./seat-reservation.component.css']
})
export class SeatReservationComponent implements AfterViewChecked {

  reproduction: Reproduction;
  theater: Theater;
  seats: string[][];
  soldTickets: Ticket[];
  marked : TicketReserve[] = [];
  displayedColumns: string[] = ['seat', 'originalPrice', 'discount','finalPrice'];
  dataSource = new MatTableDataSource<any>([]);
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


  ngAfterViewChecked(): void {
  }


  submit() {
    let id: string = ""
    this.route.queryParams.subscribe(params => {
      id = params.reproduction
    })
    let form = {"id":id,seats:[]};
    for (const ticketReserve of this.marked) {
      form.seats.push(ticketReserve.getSerializable())
    }
    this.http.post(this.baseUrl + 'api/ticket/' + id, form).subscribe();
  }

  seatClick(event) {
    let elem = event.target
    if (elem.checked) {
      let ij= elem.id.split(":").map(Number)
      this.marked.push(new TicketReserve("0","0","0",ij[0],ij[1],elem))
    } else {
      this.marked.splice(this.marked.findIndex((element, index, array)=>element.htmlSeat ==elem), 1)
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
        let ij= elem.id.split(":").map(Number)
        this.marked.push(new TicketReserve("0","0","0",ij[0],ij[1],elem))
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

