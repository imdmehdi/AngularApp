import { Injectable } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

import { RegisterBase } from '../models/register-base';

@Injectable()
export class RegisterControlService {
  constructor() { }

  toFormGroup(registerlist: RegisterBase<string>[]) {
    let group: any = {};

    registerlist.forEach(register => {
      group[register.key] = register.required ? new FormControl(register.value || '', Validators.required)
        : new FormControl(register.value || '');
    });
    return new FormGroup(group);
  }
}
