Create Procedure [dbo].[InsertarActualizar_ReporteSoporte](
@Accion varchar(15), 
@ID smallint,
@ClienteID smallint,
@ColaboradorID smallint,
@FechaInforme datetime,
@FechaSolucion datetime,
@HoraReporte datetime,
@ReportadoPor varchar(30),
@Caso varchar(max),
@Solucion varchar(max),
@TemaPendiente varchar(max),
@HoraSolucion datetime,
@Solucionado bit
)as begin

	if @Accion = 'Insertar' begin
	   set @ID = null
	    select top 1 @ID = ID +1
	    from ReporteSoporte order by ID desc
	    
	    set @ID = ISNULL(@ID,1)
	    
		Insert into ReporteSoporte
		  (ID,
			ClienteID,
			ColaboradorID,
			FechaInforme,
			FechaSolucion,
			HoraReporte,
			ReportadoPor,
			Caso,
			Solucion,
			TemaPendiente,
			HoraSolucion,
			Solucionado)
		values
		 (@ID,
			@ClienteID,
			@ColaboradorID,
			@FechaInforme,
			@FechaSolucion,
			@HoraReporte,
			@ReportadoPor,
			@Caso,
			@Solucion,
			@TemaPendiente,
			@HoraSolucion,
			@Solucionado)
		
	end
	if @Accion = 'Actualizar' begin 
		update ReporteSoporte
		set 
			FechaInforme = @FechaInforme,
			FechaSolucion = @FechaSolucion,
			HoraReporte = @HoraReporte,
			ReportadoPor = @ReportadoPor,
			Caso = @Caso,
			Solucion = @Solucion,
			TemaPendiente = @TemaPendiente,
			HoraSolucion = @HoraSolucion,
			Solucionado	= @Solucionado		
	    where ID = @ID and 
			  ClienteID = @ClienteID and
			  ColaboradorID = @ColaboradorID
	    
	end

end
