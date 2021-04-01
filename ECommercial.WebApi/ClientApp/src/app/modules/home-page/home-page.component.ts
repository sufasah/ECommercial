import { Component, OnInit } from '@angular/core';
declare var $:any;
@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.scss']
})
export class HomePageComponent implements OnInit {

  constructor() { }
  logged=false;

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
    $(document).ready(()=>{
      let horiLefts=$(".horizontal-box .horizontal-box-left");
      let horiRights=$(".horizontal-box .horizontal-box-right");

      $(".horizontal-box:not(.last-box) .horizontal-box-right").each((i:any,elem:any)=>{
        let overflow = $(elem).closest(".overflow-control");
        let imageLayout=$(elem).closest(".image-layout");
        if(overflow.get(0).scrollWidth>imageLayout.width()-1){
          $(elem).addClass("horizontal-lr-active");
        }
      });

      {
        let imageLayout=$(".last-box .image-layout")
        let overflow = imageLayout.find(".overflow-control");
        if(overflow.get(0).scrollWidth>imageLayout.width()-1){
          imageLayout.find(".horizontal-box-right").addClass("horizontal-lr-active");
        }
      }


      horiLefts.on("click",(evt:any)=>{
        let elem = $(evt.currentTarget);
        if(elem.hasClass("horizontal-lr-active")){
          let overflow = elem.closest(".overflow-control");
          let imageLayout= elem.closest(".image-layout");
          let nextPos= overflow.scrollLeft() - imageLayout.width();
          overflow.stop();
          overflow.animate({
            scrollLeft: nextPos<0?0:nextPos,
          },1000);
        }
      });

      horiRights.on("click",(evt:any)=>{
        let elem = $(evt.currentTarget);
        if(elem.hasClass("horizontal-lr-active")){
          let overflow = elem.closest(".overflow-control");
          let imageLayout= elem.closest(".image-layout");
          let nextPos=overflow.scrollLeft() + imageLayout.width();
          overflow.stop();
          overflow.animate({
            scrollLeft:nextPos>overflow[0].scrollWidth?overflow[0].scrollWidth:nextPos,
          },1000);
        }
      });

      $(".overflow-control").on("scroll",function(evt:any){
        let overflow = $(evt.currentTarget);
        if(overflow.scrollLeft()+overflow.innerWidth()>=overflow[0].scrollWidth-1)
          overflow.find(".horizontal-box-right").removeClass("horizontal-lr-active");
        else
          overflow.find(".horizontal-box-right").addClass("horizontal-lr-active");

        if(overflow.scrollLeft()<=0)
          overflow.find(".horizontal-box-left").removeClass("horizontal-lr-active");
        else
          overflow.find(".horizontal-box-left").addClass("horizontal-lr-active");
      });
    });
  }

}
