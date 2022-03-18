import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";

@Injectable({
    providedIn: 'root'
})

export class VentaService{
    private myAppUrl = 'https://localhost:44330/';
    private myApiUrl = 'api/Ventas/';

    constructor(private http: HttpClient){}

    getVentas(): Observable<any>{
        return this.http.get(this.myAppUrl + this.myApiUrl);
    }
    deleteVentas(id: number): Observable<any>{
        return this.http.delete(this.myAppUrl + this.myApiUrl + id);
    }
    postVentas(venta : any): Observable<any>{
        return this.http.post(this.myAppUrl + this.myApiUrl, venta);
    }
    updateVenta(id: number, venta: any): Observable<any>{
        return this.http.put(this.myAppUrl + this.myApiUrl + id, venta)
    }
}
