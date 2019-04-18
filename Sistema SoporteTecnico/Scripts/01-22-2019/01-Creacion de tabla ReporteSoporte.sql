Create table ReporteSoporte(
ID smallint not null,
ClienteID smallint not null,
ColaboradorID smallint not null,
FechaInforme datetime not null,
FechaSolucion datetime null,
HoraReporte datetime not null,
ReportadoPor varchar(30) not null,
Caso varchar(max) not null,
Solucion varchar(max) null,
TemaPendiente varchar(max) null,
HoraSolucion datetime null,
Solucionado bit
)

go

alter table ReporteSoporte add constraint PK_ReporteSolucion primary key(ID,ClienteID,ColaboradorID)
go
Alter table ReporteSoporte add constraint FK_ReporteSolucion_Clientes foreign key(ClienteID) references Clientes(ID)
go
Alter table ReporteSoporte add constraint FK_ReporteSolucion_Colaboradores foreign key(ColaboradorID) references Colaboradores(ID)
go
alter table ReporteSoporte add constraint DF_ReporteSolucion_FechaInforme default('00/00/000') for FechaInforme
go
alter table ReporteSoporte add constraint DF_ReporteSolucion_FechaSolucion default('00/00/000') for FechaSolucion
go
alter table ReporteSoporte add constraint DF_ReporteSolucion_HoraReporte default('00:00:00') for HoraReporte
go
alter table ReporteSoporte add constraint DF_ReporteSolucion_ReportadoPor default('') for ReportadoPor
go
alter table ReporteSoporte add constraint DF_ReporteSolucion_Caso default('') for Caso
go
alter table ReporteSoporte add constraint DF_ReporteSolucion_Solucion default('') for Solucion
go
alter table ReporteSoporte add constraint DF_ReporteSolucion_TemaPendiente default('') for TemaPendiente
go
alter table ReporteSoporte add constraint DF_ReporteSolucion_HoraSolucion default('00:00:00') for HoraSolucion
go
alter table ReporteSoporte add constraint DF_ReporteSolucion_Solucionado default(0) for Solucionado


