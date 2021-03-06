GO
/****** Object:  StoredProcedure [dbo].[pa_DesisteOvsPorFecha]    Script Date: 25/9/2021 8:27:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =========================================================================================
-- Author:       IGNACIO HERRERIA
-- Create date:  14-06-2021
-- Description:  Desiste oportunidades por fecha
-- =========================================================================================
-- drop PROCEDURE Sp_Restauranes
CREATE OR ALTER    PROCEDURE [dbo].[Sp_Restauranes](
 @Accion varchar(1),
 @Nombre varchar(30),
 @IdRestaurante varchar(3),
 @Telefono varchar(15),
 @NumeroAforo varchar(3),
 @IdCiudad varchar(3)
 )

 --Sp_Restauranes @Accion, @Nombre,@IdRestaurante,@Telefono,@NumeroAforo,@IdCiudad
--WITH ENCRYPTION
AS
BEGIN

   SET NOCOUNT ON;
   --
   
   
   IF @Accion = ''
   return 
   IF @Accion = '1'
   Begin
   if @Nombre<>''
   select r.* from Restaurante r  left join Ciudad c on r.CiudadId=c.Id where c.NombreCiudad=@Nombre;
   else
   select * from Restaurante 
   End
   IF @Accion = '2'
   Begin
   select * from Restaurante where id=@IdRestaurante;
   End
   IF @Accion = '3'
   Begin
   INSERT INTO Restaurante (NombreRestaurante, NumeroAforo,CiudadId)VALUES (@Nombre, @NumeroAforo,@IdCiudad);
   select * from Restaurante 
   End
   IF @Accion = '4'
   Begin
   update Restaurante set NombreRestaurante=@Nombre, NumeroAforo=@NumeroAforo where id=@IdRestaurante;
   select * from Restaurante 
   End
   IF @Accion = '5'
   Begin
   delete from Restaurante where id=@IdRestaurante
   select * from Restaurante 
   End
END
