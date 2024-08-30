import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AddressService {
  private apiUrl = 'https://localhost:7262/api/address';

  constructor(private http: HttpClient) { }

  submitAddress(addressInfo: { name: string, address: string }): Observable<any> {
    return this.http.post(this.apiUrl, addressInfo);
  }

  //getAddress(id: string): Observable<any> {
  //  return this.http.get(`${this.apiUrl}/${id}`);
  //}
}
