import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SocietyDetailComponent } from './society-detail.component';

describe('SocietyDetailComponent', () => {
  let component: SocietyDetailComponent;
  let fixture: ComponentFixture<SocietyDetailComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [SocietyDetailComponent]
    });
    fixture = TestBed.createComponent(SocietyDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
