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

  makeProducts=function(from:number,to:number,preText:string ){
    var res=[];
    for(let i=from;i<=to;i++){
      res.push({
        imgUrl:`/assets/images/${preText}${i}.jpg`,
        imgAlt:"AltPlaceHolder",
        link:"",
      });
    }
    return res;
  }
  topItems=[{
    header:"Computers & Accessories",
    linkText:"Shop now",
    link:"",
    imgUrl:"/assets/images/product1.jpg",
    imgAlt:"AltPlaceHolder",
  },{
    header:"Recently viewed",
    linkText:"Shop now",
    link:"",
    imgUrl:"/assets/images/product2.jpg",
    imgAlt:"AltPlaceHolder",
  },{
    header:"Shop top categories",
    linkText:"See more",
    link:"",
    imgUrl:"/assets/images/product7.jpg",
    imgAlt:"AltPlaceHolder",
  },{
    header:"Deals and promotions",
    linkText:"Shop now",
    link:"",
    imgUrl:"/assets/images/product8.jpg",
    imgAlt:"AltPlaceHolder",
  },{
    header:"Get fit at home",
    linkText:"Explore now",
    link:"",
    imgUrl:"/assets/images/product8.jpg",
    imgAlt:"AltPlaceHolder",
  },{
    header:"Basic products",
    linkText:"See more",
    link:"",
    imgUrl:"/assets/images/product9.jpg",
    imgAlt:"AltPlaceHolder",
  },{
    header:"Find your ideal tv",
    linkText:"See more",
    link:"",
    imgUrl:"/assets/images/product10.jpg",
    imgAlt:"AltPlaceHolder",
  },{
    header:"Shop by category",
    linkText:"Shop now",
    dividedList:[{
      imgUrl:"/assets/images/product3.jpg",
      imgAlt:"AltPlaceHolder",
      text:"Computers & Accessories",
      link:"",
    },{
      imgUrl:"/assets/images/product4.jpg",
      imgAlt:"AltPlaceHolder",
      text:"Video Games",
      link:"",
    },{
      imgUrl:"/assets/images/product5.jpg",
      imgAlt:"AltPlaceHolder",
      text:"Baby",
      link:"",
    },{
      imgUrl:"/assets/images/product6.jpg",
      imgAlt:"AltPlaceHolder",
      text:"Toy & Games",
      link:"",
    }],
  }];

  fromDiscover=[{
    header:"Discover ECommercial",
    linkText:"Click to learn more",
    link:"",
    products:this.makeProducts(1,6,"discover"),
  },{
    header:"Top Sellers",
    linkText:"Shop now",
    products:this.makeProducts(11,19,"product"),
  },{
    header:"Must have wireless products",
    linkText:"Shop now",
    link:"",
    products:this.makeProducts(20,28,"product"),
  }];

  afterDiscover=[{
    header:"Comfy styles for her",
    linkText:"See more",
    dividedList:[{
      imgUrl:"/assets/images/product29.jpg",
      imgAlt:"AltPlaceHolder",
      text:"Computers & Accessories",
      link:"",
    },{
      imgUrl:"/assets/images/product30.jpg",
      imgAlt:"AltPlaceHolder",
      text:"Video Games",
      link:"",
    },{
      imgUrl:"/assets/images/product31.jpg",
      imgAlt:"AltPlaceHolder",
      text:"Baby",
      link:"",
    },{
      imgUrl:"/assets/images/product32.jpg",
      imgAlt:"AltPlaceHolder",
      text:"Toy & Games",
      link:"",
    }],
  },{
    header:"Shop laptops & tablets",
    linkText:"See more",
    link:"",
    imgUrl:"/assets/images/product33.jpg",
    imgAlt:"AltPlaceHolder",
  },{
    header:"Explore home bedding",
    linkText:"See more",
    link:"",
    imgUrl:"/assets/images/product34.jpg",
    imgAlt:"AltPlaceHolder",
  },{
    header:"Create with strip lights",
    linkText:"Shop now",
    link:"",
    imgUrl:"/assets/images/product35.jpg",
    imgAlt:"AltPlaceHolder",
  }];

  beforeBottom=[{
    header:"Best Sellers in Kitchen",
    linkText:"Shop now",
    link:"",
    products:this.makeProducts(36,44,"product"),
  },{
    header:"Gifts in Video Games under $30",
    linkText:"Shop now",
    link:"",
    products:this.makeProducts(45,54,"product"),
  },{
    header:"Home Décor Under $20",
    linkText:"Shop now",
    link:"",
    products:this.makeProducts(55,63,"product"),
  },{
    header:"Our favorite Toys",
    linkText:"Shop now",
    link:"",
    products:this.makeProducts(64,65,"product"),
  },{
    header:"Stuffed Animals & Toys under $10",
    linkText:"Shop now",
    link:"",
    products:this.makeProducts(66,83,"product"),
  }];
  lastboxProducts=this.makeProducts(84,94,"product");

  ngOnInit(): void {
    this.addCarouselButtonClickEvents();
  }

  addCarouselButtonClickEvents(): void {
    var sliderControl=(<any>$('#sliderControl'));
    $('#sliderControl .carousel-control-prev').on("click",function(){
      sliderControl.carousel("prev");
    });
    $('#sliderControl .carousel-control-next').on("click",function(){
        sliderControl.carousel("next");
    });

    sliderControl.carousel({interval:5000});
    sliderControl.carousel("cycle");
  }

}
