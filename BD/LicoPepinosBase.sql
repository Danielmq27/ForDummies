Create database Licorera_Pepinos;

use Licorera_Pepinos;

/* Esata tabla almacenar los roles que le seran asignados a los usuarios */

create table Rol(
ID integer IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(20) not null,
Descripcion varchar(200) not null
);
Insert into Rol values('Administrador', 'Este rol tiene permiso para todo');
select* from Rol

/* Tabla que registrara a los usuarios */
create table Usuario(
ID integer IDENTITY(1,1) PRIMARY KEY,
Cedula integer UNIQUE not null,
Nombre varchar(100) not null,
Apellido1 varchar(50) not null,
Apellido2 varchar(50) not null,
Telefono integer not null,
FecNacimiento DATE not null,
Email varchar(100) UNIQUE not null,
Pass Varchar(50) not null,
IdRol integer not null,
foreign key (IdRol) references Rol (Id)
);
insert into Usuario values(207440758, 'Freddy', 'Chicas', 'Matamoros', 88958465,
getdate(), 'fredd@gmail.com', ENCRYPTBYPASSPHRASE('8', 'pass'), 1);

select * from Usuario

create table Venta(
ID integer IDENTITY(1,1) PRIMARY KEY,
CedulaUsuario INTEGER,
Total MONEY,
Fecha DATE,
TipoPago VARCHAR(20),
foreign key (CedulaUsuario) references Usuario (cedula)
);


create table Direccion(
ID integer IDENTITY(1,1) PRIMARY KEY,
Direccion VARCHAR(MAX),
Direccion2 VARCHAR(MAX),
IdVenta INTEGER,
foreign key (IdVenta) references Venta (ID)
);


create table Categoria(
ID integer IDENTITY(1,1) PRIMARY KEY,
Nombre VARCHAR(50),
Descripcion VARCHAR(max)
);

create table Proveedor(
ID integer IDENTITY(1,1) PRIMARY KEY,
Nombre VARCHAR(30)
);

CREATE table Inventario(
ID integer IDENTITY(1,1) PRIMARY KEY,
Cantidad INTEGER,
Codigo INTEGER UNIQUE,
Precio MONEY,
IdProveedor INTEGER,
foreign key (IdProveedor) references Proveedor (ID)
);

Create table Producto(
ID integer IDENTITY(1,1) PRIMARY KEY,
Nombre VARCHAR(50),
Precio MONEY,
Descripcion NVARCHAR(MAX),
Imagen VARCHAR(50),
Marca VARCHAR(50),
IdCategoria INTEGER,
CodigoInventario INTEGER,
foreign key (IdCategoria) references Categoria (ID),
foreign key (CodigoInventario) references Inventario (Codigo)
);

create table Venta_Producto(
ID integer IDENTITY(1,1) PRIMARY KEY,
IdProducto INTEGER,
IdVenta INTEGER,
Catidad integer,
foreign key (IdProducto) references Producto (Id),
foreign key (IdVenta) references Venta (Id)
);

