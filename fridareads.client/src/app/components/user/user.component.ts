import { Component, OnInit } from '@angular/core';
import { TextService } from '../../services/text.service';
import { Text } from '../../models/text.model';
import { MartinFierroService } from '../../services/martin.fierro.service';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {
  texts: Text[] = [];
  userId: number;
  phraseOfTheDay = "Hola!"

  constructor(private textService: TextService, private phraseService: MartinFierroService)
  {
    this.userId = parseInt(localStorage.getItem('userId') || '0', 10);
  }

  ngOnInit(): void {
    // this.getTextsByUser();
    this.phraseService.getRandomPhrase().subscribe(phrase => { 
      this.phraseOfTheDay = phrase;
    })
    
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
    this.textService.addText(text).subscribe(newText => {
      this.texts.push(newText);
    });
  }
}
