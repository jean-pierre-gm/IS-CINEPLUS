import {Component, Inject, OnInit} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Movie} from "../../models/movie";
import {Genre} from "../../models/genre";
import {Pagination} from "../../models/pagination";
import {CineplusDataSource} from "../../models/cineplusDataSource";
import {DataSourceConf} from "../../models/dataSourceConf";

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit{

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
  }

  ngOnInit() {

  }
}
