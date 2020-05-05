import { Component, Input, OnInit, Inject } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';


import { RegisterBase } from '../shared/models/register-base';
import { RegisterControlService } from '../shared/service/register-control.service';
@Component({
  selector: 'app-dynamic-form',
  templateUrl: './dynamic-form.component.html',
  providers: [RegisterControlService]
})
export class DynamicFormComponent implements OnInit {

  @Input() registerlist: RegisterBase<string>[] = [];
  form: FormGroup;
  payLoad = '';

  constructor(private qcs: RegisterControlService,private http: HttpClient, @Inject('BASE_URL')private baseUrl: string) { }

  ngOnInit() {
    this.form = this.qcs.toFormGroup(this.registerlist);
  }

  onSubmit() {
    this.payLoad = JSON.stringify(this.form.getRawValue());

    this.sendPostRequest(this.payLoad).subscribe(
      res => {
        console.log(res);
      }
    );
    //this.http.post<any>(this.baseUrl + 'weatherforecast/SaveRegistrationDetails',  this.payLoad , { headers}).subscribe(res => { console.log(res) });
    this.payLoad = JSON.stringify(this.form.getRawValue());
  }
  sendPostRequest(data: any): Observable<any> {
    const headers = new HttpHeaders({
      'Content-Type': 'application/json'
      
    });
    const options = { headers: headers };
    return this.http.post<any>(this.baseUrl + 'register/SaveRegistrationDetails', data, options);

  }
}


