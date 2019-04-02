import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import {HttpClientModule, HttpClient} from '@angular/common/http';
import { UserComponent } from './user/user.component';
import { RegisterComponent } from './register/register.component';
import { RouterModule, Routes } from '@angular/router';

const appRoutes: Routes = [
  { path: 'login', component: LoginComponent },
  { path: 'register',      component: RegisterComponent },
];
@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    UserComponent,
    RegisterComponent,
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    RouterModule.forRoot(
      appRoutes,
      { enableTracing: true } // <-- debugging purposes only
    )
    // other imports here
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {
  
 }
