-- 1 - Login con usuario y clave (5 puntos)
create database Proyecto_Final
go

use Proyecto_Final
go

create table Usuario (
	idUsuario nvarchar(30) primary key not null,
	clave nvarchar(30) not null,
	estado bit
)
go

create procedure Validate
@idUsuario nvarchar(30),
@clave nvarchar(30)
as
select count(*) from Usuario where idUsuario = @idUsuario and clave = @clave and estado = 1
go

/*3 - Formularios Catálogos, cada formulario debe permitir: Agregar, Editar, Eliminar y Mostrar el listado de todos los registros.
En este proyecto deben haber al menos 4 formularios Catálogos (4 tablas catálogos).*/
create table Cliente (
	idCliente int identity(1,1) primary key not null,
	primer_nombre nvarchar(35) not null,
	segundo_nombre nvarchar(35),
	primer_apellido nvarchar(35) not null,
	segundo_apellido nvarchar(35),
	direccion nvarchar(500),
	telefono char(8) check (telefono like '2[0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	email nvarchar(40)
)
go

create table Producto (
	idProducto int identity(1,1) primary key not null,
	descripcion nvarchar(200) not null,
	precio money,
	existencia int,
)
go

create table Factura (
	idFactura int identity(1,1) primary key not null,
	fecha date default getDate(),
	idCliente int foreign key references Cliente(idCliente) not null,
	total money
)
go

create table Detalle_Factura (
	idFactura int foreign key references Factura(idFactura) not null,
	idProducto int foreign key references Producto(idProducto) not null,
	primary key(idFactura, idProducto),
	cantidad int,
	subtotal money
)
go

create trigger Total_Factura
on Detalle_Factura
after insert, update, delete
as
	update Factura set total = (select sum(subtotal) from Detalle_Factura where Detalle_Factura.idFactura = Factura.idFactura)
go

create trigger Existencia_Producto
on Detalle_Factura
after insert
as
	update Producto set existencia = existencia - (select cantidad from inserted) where Producto.idProducto = (select idProducto from inserted)
go

create table LastIDFactura (
	idFactura int foreign key references Factura(idFactura) not null,
	primary key(idFactura)
)
go

create trigger InsertLastIDFactura
on Factura
after insert
as
	truncate table LastIDFactura
	insert into LastIDFactura values((select idFactura from inserted))
go

create procedure Detalle_Factura_InsertQuery
@idFactura int,
@idProducto int,
@cantidad int
as
if(@cantidad <= (select existencia from Producto where idProducto = @idProducto) and @cantidad > 0)
begin
	insert into Detalle_Factura values (@idFactura, @idProducto, @cantidad, @cantidad * (select precio from Producto where idProducto = @idProducto))
end
go

create procedure Detalle_Factura_UpdateQuery
@idFactura int,
@idProducto int,
@cantidad int
as
if(@cantidad <= (select existencia from Producto where idProducto = @idProducto) and @cantidad > 0)
begin
	update Detalle_Factura set cantidad = @cantidad, subtotal = @cantidad * (select precio from Producto where idProducto = @idProducto) where idFactura = @idFactura and idProducto = @idProducto
end
go

use Proyecto_Final

SET IDENTITY_INSERT dbo.Factura ON
GO

insert into Factura(idFactura, fecha, idCliente, total) values (1, getdate(), 4, null)

select * from LastIDFactura

select Detalle_Factura.idFactura, fecha, idProducto, cantidad, subtotal, fecha, idCliente from Factura inner join Detalle_Factura
on Factura.idFactura = Detalle_Factura.idFactura and fecha = cast(getdate() as date)

select Detalle_Factura.idFactura, fecha, idProducto, cantidad, subtotal, fecha, idCliente from Factura inner join Detalle_Factura
on Factura.idFactura = Detalle_Factura.idFactura and month(fecha) = month(getdate()) and year(fecha) = year(getdate())

select Detalle_Factura.idFactura, fecha, idProducto, cantidad, subtotal, fecha, idCliente from Factura inner join Detalle_Factura
on Factura.idFactura = Detalle_Factura.idFactura and year(fecha) = year(getdate())

select Detalle_Factura.idFactura, fecha, idProducto, cantidad, subtotal, fecha, idCliente from Factura inner join Detalle_Factura
on Factura.idFactura = Detalle_Factura.idFactura and cantidad = cantidad and fecha = fecha

select Detalle_Factura.idFactura, fecha, idProducto, cantidad, subtotal, fecha, idCliente
from Factura, Detalle_Factura
where Factura.idFactura = Detalle_Factura.idFactura
and cantidad > 2 and fecha = cast(getdate() as date)