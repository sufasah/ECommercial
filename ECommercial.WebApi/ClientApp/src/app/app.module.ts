import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

/*
  Home Page Components
 */
import { HomePageComponent } from './modules/home-page/home-page.component';
import { HeaderComponent } from './core/header/header.component';
import { CartComponent } from './modules/home-page/components/cart/cart.component';
import { CategoryNavComponent } from './modules/home-page/components/category-nav/category-nav.component';
import { ExploreComponent } from './modules/home-page/components/explore/explore.component';
import { FooterComponent } from './core/footer/footer.component';
import { SliderComponent } from './modules/home-page/components/slider/slider.component';
/*
End of Home Page Components
 */

@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    HeaderComponent,
    CartComponent,
    CategoryNavComponent,
    ExploreComponent,
    FooterComponent,
    SliderComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
