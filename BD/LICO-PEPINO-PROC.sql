use Licorera_Pepinos;

--Procedimiento para insertar usuarios
go
create proc Insert_User1
(@cedula integer, @nombre varchar(100), @Apellido1 varchar(50), @Apellido2 varchar(50), 
@Telefono integer, @FecNacimiento DATETime, @Email varchar(100), @Pass Varchar(50), @IdRol integer)
as
insert into Usuario (Cedula, Nombre, Apellido1, Apellido2, Telefono, FecNacimiento, Email, Pass,
IdRol) values
(@cedula, @nombre, @Apellido1, @Apellido2, @Telefono, @FecNacimiento, @Email, 
ENCRYPTBYPASSPHRASE('llave', @Pass), @IdRol);
go

--PROCEDIMIENTO PARA LOGIN
CREATE PROC LOGIN_USUARIO
(@CEDULA varchar(20), @PASS varchar(40), @RES BIT output)
as
declare
@ClaveEncriptada as varchar(100),
@ClaveDesencriptada as varchar(40)
begin
Select @ClaveEncriptada = Pass from Usuario
where cedula=@CEDULA

set @ClaveDesencriptada = DECRYPTBYPASSPHRASE('llave', @ClaveEncriptada)
end

begin
if @PASS=@ClaveDesencriptada 
SET @RES = 1
else
SET @RES = 0
END


--PROCEDIMIENTO INSERTAR CATEGORIA

GO 
CREATE PROC INSERT_CAT
(@NOMBRE VARCHAR(50), @Descripcion VARCHAR(max))
AS
INSERT INTO Categoria(Nombre, Descripcion) 
VALUES (@NOMBRE, @Descripcion);


--PROCEDIMIENTO INSERTAR PROVEEDOR

GO 
CREATE PROC INSERT_PROV
(@NOMBRE VARCHAR(30))
AS 
INSERT INTO Proveedor(Nombre) 
VALUES
(@NOMBRE);


--PROCEDIMIENTO INSERTAR INVENTARIO
GO
CREATE PROCEDURE INSERT_INVENTARIO
(@CANTIDAD INTEGER, @CODIGO INTEGER, @PRECIO MONEY, @IDPROVEEDOR INTEGER,
@TEXTO varchar(50) output)
AS
if (select count(*) from Inventario where CODIGO = @CODIGO)  = 0
INSERT INTO Inventario (Cantidad, Codigo, Precio, IdProveedor)
VALUES
(@CANTIDAD, @CODIGO, @PRECIO, @IDPROVEEDOR);
ELSE
select @TEXTO = 'Esta registrando un codigo que ya existe'
go


--Procedimiento Insertar Producto
GO
CREATE PROC INSERT_PRODUCTO
(@NOMBRE VARCHAR(50), @PRECIO MONEY, @DESCRIPCION NVARCHAR(MAX), @IMAGEN VARCHAR(50), 
@MARCA VARCHAR(50), @IDCATEGORIA INTEGER, @CODIGOINVENTARIO INTEGER, @TEXTO varchar(50) output)
AS 
if (select count(*) from Producto where CodigoInventario = @CODIGOINVENTARIO)  = 0
INSERT INTO Producto (Nombre, Precio, Descripcion, Imagen, Marca, IdCategoria, CodigoInventario)
VALUES
(@NOMBRE, @PRECIO, @DESCRIPCION, @IMAGEN, @MARCA, @IDCATEGORIA, @CODIGOINVENTARIO);
ELSE
select @TEXTO = 'Esta registrando un codigo que ya existe'
go

--Procedimiento INSERTAR VENTA
GO
CREATE PROC INSERT_VENTA
(@CEDULAUSUARIO INTEGER, @TOTAL MONEY, @FECHA DATE, @TIPOPAGO VARCHAR(20))
AS
INSERT INTO Venta (CedulaUsuario, Total, Fecha, TipoPago)
values
(@CEDULAUSUARIO, @TOTAL, @FECHA, @TIPOPAGO);

--Procedimiento VENTA PRODUCTO
GO
CREATE PROC INSERT_VENTA_PRODUCT
(@IDPRODUCTO INTEGER, @IDVENTA INTEGER, @CANTIDAD INTEGER)
AS
INSERT INTO Venta_Producto (IdProducto, IdVenta, Catidad)
values
(@IDPRODUCTO, @IDVENTA, @CANTIDAD);


--PROCEDIMIENTO INSERTAR DIRECCION
GO 
CREATE PROC INSERT_DIRECCION
(@DIRECCION VARCHAR(MAX), @DIRECCION2 VARCHAR(MAX), @IDVENTA INTEGER)
AS
INSERT INTO Direccion (Direccion, Direccion2, IdVenta)
VALUES
(@DIRECCION, @DIRECCION2, @IDVENTA);


