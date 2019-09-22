import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PopsItemComponent } from './project-manager-task.component';

describe('PopsItemComponent', () => {
  let component: PopsItemComponent;
  let fixture: ComponentFixture<PopsItemComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PopsItemComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PopsItemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
