import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BuyerAuthComponent } from './buyer-auth.component';

describe('BuyerAuthComponent', () => {
  let component: BuyerAuthComponent;
  let fixture: ComponentFixture<BuyerAuthComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [BuyerAuthComponent]
    });
    fixture = TestBed.createComponent(BuyerAuthComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
