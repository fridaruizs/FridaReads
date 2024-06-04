import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';
import { User } from '../models/user.model';
import { tap } from 'rxjs/operators';
import { Router } from '@angular/router';


@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private apiUrl = 'https://localhost:7265/api/auth';
  private loggedIn = new BehaviorSubject<boolean>(false);
  
  constructor(private http: HttpClient, private router: Router) { }

  get isLoggedIn(): Observable<boolean> {
    return this.loggedIn.asObservable();
  }

  register(user: any): Observable<any> {
    return this.http.post(`${this.apiUrl}/register`, user);
    this.loggedIn.next(true);
  }

  login(user: any): Observable<any> {
    return this.http.post<any>(`${this.apiUrl}/login`, user).pipe(
      tap(response => {
        if (response && response.token && response.userId) {
          console.log("res", response);
          localStorage.setItem('userId', response.userId);
          localStorage.setItem('jwtToken', response.token);
          this.loggedIn.next(true);
          this.router.navigate(['/user']); 
        }
      })
    );
  }

  logout(): void {
    localStorage.removeItem('userEmail');
    localStorage.removeItem('jwtToken');
    this.loggedIn.next(false);
    this.router.navigate(['/login']);

  }

  getToken(): string | null {
    return localStorage.getItem('jwtToken');
  }
}
