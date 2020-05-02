import { Component, Input, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';


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

  constructor(private qcs: RegisterControlService) { }

  ngOnInit() {
    this.form = this.qcs.toFormGroup(this.registerlist);
  }

  onSubmit() {
    this.payLoad = JSON.stringify(this.form.getRawValue());
  }
}
