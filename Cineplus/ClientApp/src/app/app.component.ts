import {Component, Inject, Input, OnInit} from '@angular/core';
import {NotificationService} from "./notification.service";
import {MAT_SNACK_BAR_DATA, MatSnackBar, MatSnackBarRef} from "@angular/material/snack-bar";
import {faWindowClose} from "@fortawesome/free-solid-svg-icons";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app';
  snackDuration = 5000

  constructor(
    private notificationService: NotificationService, private snackBar: MatSnackBar
  ) {
    this.notificationService.success$.subscribe( message => {
      this.snackBar.openFromComponent(SnackBarComponent, {
        duration: this.snackDuration,
        data: { message: message },
        panelClass: ['success-snackbar']
      });
    });

    this.notificationService.error$.subscribe( message => {
      this.snackBar.openFromComponent(SnackBarComponent, {
        duration: this.snackDuration,
        data: { message: message },
        panelClass: ['error-snackbar']
      });
    });

    this.notificationService.warning$.subscribe( message => {
      this.snackBar.openFromComponent(SnackBarComponent, {
        duration: this.snackDuration,
        data: { message: message },
        panelClass: ['warning-snackbar']
      });
    });
  }
}


@Component({
  selector: 'snack-bar-component',
  template: `
    <span class="text-dark" style="margin-right: 16px">{{message}}</span>
    <button class="float-right btn" style="padding: unset !important;" (click)="snackBarRef.dismiss()">
      <fa-icon [icon]="faWindowClose"></fa-icon>
    </button>
  `,
})
export class SnackBarComponent {
  public message: string;
  public faWindowClose = faWindowClose;

  constructor(public snackBarRef: MatSnackBarRef<SnackBarComponent>,
              @Inject(MAT_SNACK_BAR_DATA) public data: {message: string}) {
    this.message = data.message;
  }
}
