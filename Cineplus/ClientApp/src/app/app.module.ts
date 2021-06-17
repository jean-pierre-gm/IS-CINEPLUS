import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import {HttpClientModule, HTTP_INTERCEPTORS} from '@angular/common/http';
import {RouterModule} from '@angular/router';

import {AppComponent, SnackBarComponent} from './app.component';
import {NavMenuComponent} from './nav-menu/nav-menu.component';
import {HomeComponent} from './home/home.component';
import {CounterComponent} from './counter/counter.component';
import {FetchDataComponent} from './fetch-data/fetch-data.component';
import {ApiAuthorizationModule} from 'src/api-authorization/api-authorization.module';
import {AuthorizeGuard} from 'src/api-authorization/authorize.guard';
import {AuthorizeInterceptor} from 'src/api-authorization/authorize.interceptor';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
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
import {BillingDialogComponent, SeatReservationComponent} from "./seat-reservation/seat-reservation.component";
import {MovieReproductionComponent} from "./movie-reproduction/movie-reproduction.component";
import {MatSliderModule} from "@angular/material/slider";
import {CarouselModule} from "ngx-owl-carousel-o";
import {MatGridListModule} from "@angular/material/grid-list";
import {MatSnackBarModule} from "@angular/material/snack-bar";
import {ManageCarouselComponent} from "./manage/manage-carousel/manage-carousel.component";
import {MatRadioModule} from "@angular/material/radio";
import {MatDatepickerModule} from "@angular/material/datepicker";
import {MatNativeDateModule} from "@angular/material/core";
import {ManageDateDiscountsComponent} from "./manage/manage-dateDiscounts/manage-dateDiscounts.component";
import {CreateDateDiscountComponent} from "./manage/manage-dateDiscounts/create-dateDiscount/create-dateDiscount.component";
import {ManagePersonalDiscountsComponent} from "./manage/manage-personalDiscounts/manage-personalDiscounts.component";
import {CreatePersonalDiscountComponent} from "./manage/manage-personalDiscounts/create-personalDiscount/create-personalDiscount.component";
import {ManageStatisticsComponent} from "./manage/manage-statistics/manage-statistics.component";
import {ChartsModule, ThemeService} from "ng2-charts";
import {MatButtonToggleModule} from "@angular/material/button-toggle";
import {ManageStatisticsGeneralComponent} from "./manage/manage-statistics/manage-statistics-general/manage-statistics-general.component";
import {ManageActorsComponent} from "./manage/manage-actors/manage-actors.component";
import {CreateActorComponent} from "./manage/manage-actors/create-actor/create-actor.component";
import { CdTimerModule } from 'angular-cd-timer';
import {MatSlideToggleModule} from "@angular/material/slide-toggle";
import {MatTooltipModule} from "@angular/material/tooltip";
import {QRCodeModule} from "angularx-qrcode";
import {NgxPrintModule} from "ngx-print";
import {MatExpansionModule} from "@angular/material/expansion";
import {ListMoviesComponent} from "./home/list-movies/list-movies.component";
import {MatProgressBarModule} from "@angular/material/progress-bar";
import {PurchaseHistoryComponent} from "./client-profile/purchase-history/purchase-history.component";
import {CancelationFormComponent} from "./client-profile/purchase-history/cancelation-form/cancelation-form.component";
import {MatChipsModule} from "@angular/material/chips";
import {MatIconModule} from "@angular/material/icon";
import {ManageStatisticsCountriesComponent} from "./manage/manage-statistics/manage-statistics-countries/manage-statistics-countries.component";
import {ManageStatisticsRangeComponent} from "./manage/manage-statistics/manage-statistics-range/manage-statistics-range.component";
import {ManageStatisticsScoreComponent} from "./manage/manage-statistics/manage-statistics-score/manage-statistics-score.component";

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
    BillingDialogComponent,
    SeatReservationComponent,
    MovieReproductionComponent,
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
    CreatePersonalDiscountComponent,
    ManageCarouselComponent,
    ManageStatisticsComponent,
    ManageStatisticsGeneralComponent,
    ManageActorsComponent,
    CreateActorComponent,
    ListMoviesComponent,
    ManageStatisticsCountriesComponent,
    ManageStatisticsRangeComponent,
    ManageStatisticsScoreComponent,
    SnackBarComponent,
    PurchaseHistoryComponent,
    CancelationFormComponent
  ],
    imports: [
        BrowserModule.withServerTransition({appId: 'ng-cli-universal'}),
      CdTimerModule,
        HttpClientModule,
        FormsModule,
        ApiAuthorizationModule,
        MatSnackBarModule,
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
                path: 'reproduction',
                component: MovieReproductionComponent
            },
            {
                path: 'reserve',
                component: SeatReservationComponent
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
        MatTabsModule,
        MatDialogModule,
        MatToolbarModule,
        ReactiveFormsModule,
        MatAutocompleteModule,
        MatSortModule,
        CarouselModule,
        MatGridListModule,
        MatSliderModule,
        MatRadioModule,
        MatDatepickerModule,
        MatNativeDateModule,
        MatExpansionModule,
        MatProgressBarModule,
        ChartsModule,
        MatButtonToggleModule,
        MatIconModule,
        MatSlideToggleModule,
        MatChipsModule,
        MatTooltipModule,
        QRCodeModule,
        NgxPrintModule,
    ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: AuthorizeInterceptor, multi: true },
    ThemeService
  ],
  bootstrap: [AppComponent],
  entryComponents: [CreateMovieComponent, CreateGenreComponent, CreateDateDiscountComponent, CreateActorComponent,
    CreatePersonalDiscountComponent, BecomeAssociateComponent, BillingDialogComponent, CancelationFormComponent, SnackBarComponent]
})
export class AppModule { }
