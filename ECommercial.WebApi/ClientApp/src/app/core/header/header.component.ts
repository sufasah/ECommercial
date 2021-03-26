import { asNativeElements, Component, OnInit } from '@angular/core';
import  $  from 'jquery';
import "bootstrap";
@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {

  logged=false;
  profileName="Fadıl";
  selectedCategory="All";

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

  clickSearchCategory(){

    (<any>$("#searchCategory")).dropdown("toggle");
  }
  clickCategoryDropdownItem(evt:any){
    this.selectedCategory=evt.target.innerText
  }
  categories=[
    "Arts & Crafts",
    "Automotive",
    "Baby",
    "Electronics",
    "Books",
    "Arts & Crafts",
    "Automotive",
    "Baby",
    "Electronics",
    "Books",
    "Arts & Crafts",
    "Automotive",
    "Baby",
    "Electronics",
    "Books",
    "Arts & Crafts",
    "Automotive",
    "Baby",
    "Electronics",
    "Books",
  ];
}
