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

  showPart(elem:any){
    $(".login-part").addClass("d-none");
    $(elem).removeClass("d-none");
  }


}
