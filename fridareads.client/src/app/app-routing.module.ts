import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UserComponent } from './components/user/user.component';
import { AuthGuard } from './modules/auth.guard';
import { LoginComponent } from './components/login/login.component';
import { SignupComponent } from './components/signup/signup.component';
import { TextListComponent } from './components/text-list/text-list.component';
import { AddTextComponent } from './components/add-text/add-text.component';

const routes: Routes = [
  // { path: 'auth', component: AuthComponent },
  { path: 'login', component: LoginComponent },
  { path: 'signup', component: SignupComponent },
  { path: 'user', component: UserComponent, canActivate: [AuthGuard] },
  { path: "myTexts", component: TextListComponent, canActivate: [AuthGuard]},
  { path: "addTexts", component: AddTextComponent, canActivate: [AuthGuard]},
  { path: '', redirectTo: '/login', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
