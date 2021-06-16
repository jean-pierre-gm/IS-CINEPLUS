import {AfterViewChecked, AfterViewInit, Component, Inject, ViewChild} from '@angular/core';
import {HttpClient, HttpHeaders} from "@angular/common/http";
import {ActivatedRoute} from "@angular/router";
import {Reproduction} from "../../models/reproduction";
import {Theater} from "../../models/theater";
import {Ticket} from "../../models/ticket";
import {FormControl, FormGroupDirective, NgForm, Validators} from "@angular/forms";
import {ErrorStateMatcher} from "@angular/material/core";
import {MatTableDataSource} from '@angular/material/table';
import {animate, state, style, transition, trigger} from '@angular/animations';
import {Seat} from "../../models/seat";
import {DateDiscount} from "../../models/dateDiscount";
import {PersonalDiscount} from "../../models/personalDiscount";
import {Pagination} from "../../models/pagination";
import {Discount} from "../../models/discount";
import {MAT_DIALOG_DATA, MatDialog, MatDialogRef} from "@angular/material/dialog";
import {CdTimerComponent, CdTimerModule} from 'angular-cd-timer';
import {BillingDialogComponent} from "./billing-dialog.component";
import {NotificationService} from "../notification.service";
import {Associate} from "../../models/associate";


class TicketReserve {
  constructor(row: number, col: number) {
    this.originalPrice = TicketReserve.staticReprod.price.toFixed(2)
    this.finalPrice = this.originalPrice
    let seat: Seat = new Seat();
    seat.row = row
    seat.column = col
    seat.theaterId = TicketReserve.staticReprod.theaterId
    this.seat = seat

    if (TicketReserve.staticdateDiscount) {
      let dis = {...TicketReserve.staticdateDiscount} as DateDiscount
      if (dis.enable) {
        dis.enable = false;
        this.discounts.push(dis)
      }
    }
    if (TicketReserve.staticpersonalDiscounts && TicketReserve.staticpersonalDiscounts.length > 0) {
      for (const pd of TicketReserve.staticpersonalDiscounts) {
        let dis = {...pd} as PersonalDiscount
        if (!dis.enable) continue;
        dis.enable = false
        this.discounts.push(dis)
      }
    }
  }

  updatePrice() {
    let totalDiscount = 0
    for (const discount of this.discounts) {
      if (discount.enable) {
        totalDiscount += discount.discount
      }
    }
    totalDiscount = Math.min(totalDiscount, 100)
    let price = Number(this.originalPrice)
    this.discount = `${totalDiscount}%`
    this.finalPrice = (price - price * totalDiscount / 100).toFixed(2)
  }

  discount: string = "0%"
  originalPrice: string;
  finalPrice: string;
  seat: Seat = null
  static staticReprod: Reproduction = null;
  static staticdateDiscount: DateDiscount;
  static staticpersonalDiscounts: PersonalDiscount[];
  discounts: Discount[] = [];

