import { Component, OnInit } from '@angular/core';
import $ from "jquery";
import "bootstrap";
import { ZipOperator } from 'rxjs/internal/observable/zip';
@Component({
  selector: 'app-modal',
  templateUrl: './modal.component.html',
  styleUrls: ['./modal.component.scss']
})
export class ModalComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  ngAfterViewInit(): void {

    let modal:any = $("#deliverModal");
    modal.modal("show");

    let zip:any = $("#zipCode");
    zip.on("input",function(e:any){
      let val = zip.val();

      if(val.length>5)
        zip.val(val.slice(0,5));
    });
  }
}
