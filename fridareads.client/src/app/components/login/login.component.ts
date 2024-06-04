import { Component } from '@angular/core';
import { AuthService } from '../../services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  email = '';
  password = '';
  errorMessage: string = '';

  constructor(private authService: AuthService) { }

  onLogin(): void {
    const user = {
      email: this.email,
      password: this.password
    };

    this.authService.login(user).subscribe(response => {
      console.log('User logged in successfully', response);
    }, error => {
      console.error('Error logging in', error);
      this.errorMessage = 'Invalid login credentials';
    });
  }
}
