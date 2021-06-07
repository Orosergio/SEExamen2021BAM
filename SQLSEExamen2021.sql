--CREATE TABLE te_clientes(
--cli_codigo_cliente INT IDENTITY(1,1),
--cli_nombre1 VARCHAR(40),
--cli_nombre2 VARCHAR(40),
--cli_apellido1 VARCHAR(40),
--cli_apellido2 VARCHAR(40),
--cli_apellido_casada VARCHAR(40),
--cli_direccion VARCHAR(250),
--cli_telefono1 INT,
--cli_telefono2 INT,
--cli_identificacion VARCHAR(25),
--cli_fechaNacimiento DATETIME,
--estado TINYINT
--);
--ALTER TABLE te_clientes ADD PRIMARY KEY(cli_codigo_cliente);


SELECT * FROM te_clientes
CREATE PROC SP_INSERTAR
@i_cli_nombre1 VARCHAR(40),
@i_cli_nombre2 VARCHAR(40),
@i_cli_apellido1 VARCHAR(40),
@i_cli_apellido2 VARCHAR(40),
@i_cli_apellido_casada VARCHAR(40),
@i_cli_direccion VARCHAR(250),
@i_cli_telefono1 INT,
@i_cli_telefono2 INT,
@i_cli_identificacion VARCHAR(25),
@i_cli_fechaNacimiento DATETIME,
@i_estado TINYINT
AS
BEGIN TRY
	BEGIN TRAN
	INSERT INTO te_clientes VALUES(@i_cli_nombre1,@i_cli_nombre2,@i_cli_apellido1,@i_cli_apellido2,@i_cli_apellido_casada,@i_cli_direccion,@i_cli_telefono1,@i_cli_telefono2,@i_cli_identificacion,@i_cli_fechaNacimiento, @i_estado);
	COMMIT TRAN
END TRY
BEGIN CATCH
	SELECT ERROR_MESSAGE()
	ROLLBACK TRAN
END CATCH

EXEC SP_INSERTAR 'Christian','Israel','Reyes','Aldana','NULL','Zona 4, Ciudad de Guatemala',18756845,12584987,'1223652412352','03/27/1995',1;
EXEC SP_INSERTAR 'Bryan','Orlando','Aguirre','Sagastume','Pérez','Zona 2, Ciudad de Guatemala',18756845,12584987,'9898487562512','08/07/1996',1;

SELECT * FROM te_clientes;

CREATE PROC		
@i_codigo INT,
@w_cli_apellido_casada VARCHAR(40),
@w_cli_direccion VARCHAR(250),
@w_estado TINYINT
AS
BEGIN TRY
	BEGIN TRAN
	UPDATE te_clientes SET cli_apellido_casada = @w_cli_apellido_casada, cli_direccion = @w_cli_direccion, estado = @w_estado
	WHERE cli_codigo_cliente = @i_codigo;
	COMMIT TRAN
END TRY
BEGIN CATCH
	SELECT ERROR_MESSAGE()
	ROLLBACK TRAN
END CATCH

EXEC SP_MODIFICAR 1,'NULL','Zona 4, ciudad de Guatemala',1

SELECT * FROM te_clientes


CREATE PROC SP_DELETEDEFINITIVO
@i_codigo INT
AS
BEGIN TRY
	BEGIN TRAN
	DELETE FROM te_clientes WHERE cli_codigo_cliente = @i_codigo
	COMMIT TRAN
END TRY
BEGIN CATCH
	SELECT ERROR_MESSAGE()
	ROLLBACK TRAN
END CATCH

EXEC SP_DELETEDEFINITIVO 1
SELECT * FROM te_clientes


CREATE PROC SP_BORRAR
@i_codigo INT
AS
BEGIN TRY
	BEGIN TRAN
	UPDATE te_clientes SET estado = 0 WHERE cli_codigo_cliente = @i_codigo
	COMMIT TRAN
END TRY
BEGIN CATCH
	SELECT ERROR_MESSAGE()
	ROLLBACK TRAN
END CATCH
EXEC SP_BORRAR 1
SELECT * FROM te_clientes

/*CONSULTAS*/
CREATE PROC SP_CONSULTANOMBRE
@i_nombre1 VARCHAR(40),
@i_apellido1 VARCHAR(40)
AS
BEGIN TRY
	BEGIN TRAN
	SELECT * FROM te_clientes
	WHERE cli_nombre1 = @i_nombre1 AND cli_apellido1 = @i_apellido1
	COMMIT TRAN
END TRY
BEGIN CATCH
	SELECT ERROR_MESSAGE()
	ROLLBACK TRAN
END CATCH

SELECT * FROM te_clientes

EXEC SP_CONSULTANOMBRE 'Bryan','Aguirre'

CREATE PROC SP_BUSQUEDAFECHA
@i_fechaInic VARCHAR(40),
@i_fechaFin VARCHAR(40)
AS
BEGIN TRY
	BEGIN TRAN
	SELECT cli_fechaNacimiento FROM te_clientes
	WHERE cli_fechaNacimiento BETWEEN @i_fechaInic AND @i_fechaFin
	COMMIT TRAN
END TRY
BEGIN CATCH
	SELECT ERROR_MESSAGE()
	ROLLBACK TRAN
END CATCH

SELECT * FROM te_clientes

EXEC SP_BUSQUEDAFECHA '03/01/1991','12/22/1996'
