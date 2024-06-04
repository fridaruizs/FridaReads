import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Text } from '../models/text.model';

@Injectable({
  providedIn: 'root'
})
export class TextService {
  private apiUrl = 'https://localhost:7265/api/text';

  constructor(private http: HttpClient) { }

  getAllTexts(): Observable<Text[]> {
    // return this.http.get<Text[]>(this.apiUrl);
    return this.http.get<Text[]>(this.apiUrl, { headers: this.getHeaders() });
  }

  getTextsByUser(id: number): Observable<Text[]> {
    // return this.http.get<Text[]>(`${this.apiUrl}/user/${id}`,);
    return this.http.get<Text[]>(`${this.apiUrl}/user/${id}`, { headers: this.getHeaders() });

  }

  addText(text: Text): Observable<Text> {
    // return this.http.post<Text>(this.apiUrl, text);
    return this.http.post<Text>(this.apiUrl, text, { headers: this.getHeaders() });
  }

  private getHeaders(): HttpHeaders {
    const token = localStorage.getItem('jwtToken');
    return new HttpHeaders().set('Authorization', `Bearer ${token}`);
  }
}
