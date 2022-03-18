import { Component, OnInit } from '@angular/core';
import { ProductoService } from './productos.service';

@Component({
  selector: 'app-productos',
  templateUrl: './productos.component.html',
  styleUrls: ['./productos.component.css']
})
export class ProductosComponent implements OnInit {
  listaProductos: any[] = [];


  constructor(private _productos: ProductoService) {

  }

  ngOnInit(): void {
    this.obtenerProductos();
  }

  obtenerProductos(){
    this._productos.getProductos().subscribe(data => {
      // console.log(data);
      this.listaProductos = data;
    }, error => {
      console.log(error);
    })
  }

  onRowInsertedProducto(event: any){
    let jsonAux: any = {
      producto: event.data.producto,
      precio: event.data.precio,
      cantidad_Bodega: event.data.cantidad_Bodega
    }
    this._productos.postProductos(jsonAux).subscribe(data => {
      // console.log('nuevo producto en la BD ',jsonAux);
      this.obtenerProductos();
    },error => {
      console.log(error);
    })
  }
  onRowUpdatedProducto(event: any){
    let id = event.data.id_Producto;    
    this._productos.updateProductos(id,event.data).subscribe(data => {
      // console.log('actualizo un producto en la BD');
      this.obtenerProductos();
    }, error => {
      console.log(error);
    })

  }
  onRowRemovedProducto(event: any){
    let id = event.data.id_Producto;
    this._productos.deleteProductos(id).subscribe(data => {
      // console.log('elimino un Producto de la BD',event.data);
      this.obtenerProductos();
    }, error => {
      console.log(error);
    })
  }
}
