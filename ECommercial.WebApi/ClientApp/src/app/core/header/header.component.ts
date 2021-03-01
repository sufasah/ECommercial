import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {

  logged=false;
  profileName="Fadıl";
  constructor() { }

  ngOnInit(): void {
  }

  searchAction(f:any){
    f.ent=2;
  }

}
