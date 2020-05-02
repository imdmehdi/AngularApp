import { Component, Input } from '@angular/core';
import { FormGroup } from '@angular/forms';

import { RegisterBase } from '../shared/models/register-base';


@Component({
  selector: 'app-dynamic-form-register',
  templateUrl: './dynamic-form-register.component.html'
})
export class DynamicFormRegisterComponent {
  @Input() register: RegisterBase<string>;
  @Input() form: FormGroup;
  get isValid() { return this.form.controls[this.register.key].valid; }
}
