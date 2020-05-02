import { Component } from '@angular/core';
import { RegisterService } from '../shared/service/register.service';
import { RegisterBase } from '../shared/models/register-base';
import { Observable } from 'rxjs';
@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
  providers: [RegisterService]
})

export class RegisterComponent {
  registerlist$: Observable<RegisterBase<any>[]>;

  constructor(service: RegisterService) {
    this.registerlist$ = service.getQuestions();
  }
}
