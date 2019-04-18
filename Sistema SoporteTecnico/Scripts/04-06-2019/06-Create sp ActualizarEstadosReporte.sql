Create Procedure ActualizarEstadosReporte(
@ReporteID smallint,
@ClienteID smallint,
@ColaboradorID smallint
)as begin

Update ReporteSoporte
set solucionado = 1
where ID = @ReporteID
and ClienteID = @ClienteID
and ColaboradorID = @ColaboradorID

Update ReporteSoporte
Set TemaPendienteCheck = 1
where ID = (Select CasoSolucionID from ReporteSoporte where ID = @ReporteID)

end