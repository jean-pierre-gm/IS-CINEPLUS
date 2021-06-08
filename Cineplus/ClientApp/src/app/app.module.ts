import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
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
import {ManageComponent} from "./manage/manage.component";
import {MatTabsModule} from "@angular/material/tabs";
import {ManageMoviesComponent} from "./manage/manage-movies/manage-movies.component";
import {CreateMovieComponent} from "./manage/manage-movies/create-movie/create-movie.component";
import {MatDialogModule} from "@angular/material/dialog";
import {MatToolbarModule} from "@angular/material/toolbar";
import {MatAutocompleteModule} from "@angular/material/autocomplete";
import {MatSortModule} from "@angular/material/sort";
import {ManageGenresComponent} from "./manage/manage-genres/manage-genres.component";
import {CreateGenreComponent} from "./manage/manage-genres/create-genre/create-genre.component";
import {ClientProfileComponent} from "./client-profile/client-profile.component";
import {BecomeAssociateComponent} from "./client-profile/become-associate/become-associate.component";
import {DateDiscountComponent} from "./discounts/date-discount/date-discount.component";
import {DiscountsComponent} from "./discounts/discounts.component";
import {MatDatepickerModule} from "@angular/material/datepicker";
import {MatNativeDateModule} from "@angular/material/core";
import {ManageDateDiscountsComponent} from "./manage/manage-dateDiscounts/manage-dateDiscounts.component";
import {CreateDateDiscountComponent} from "./manage/manage-dateDiscounts/create-dateDiscount/create-dateDiscount.component";
import {ManagePersonalDiscountsComponent} from "./manage/manage-personalDiscounts/manage-personalDiscounts.component";
import {CreatePersonalDiscountComponent} from "./manage/manage-personalDiscounts/create-personalDiscount/create-personalDiscount.component";

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
    DiscountsComponent,
    ManageComponent,
    ManageMoviesComponent,
    CreateMovieComponent,
    ManageGenresComponent,
    CreateGenreComponent,
    ClientProfileComponent,
    BecomeAssociateComponent,
    ManageDateDiscountsComponent,
    CreateDateDiscountComponent,
    ManagePersonalDiscountsComponent,
    CreatePersonalDiscountComponent
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
      },
      {
        path: 'manage',
        component: ManageComponent,
        canActivate: [AuthorizeGuard],
        data: {permittedRoles: ["Manager", "Admin"]}
      },
      {
        path: 'client-profile',
        component: ClientProfileComponent,
        canActivate: [AuthorizeGuard]
      },
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
    MatNativeDateModule,
    MatTabsModule,
    MatDialogModule,
    MatToolbarModule,
    ReactiveFormsModule,
    MatAutocompleteModule,
  ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: AuthorizeInterceptor, multi: true }
  ],
  bootstrap: [AppComponent],
  entryComponents: [CreateMovieComponent, CreateGenreComponent, CreateDateDiscountComponent,
    CreatePersonalDiscountComponent, BecomeAssociateComponent]
})
export class AppModule { }
