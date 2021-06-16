import {Component, Inject, OnInit} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {AuthorizeService} from "../../api-authorization/authorize.service";
import {Associate} from "../../models/associate";
import {MatDialog} from "@angular/material/dialog";
import {BecomeAssociateComponent} from "./become-associate/become-associate.component";
import {MatTabChangeEvent} from "@angular/material/tabs";

@Component({
  selector: 'app-client-profile',
  templateUrl: './client-profile.component.html',
  styleUrls: ['./client-profile.component.css']
})
export class ClientProfileComponent implements OnInit {

  public associate: Associate;
  edit: boolean;

  constructor(private httpClient: HttpClient,
              @Inject('BASE_URL') private baseUrl: string,
              private authService: AuthorizeService,
              public dialog: MatDialog) { }

  ngOnInit() {
    this.httpClient.get<Associate>(this.baseUrl + 'api/associate').subscribe(result => {
      this.associate = result;
      console.log(result)
    });
  }

  tabChange(event: MatTabChangeEvent){
    const tab = event.tab.textLabel;
    if(tab==="Associate") {
      this.ngOnInit()
    }
  }


  openDialog(): void {

    const dialogRef = this.dialog.open(BecomeAssociateComponent, {
      width: '250px'
    });

    dialogRef.afterClosed().subscribe(result => {
      if (!result) {
        console.log('The dialog was closed with cancel button');
      } else {
        console.log('The dialog was closed with ok button');
        let associate: Associate = result;
        this.httpClient.put<Associate>(this.baseUrl + 'api/associate', associate).toPromise().then(result => {
          this.associate = result;
        }).catch(error => {
          console.log("An error occurred", error)
        })
      }
    });
  }

}
