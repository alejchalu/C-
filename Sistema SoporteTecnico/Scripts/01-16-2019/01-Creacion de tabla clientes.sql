Create table Clientes(
ID smallint not null,
Nombre varchar(100) not null,
Correo varchar(100) not null,
Activo bit not null
)

Alter table Clientes add constraint PK_Clientes primary key(ID)
go
alter table Clientes add constraint DF_Clientes_Nombre default('') for Nombre
go
alter table Clientes add constraint DF_Clientes_Correo default('') for Correo
go
alter table Clientes add constraint DF_Clientes_Activo default('') for Activo