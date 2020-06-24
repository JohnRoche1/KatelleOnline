import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormBuilder, FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'app-questions-answer',
  templateUrl: './questions-answer.component.html',
  styleUrls: ['./questions-answer.component.css']
})
export class QuestionsAnswerComponent implements OnInit {

  questionType: number;
  questionForm: FormGroup;
  showAnswer: boolean = false;

  questions: string[];
  answers: string[];

  constructor(private route: ActivatedRoute, private router: Router, private fb: FormBuilder ){
  }

  ngOnInit() {
    this.createForm();

    this.route.params.subscribe(
        params => {
          this.questionType = +params['id'];
        }
    );

    this.questions = ["question 1", "question 2"]
    this.answers = ["answer 1", "anwers 2"]

    //this.question.setValue(this.questions[0]);

    this.questionForm.patchValue({
      question: this.questions[0],
      answer: this.answers[0]
    });
  }

  createForm(){
    this.questionForm = this.fb.group({
      question: [null],
      answer: [null]
    })
  }

  displayAnswer() {
    this.showAnswer = true;
  }
  // Crete getters
  get question() {
    return this.questionForm.get('question') as FormControl;
  }
  getnextQuestion()
  {
    this.showAnswer = false;
    this.questionForm.patchValue({
      question: this.questions[1],
      answer: this.answers[1]
    });

  }

  goBack()
  {
    console.log("Here")
    this.router.navigate(['questions-get']);
  }
}
