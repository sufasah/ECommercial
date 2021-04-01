import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.scss']
})
export class FooterComponent implements OnInit {

  choosenLanguage="TR";
  languages = [
    {language:"Türkçe", code:"TR"},
    {language:"English", code:"EN"},
  ];

  constructor() { }

  ngOnInit(): void {
  }

  topCols=[{
    header:"Get to Know Us",
    items:[{
      link:"",
      linkText:"Careers",
    },{
      link:"",
      linkText:"Blog",
    },{
      link:"",
      linkText:"About us",
    },{
      link:"",
      linkText:"Sustainability",
    },{
      link:"",
      linkText:"Investor relations",
    }]
  },{
    header:"Make Money with Us",
    items:[{
      link:"",
      linkText:"Sell products",
    },{
      link:"",
      linkText:"Sell apps",
    },{
      link:"",
      linkText:"Become an affilliate",
    },{
      link:"",
      linkText:"Advertise your products",
    },{
      link:"",
      linkText:"Self-publish with Us",
    }],
  },{
    header:"Payment Products",
    items:[{
      link:"",
      linkText:"Business card",
    },{
      link:"",
      linkText:"Shop with Points",
    },{
      link:"",
      linkText:"Reload your balance",
    }],
  },{
    header:"Let Us Help You",
    items:[{
      link:"",
      linkText:"ECommercial and Covid-19",
    },{
      link:"",
      linkText:"Your account",
    },{
      link:"",
      linkText:"Your orders",
    },{
      link:"",
      linkText:"Shipping rates & policies",
    },{
      link:"",
      linkText:"Returns & replacements",
    },{
      link:"",
      linkText:"Help",
    }]
  }];

  botCols=[{
    items:[{
      link:"",
      linkText:"Music",
      linkText2:"Stream millions of songs",
    },{
      link:"",
      linkText:"Sell on",
      linkText2:"Start a Selling Account",
    },{
      link:"",
      linkText:"Book Depository",
      linkText2:"Books With Free Delivery Worldwide",
    },{
      link:"",
      linkText:"IMDb",
      linkText2:"Movies, TV & Celebrities",
    },{
      link:"",
      linkText:"Ring",
      linkText2:"Smart Home Security Systems",
    }]
  },{
    items:[{
      link:"",
      linkText:"Advertising",
      linkText2:"Find, attract, and engage customers",
    },{
      link:"",
      linkText:"Business",
      linkText2:"Everything For Your Business",
    },{
      link:"",
      linkText:"Box Office Mojo",
      linkText2:"Find Movie Box Office Data",
    },{
      link:"",
      linkText:"IMDbPro",
      linkText2:"Get Info Entertainment Professionals Need",
    },{
      link:"",
      linkText:"eero WiFi",
      linkText2:"Stream 4K Video in Every Room",
    }],
  },{
    items:[{
      link:"",
      linkText:"Drive",
      linkText2:"Cloud storage from",
    },{
      link:"",
      linkText:"Global",
      linkText2:"Ship Orders Internationally",
    },{
      link:"",
      linkText:"ComiXology",
      linkText2:"Thousands of Digital Comics",
    },{
      link:"",
      linkText:"Kindle Direct Publishing",
      linkText2:"Indie Digital & Print Publishing Made Easy",
    },{
      link:"",
      linkText:"Neighbors App",
      linkText2:"Real-Time Crime & Safety Alerts",
    }],
  },{
    items:[{
      link:"",
      linkText:"6pm",
      linkText2:"Score deals on fashion brands",
    },{
      link:"",
      linkText:"Home Services",
      linkText2:"Experienced Pros Happiness Guarantee",
    },{
      link:"",
      linkText:"DPReview",
      linkText2:"Digital Photography",
    },{
      link:"",
      linkText:"Prime Video Direct",
      linkText2:"Video Distribution Made Easy",
    },{
      link:"",
      linkText:"Subscription Boxes",
      linkText2:"Top subscription boxes – right to your door",
    }]
  }]
}
