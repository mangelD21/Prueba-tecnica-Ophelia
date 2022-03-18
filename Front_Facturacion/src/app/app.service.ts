import { Injectable } from "@angular/core";

export interface Venta_Prueba {
    Id_Venta : Number,
    Id_Producto: Number,
    Producto : String,
    Cantidad : Number,
    Nombre_Cliente : String,
    Fecha_Compra : String,
    Total : Number
}

export interface Producto_Prueba{
    Id_Producto : Number,
    Producto: String,
    Precio : Number,
    Cantidad_Bodega : Number
}

let venta_prueba: Venta_Prueba[] = [{
    "Id_Venta" : 1,
    "Id_Producto" : 3,
    "Producto" : "lapiz",
    "Cantidad" : 5,
    "Nombre_Cliente": "Miguel Diaz",
    "Fecha_Compra": "18/02/2008",
    "Total" : 2500
},{
    "Id_Venta" : 2,
    "Id_Producto" : 1,
    "Producto" : "cuaderno",
    "Cantidad" : 10,
    "Nombre_Cliente": "Diego Garavito",
    "Fecha_Compra": "10/04/2012",
    "Total" : 15000
},{
    "Id_Venta" : 3,
    "Id_Producto" : 2,
    "Producto" : "borrador",
    "Cantidad" : 3,
    "Nombre_Cliente": "Cristian Herrera",
    "Fecha_Compra": "28/05/2010",
    "Total" : 5200 
}];

let producto_prueba : Producto_Prueba[]=[{
    "Id_Producto" : 1,
    "Producto" : "cuaderno",
    "Precio" : 1200,
    "Cantidad_Bodega" : 6
},{
    "Id_Producto" : 2,
    "Producto" : "borrador",
    "Precio" : 800,
    "Cantidad_Bodega" : 10
},{
    "Id_Producto" : 3,
    "Producto" : "lapiz",
    "Precio" : 1000,
    "Cantidad_Bodega" : 25
}]

@Injectable({
    providedIn: 'root'
})

export class VentaPruebaService{
    getVentasPrueba(): Venta_Prueba[]{
        return venta_prueba;
    }
}

export class ProductoPruebaService{
    getProductosPrueba(): Producto_Prueba[]{
        return producto_prueba;
    }
}