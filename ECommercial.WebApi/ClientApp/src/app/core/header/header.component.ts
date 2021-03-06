import { asNativeElements, Component, OnInit } from '@angular/core';
import { $ } from 'protractor';

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

  searchInputFocus(){
    document.getElementById("searchbar")?.classList.add("input-focused");
  }
  searchInputFocusOut(){
    document.getElementById("searchbar")?.classList.remove("input-focused");
  }

}
