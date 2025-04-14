import { TestBed } from '@angular/core/testing';

import { HaniService } from './hani.service';

describe('HaniService', () => {
  let service: HaniService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(HaniService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
