import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router } from '@angular/router';
import { Observable } from 'rxjs';
import {AuthorizeService, IUser} from './authorize.service';
import {map, tap} from 'rxjs/operators';
import { ApplicationPaths, QueryParameterNames } from './api-authorization.constants';

@Injectable({
  providedIn: 'root'
})
export class AuthorizeGuard implements CanActivate {
  constructor(private authorize: AuthorizeService, private router: Router) {
  }
  canActivate(
    _next: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean> | Promise<boolean> | boolean {
      return this.authorize.getUser()
        .pipe(map(user => this.handleAuthorization(user, _next, state)));
  }

  private handleAuthorization(user: IUser, next: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
    if (!user) {
      this.router.navigate(ApplicationPaths.LoginPathComponents, {
        queryParams: {
          [QueryParameterNames.ReturnUrl]: state.url
        }
      });
    } else {
      let roles = next.data['permittedRoles'] as string[];
      if (roles) {
        if (this.authorize.userInRoles(user, roles)) return true;
        this.router.navigate(ApplicationPaths.ForbiddenPathComponents)
      }
      return true;
    }
  }
}
