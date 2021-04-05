import { Component, OnInit } from '@angular/core';
declare var $:any;
@Component({
  selector: 'app-register-page',
  templateUrl: './register-page.component.html',
  styleUrls: ['./register-page.component.scss']
})
export class RegisterPageComponent implements OnInit {

  name="";
  email="";
  password="";

  constructor() { }

  ngOnInit(): void {
  }

  showPart(elem:any){
    $(".register-part").addClass("d-none");
    $(elem).removeClass("d-none");
  }

}
