import {Component, Inject, OnInit} from '@angular/core';
import {MatDialogRef} from "@angular/material/dialog";
import {HttpClient} from "@angular/common/http";

@Component({
  selector: 'app-cancelation-form',
  templateUrl: './cancelation-form.component.html',
  styleUrls: ['./cancelation-form.component.css']
})
export class CancelationFormComponent implements OnInit {

  constructor(
    private httpClient: HttpClient,
    public dialogRef: MatDialogRef<CancelationFormComponent>,
    @Inject('BASE_URL') private baseUrl: string) {}

  onNoClick(): void {
    this.dialogRef.close();
  }

  ngOnInit() {
  }

  onSubmitClick() {
    this.dialogRef.close(true);
  }
}
