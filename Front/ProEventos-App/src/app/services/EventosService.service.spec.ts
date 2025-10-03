/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { EventosServiceService } from './EventosService.service';

describe('Service: EventosService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [EventosServiceService]
    });
  });

  it('should ...', inject([EventosServiceService], (service: EventosServiceService) => {
    expect(service).toBeTruthy();
  }));
});
