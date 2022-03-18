import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { DevExtremeModule } from 'devextreme-angular';
import { DxDataGridModule } from 'devextreme-angular/ui/data-grid';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { ProductosComponent } from './components/productos/productos.component';
import { VentasComponent } from './components/ventas/ventas.component';

@NgModule({
  declarations: [
    AppComponent,
    ProductosComponent,
    VentasComponent
  ],
  imports: [
    BrowserModule,
    DevExtremeModule,
    DxDataGridModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
