Create table Configuracion(
ID smallint not null,
SMTP varchar(100) not null,
ContraseñaSMTP  varchar(100) not null,
UsuarioSMTP varchar(100) not null,
Puerto smallint not null,
SSL bit,
CorreoDe varchar(100) not null,
Asunto varchar(100),
Cuerpo varchar(max),
CopiaCorreos varchar(max)
)

Alter table Configuracion add constraint PK_Configuracion primary key(ID)
go
alter table Configuracion add constraint DF_Configuracion_ContraseñaSMTP default('') for ContraseñaSMTP
go
alter table Configuracion add constraint DF_Configuracion_UsuarioSMTP default('') for UsuarioSMTP
go
alter table Configuracion add constraint DF_Configuracion_Puerto default(0) for Puerto
go
alter table Configuracion add constraint DF_Configuracion_SSL default('') for SSL
go
alter table Configuracion add constraint DF_Configuracion_CorreoDe default('') for CorreoDe
go
alter table Configuracion add constraint DF_Configuracion_Asunto default('') for Asunto
go
alter table Configuracion add constraint DF_Configuracion_Cuerpo default('') for Cuerpo
go
alter table Configuracion add constraint DF_Configuracion_CopiaCorreos default('') for CopiaCorreos
go
alter table Configuracion add constraint DF_Configuracion_SMTP default('') for SMTP