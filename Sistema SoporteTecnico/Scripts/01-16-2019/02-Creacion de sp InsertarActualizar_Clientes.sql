Create Procedure [dbo].[InsertarActualizar_Clientes](
@Accion varchar(15), 
@ID smallint,
@Nombre varchar(100), 
@Correo varchar(100), 
@Activo bit
)as begin

	if @Accion = 'Insertar' begin
	   set @ID = null
	    select top 1 @ID = ID +1
	    from Clientes order by ID desc
	    
	    set @ID = ISNULL(@ID,1)
	    
		Insert into Clientes
		  (ID,Nombre,Correo,Activo)
		values
				(@ID,@Nombre,@Correo,@Activo)
		
	end
	if @Accion = 'Actualizar' begin 
	
		update Clientes
		set Nombre = @Nombre,
			Activo = @Activo			
	    where ID = @ID
	    
	end

end
