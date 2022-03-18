Create database Modelo_Facturacion
go
use Modelo_Facturacion
go

--CREACION DE TABLAS
create table Clientes(
id_cliente int identity(1,1) primary key,
nombre varchar(25) not null,
telefono bigint,
edad int not null
);
create table Ventas(
id_venta int identity(1,1) primary key,
id_cliente int foreign key (id_cliente) references Clientes(id_cliente),
fecha date not null,
);
create table Productos(
id_producto int identity(1,1) primary key,
nombre_producto varchar(25) not null,
precio int not null,
cantidad_bodega int not null,
id_venta int foreign key (id_venta) references Ventas(id_venta)
)
create table Detalle_Ventas(
id_detalle int identity(1,1) primary key,
id_producto int foreign key (id_producto) references Productos(id_producto),
cantidad int not null,
precio int not null
)
--CREACION DE TABLAS

--DATA DE PRUEBA
INSERT INTO Clientes (nombre,telefono,edad)
VALUES
('Miguel Diaz', 3522566321, 20),
('Nicolas Rodriguez', 3002566614, 30),
('Natalia Romero', 3215526984, 40),
('Jorge Quintero', 3256696584, 18),
('Cristian Moreno', 3255633001, 45)

INSERT INTO Ventas (id_cliente,fecha)
VALUES
(1, '05-15-2000'),
(3, '03-18-2002'),
(5, '03-22-2000'),
(2, '02-11-2000'),
(1, '08-25-2000'),
(4, '06-19-2004')

INSERT INTO Productos (nombre_producto, precio, cantidad_bodega, id_venta)
VALUES
('Cuaderno', 2500, 12, 1),
('Esfero', 1200, 8, 2),
('Caja de colores', 12500, 4, 3),
('Borrador', 800, 15, 4),
('Lapiz', 1000, 20, 5)

INSERT INTO Detalle_Ventas (id_producto, cantidad, precio)
VALUES
(1, 2, 5000),
(2, 4, 4800),
(3, 1, 12500),
(4, 6, 4800),
(5, 10, 10000),
(1, 1, 2500)
--DATA DE PRUEBA

--CONSULTAS GENERALES
select * from Clientes
select * from Ventas
select * from Productos
select * from Detalle_Ventas
--CONSULTAS GENERALES


--OBTENER LA LISTA DE PRECIOS DE TODOS LOS PRODUCTOS
SELECT nombre_producto, precio FROM Productos

--OBTENER LA LISTA DE PRODUCTOS CUYA EXISTENCIA EN EL INVENTARIO HAYA LLEGADO AL MINIMO PERMITIDO (5 UNIDADES)
SELECT nombre_producto, cantidad_bodega FROM Productos
WHERE cantidad_bodega >= 5

--OBTENER UNA LISTA DE CLIENTES NO MAYORRES DE 35 AÑOS QUE HAYAN REALIZADO COMPRAS ENTRE EL 1 DE FEBRERO DEL 2000 Y EL 25 DE MAYO DEL 2000
SELECT Clientes.nombre AS Nombre_Cliente, Clientes.edad AS Edad, Ventas.fecha AS Fecha_Venta
FROM Ventas INNER JOIN Clientes ON Ventas.id_cliente = Clientes.id_cliente
WHERE Clientes.edad <= 35 and (Ventas.fecha BETWEEN '02-01-2000' and '05-25-2000')

--OBTENER EL VALOR TOTAL VENDIDO POR CADA PRODUCTO EN EL AÑO 2000
SELECT nombre_producto,
(select SUM (precio) from Detalle_Ventas
where id_producto = Productos.id_producto) as Total_vendido_anio_2000
FROM Productos INNER JOIN Ventas ON Productos.id_venta = Ventas.id_cliente
WHERE fecha BETWEEN '01-01-2000' and '12-31-2000'







