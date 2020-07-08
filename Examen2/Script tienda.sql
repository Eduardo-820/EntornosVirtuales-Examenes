create database Tienda
go

create schema factura
go

use Tienda

create table factura.cliente (
	idCliente int primary key not null,
	nombre varchar(25),
	apellido varchar(25),
	direccion varchar(50),
)


create table factura.producto(
	idProducto int primary key not null,
	nombreProducto varchar(40),
	descripcion varchar(50)
)

create table factura.Venta(
	idVenta int primary key not null,
	fechaVenta date,
	precio int,
	cantidad int,
	idCliente int foreign key references factura.cliente(idCliente),
	idProducto int foreign key references factura.producto(idProducto)
)

go

create procedure reporte
as begin
	select c.nombre as 'Nombre del Cliente', c.apellido as 'Apellido del Cliente', p.nombreProducto as 'Nombre de Producto', cantidad as 'Cantidad', precio as 'Precio', fechaventa as 'Fecha de Venta'
						from factura.Venta v 
						inner join factura.cliente c
						on v.idCliente = c.idCliente
						inner join factura.producto p
						on v.idProducto = p.idProducto
end
Execute reporte 

drop procedure reporte