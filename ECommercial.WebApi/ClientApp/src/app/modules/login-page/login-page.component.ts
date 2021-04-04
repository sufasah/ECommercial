import { Component, OnInit } from '@angular/core';
declare var $:any;
@Component({
  selector: 'app-login-page',
  templateUrl: './login-page.component.html',
  styleUrls: ['./login-page.component.scss']
})
export class LoginPageComponent implements OnInit {

  rememberMe=false;
  email="";

  constructor() { }

  ngOnInit(): void {

  }

  rememberMeChanged(){
    this.rememberMe=!this.rememberMe;
  }

  showPasswordPart(){
    let loginFirst = $(".login-first");
    let loginSecond = $(".login-second");

    loginFirst.addClass("d-none");
    loginSecond.removeClass("d-none");
  }

  showEmailPart(){
    let loginFirst = $(".login-first");
    let loginSecond = $(".login-second");

    loginFirst.removeClass("d-none");
    loginSecond.addClass("d-none");
  }


}
