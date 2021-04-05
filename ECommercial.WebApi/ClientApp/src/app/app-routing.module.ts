import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AccountPageComponent } from '@modules/account-page/account-page.component';
import { ForgotPasswordPageComponent } from '@modules/forgot-password-page/forgot-password-page.component';
import { HomePageComponent } from '@modules/home-page/home-page.component';
import { LoginPageComponent } from '@modules/login-page/login-page.component';
import { RegisterPageComponent } from '@modules/register-page/register-page.component';

const routes: Routes = [
  {
    path:"",
    component:HomePageComponent,
  },
  {
    path:"Account",
    component:AccountPageComponent,
  },
  {
    path:"Login",
    component:LoginPageComponent,
  },
  {
    path:"ForgotPassword",
    component:ForgotPasswordPageComponent,
  },
  {
    path:"Register",
    component:RegisterPageComponent,
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