  getAsTicket() {
    let tck: Ticket = new Ticket()
    tck.seat = this.seat
    tck.reproductionId = TicketReserve.staticReprod.id
    let dateDiscount: DateDiscount[] = this.discounts.filter((d) => d.enable && (<DateDiscount>d).date != undefined) as DateDiscount[]
    let personalDiscount: PersonalDiscount[] = this.discounts.filter((d) => d.enable && (<PersonalDiscount>d).personalName != undefined) as PersonalDiscount[]

    if (dateDiscount) {
      tck.dateDiscount = dateDiscount[0]
    }
    if (personalDiscount) {
      tck.personalDiscounts = personalDiscount
    }
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


export class SeatReservationComponent {

  reproduction: Reproduction;
  theater: Theater;
  seats: string[][];
  soldSeats: Seat[];
  associate:Associate;
  selectedDataSource = new MatTableDataSource<TicketReserve>([]);
  selectedColumnsToDisplay: string[] = ['seat', 'originalPrice', 'discount', 'finalPrice'];
  selectedExpandedElement: TicketReserve | null;

  unpaidDatasource = new MatTableDataSource<Ticket>([]);
  unpaidColumnsToDisplay: string[] = ['seat', 'price'];

  time: number


  @ViewChild('cd', {static: false}) cd: CdTimerComponent;
  ticketsFormControl = new FormControl('', [
    Validators.required,
    Validators.min(1),
  ]);
  matcher = new MyErrorStateMatcher();

  constructor(private notificationService: NotificationService, public dialog: MatDialog, private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private route: ActivatedRoute) {
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

            this.http.get<Associate>(baseUrl + 'api/associate/').subscribe(
              result => {
                this.associate = result
                this.updateSeatsAndReserves()
                this.fetchDiscounts()
              })
          })
      }
      , error => this.notificationService.error$.next("Error o init: " + error))
  }



  onHoverSeat(event) {
    let elem = event.target.children[0]
    let rowSelection = document.getElementById(elem.id + "s")
    rowSelection = rowSelection != undefined ? rowSelection : document.getElementById(elem.id + "r")
    if (rowSelection === null) return
    if (event.type == 'mouseenter') {
      rowSelection.classList.add("hoverRow")
    } else {
      rowSelection.classList.remove("hoverRow")
    }
  }

  onHoverRow(event) {
    let elem = event.target
    let seat = document.getElementById(elem.id.slice(0, -1))
    if (seat === null) return
    if (event.type == 'mouseenter') {
      seat.parentElement.classList.add("hoverSeat")
    } else {
      seat.parentElement.classList.remove("hoverSeat")
    }
  }

  calcTotalSelectionPrice() {
    let sum: number = 0;
    if (this.selectedDataSource)
      for (let row of this.selectedDataSource.data) {
        if (row.finalPrice) sum += Number(row.finalPrice);
      }
    return sum;
  }


  calcTotalReservePrice() {
    let price = 0
    if (this.unpaidDatasource)
      for (let row of this.unpaidDatasource.data) {
        if (row.price) price += row.price;
      }
    return price;
  }

  async expire() {
    this.dialog.closeAll()
    await this.updateSeatsAndReserves()
  }


  async fetchNotAvailableSeatsAndUpdate() {
    let result: Seat[] = []
    try {
      result = await this.http.get<Seat[]>(this.baseUrl + 'api/seat/reserved/' + this.reproduction.id).toPromise()
    } catch {
      this.notificationService.error$.next("Error Fetching the seats: RelogIn and refresh page")
    }
    this.soldSeats = result

    this.ticketsFormControl.setValidators(Validators.compose([this.ticketsFormControl.validator, Validators.max(this.theater.columns * this.theater.rows - this.soldSeats.length)]))
    this.ticketsFormControl.updateValueAndValidity();

    this.seats = Array<Array<string>>(Array<string>(this.theater.rows))
    for (let i: number = 0; i < this.theater.rows; i++) {
      this.seats[i] = Array<string>(this.theater.columns)
      for (let j: number = 0; j < this.theater.columns; j++)
        this.seats[i][j] = `${i}:${j}:s`
    }
    for (const soldSeat of this.soldSeats) {
      this.seats[soldSeat.row][soldSeat.column] += "d"
    }
  }

  async fetchReservations() {
    let tickets: Ticket[] = []
    try {
      tickets = await this.http.get<Ticket[]>(this.baseUrl + 'api/ticket/reserved/' + this.reproduction.id).toPromise()
    } catch {
      this.notificationService.error$.next("Error Fetching Current Reserve: RelogIn and refresh page")
    }
    this.unpaidDatasource.data = tickets
    if (this.unpaidDatasource.data.length > 0) {
      let tick = this.unpaidDatasource.data[0]
      let reserveTimeout = 1
      this.time = Math.round(new Date(tick.reserveTime).getTime() / 1000) + reserveTimeout * 60 - Math.round(Date.now() / 1000)
      if (this.cd) {
        this.cd.stop()
        this.cd.startTime = this.time
        this.cd.start()
      }
    }
  }

  async fetchDiscounts() {
    let dateDiscount: DateDiscount = undefined
    try {
      let reprDate: Date = new Date(this.reproduction.startTime)
      dateDiscount = await this.http.get<DateDiscount>(this.baseUrl + 'api/datediscount/' + `${reprDate.getDate()}-${reprDate.getMonth()}-${reprDate.getFullYear()}`).toPromise()
    } catch (err) {
      if (err.status != 404) {
        this.notificationService.error$.next("Error Fetching Today Discounts: RelogIn and refresh page")
      }
    }
    TicketReserve.staticdateDiscount = dateDiscount
    let personalDiscounts: PersonalDiscount[] = []
    try {
      personalDiscounts = (await this.http.get<Pagination<PersonalDiscount>>(this.baseUrl + 'api/personaldiscount' + "?pageSize=50&currentPage=1").toPromise()).result
    } catch {
      this.notificationService.error$.next("Error Fetching Personal Discounts: RelogIn and refresh page")
    }
    TicketReserve.staticpersonalDiscounts = personalDiscounts
  }


  async updateSeatsAndReserves() {
    await this.fetchNotAvailableSeatsAndUpdate()
    await this.fetchReservations()
    for (const ticketReserve of this.unpaidDatasource.data) {
      let seat: HTMLInputElement = document.getElementById(`${ticketReserve.seat.row}:${ticketReserve.seat.column}:sd`) as HTMLInputElement;
      seat.parentElement.classList.add("reservedSeat")
    }
  }

  async reserve() {
    try {
      let headers = new HttpHeaders().set('Content-Type', 'application/json')
      let resp = await this.http.post<Ticket[]>(this.baseUrl + 'api/ticket/', this.selectedDataSource.data.map((ticketReserve) => {
        return ticketReserve.getAsTicket()
      }), {headers}).toPromise()
    } catch {
      this.notificationService.error$.next("Error Reserving tickets: RelogIn or refresh page, some other user may got one of your seat")
    }
    await this.updateSeatsAndReserves()
    this.selectedDataSource.data = []
    this.ticketsFormControl.reset()
  }

  async cancelReserve(id: string) {
    try {
      let resp = await this.http.delete(this.baseUrl + 'api/ticket/' + id).toPromise()
    } catch {
      this.notificationService.error$.next("Error Reserving tickets: RelogIn or refresh page")
    }
    await this.updateSeatsAndReserves()
  }


  seatClick(event) {
    let elem = event.target
    let ij = elem.id.split(":").map(Number)
    if (elem.checked) {
      this.selectedDataSource.data.push(new TicketReserve(ij[0], ij[1]))
    } else {
      this.selectedDataSource.data.splice(this.selectedDataSource.data.findIndex((element, index, array) => element.seat.row == ij[0] && element.seat.column == ij[1]), 1)
    }
    if (this.selectedDataSource.data) {
      this.ticketsFormControl.setValue(this.selectedDataSource.data.length)
    } else {
      this.ticketsFormControl.reset();
    }
    this.selectedDataSource._updateChangeSubscription()
  }

  sliderChange() {
    if (isNaN(this.ticketsFormControl.value) || this.ticketsFormControl.value < 0 || this.ticketsFormControl.value > this.theater.columns * this.theater.rows - this.soldSeats.length) {
      for (const ticketReserve of this.selectedDataSource.data) {
        let seatHtml: HTMLInputElement = document.getElementById(`${ticketReserve.seat.row}:${ticketReserve.seat.column}:s`) as HTMLInputElement;
        seatHtml.checked = false
      }
      this.selectedDataSource.data = []
      return
    }
    let offset: number = this.ticketsFormControl.value - this.selectedDataSource.data.length
    let validSeats = Array.from(document.getElementById("seats").querySelectorAll("input")).filter(it => {
      return !it.disabled && it.checked == false
    })
    if (offset > 0) {
      for (let j = 0; j < offset; j++) {
        let elem: HTMLInputElement = undefined;
        if (this.selectedDataSource.data.length > 0) {
          let ticketReserve = this.selectedDataSource.data[0]
          let lastij = [ticketReserve.seat.row, ticketReserve.seat.column]
          elem = validSeats.reduce((acc, curr) => {
            if (acc == undefined) return curr
            let accij = acc.id.split(":").map(Number)
            let currij = curr.id.split(":").map(Number)
            let distAcc = Math.sqrt(Math.pow(accij[0] - lastij[0], 2) + Math.pow(accij[1] - lastij[1], 2))
            let distCurr = Math.sqrt(Math.pow(currij[0] - lastij[0], 2) + Math.pow(currij[1] - lastij[1], 2))
            return distAcc > distCurr ? curr : acc
          })
        } else {
          let s = Math.floor(Math.random() * (validSeats.length - 1));
          elem = validSeats[s]
        }
        validSeats.splice(validSeats.indexOf(elem), 1)[0]
        let ij = elem.id.split(":").map(Number)
        this.selectedDataSource.data.push(new TicketReserve(ij[0], ij[1]))
        elem.checked = true
      }
    } else if (offset < 0) {
      for (let j = 0; j < Math.abs(offset); j++) {
        let ticketReserve = this.selectedDataSource.data.pop()
        let seatHtml: HTMLInputElement = document.getElementById(`${ticketReserve.seat.row}:${ticketReserve.seat.column}:s`) as HTMLInputElement;
        seatHtml.checked = false
      }
    }
    this.selectedDataSource._updateChangeSubscription()
  }

  openDialog(): void {
    const dialogRef = this.dialog.open(BillingDialogComponent, {
      disableClose: true,
      minWidth:"30%",
      data: {
        that: this,
        order: this.unpaidDatasource.data[0].orderId,
        seatCount: this.unpaidDatasource.data.length,
        price: this.calcTotalReservePrice()
      },
    });

    dialogRef.afterClosed().subscribe(result => {
    });
  }

}


