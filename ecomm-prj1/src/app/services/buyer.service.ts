import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class BuyerService {
  private apiUrl = 'http://localhost:5202'; // Replaced with my backend API URL
  constructor(private http: HttpClient) { }
  
  userSignUp(data: object): Promise<any> {
    const url = `${this.apiUrl}/Register`;
    return this.http.post(url, data).toPromise();
  }

  executeQuery(query: string): Promise<any> {
    const url = `${this.apiUrl}/query`;
    const body = { query: query };
    return this.http.post(url, body).toPromise();
  }

  async getCustomers(): Promise<any> {
    const query = 'SELECT * FROM Customer';
    return await this.executeQuery(query);
  }

  async getInventory(): Promise<any> {
    const query = 'SELECT * FROM Inventory';
    return await this.executeQuery(query);
  }

  async getOrders(): Promise<any> {
    const query = 'SELECT * FROM [Order]';
    return await this.executeQuery(query);
  }

  async getProducts(): Promise<any> {
    const query = 'SELECT * FROM Products';
    return await this.executeQuery(query);
  }

  async getJunction(): Promise<any> {
    const query = 'SELECT * FROM StoreProductJunction';
    return await this.executeQuery(query);
  }

  async getStores(): Promise<any> {
    const query = 'SELECT * FROM Stores';
    return await this.executeQuery(query);
  }
}
