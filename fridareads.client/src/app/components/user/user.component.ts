import { Component, OnInit } from '@angular/core';
import { TextService } from '../../services/text.service';
import { Text } from '../../models/text.model';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {
  texts: Text[] = [];
  userId: number;

  constructor(private textService: TextService)
  {
    this.userId = parseInt(localStorage.getItem('userId') || '0', 10);
  }

  ngOnInit(): void {
    this.getTextsByUser();
  }
  getTextsByUser(): void {
    if (this.userId != 0) {
      this.textService.getTextsByUser(this.userId).subscribe(texts => {
        this.texts = texts;
      });
    } else {
      // TODO: handle when the email is not available
    }
  }

  onTextAdded(text: any): void {
    console.log(text);
    this.textService.addText(text).subscribe(newText => {
      this.texts.push(newText);
    });
  }
}
