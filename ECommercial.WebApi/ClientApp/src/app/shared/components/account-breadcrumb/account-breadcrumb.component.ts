import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-account-breadcrumb',
  templateUrl: './account-breadcrumb.component.html',
  styleUrls: ['./account-breadcrumb.component.scss']
})
export class AccountBreadcrumbComponent implements OnInit {

  @Input() page:any;

  constructor() { }

  ngOnInit(): void {
  }

}
