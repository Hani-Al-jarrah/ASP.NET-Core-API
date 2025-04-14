import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class HaniService {

  constructor(private _url: HttpClient) { }

  getCategories() {
    return this._url.get('https://localhost:7162/api/Category/getCategories');
  }

  AddCategories(data: any) {
    return this._url.post('https://localhost:7162/api/Category/addCategories', data);
  }

  updateCategory(id: number, data: any) {
    return this._url.put(`https://localhost:7162/api/Category/updateCategory/${id}`, data);
  }
  deleteCategory(id: number) {
    return this._url.delete(`https://localhost:7162/api/Category/deleteCategory/${id}`);
  }

}
