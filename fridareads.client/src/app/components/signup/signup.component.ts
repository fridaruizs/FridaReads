import { Component } from '@angular/core';
import { AuthService } from '../../services/auth.service';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent {
  name = '';
  email = '';
  password = '';
  isAdmin = false;
  errorMessage: string = '';

  constructor(private authService: AuthService) { }

  onSignup(): void {
    const user = {
      name: this.name,
      email: this.email,
      password: this.password,
      isAdmin: this.isAdmin
    };

    this.authService.register(user).subscribe(response => {
      console.log('User registered successfully', response);
    }, error => {
      console.error('Error registering user', error);
      this.errorMessage = 'Invalid registering credentials';
    });
  }
}
