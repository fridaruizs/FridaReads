import { Component, OnInit, Input } from '@angular/core';
import { Text } from '../../models/text.model';
import { TextService } from '../../services/text.service';

@Component({
  selector: 'app-text-list',
  templateUrl: './text-list.component.html',
  styleUrls: ['./text-list.component.css']
})
export class TextListComponent implements OnInit {
  texts: Text[] = [];
  userId: number;

  displayedColumns: string[] = ['name', 'author', 'description', 'readDate', 'stars', 'review', 'actions'];

  constructor(private textService: TextService) {
    this.userId = parseInt(localStorage.getItem('userId') || '0', 10);
  }

  ngOnInit(): void {
    this.loadTexts();
  }

  loadTexts(): void {
    this.textService.getTextsByUser(this.userId).subscribe(texts => {
      this.texts = texts;
    });
  }
  
  editText(text: Text) {
    // TODO send to edit first
    // this.textService.updateText(text);
    this.loadTexts();
  }

  deleteText(text: Text) {
    this.textService.deleteText(text);
    this.loadTexts();
  }
}
