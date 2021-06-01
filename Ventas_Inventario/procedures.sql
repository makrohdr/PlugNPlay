use ControlVentas
go

alter proc MostrarClientes

as
select * from Cliente
go

create proc AgregarCliente
@celular varchar (100),
@apellido varchar (100),
@nombre varchar (100),
@puntaje int
as
insert into Cliente values(@celular,@apellido,@nombre,@puntaje)

go

create proc EditarCliente
@celular varchar (100),
@apellido varchar (100),
@nombre varchar (100),
@puntaje int,
@id int
as
UPDATE Cliente SET Celular=@celular, Apellido=@apellido, Nombre=@Nombre, Puntaje=@puntaje
where IDcliente=@id
go

create proc EliminarCliente
@id int
as
delete from Cliente where IDcliente=@id;
go

exec NombreDelProceso 'ejemplo1', 'ejemplo2'
---------------------------------------

go

alter proc MostrarInventario
as
select * from Inventario
go
select IDinventario from Inventario
go
------------------------------------------------------------------------------

create proc AgregarInventario
@nombre varchar (100),
@volumen varchar (5),
@portada varchar (5),
@categoria varchar(100),
@empresa varchar(50),
@precio float,
@cantidad int,
@puntaje int
as
insert into Inventario values(@nombre,@volumen,@portada,@categoria,@empresa,@precio,@cantidad,@puntaje)
go

alter proc EditarInventario
@nombre varchar (100),
@volumen varchar (5),
@portada varchar (5),
@categoria varchar(100),
@empresa varchar(50),
@precio float,
@cantidad int,
@puntaje int,
@id int
as
update Inventario set Nombre=@nombre, [Volumen/Edicion]=@volumen, Portada=@portada, Categoria=@categoria,
					  Empresa=@empresa, Precio=@precio, Cantidad=@cantidad, Puntaje=@puntaje
where IDinventario=@id;
go

create proc EliminarInventario
@id int
as
delete from Inventario where IDinventario=@id
go

exec AgregarInventario 'Oreigaru', '1', 'A', 'Manga', 'Kamite', '85', '1', '45'
go
--------------------------------------------
--Crear tablas
create table Inventario(
IDinventario int identity primary key,
Nombre varchar(100),
Volumen varchar(5),
Portada varchar(5), 
Categoria varchar(100),
Empresa varchar(50),
Precio float,
Cantidad int,
Punataje int)

create table Clientes(
IDTelefono int identity (1,1) primary key,
RedSocial varchar(100),
Contacto varchar(100),
Nombre varchar(100),
Apellido varchar(100),
Puntaje int)

create table ReporteVentaLibros(
IDReporteLibros int identity(1,1) primary key,
IDlibros int foreign key (IDLibros) references inventario(IDinventario),
IDClientes int foreign key (IDClientes) references Clientes(IDTelefono),
Fecha varchar(100), 
Nombre varchar(100),
Volumen varchar(100),
Portada varchar(100),
Editorial varchar(100),
Precio int,
Puntaje int)

create table JuegosDeMesa(
IDJuegosDeMesa int identity (1,1) primary key,
Nombre varchar(100),
Precio int,
Puntaje int);

create table ReporteVentaJuegosDeMesa(
IDReporteJuegosDeMesa int identity(1,1) primary key,
IDJuegosDeMesa int foreign key (IDJuegosDeMesa) references JuegosDeMesa(IDJuegosDeMesa),
IDClientes int foreign key (IDClientes) references Clientes(IDTelefono),
Nombre varchar(100),
Precio int,
Puntaje int);

create table TCG(
IDTCG int identity (1,1) primary key,
Nombre Varchar(100),
Producto varchar(100),
Precio int,
Puntaje int);

create table ReporteVentasTCG(
ReporteTCG int identity (1,1) primary key,
IDTCG int foreign key (IDTCG) references TCG(IDTCG),
IDClientes int foreign key (IDClientes) references Clientes(IDTelefono),
Nombre Varchar(100),
Producto varchar(100),
Precio int,
Puntaje int);

create table Annetys(
IDAnnetys int identity(1,1) primary key,
Categoria varchar(100),
Nombre varchar(100),
Descripcion varchar(100),
Precio int,
Punatje int)

create table ReporteVentasAnnetys(
IDReporteAnnetys int identity(1,1) primary key,
IDAnnetys int foreign key (IDAnnetys) references Annetys(IDAnnetys),
IDClientes int foreign key (IDClientes) references Clientes(IDTelefono),
Categoria varchar(100),
Nombre varchar(100),
Descripcion varchar(100),
Precio int,
Punatje int)