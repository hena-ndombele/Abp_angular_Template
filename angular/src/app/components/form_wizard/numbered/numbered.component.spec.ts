import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NumberedComponent } from './numbered.component';

describe('NumberedComponent', () => {
  let component: NumberedComponent;
  let fixture: ComponentFixture<NumberedComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [NumberedComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NumberedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
