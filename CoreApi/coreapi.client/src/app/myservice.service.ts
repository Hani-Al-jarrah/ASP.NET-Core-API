import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

export interface Category {
  id: number;
  name: string;
  description: string;
}

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  private baseUrl = 'https://localhost:7096/api/Category'; // 👈 Your base API URL

  constructor(private http: HttpClient) { }

  getAll(): Observable<Category[]> {
    return this.http.get<Category[]>(`${this.baseUrl}/getCategory`);
  }

  getById(id: number): Observable<Category> {
    return this.http.get<Category>(`${this.baseUrl}/getCategoryById?id=${id}`);
  }

  getByName(name: string): Observable<Category> {
    return this.http.get<Category>(`${this.baseUrl}/getCategoryByName?name=${name}`);
  }

  getFirst(): Observable<Category> {
    return this.http.get<Category>(`${this.baseUrl}/getFirstCategory`);
  }
}
