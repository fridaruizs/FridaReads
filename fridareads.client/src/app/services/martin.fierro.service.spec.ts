import { TestBed } from '@angular/core/testing';

import { MartinFierroService } from './martin.fierro.service';

describe('MartinFierroService', () => {
  let service: MartinFierroService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MartinFierroService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
