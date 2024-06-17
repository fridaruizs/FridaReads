import { Component, OnInit } from '@angular/core';
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

  editText(text: Text) {
    // Open the add-text form in editing mode
    // Pass the text object to the form for pre-filling
  }

  deleteText(text: Text) {
    // Remove the text from the texts array
    // You can also add a confirmation dialog if desired
  }

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
}
