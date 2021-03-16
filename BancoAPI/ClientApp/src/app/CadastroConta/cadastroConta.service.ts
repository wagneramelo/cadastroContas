import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CadastroContaService {

  readonly rootURL = 'https://localhost:44306/api';
  constructor(private http: HttpClient) { }
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  }
  getData() {
    return this.http.get(this.rootURL + '/Contas');
  }
  postData(formData) {
    return this.http.post(this.rootURL + '/Contas', formData);
  }
  putData(id, formData) {
    return this.http.put(this.rootURL + '/Contas/' + id, formData);
  }

  deleteData(id) {
    return this.http.delete(this.rootURL + '/Contas/' + id);
  }  
}
