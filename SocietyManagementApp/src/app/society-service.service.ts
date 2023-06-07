import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { User } from './user';
@Injectable({
  providedIn: 'root'
})
export class SocietyServiceService {
private REST_API_SERVER="https://localhost:44366/api/";
  constructor(private httpClient:HttpClient) { }

  public postUserName(userName:string){
    return this.httpClient.post(this.REST_API_SERVER +"UserDetails/login",userName);
   }

}
