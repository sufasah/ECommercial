import { Component, OnInit } from '@angular/core';
import $ from "jquery";
import "bootstrap";

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.scss']
})
export class HomePageComponent implements OnInit {

  constructor() { }
  topItems=[{
    header:"Computers & Accessories",
    link:"shop now",
  },{
    header:"Recently viewed",
    link:"shop now",
  },{
    header:"Shop by category",
    link:"shop now",
  },{
    header:"Shop top categories",
    link:"see more",
  },{
    header:"Deals and promotions",
    link:"shop now",
  },{
    header:"Get fit at home",
    link:"explore now",
  },{
    header:"Basic products",
    link:"see more",
  },{
    header:"Find your ideal tv",
    link:"see more",
  }];

  fromDiscover=[{
    header:"Discover ECommercial",
    link:"Click to learn more",
  },{
    header:"Top Sellers",
    link:"shop now",
  },{
    header:"Must have wireless products",
    link:"shop now",
  }];

  afterDiscover=[{
    header:"Comfy styles for her",
    link:"see more",
  },{
    header:"Shop laptops & tablets",
    link:"see more",
  },{
    header:"Explore home bedding",
    link:"see more",
  },{
    header:"Create with strip lights",
    link:"shop now",
  }];

  beforeBottom=[{
    header:"Best Sellers in Kitchen",
    link:"shop now",
  },{
    header:"Gifts in Video Games under $30",
    link:"shop now",
  },{
    header:"Home Décor Under $20",
    link:"shop now",
  },{
    header:"Our favorite Toys",
    link:"shop now",
  },{
    header:"Stuffed Animals & Toys under $10",
    link:"shop now",
  }];
  ngOnInit(): void {
    this.addCarouselButtonClickEvents();
  }

  addCarouselButtonClickEvents(): void {
    $('#sliderControl .carousel-control-prev').on("click",function(){
      (<any>$('#sliderControl')).carousel("prev");
    });
    $('#sliderControl .carousel-control-next').on("click",function(){
        (<any>$('#sliderControl')).carousel("next");
    });
  }

}
