import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { User } from './user';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'SocietyManagementApp';

  currentUser!: User;

  constructor(){}

}

