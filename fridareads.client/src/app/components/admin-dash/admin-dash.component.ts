import { Component } from '@angular/core';
import { TextService } from '../../services/text.service';
import { User } from '../../models/user.model';
import { Text } from '../../models/text.model';

@Component({
  selector: 'app-admin-dash',
  templateUrl: './admin-dash.component.html',
  styleUrl: './admin-dash.component.css'
})
export class AdminDashComponent {
  texts: Text[] = [];
  users: User[] = [];
  displayedColumns: string[] = ['name', 'author', 'stars', 'review', 'userId'];

  constructor(private textService: TextService) {
  }

  ngOnInit(): void {
    // validate isAdmin by authguard?
    this.loadTexts();
    this.loadUsers();
  }

  loadTexts(): void {
    this.textService.getAllTexts().subscribe(texts => { this.texts = texts });
  }

  loadUsers(): void {
    // TODO users
  }
}
