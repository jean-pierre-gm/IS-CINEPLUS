import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { ApiAuthorizationModule } from 'src/api-authorization/api-authorization.module';
import { AuthorizeGuard } from 'src/api-authorization/authorize.guard';
import { AuthorizeInterceptor } from 'src/api-authorization/authorize.interceptor';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatCardModule} from "@angular/material/card";
import {MatInputModule} from "@angular/material/input";
import {MatButtonModule} from "@angular/material/button";
import {MatDividerModule} from "@angular/material/divider";
import {MatSelectModule} from "@angular/material/select";
import {ApiTestComponent} from "./api-test/api-test.component";
import {ForbiddenComponent} from "./forbidden/forbidden.component";
import {RoleListComponent} from "./role/role-list/role-list.component";
import {MatTableModule} from "@angular/material/table";
import {FontAwesomeModule} from "@fortawesome/angular-fontawesome";
import {MatListModule} from "@angular/material/list";
import {RoleUsersComponent} from "./role/role-users/role-users.component";
import {MatPaginatorModule} from "@angular/material/paginator";
import {MatCheckboxModule} from "@angular/material/checkbox";
import {DateDiscountComponent} from "./discounts/date-discount/date-discount.component";
import {DiscountsComponent} from "./discounts/discounts.component";
import {MatSortModule} from "@angular/material/sort";
import {MatDatepickerModule} from "@angular/material/datepicker";
import {MatNativeDateModule} from "@angular/material/core";

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    ApiTestComponent,
    ForbiddenComponent,
    RoleListComponent,
    RoleUsersComponent,
    DateDiscountComponent,
    DiscountsComponent
  ],
    imports: [
        BrowserModule.withServerTransition({appId: 'ng-cli-universal'}),
        HttpClientModule,
        FormsModule,
        ApiAuthorizationModule,
        RouterModule.forRoot([
            {path: '', component: HomeComponent, pathMatch: 'full'},
            {path: 'counter', component: CounterComponent},
            {path: 'fetch-data', component: FetchDataComponent, canActivate: [AuthorizeGuard]},
            {
                path: 'api-test', component: ApiTestComponent,
                canActivate: [AuthorizeGuard], data: {permittedRoles: ["Manager", "Admin"]}
            },
            {path: 'forbidden', component: ForbiddenComponent},
            {
                path: 'role-list',
                component: RoleListComponent,
                canActivate: [AuthorizeGuard],
                data: {permittedRoles: ["Admin"]}
            },
            {
                path: 'role-users',
                component: RoleUsersComponent,
                canActivate: [AuthorizeGuard],
                data: {permittedRoles: ["Admin"]}
            },
            {
                path: 'discounts',
                component: DiscountsComponent,
                canActivate: [AuthorizeGuard],
                data: {permittedRoles: ["Admin"]}
            },
            {
                path: 'date-discount',
                component: DateDiscountComponent,
                canActivate: [AuthorizeGuard],
                data: {permittedRoles: ["Admin"]}
            }
        ]),
        BrowserAnimationsModule,
        MatCardModule,
        MatInputModule,
        MatButtonModule,
        MatDividerModule,
        MatSelectModule,
        MatTableModule,
        FontAwesomeModule,
        MatListModule,
        MatPaginatorModule,
        MatCheckboxModule,
        MatSortModule,
        MatDatepickerModule,
        MatNativeDateModule
    ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: AuthorizeInterceptor, multi: true }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
