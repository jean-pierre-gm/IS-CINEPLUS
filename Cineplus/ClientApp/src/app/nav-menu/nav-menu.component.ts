import { Component } from '@angular/core';
import {AuthorizeService, IUser} from "../../api-authorization/authorize.service";

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  public user: IUser;

  constructor(authorizeService: AuthorizeService) {
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
