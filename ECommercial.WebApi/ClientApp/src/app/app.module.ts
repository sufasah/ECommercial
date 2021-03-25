/**Modules */
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { FormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

/**Components */
import { AppComponent } from './app.component';
import { HeaderComponent } from '@core/header/header.component';
import { FooterComponent } from '@core/footer/footer.component';
import { HomePageComponent } from '@modules/home-page/home-page.component';
import { LogoComponent } from '@shared/components/logo/logo.component';
import { ModalComponent } from '@shared/components/modal/modal.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    HomePageComponent,
    LogoComponent,
    ModalComponent,
  ],
  imports: [
    FormsModule,
    BrowserModule,
    AppRoutingModule,
    NgbModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
