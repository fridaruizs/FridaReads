import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SignupComponent } from './components/signup/signup.component';
import { LoginComponent } from './components/login/login.component';
import { TextListComponent } from './components/text-list/text-list.component';
import { AddTextComponent } from './components/add-text/add-text.component';
import { UserComponent } from './components/user/user.component';

import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';

import { MatCardModule } from '@angular/material/card';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatIconModule } from '@angular/material/icon';
import { MatListModule } from '@angular/material/list';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatTableModule } from '@angular/material/table';
import { MatDatepickerModule } from '@angular/material/datepicker';
// import { FlexLayouModule } from '@angular/flex-layout';
// import { DateFnsModule } from '@angular/material-date-fns-adapter';
// import { DateFnsAdapter, MAT_DATE_FNS_FORMATS } from '@angular/material-date-fns-adapter';

@NgModule({
  declarations: [
    AppComponent,
    SignupComponent,
    LoginComponent,
    TextListComponent,
    AddTextComponent,
    UserComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    AppRoutingModule,

    MatCardModule,
    MatInputModule,
    MatButtonModule,
    MatFormFieldModule,
    MatToolbarModule,
    MatButtonModule,
    MatSidenavModule,
    MatIconModule,
    MatListModule,
    MatCheckboxModule,
    MatTableModule,
    MatDatepickerModule,
    // DateFnsModule,
    // FlexLayouModule,
  ],
  providers: [
    provideAnimationsAsync('noop'),
    /* {
      provide: MAT_DATE_FNS_FORMATS,
      useValue: {
        // Specify your desired date format here
        parse: {
          dateInput: 'MM/YYYY',
        },
        display: {
          dateInput: 'MM/YYYY',
          monthYearLabel: 'MMM YYYY',
          dateA11yLabel: 'LL',
          monthYearA11yLabel: 'MMMM YYYY',
        },
      },
    },
    { provide: DateFnsAdapter, useClass: DateFnsAdapter }, */
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
