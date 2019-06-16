import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AirplaneAddComponent } from './airplane-add/airplane-add.component';
import { AirplaneGetComponent } from './airplane-get/airplane-get.component';
import { AirplaneEditComponent } from './airplane-edit/airplane-edit.component';
import { SlimLoadingBarModule } from 'ng2-slim-loading-bar';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { AirplaneService } from './services/airplane.service';

@NgModule({
  declarations: [
    AppComponent,
    AirplaneAddComponent,
    AirplaneGetComponent,
    AirplaneEditComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    SlimLoadingBarModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [AirplaneService],
  bootstrap: [AppComponent]
})
export class AppModule { }
