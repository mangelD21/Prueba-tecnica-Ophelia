import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";

@Injectable({
    providedIn: 'root'
})

export class ProductoService{
    private myAppUrl = 'https://localhost:44330/';
    private myApiUrl = 'api/Productos/';

    constructor(private http: HttpClient){}

    getProductos(): Observable<any>{
        return this.http.get(this.myAppUrl + this.myApiUrl);
    }
    deleteProductos(id: number): Observable<any>{
        return this.http.delete(this.myAppUrl + this.myApiUrl + id);
    }
    postProductos(producto : any): Observable<any>{
        return this.http.post(this.myAppUrl + this.myApiUrl, producto);
    }
    updateProductos(id: number, producto: any): Observable<any>{
        return this.http.put(this.myAppUrl + this.myApiUrl + id, producto)
    }
}