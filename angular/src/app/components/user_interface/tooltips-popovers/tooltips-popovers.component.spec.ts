import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TooltipsPopoversComponent } from './tooltips-popovers.component';

describe('TooltipsPopoversComponent', () => {
  let component: TooltipsPopoversComponent;
  let fixture: ComponentFixture<TooltipsPopoversComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TooltipsPopoversComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TooltipsPopoversComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
