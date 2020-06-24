import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Product } from '../_models/product';
import { ProductService } from '../_services/product.service';

@Component({
  selector: 'app-shoppingbasket',
  templateUrl: './shoppingbasket.component.html',
  styleUrls: ['./shoppingbasket.component.css']
})
export class ShoppingBasketComponent implements OnInit {

  products: Product[];
  showBasket = false;

  constructor(private productService: ProductService) { }

  ngOnInit() {

    this.productService.getProducts(null, null).subscribe(
      data => {
        this.products = data;
      }
    )
  }

  addItemToBasket(productId: number){
    console.log("Here")
    console.log(productId)
    this.showBasket=true;
  }

  removeItemFromBasket(productId: number){
    console.log("Here")
    console.log(productId)
    this.showBasket=true;
  }
}
