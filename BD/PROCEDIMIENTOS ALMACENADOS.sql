/*PROCEDIMIENTO ALMACENADO PARA CREAR NUEVO USUARIO*/
CREATE PROC sp_RegistrarUsuario(
/*PARAMETROS DE ENTRADA*/
 @Nombre varchar (100),
 @Apellido varchar (100),
 @Correo varchar (100),
 @Clave varchar (150),
 @Activo bit,
 /*PARAMETROS DE SALIDA*/
 @Mensaje varchar (500) output,
 @Resultado int output
 )
 AS
 BEGIN
     SET @Resultado = 0
     IF NOT EXISTS (SELECT * FROM USUARIO WHERE Correo = @Correo)
     BEGIN
         INSERT INTO USUARIO(Nombre, Apellido, Correo, Clave, Activo) VALUES
         (@Nombre, @Apellido, @Correo, @Clave, @Activo)
         SET @Resultado = scope_identity()
     END
     ELSE
      SET @Mensaje = 'El correo del usuario ya existe'
 END

 /*PROCEDIMIENTO ALMACENADO PARA EDITAR USUARIO*/
 CREATE PROC sp_EditarUsuario(
 /*PARAMETROS DE ENTRADA*/
 @IdUsuario int,
 @Nombre varchar (100),
 @Apellido varchar (100),
 @Correo varchar (100),
 @Activo bit,
 /*PARAMETROS DE SALIDA*/
 @Mensaje varchar (500) output,
 @Resultado int output
 )
 AS
 BEGIN
	 SET @Resultado = 0
     IF NOT EXISTS (SELECT * FROM USUARIO WHERE Correo = @Correo AND IdUsuario != @IdUsuario)
     BEGIN
         UPDATE TOP(1) USUARIO SET
		 Nombre = @Nombre,
		 Apellido = @Apellido,
		 Correo = @Correo,
		 Activo = @Activo
		 WHERE IdUsuario = @IdUsuario

         SET @Resultado = 1

	 END
     ELSE
      SET @Mensaje = 'El correo del usuario ya existe'
 END
