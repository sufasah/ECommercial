/**Modules */
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { FormsModule } from '@angular/forms';

/**Components */
import { AppComponent } from './app.component';
import { HeaderComponent } from '@core/header/header.component';
import { FooterComponent } from '@core/footer/footer.component';
import { HomePageComponent } from '@modules/home-page/home-page.component';
import { LogoComponent } from '@shared/components/logo/logo.component';
import { AccountPageComponent } from './modules/account-page/account-page.component';
import { LoginPageComponent } from './modules/login-page/login-page.component';
import { ForgotPasswordPageComponent } from './modules/forgot-password-page/forgot-password-page.component';
import { RegisterPageComponent } from './modules/register-page/register-page.component';
import { LoginEndComponent } from './shared/components/login-end/login-end.component';
import { OrdersPageComponent } from './modules/orders-page/orders-page.component';
import { AccountBreadcrumbComponent } from './shared/components/account-breadcrumb/account-breadcrumb.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    HomePageComponent,
    LogoComponent,
    AccountPageComponent,
    LoginPageComponent,
    ForgotPasswordPageComponent,
    RegisterPageComponent,
    LoginEndComponent,
    OrdersPageComponent,
    AccountBreadcrumbComponent,
  ],
  imports: [
    FormsModule,
    BrowserModule,
    AppRoutingModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
