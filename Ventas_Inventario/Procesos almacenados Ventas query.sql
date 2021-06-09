USE [DBplugYplay]
----------------------------------------
-----------PROCESOS DE VENTA------------
----------------------------------------
--Ventas Clientes--
----------------------------------------
GO
Create proc [dbo].[VentasCliente]
@Telefono VARCHAR (100)
as
Begin
select IDTelefono from Clientes where Clientes.IDTelefono = @Telefono
Return
END
go
Exec VentasCliente @Telefono = '6862338885'
----------------------------------------
--Procesos Libros--
----------------------------------------
GO
Alter proc [dbo].[VentasCbEditorialL]
@Nombre VARCHAR (100)

as
Begin
select distinct Editorial from Inventario where Inventario.Nombre = @Nombre
Return
END
go
Exec VentasCbEditorialL @Nombre = 'Naruto'
-----------------------------------------
GO
Create proc [dbo].[VentasCbNombreL]
@Categoria VARCHAR (100)
as
Begin
select distinct Nombre from Inventario where Inventario.Categoria = @Categoria
Return
END
go
Exec VentasCbNombreL @Categoria = 'Manga'
-----------------------------------------
GO
Create proc [dbo].[VentasCbPortadaL]
@Nombre VARCHAR (100)
as
Begin
select distinct Portada from Inventario where Inventario.Nombre = @Nombre
Return
END
go
Exec VentasCbPortadaL @Nombre = 'Naruto'
-----------------------------------------
GO
Create proc [dbo].[VentasCbVolumenL]
@Nombre VARCHAR (100)
as
Begin
select distinct Volumen from Inventario where Inventario.Nombre = @Nombre
Return
END
go
Exec VentasCbVolumenL @Nombre = 'Naruto'
-----------------------------------------
GO
Create proc [dbo].[VentastxtCantidadL]
@Nombre VARCHAR (100),
@Volumen VARCHAR (100)
as
Begin
select distinct Cantidad from Inventario where Inventario.Nombre = @Nombre and
Inventario.Volumen = @Volumen
Return
END
go
Exec VentasCantidadL @Nombre = 'Naruto', @Volumen = 9
-----------------------------------------
GO
Create proc [dbo].[VentasIDLibrosL]
@Nombre VARCHAR (100),
@Volumen VARCHAR (100)
as
Begin
select distinct Cantidad from Inventario where Inventario.Nombre = @Nombre and
Inventario.Volumen = @Volumen
Return
END
go
Exec VentasIDLibrosL @Nombre = 'Naruto', @Volumen = 9
-----------------------------------------
GO
Create proc [dbo].[VentaslblPrecioL]
@Nombre VARCHAR (100),
@Volumen VARCHAR (100),
@Portada Varchar (100)
as
Begin
select distinct Precio from Inventario where Inventario.Nombre = @Nombre and
Inventario.Volumen = @Volumen and Inventario.Portada = @Portada
Return
END
go
Exec VentaslblPrecioL @Nombre = 'Naruto', @Volumen = 9, @Portada = 'A'
-----------------------------------------
GO
Create proc [dbo].[VentaslblPuntajeL]
@Nombre VARCHAR (100),
@Volumen VARCHAR (100),
@Portada Varchar (100)
as
Begin
select distinct Puntaje from Inventario where Inventario.Nombre = @Nombre and
Inventario.Volumen = @Volumen and Inventario.Portada = @Portada
Return
END
go
Exec VentaslblPuntajeL @Nombre = 'Naruto', @Volumen = 9, @Portada = 'A'
-----------------------------------------
--Procesos Annetys--
-----------------------------------------
GO
Create proc [dbo].[VentasCbDescripcionA]
@Nombre VARCHAR (100)
as
Begin
select distinct Descripcion from Annetys where Annetys.Nombre = @Nombre
Return
END
go
Exec VentasCbDescripcionA @Nombre = ''
GO
----------------------------------------
Create proc [dbo].[VentasIDAnnetys]
@Nombre VARCHAR (100),
@Descripcion Varchar (200)
as
Begin
select distinct IDAnnetys from Annetys where Annetys.Nombre = @Nombre and Annetys.Descripcion = @Descripcion
Return
END
go
Exec VentasCbDescripcionA @Nombre = ''
-----------------------------------------
GO
Alter proc [dbo].[VentasCbNombreA]
@Categoria VARCHAR (100)
as
Begin
select distinct Nombre from Annetys where Annetys.Categoria = @Categoria
Return
END
go
Exec VentasCbNombreL @Categoria = 'Manga'
-----------------------------------------
GO
Create proc [dbo].[VentaslblPrecioA]
@Nombre VARCHAR (100),
@Descripcion VARCHAR (200),
@Categoria Varchar (200)
as
Begin
select distinct Precio from Annetys where Annetys.Nombre = @Nombre and
Descripcion = @Descripcion and Annetys.Categoria = @Categoria
Return
END
go
Exec VentaslblPrecioA @Nombre = 'Manga', @Descripcion = '', @Categoria = ''
-----------------------------------------
GO
Create proc [dbo].[VentaslblPuntajeA]
@Nombre VARCHAR (100),
@Descripcion VARCHAR (200),
@Categoria Varchar (200)
as
Begin
select distinct Annetys.Punatje from Annetys where Annetys.Nombre = @Nombre and
Descripcion = @Descripcion and Annetys.Categoria = @Categoria
Return
END
go
Exec VentaslblPrecioA @Nombre = 'Manga', @Descripcion = '', @Categoria = ''
-----------------------------------------
GO
Create proc [dbo].[VentastxtPrecioA]
@Nombre VARCHAR (100),
@Descripcion VARCHAR (200),
@Categoria Varchar (200)
as
Begin
select distinct Annetys.Precio from Annetys where Annetys.Nombre = @Nombre and
Descripcion = @Descripcion and Annetys.Categoria = @Categoria
Return
END
go
Exec VentaslblPrecioA @Nombre = 'Manga', @Descripcion = '', @Categoria = ''
-----------------------------------------
--Procesos TCG-- (Nombre sin Proceso)
-----------------------------------------
GO
Create proc [dbo].[VentasCbProductoT]
@Nombre VARCHAR (100)
as
Begin
select distinct Producto from TCG where TCG.Nombre = @Nombre
Return
END
go
Exec VentasCbNombreL @Categoria = 'Manga'
-----------------------------------------
GO
Create proc [dbo].[VentastxtCantidadT]
@Nombre VARCHAR (100),
@Producto Varchar(100)
as
Begin
select distinct TCG.Cantidad from TCG where TCG.Nombre = @Nombre and
TCG.Producto = TCG.Producto
Return
END
go
Exec VentasCbNombreL @Categoria = 'Manga'
-----------------------------------------
GO
Create proc [dbo].[VentaslblPrecioT]
@Nombre VARCHAR (100),
@Producto Varchar(100)
as
Begin
select distinct Producto from TCG where TCG.Nombre = @Nombre and
TCG.Producto = TCG.Producto
Return
END
go
Exec VentasCbNombreL @Categoria = 'Manga'
-----------------------------------------
GO
Create proc [dbo].[VentaslblPuntajeT]
@Nombre VARCHAR (100),
@Producto Varchar(100)
as
Begin
select distinct Producto from TCG where TCG.Nombre = @Nombre and
TCG.Producto = TCG.Producto
Return
END
go
Exec VentasCbNombreL @Categoria = 'Manga'
-----------------------------------------
GO
Create proc [dbo].[VentasIDTCG]
@Nombre VARCHAR (100),
@Producto Varchar(100)
as
Begin
select distinct IDTCG from TCG where TCG.Nombre = @Nombre and
TCG.Producto = @Producto
Return
END
go
Exec VentasCbNombreL @Categoria = 'Manga'
-----------------------------------------
--Procesos Juegos de mesa-- (Nombre sin proceso)
-----------------------------------------
GO
Create proc [dbo].[VentastxtCantidadJ]
@Nombre VARCHAR (100)
as
Begin
select distinct JuegosDeMesa.Cantidad from JuegosDeMesa where JuegosDeMesa.Nombre = @Nombre
Return
END
go
Exec VentasCbNombreL @Categoria = 'Manga'
-----------------------------------------
GO
Create proc [dbo].[VentaslblPrecioJ]
@Nombre VARCHAR (100),
@Producto Varchar(100)
as
Begin
select distinct Precio from JuegosDeMesa where JuegosDeMesa.Nombre = @Nombre 
Return
END
go
Exec VentasCbNombreL @Categoria = 'Manga'
-----------------------------------------
GO
Create proc [dbo].[VentaslblPuntajeJ]
@Nombre VARCHAR (100),
@Producto Varchar(100)
as
Begin
select distinct Puntaje from JuegosDeMesa where JuegosDeMesa.Nombre = @Nombre 
Return
END
go
Exec VentasCbNombreL @Categoria = 'Manga'
-----------------------------------------
GO
Create proc [dbo].[VentasIDJuegosdeMesa]
@Nombre VARCHAR (100)
as
Begin
select distinct IDJuegosDeMesa from JuegosDeMesa where JuegosDeMesa.Nombre = @Nombre
Return
END
go
Exec VentasCbNombreL @Categoria = 'Manga'
-----------------------------------------
