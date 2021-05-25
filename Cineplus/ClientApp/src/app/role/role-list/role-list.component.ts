import {Component, Inject, OnInit} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Role} from "../../../models/role";
import {faUser} from "@fortawesome/free-solid-svg-icons";

@Component({
  selector: 'app-role-list',
  templateUrl: './role-list.component.html',
  styleUrls: ['./role-list.component.css']
})
export class RoleListComponent implements OnInit {

  roles: Role[] = [];
  displayedColumns = ['id', 'name']
  faUser = faUser

  constructor(private httpClient: HttpClient,
              @Inject('BASE_URL') private baseUrl: string) {
    this.httpClient.get<Role[]>(baseUrl + 'api/role/').subscribe(roles => {
      this.roles = roles;
    })
  }

  ngOnInit() {
  }

}
