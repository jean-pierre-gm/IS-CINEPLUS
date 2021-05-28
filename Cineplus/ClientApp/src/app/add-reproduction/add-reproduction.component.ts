import {Component, Inject, OnInit} from '@angular/core';
import {Reproduction} from "../../models/reproduction";
import {HttpClient} from "@angular/common/http";
import {Movie} from "../../models/movie";
import {Theater} from "../../models/theater";
import {FormControl, FormGroupDirective, NgForm, Validators} from "@angular/forms";
import {MyErrorStateMatcher} from "../seat-reservation/seat-reservation.component";

@Component({
  selector: 'app-add-reproduction',
  templateUrl: './add-reproduction.component.html',
  styleUrls: ['./add-reproduction.component.css']
})
export class AddReproductionComponent implements OnInit {

  idFormControl = new FormControl('', [Validators.required]);
  dateTimeFormControl = new FormControl('', [Validators.required])
  movieFormControl = new FormControl('', [Validators.required])
  theaterFormControl = new FormControl('', [Validators.required])

  matcher = new MyErrorStateMatcher()

  public newReproduction: Reproduction = new Reproduction();
  public movies: Movie[];
  public theaters: Theater[];

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    this.http.get<Movie[]>(this.baseUrl + 'api/movie/all').subscribe(movies => this.movies = movies)
    this.http.get<Theater[]>(this.baseUrl + 'api/theater').subscribe(theaters => this.theaters = theaters)
  }

  ngOnInit() {
  }

  AddReproduction() {
    console.log("SUBMIT")
    if ((!this.newReproduction.theater && !this.newReproduction.theaterId) ||
      !this.newReproduction.startTime ||
      (!this.newReproduction.movie && !this.newReproduction['movieId']))
        return;
    this.http.post<Reproduction>(this.baseUrl + 'api/reproduction', this.newReproduction).subscribe(reproduction => {
      if(reproduction) {
        this.newReproduction = new Reproduction();
        this.idFormControl.setValue("")
        this.movieFormControl.setValue("")
        this.dateTimeFormControl.setValue("")
        this.theaterFormControl.setValue("")
      }
      console.log(reproduction)
      }, error => console.log(error))
  }

  setNewReproductionMovie($event, movie) {
    if ($event.source.selected){
      this.newReproduction.movie = movie
    }
  }

  setNewReproductionTheater($event, theater){
    if($event.source.selected)
      this.newReproduction.theater = theater
  }
}
