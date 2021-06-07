import {Component, Inject, OnInit} from '@angular/core';
import {Role} from "../../models/role";
import {CineplusDataSource} from "../../models/cineplusDataSource";
import {UserWithRoles} from "../../models/userWithRoles";
import {HttpClient, HttpParams} from "@angular/common/http";
import {ActivatedRoute} from "@angular/router";
import {DataSourceConf} from "../../models/dataSourceConf";
import {MatCheckboxChange} from "@angular/material/checkbox";
import {Movie} from "../../models/movie";

@Component({
  selector: 'app-manage',
  templateUrl: './manage.component.html',
  styleUrls: ['./manage.component.css']
})
export class ManageComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }
}
