import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FullscreenComponent } from './fullscreen.component';

describe('FullscreenComponent', () => {
  let component: FullscreenComponent;
  let fixture: ComponentFixture<FullscreenComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [FullscreenComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FullscreenComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
