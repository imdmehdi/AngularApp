import { Injectable } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

import { RegisterBase } from '../models/register-base';

@Injectable()
export class RegisterControlService {
  constructor() { }

  toFormGroup(questions: RegisterBase<string>[]) {
    let group: any = {};

    questions.forEach(question => {
      group[question.key] = question.required ? new FormControl(question.value || '', Validators.required)
        : new FormControl(question.value || '');
    });
    return new FormGroup(group);
  }
}
