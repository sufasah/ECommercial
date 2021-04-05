import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-account-page',
  templateUrl: './account-page.component.html',
  styleUrls: ['./account-page.component.scss']
})
export class AccountPageComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  cards=[{
    imgUrl:"/assets/images/account1.png",
    title:"Your Orders",
    text:"Track, return, or buy things again",
    link:"Orders",
  },
  {
    imgUrl:"/assets/images/account2.png",
    title:"Login & Security",
    text:"Edit login,name,and mobile number",
    link:"Login-Security",
  },
  {
    imgUrl:"/assets/images/account3.png",
    title:"Prime",
    text:"View benefits and payment settings",
    link:"Prime",
  },
  {
    imgUrl:"/assets/images/account4.png",
    title:"Gift cards",
    text:"View balance, redeem, or reload cards",
    link:"Gifts",
  },
  {
    imgUrl:"/assets/images/account5.png",
    title:"Your Payments",
    text:"Manage payment methods and settings, view all transactions",
    link:"Payments",
  },
  {
    imgUrl:"/assets/images/account6.png",
    title:"Your Profiles",
    text:"Manage, add, or remove user profiles for personalized experiences",
    link:"Profiles",
  },
  {
    imgUrl:"/assets/images/account7.png",
    title:"Your devices and content",
    text:"Manage your devices and digital content",
    link:"Devices",
  },
];
}
