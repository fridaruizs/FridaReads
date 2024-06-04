import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { AuthService } from './services/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  title = 'FridaReads';
  isLoggedIn: boolean = false;

  constructor(private authService: AuthService, private router: Router) {
    this.authService.isLoggedIn.subscribe(status => {
      this.isLoggedIn = status;
    });
  }

  ngOnInit() {
  }

  logout(): void {
    this.authService.logout();
    this.router.navigate(['/login']);
  }
  
}
