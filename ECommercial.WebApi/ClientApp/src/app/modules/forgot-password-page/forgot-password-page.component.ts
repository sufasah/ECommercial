import { Component, OnInit } from '@angular/core';
declare var $:any;

@Component({
  selector: 'app-forgot-password-page',
  templateUrl: './forgot-password-page.component.html',
  styleUrls: ['./forgot-password-page.component.scss']
})
export class ForgotPasswordPageComponent implements OnInit {

  email ="";

  constructor() { }

  ngOnInit(): void {
  }

  showPart(elem:any){
    $(".forgot-part").addClass("d-none");
    $(elem).removeClass("d-none");
  }
}
