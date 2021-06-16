import { Component } from '@angular/core';
import {AuthorizeService, IUser} from "../../api-authorization/authorize.service";
import { Router} from "@angular/router";

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  public user: IUser;

  constructor(public router: Router,public authorizeService: AuthorizeService) {
    authorizeService.getUser().subscribe(user => this.user = user);
  }

  isExpanded = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}
