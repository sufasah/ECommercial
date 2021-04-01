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

  dropdowns:any=[]
  constructor() {
  }
  ngAfterViewInit(): void {
    let self=this;
    $(document).ready(function(){
      let elem = $("#navCountry");
      let menu = elem.next();

      let navCountryForeground = $(".ecom-foreground[aria-labelledby='navCountry']");
      let header = $("header");
      let body=$("body");

      let footerCountry = $("#footerCountry");
      let footerMenu=footerCountry.next();

      self.convertHoverDropdown(elem,menu);
      self.convertHoverDropdown(footerCountry,footerMenu);

      let onShow=()=>{
        navCountryForeground.css("top",header.position().top+header.css("height"));
        navCountryForeground.css("opacity",.4);
        navCountryForeground.css("height",body.height()-header.height());
      };

      let onHide=()=>{
        navCountryForeground.css("opacity",0);
        navCountryForeground.css("height",0);
      }

      let navAccount=$("#navAccount");

      self.convertHoverDropdown(navAccount,navAccount.next(),onShow,onHide);


      let overflows = $(".overflow-control");
      let positions:any=[];

      overflows.each(function(index:any){
        let overflow = $(overflows[index]);
        positions.push({
          dragging:false,
          left: 0,
          x: 0,
          y: 0,
        });

        let dragging=false;
        let pos:any =positions[index];

        overflow.on("mousedown",function(e:MouseEvent){
          pos.left=overflow.scrollLeft();
          pos.x=e.clientX;
          pos.y=e.clientY;
          pos.dragging=true;
        });

        overflow.on("mousemove",function(e:MouseEvent){
          if(pos.dragging){
            const dx = e.clientX - pos.x;
            overflow[0].scrollLeft = pos.left - dx;
          }
        });

        $(window).on("mouseup",function(){
          pos.dragging=false;
        });
      });
    });
  }

convertHoverDropdown(elem:any,menu:any,onShow:any=()=>{},onHide:any=()=>{}){
  let shown=false
  let to:any,toh:any;
  let self=this;
  elem.removeAttr("data-toggle");

  let enteredListener=function(){
    clearTimeout(toh);
    to=setTimeout(function(){
      if(!shown){
        elem.dropdown("toggle");
        self.dropdowns.forEach((element:any) => {
          if(element!==elem)
            element.dropdown("hide");
        });
        shown=true;
        onShow();
      }
    },200);
  };

  let leavedListener=function(){
    clearTimeout(to);
    toh = setTimeout(function(){
      elem.dropdown("hide");
      shown=false;
      onHide();
    },400);
  };

  let menuEnteredListener=function(){
    clearTimeout(toh);
  };
  elem.on("mouseenter",enteredListener);
  elem.on("mouseleave",leavedListener);
  menu.on("mouseenter",menuEnteredListener);
  menu.on("mouseleave",leavedListener);
  this.dropdowns.push(elem);
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
