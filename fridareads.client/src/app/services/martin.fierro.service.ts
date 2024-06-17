import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, map } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MartinFierroService {
  private apiUrl = 'https://localhost:7265/api/martinFierro';

  constructor(private http: HttpClient) { }

  getRandomPhrase(): Observable<string> {
    const headers = new HttpHeaders({
      'Content-Type': 'text/plain',
      'Accept': 'text/plain'
    });
  
    const options = { headers, responseType: 'text' as 'json' };
  
    return this.http.get<string>(`${this.apiUrl}/phrase`, options);
  }
  
}
