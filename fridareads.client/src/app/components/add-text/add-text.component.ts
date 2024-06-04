import { Component } from '@angular/core';
import { Text } from '../../models/text.model';
import { TextService } from '../../services/text.service';

@Component({
  selector: 'app-add-text',
  templateUrl: './add-text.component.html',
  styleUrls: ['./add-text.component.css']
})
export class AddTextComponent {
  text: Text = {
    name: '',
    author: '',
    description: '',
    readDate: new Date(),
    stars: 0,
    review: '',
    userId: 0,
  };

  userId: number;

  constructor(private textService: TextService) {
    this.userId = parseInt(localStorage.getItem('userId') || '0', 10);
   }

  onSubmit(): void {
    this.text.userId = this.userId;
    this.textService.addText(this.text).subscribe(newText => {
      console.log('Text added successfully', newText);
      this.text = {
        name: '',
        author: '',
        description: '',
        readDate: new Date(),
        stars: 0,
        review: '',
        userId: this.userId,
      };
    }, error => {
      console.error('Error adding text', error);
    });
  }
}
