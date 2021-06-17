import { Injectable } from '@angular/core';
import {Observer, Subject} from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class NotificationService {

  public success$: Subject<string> = new Subject();
  public error$: Subject<string> = new Subject();
  public warning$: Subject<string> = new Subject();

  constructor() {

  }
}
