import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, pipe } from 'rxjs';
import { map } from 'rxjs/operators'
import { Product } from '../_models/product';



@Injectable({
  providedIn: 'root'
})
export class ProductService {

private productUrl = '123/qwe';

  constructor(private http: HttpClient ) { }

  getProducts(categoryId: number, description: string): Observable<Product[]> {
    return this.http.get('https://localhost:44347/api/products/1/1').pipe(
      map(data => {
        const products: Array<Product> = [];
        for (const id in data) {
          if(data.hasOwnProperty(id)) {
            products.push(data[id]);
          }
        }
        return products;
      })
    );
  }

}
