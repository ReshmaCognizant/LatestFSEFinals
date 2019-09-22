import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PopsPurchaseorderComponent } from './project-manager-project.component';

describe('PopsPurchaseorderComponent', () => {
  let component: PopsPurchaseorderComponent;
  let fixture: ComponentFixture<PopsPurchaseorderComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PopsPurchaseorderComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PopsPurchaseorderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
