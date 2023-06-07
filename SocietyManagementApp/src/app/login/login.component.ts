import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { first } from 'rxjs/operators';
import { SocietyServiceService } from '../society-service.service';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  loginForm!: FormGroup;
  loading = false;
  submitted = false;
  returnUrl!: string;
  router: any;
constructor(  private formBuilder: FormBuilder, private userservice:SocietyServiceService, router:Router){}
  ngOnInit() {
    this.loginForm = this.formBuilder.group({
        username: ['', Validators.required],
        password: ['', Validators.required]
    });
  }
  get f() { return this.loginForm.controls; }
  onSubmit():void {
    this.submitted = true;

    // stop here if form is invalid
    if (this.loginForm.invalid) {
        return;
    }

    this.loading = true;
    // Call user service for login.
    this.userservice.postUserName(this.loginForm.value).subscribe(x => {
      this.loading = false;
      // redirect to Home page.
      this.router.navigate(["/userDetail"]);
    },
      error =>{
        this.loading = false;
        this.loading = true;
      });
  }

  openUserDetailDialog(){

  }

}
