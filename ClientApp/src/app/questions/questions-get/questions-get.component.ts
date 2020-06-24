import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators, FormControl } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-questions-get',
  templateUrl: './questions-get.component.html',
  styleUrls: ['./questions-get.component.css']
})
export class QuestionsGetComponent implements OnInit {

  questionGetForm: FormGroup;
  constructor(private fb: FormBuilder, private router: Router) { }

  ngOnInit() {

    this.questionGetForm = this.fb.group({
      questionType: [null, Validators.required]
    })
  }

  // Getter methods for form controls
  get questionType() {
    return this.questionGetForm.get('questionType') as FormControl;
  }

  getQuestions()
  {
    this.router.navigate(['/questions-answer', +this.questionType.value])
  }

}
