import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';

import { RegistrationComponent } from './registration/registration.component';
import { UserDetailComponent } from './user-detail/user-detail.component';
const routes: Routes = [
  {path:'',redirectTo:'/login',pathMatch:'full'},
  { path:'login',component:LoginComponent },
  {path:'register',component:RegistrationComponent},
  {path: 'userDetail',component:UserDetailComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
