import {Component, Inject} from "@angular/core";
import {MAT_DIALOG_DATA, MatDialogRef} from "@angular/material/dialog";
import {HttpClient, HttpHeaders} from "@angular/common/http";
import {AuthorizeService, IUser} from "../../api-authorization/authorize.service";
import {NotificationService} from "../notification.service";
import {Associate} from "../../models/associate";

@Component({
  selector: 'billing-dialog',
  templateUrl: './billing-dialog.component.html',
  styleUrls: ['./billing-dialog.component.css'],
})
export class BillingDialogComponent {
  public user: IUser;
  associate: Associate;

  constructor(private notificationService: NotificationService,
              private http: HttpClient,
              @Inject('BASE_URL') private baseUrl: string,
              public authorizeService: AuthorizeService,
              public dialogRef: MatDialogRef<BillingDialogComponent>,
              @Inject(MAT_DIALOG_DATA) public data) {
    authorizeService.getUser().subscribe(user => this.user = user);

    this.http.get<Associate>(baseUrl + 'api/associate/').subscribe(
      result => {
        this.associate = result

      })
  }

  purchaseCompleted: boolean = false
  printed: boolean = false

  async makeOrder(type: string = "user") {
    const headers = new HttpHeaders()
      .set('Content-Type', 'application/json')
    try {
      let result = await this.http.post(this.baseUrl + `api/ticket/order/${type}/`, "\"" + this.data.order + "\"", {headers}).toPromise()
    } catch {
      this.notificationService.error$.next("Error in purchase")
      this.dialogRef.close()
    }
    this.purchaseCompleted = true
    await  this.data.that.updateSeatsAndReserves()
  }


}
