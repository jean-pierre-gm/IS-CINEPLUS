import {Component, Inject, OnInit} from '@angular/core';
import {CineplusDataSource} from "../../models/cineplusDataSource";
import {Reproduction} from "../../models/reproduction";
import {HttpClient} from "@angular/common/http";
import {ActivatedRoute} from "@angular/router";
import {DataSourceConf} from "../../models/dataSourceConf";
import {Pagination} from "../../models/pagination";
import {Movie} from "../../models/movie";
import {FormControl, Validators} from "@angular/forms";
import {Theater} from "../../models/theater";
import {MatSnackBar} from "@angular/material/snack-bar";
import {MyErrorStateMatcher} from "../seat-reservation/seat-reservation.component";
import {AuthorizeService, IUser} from "../../api-authorization/authorize.service";

@Component({
  selector: 'app-movie-reproduction',
  templateUrl: './movie-reproduction.component.html',
  styleUrls: ['./movie-reproduction.component.css']
})
export class MovieReproductionComponent implements OnInit {

  public user: IUser;

  reproductionData: CineplusDataSource<Reproduction>
  movie: Movie
  displayedColumns: string[] = ['theaterId', 'startTime', 'price', 'availSeats'];

  dateTimeFormControl = new FormControl('', [Validators.required])
  priceFormControl = new FormControl('', [Validators.required, Validators.min(0)])
  theaterFormControl = new FormControl('', [Validators.required])

  matcher = new MyErrorStateMatcher()

  public newReproduction: Reproduction = new Reproduction();
  public theaters: Theater[];

  constructor(private http: HttpClient, private _snackBar: MatSnackBar, @Inject('BASE_URL') private baseUrl: string,
              private route: ActivatedRoute, public authorizeService: AuthorizeService) {
    authorizeService.getUser().subscribe(user => this.user = user);
    let id: string = ""
    this.route.queryParams.subscribe(params => {id = params.movie})
    let reproductionSourceConf: DataSourceConf = new DataSourceConf()
    reproductionSourceConf.endPoint = baseUrl + 'api/reproduction'
    let reproductionPagination: Pagination<Reproduction> = new Pagination()
    this.reproductionData = new CineplusDataSource<Reproduction>(http, reproductionSourceConf, reproductionPagination)
    this.reproductionData.httpParams = this.reproductionData.httpParams.set('movieId', id)
    this.reproductionData.refresh()
    this.http.get<Movie>(baseUrl + 'api/movie/'  + id).subscribe(t => this.movie = t)
    this.http.get<Theater[]>(this.baseUrl + 'api/theater').subscribe(theaters => this.theaters = theaters)
  }

  ngOnInit() {
  }

  editPagination($event) {
    console.log($event)
    this.reproductionData.currentPagination.pageSize = $event.pageSize;
    this.reproductionData.setPage($event.pageIndex + 1);
  }

  AddReproduction() {
    console.log("SUBMIT")
    if (!this.dateTimeFormControl.valid || (new Date(this.dateTimeFormControl.value)).getTime() <= Date.now()) {
      this._snackBar.open("Date or time is invalid", "", {'duration': 2000})
      return;
    }
    if (!this.theaterFormControl.valid) {
      this._snackBar.open("Theater is invalid", "", {'duration': 2000})
      return;
    }
    if (!this.priceFormControl.valid) {
      this._snackBar.open("Price is invalid", "", {'duration': 2000})
      return;
    }
    this.newReproduction.movie = this.movie
    this.newReproduction.startTime = this.dateTimeFormControl.value
    this.newReproduction.price = this.priceFormControl.value
    this.http.post<Reproduction>(this.baseUrl + 'api/reproduction', this.newReproduction).subscribe(reproduction => {
      this.dateTimeFormControl.reset()
      this.theaterFormControl.reset()
      this.priceFormControl.reset()
      this.reproductionData.refresh()
      console.log(reproduction)
    }, error => {
      this._snackBar.open("Reproduction can't be added", "", {'duration': 2000})
      console.log(error)
    })
  }

  setNewReproductionTheater($event, theater){
    if($event.source.selected)
      this.newReproduction.theater = theater
  }
}
