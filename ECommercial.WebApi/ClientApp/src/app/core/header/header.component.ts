import { AfterViewInit, Component, OnInit} from '@angular/core';
declare var $:any;
@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss'],
})
export class HeaderComponent implements OnInit,AfterViewInit{

  logged=false;
  profileName="Fadıl";
  selectedCategory="All";
  choosenLanguage="TR";
  languages = [
    {language:"Türkçe", code:"TR"},
    {language:"English", code:"EN"},
  ];

  constructor() {
  }
  ngAfterViewInit(): void {
    let self=this;
    $(document).ready(function(){
      let elem = $("#navCountry");
      let menu = elem.next();
      self.convertHoverDropdown(elem,menu);
  });
}

convertHoverDropdown(elem:any,menu:any){
  let shown=false
  let to:any,toh:any;
  elem.removeAttr("data-toggle");

  let enteredListener=function(){
    clearTimeout(toh);
    to=setTimeout(function(){
      if(!shown){
        elem.dropdown("toggle");
        shown=true;
      }
    },200);
  };

  let leavedListener=function(){
    clearTimeout(to);
    toh = setTimeout(function(){
      elem.dropdown("hide");
      shown=false;
    },400);
  };

  let menuEnteredListener=function(){
    clearTimeout(toh);
  };
  elem.on("mouseenter",enteredListener);
  elem.on("mouseleave",leavedListener);
  menu.on("mouseenter",menuEnteredListener);
  menu.on("mouseleave",leavedListener);
}

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
