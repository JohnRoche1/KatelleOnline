import { BrowserModule } from '@angular/platform-browser';
import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CommandsComponent } from './commands/commands.component';
import { QuestionsGetComponent } from './questions/questions-get/questions-get.component';
import { QuestionsAnswerComponent } from './questions/questions-answer/questions-answer.component';
import { ShoppingComponent } from './shopping/shopping.component';
import { ShoppingBasketComponent } from './shoppingbasket/shoppingbasket.component';
import { ProductService } from './_services/product.service';

const appRoutes: Routes = [
  { path: '', component: HomeComponent},
  { path: 'questions-get', component: QuestionsGetComponent },
  { path: 'questions-answer/:id', component: QuestionsAnswerComponent },
  { path: 'commands', component: CommandsComponent },
  { path: 'shopping', component: ShoppingComponent },
  { path: 'basket', component: ShoppingBasketComponent }
];

@NgModule({
   declarations: [
      AppComponent,
      NavMenuComponent,
      HomeComponent,
      QuestionsGetComponent,
      QuestionsAnswerComponent,
      CommandsComponent,
      ShoppingComponent,
      ShoppingBasketComponent
   ],
   imports: [
	 CommonModule,
	 BrowserModule.withServerTransition({appId:'ng-cli-universal'}),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [ProductService],
  bootstrap: [AppComponent]
})
export class AppModule { }
