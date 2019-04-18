create procedure SeleccionarReportes(
@ReporteID smallint,
@Solucionado bit
)as begin

	if @ReporteID = 0 begin
	 
		select 
			 RS.ID,
			 C.Nombre [Nombre del Cliente],
			 CL.Nombre [Nombre del Colaborador],
			 Convert(varchar(10),RS.FechaInforme,103) [Fecha informe de caso],
			 Convert(varchar(10),RS.FechaSolucion,103) [Fecha solucion caso],
			 Convert(varchar(8),RS.HoraReporte,8) [Hora reporte caso],
			 RS.ReportadoPor [Reportado por],
			 RS.Caso,
			 isnull(RS.Solucion,'') [Solucion],
			 isnull(RS.TemaPendiente,'') [Tema pendiente],
			 Convert(varchar(8),RS.HoraSolucion,8) [Hora solucion caso],
			 RS.Solucionado 
		from ReporteSoporte RS,
			 Clientes C,
			 Colaboradores CL
		Where 
			RS.ClienteID = C.ID and
			RS.ColaboradorID = CL.ID and
			RS.Solucionado = @Solucionado
	end
	else begin
		select 
			 RS.ID,
			 C.Nombre [Nombre del Cliente],
			 CL.Nombre [Nombre del Colaborador],
			 Convert(varchar(10),RS.FechaInforme,103) [Fecha informe de caso],
			 Convert(varchar(10),RS.FechaSolucion,103) [Fecha solucion caso],
			 Convert(varchar(8),RS.HoraReporte,8) [Hora reporte caso],
			 RS.ReportadoPor [Reportado por],
			 RS.Caso,
			 isnull(RS.Solucion,'') [Solucion],
			 isnull(RS.TemaPendiente,'') [Tema pendiente],
			 Convert(varchar(8),RS.HoraSolucion,8) [Hora solucion caso],
			 RS.Solucionado 
		from ReporteSoporte RS,
			 Clientes C,
			 Colaboradores CL
		Where 
			RS.ID = @ReporteID and
			RS.ClienteID = C.ID and
			RS.ColaboradorID = CL.ID
	end

end