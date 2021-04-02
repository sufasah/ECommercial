import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AccountPageComponent } from '@modules/account-page/account-page.component';
import { HomePageComponent } from '@modules/home-page/home-page.component';

const routes: Routes = [
  {
    path:"",
    component:HomePageComponent,
  },
  {
    path:"Account",
    component:AccountPageComponent,
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
