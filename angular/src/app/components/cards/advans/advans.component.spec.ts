import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdvansComponent } from './advans.component';

describe('AdvansComponent', () => {
  let component: AdvansComponent;
  let fixture: ComponentFixture<AdvansComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AdvansComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AdvansComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
