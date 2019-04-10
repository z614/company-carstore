import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CarRowComponent } from './car-row.component';

describe('CarRowComponent', () => {
  let component: CarRowComponent;
  let fixture: ComponentFixture<CarRowComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CarRowComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CarRowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
