import { TestBed } from '@angular/core/testing';

import { SocietyServiceService } from './society-service.service';

describe('SocietyServiceService', () => {
  let service: SocietyServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SocietyServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
