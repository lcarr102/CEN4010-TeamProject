import { Component, OnInit } from '@angular/core';
import { BookService } from '../../services/book/book.service';
import { Router, Params } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BookInterface } from '../../components/book/book.model';

@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.css']
})
export class BookComponent implements OnInit {
  
  searchForm: FormGroup;
  errorMessage: string = 'check it';
  public bookID: string = 'empty';
  book: BookInterface;

  constructor(
    private bookService: BookService,
	private router: Router,
	private fb: FormBuilder
  ) { 
    this.createForm();
  }
  
  createForm() {
    this.searchForm = this.fb.group({
      id: ['', Validators.required ]
    });
  }
  
  trySearch(value) {
    //this.book = this.bookService.findById(value)
	this.bookService.findById(value).subscribe(result => {
	  this.book = result;
	  });
	return this.book.id; 
  }

  ngOnInit() {
  }
}
