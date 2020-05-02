import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DynamicFormRegisterComponent } from './dynamic-form-register.component';

describe('DynamicFormRegisterComponent', () => {
  let component: DynamicFormRegisterComponent;
  let fixture: ComponentFixture<DynamicFormRegisterComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DynamicFormRegisterComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DynamicFormRegisterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
