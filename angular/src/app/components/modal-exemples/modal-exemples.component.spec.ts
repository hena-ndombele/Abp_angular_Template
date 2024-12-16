import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ModalExemplesComponent } from './modal-exemples.component';

describe('ModalExemplesComponent', () => {
  let component: ModalExemplesComponent;
  let fixture: ComponentFixture<ModalExemplesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ModalExemplesComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ModalExemplesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
