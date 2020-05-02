import { Injectable } from '@angular/core';

import { RegisterDropdown } from '../models/register-dropdown';
import { RegisterBase } from '../models/register-base';
import { RegisterTextbox } from '../models/register-textbox';
import { of } from 'rxjs';

@Injectable()
export class RegisterService {

  // TODO: get from a remote source of question metadata
  getQuestions() {

    let registerlist: RegisterBase<string>[] = [

      new RegisterDropdown({
        key: 'brave',
        label: 'Bravery Rating',
        options: [
          { key: 'solid', value: 'Solid' },
          { key: 'great', value: 'Great' },
          { key: 'good', value: 'Good' },
          { key: 'unproven', value: 'Unproven' }
        ],
        order: 4
      }),

      new RegisterTextbox({
        key: 'firstName',
        label: 'First name',
        value: 'Bombasto',
        required: true,
        order: 1
      }),
      new RegisterTextbox({
        key: 'lastName',
        label: 'Last name',
        value: 'Khan',
        required: true,
        order: 2
      }),
      new RegisterTextbox({
        key: 'emailAddress',
        label: 'Email',
        type: 'email',
        order: 3
      })
    ];

    return of(registerlist.sort((a, b) => a.order - b.order));
  }
}
