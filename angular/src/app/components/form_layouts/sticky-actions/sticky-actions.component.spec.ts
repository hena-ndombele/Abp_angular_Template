import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StickyActionsComponent } from './sticky-actions.component';

describe('StickyActionsComponent', () => {
  let component: StickyActionsComponent;
  let fixture: ComponentFixture<StickyActionsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [StickyActionsComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(StickyActionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
