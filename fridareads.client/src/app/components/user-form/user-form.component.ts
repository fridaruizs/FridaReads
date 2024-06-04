import { Component } from '@angular/core';
import { UserService } from '../../services/user.service';
import { User } from '../../models/user.model';

@Component({
  selector: 'app-user-form',
  templateUrl: './user-form.component.html',
  styleUrls: ['./user-form.component.css']
})
export class UserFormComponent {
  user: User = { name: '', email: '', password: '', isAdmin: true, texts: [] };

  constructor(private userService: UserService) {}

  onSubmit() {
    this.userService.addUser(this.user).subscribe(response => {
      console.log('User added successfully!', response);
      // Reset form or handle success response
    }, error => {
      console.error('Error adding user:', error);
    });
  }
}
