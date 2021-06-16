import {Component, Inject} from "@angular/core";
import {MAT_DIALOG_DATA, MatDialogRef} from "@angular/material/dialog";
import {HttpHeaders} from "@angular/common/http";
import {AuthorizeService, IUser} from "../../api-authorization/authorize.service";
import {NotificationService} from "../notification.service";

@Component({
  selector: 'billing-dialog',
  templateUrl: './billing-dialog.component.html',
  styleUrls: ['./billing-dialog.component.css'],
})
export class BillingDialogComponent {
  public user: IUser;

  constructor(private notificationService: NotificationService,
              public authorizeService: AuthorizeService,
              public dialogRef: MatDialogRef<BillingDialogComponent>,
              @Inject(MAT_DIALOG_DATA) public data) {
    authorizeService.getUser().subscribe(user => this.user = user);
  }

  purchaseCompleted: boolean = false
  printed: boolean = false

  async makeOrder(type: string = "user") {
    const headers = new HttpHeaders()
      .set('Content-Type', 'application/json')
    try {
      let result = await this.data.that.http.post(this.data.that.baseUrl + `api/ticket/order/${type}/`, "\"" + this.data.order + "\"", {headers}).toPromise()
    } catch {
      this.notificationService.error$.next("Error in purchase")
      this.dialogRef.close()
    }
    this.purchaseCompleted = true
    await  this.data.that.updateSeatsAndReserves()
  }


}
