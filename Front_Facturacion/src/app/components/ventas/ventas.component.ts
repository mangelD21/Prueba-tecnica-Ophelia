import { Component, OnInit } from '@angular/core';
import { VentaService } from './ventas.service'; 

@Component({
  selector: 'app-ventas',
  templateUrl: './ventas.component.html',
  styleUrls: ['./ventas.component.css']
})
export class VentasComponent implements OnInit {
  listaVentas: any[] = [];

  constructor(private _ventas: VentaService) { 
  }

  
  ngOnInit(): void {
    this.obtenerVentas();
  }

  obtenerVentas(){
    this._ventas.getVentas().subscribe(data => {
      // console.log(data);
      this.listaVentas = data;
    }, error => {
      console.log(error);
    })
  }
  
  onRowInsertedVenta(event: any){
    let jsonAux: any = {
      producto: event.data.producto,
      cantidad: event.data.cantidad,
      nombre: event.data.nombre,
      fecha: event.data.fecha,
      total: event.data.total
    }
    this._ventas.postVentas(jsonAux).subscribe(data => {
      // console.log('nueva venta en la BD ',jsonAux);
      this.obtenerVentas();
    },error => {
      console.log(error);
    })
  }
  onRowUpdatedVenta(event: any){
    let id = event.data.id_Venta;    
    this._ventas.updateVenta(id,event.data).subscribe(data => {
      // console.log('actualizo una venta en la BD');
      this.obtenerVentas();
    }, error => {
      console.log(error);
    })
    
  }
  onRowRemovedVenta(event: any){
    let id = event.data.id_Venta;
    this._ventas.deleteVentas(id).subscribe(data => {
      // console.log('elimino una venta de la BD',event.data);
      this.obtenerVentas();
    }, error => {
      console.log(error);
    })
    
  }
}
