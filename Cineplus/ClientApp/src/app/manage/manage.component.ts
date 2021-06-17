import {Component, Inject, OnInit} from '@angular/core';
import {Role} from "../../models/role";
import {CineplusDataSource} from "../../models/cineplusDataSource";
import {UserWithRoles} from "../../models/userWithRoles";
import {HttpClient, HttpParams} from "@angular/common/http";
import {ActivatedRoute} from "@angular/router";
import {DataSourceConf} from "../../models/dataSourceConf";
import {MatCheckboxChange} from "@angular/material/checkbox";
import {Movie} from "../../models/movie";
import {FormControl, Validators} from "@angular/forms";
import {NotificationService} from "../notification.service";
import {ResourceLoader} from "@angular/compiler";

@Component({
  selector: 'app-manage',
  templateUrl: './manage.component.html',
  styleUrls: ['./manage.component.css']
})
export class ManageComponent implements OnInit {
  priceInPoints: number;

  public priceValidator: FormControl = new FormControl('',
    [Validators.required, Validators.min(1)])

  constructor(
    @Inject('BASE_URL') private baseUrl: string,
    private notificationService: NotificationService,
    private httpClient: HttpClient) { }

  ngOnInit() {
    this.httpClient.get<number[]>(this.baseUrl + 'api/priceInPoints').subscribe(result => {
      this.priceInPoints = result[0];
    }, error => this.notificationService.error$.next("Error loading price in points."))
  }

  submit() {
    if (this.priceValidator.valid) {
      this.httpClient.put<number[]>(this.baseUrl + 'api/priceInPoints', [this.priceInPoints]).subscribe(result => {
        this.priceInPoints = result[0];
        this.notificationService.success$.next("Price in points updated successfully.")
      }, error => this.notificationService.error$.next("Error updating price in points."))
    } else {
      this.notificationService.error$.next("Price must be greater than 0.")
    }
  }
}
