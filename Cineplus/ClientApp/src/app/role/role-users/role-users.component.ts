import {Component, Inject, OnDestroy, OnInit} from '@angular/core';
import {HttpClient, HttpParams} from "@angular/common/http";
import {ActivatedRoute, ActivatedRouteSnapshot} from "@angular/router";
import {Role} from "../../../models/role";
import {Pagination} from "../../../models/pagination";
import {AuthorizeService, IUser} from "../../../api-authorization/authorize.service";
import {User} from "../../../models/user";
import {UserWithRoles} from "../../../models/userWithRoles";
import {CineplusDataSource} from "../../../models/cineplusDataSource";
import {DataSourceConf} from "../../../models/dataSourceConf";
import {MatCheckboxChange} from "@angular/material/checkbox";

@Component({
  selector: 'app-role-users',
  templateUrl: './role-users.component.html',
  styleUrls: ['./role-users.component.css']
})
export class RoleUsersComponent implements OnInit, OnDestroy {

  user: IUser;
  roles: Role[];
  usersDataSource: CineplusDataSource<UserWithRoles>;
  get roleColumns(): string[] { return this.roles.map(r => r.name) }
  get displayedColumns(): string[] { return ["UserName"].concat(this.roleColumns) }

  constructor(private http: HttpClient,
              @Inject('BASE_URL') private baseUrl: string,
              private authService: AuthorizeService
  ) {

  }

  ngOnInit() {
    this.authService.getUser().subscribe(user => this.user = user);

    this.http.get<Role[]>(this.baseUrl + 'api/role/').subscribe(roles => {
      this.roles = roles;
    })

    let dsConf = new DataSourceConf();
    dsConf.endPoint = this.baseUrl + 'api/user'
    this.usersDataSource = new CineplusDataSource<UserWithRoles>(this.http, dsConf);
    this.usersDataSource.refresh()
  }

  ngOnDestroy() {
  }

  editUserRole($event: MatCheckboxChange, roleName, userId) {
    let httpParams = new HttpParams().set('userId', userId);
    this.http.post(this.baseUrl + 'api/role/' + roleName + '?' + httpParams.toString(), {}).toPromise()
      .then(response => {
        this.usersDataSource.refresh();
      }
  );
  }

  editPagination($event) {
    console.log($event)
    this.usersDataSource.currentPagination.pageSize = $event.pageSize;
    this.usersDataSource.setPage($event.pageIndex + 1);
  }

  applyFilter(input: string) {
    if (input !== '') {
      this.usersDataSource.filter('username', input);
    } else {
      this.usersDataSource.undoFilters();
    }
  }
}
