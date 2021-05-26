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

create table Cliente(
IDcliente int identity (1,1) primary key,
Celular varchar(15),
Nombre_Facebook varchar(30),
Apellido varchar(25),
Nombre varchar(25),
Puntaje int)

insert into Cliente values('6861234567', 'Gastelum','Marco', 0)

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

create table Inventario(IDinventario int identity primary key, Nombre varchar(100), Volumen varchar(5), Portada varchar(5), 
Categoria varchar(100), Empresa varchar(50), Precio float, Cantidad int, Punataje int)
go

alter proc MostrarInventario
as
select * from Inventario
go
select IDinventario from Inventario
go

-----------------------------------------------------------------------------

alter proc FiltroNombre
@Aux1 varchar(50)
as
select * from Inventario where Nombre like @Aux1;
go

exec FiltroNombre @Aux1 = 'mi'; 
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

alter proc FiltroInventario
@filtro varchar(100)
as
select Nombre, [Volumen/Edicion], Portada, Categoria, Empresa, Precio, Cantidad, Puntaje 
from Inventario
where Nombre like @filtro + '%'

go