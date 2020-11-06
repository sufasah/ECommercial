import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomePageComponent } from './modules/home-page/home-page.component';
import { HeaderComponent } from './modules/home-page/components/header/header.component';
import { CartComponent } from './modules/home-page/components/cart/cart.component';
import { CategoryNavComponent } from './components/home-page/components/category-nav/category-nav.component';
import { SliderComponent } from './modules/home-page/components/slider/slider.component';
import { BannerComponent } from './shared/components/banner/banner.component';
import { ExploreComponent } from './modules/home-page/components/explore/explore.component';
import { FooterComponent } from './modules/home-page/components/footer/footer.component';

@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    HeaderComponent,
    CartComponent,
    CategoryNavComponent,
    SliderComponent,
    BannerComponent,
    ExploreComponent,
    FooterComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
