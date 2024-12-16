import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PaginationBreagComponent } from './pagination-breag.component';

describe('PaginationBreagComponent', () => {
  let component: PaginationBreagComponent;
  let fixture: ComponentFixture<PaginationBreagComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PaginationBreagComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PaginationBreagComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
