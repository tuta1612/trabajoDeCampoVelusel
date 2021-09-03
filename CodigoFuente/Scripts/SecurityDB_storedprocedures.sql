/****** Object:  StoredProcedure [dbo].[RethrowError]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RethrowError] AS
    /* Return if there is no error information to retrieve. */
    IF ERROR_NUMBER() IS NULL
        RETURN;

    DECLARE
        @ErrorMessage    NVARCHAR(4000),
        @ErrorNumber     INT,
        @ErrorSeverity   INT,
        @ErrorState      INT,
        @ErrorLine       INT,
        @ErrorProcedure  NVARCHAR(200); 

    /* Assign variables to error-handling functions that
       capture information for RAISERROR. */

    SELECT
        @ErrorNumber = ERROR_NUMBER(),
        @ErrorSeverity = ERROR_SEVERITY(),
        @ErrorState = ERROR_STATE(),
        @ErrorLine = ERROR_LINE(),
        @ErrorProcedure = ISNULL(ERROR_PROCEDURE(), '-'); 

    /* Building the message string that will contain original
       error information. */

    SELECT @ErrorMessage = 
        N'Error %d, Level %d, State %d, Procedure %s, Line %d, ' + 
         'Message: '+ ERROR_MESSAGE(); 

    /* Raise an error: msg_str parameter of RAISERROR will contain
	   the original error information. */

    RAISERROR(@ErrorMessage, @ErrorSeverity, 1,
        @ErrorNumber,    /* parameter: original error number. */
        @ErrorSeverity,  /* parameter: original error severity. */
        @ErrorState,     /* parameter: original error state. */
        @ErrorProcedure, /* parameter: original error procedure name. */
        @ErrorLine       /* parameter: original error line number. */
        );
GO

/****** Object:  StoredProcedure [dbo].[Familia_Delete]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Familia_Delete]
	@IdFamilia varchar (36) 
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	DELETE FROM Familia
	WHERE 
		IdFamilia=@IdFamilia
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO
/****** Object:  StoredProcedure [dbo].[Familia_Familia_Delete]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Familia_Familia_Delete]
	@IdFamilia varchar (36) , 
	@IdFamiliaHijo varchar (36) 
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	DELETE FROM Familia_Familia
	WHERE 
		IdFamilia=@IdFamilia AND 
		IdFamiliaHijo=@IdFamiliaHijo
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO
/****** Object:  StoredProcedure [dbo].[Familia_Familia_DeleteParticular]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Familia_Familia_DeleteParticular]
	@IdFamilia varchar (36)
AS
	DELETE FROM Familia_Familia
	WHERE 
		IdFamilia=@IdFamilia
GO
/****** Object:  StoredProcedure [dbo].[Familia_Familia_Insert]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Familia_Familia_Insert]	
	@IdFamilia varchar (36) , 
	@IdFamiliaHijo varchar (36) 
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	INSERT INTO Familia_Familia (
		[IdFamilia], 
		[IdFamiliaHijo]
	) VALUES (
		@IdFamilia, 
		@IdFamiliaHijo
	)
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO
/****** Object:  StoredProcedure [dbo].[Familia_Familia_Select]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Familia_Familia_Select]
	@IdFamilia varchar (36) , 
	@IdFamiliaHijo varchar (36) 
AS
	SELECT 
		[IdFamilia], 
		[IdFamiliaHijo]
	FROM Familia_Familia
	WHERE 
		[IdFamilia]=@IdFamilia AND 
		[IdFamiliaHijo]=@IdFamiliaHijo
GO
/****** Object:  StoredProcedure [dbo].[Familia_Familia_SelectAll]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Familia_Familia_SelectAll]
AS
	SELECT 
		[IdFamilia], 
		[IdFamiliaHijo]
	FROM Familia_Familia
GO
/****** Object:  StoredProcedure [dbo].[Familia_Familia_SelectParticular]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Familia_Familia_SelectParticular]
	@IdFamilia varchar(36)
AS
	SELECT 
		[IdFamilia], 
		[IdFamiliaHijo]
	FROM Familia_Familia
	WHERE 
		[IdFamilia]=@IdFamilia
GO
/****** Object:  StoredProcedure [dbo].[Familia_Insert]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Familia_Insert]
	@IdFamilia varchar(36), 
	@Nombre varchar(1000)
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	INSERT INTO Familia (
		[IdFamilia], 
		[Nombre]
	) VALUES (
		@IdFamilia, 
		@Nombre
	)
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO
/****** Object:  StoredProcedure [dbo].[Familia_Patente_Delete]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Familia_Patente_Delete]
	@IdFamilia varchar (36) 
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	DELETE FROM Familia_Patente
	WHERE 
		IdFamilia=@IdFamilia
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO
/****** Object:  StoredProcedure [dbo].[Familia_Patente_Insert]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Familia_Patente_Insert]
	@IdFamilia varchar(36), 
	@IdPatente varchar(36)
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	INSERT INTO Familia_Patente (
		[IdFamilia], 
		[IdPatente]
	) VALUES (
		@IdFamilia, 
		@IdPatente
	)
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO
/****** Object:  StoredProcedure [dbo].[Familia_Patente_Select]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Familia_Patente_Select]
	@IdFamilia varchar (36) 
AS
	SELECT 
		[IdFamilia], 
		[IdPatente]
	FROM Familia_Patente
	WHERE 
		[IdFamilia]=@IdFamilia
GO
/****** Object:  StoredProcedure [dbo].[Familia_Patente_SelectAll]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Familia_Patente_SelectAll]
AS
	SELECT 
		[IdFamilia], 
		[IdPatente]
	FROM Familia_Patente
GO
/****** Object:  StoredProcedure [dbo].[Familia_Select]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Familia_Select]
	@IdFamilia varchar (36) 
AS
	SELECT 
		[IdFamilia], 
		[Nombre]
	FROM Familia
	WHERE 
		IdFamilia=@IdFamilia
GO
/****** Object:  StoredProcedure [dbo].[Familia_SelectAll]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Familia_SelectAll]
AS
	SELECT 
		[IdFamilia], 
		[Nombre]
	FROM Familia
GO
/****** Object:  StoredProcedure [dbo].[Familia_Update]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Familia_Update]
	@IdFamilia varchar(36), 
	@Nombre varchar(1000)
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	UPDATE Familia SET 
		[Nombre]=@Nombre
	WHERE
		IdFamilia=@IdFamilia
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO
/****** Object:  StoredProcedure [dbo].[Patente_Delete]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Patente_Delete]
	@IdFamilia varchar (36) 
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	DELETE FROM Patente
	WHERE 
		IdPatente=@IdFamilia
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO
/****** Object:  StoredProcedure [dbo].[Patente_Insert]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Patente_Insert]
	@IdPatente varchar(36), 
	@Nombre varchar(1000)
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	INSERT INTO Patente (
		[IdPatente], 
		[Nombre]
	) VALUES (
		@IdPatente, 
		@Nombre
	)
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO
/****** Object:  StoredProcedure [dbo].[Patente_Select]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Patente_Select]
	@IdPatente varchar (36) 
AS
	SELECT 
		[IdPatente], 
		[Nombre]
	FROM Patente
	WHERE 
		IdPatente=@IdPatente
GO
/****** Object:  StoredProcedure [dbo].[Patente_SelectAll]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Patente_SelectAll]
AS
	SELECT 
		[IdPatente], 
		[Nombre]
	FROM Patente
GO
/****** Object:  StoredProcedure [dbo].[Patente_Update]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Patente_Update]
	@IdPatente varchar(36), 
	@Nombre varchar(1000)
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	UPDATE Patente SET 
		[Nombre]=@Nombre
	WHERE
		IdPatente=@IdPatente
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Delete]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Delete]
	@IdUsuario varchar (36) 
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	DELETE FROM Usuario
	WHERE 
		IdUsuario=@IdUsuario
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Familia_Delete]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Familia_Delete]
	@IdUsuario varchar (36) , 
	@IdFamilia varchar (36) 
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	DELETE FROM Usuario_Familia
	WHERE 
		IdUsuario=@IdUsuario AND 
		IdFamilia=@IdFamilia
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Familia_DeleteParticular]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Familia_DeleteParticular]
	@IdUsuario varchar (36)
AS
	DELETE FROM Usuario_Familia
	WHERE 
		IdUsuario=@IdUsuario
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Familia_Insert]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Familia_Insert]
	@IdUsuario varchar(36), 
	@IdFamilia varchar(36)
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	INSERT INTO Usuario_Familia (
		IdUsuario, 
		IdFamilia
	) VALUES (
		@IdUsuario, 
		@IdFamilia
	)
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Familia_Select]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Familia_Select]
	@IdUsuario varchar (36) , 
	@IdFamilia varchar (36) 
AS
	SELECT 
		IdUsuario, 
		IdFamilia
	FROM Usuario_Familia
	WHERE 
		IdUsuario=@IdUsuario AND 
		IdFamilia=@IdFamilia
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Familia_SelectAll]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Familia_SelectAll]
AS
	SELECT 
		[IdUsuario], 
		[IdFamilia]
	FROM Usuario_Familia
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Familia_SelectParticular]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Familia_SelectParticular]
	@IdUsuario varchar (36)
AS
	SELECT 
		IdUsuario, 
		IdFamilia
	FROM Usuario_familia
	WHERE 
		IdUsuario=@IdUsuario
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Insert]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Insert]
	@IdUsuario varchar(36), 
	@Nombre varchar(1000)
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	INSERT INTO Usuario (
		[IdUsuario], 
		[Nombre]
	) VALUES (
		@IdUsuario, 
		@Nombre
	)
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Patente_DeleteParticular]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Patente_DeleteParticular]
	@IdUsuario varchar (36)
AS
	DELETE FROM Usuario_Familia
	WHERE 
		IdUsuario=@IdUsuario
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Patente_Insert]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Patente_Insert]
	@IdUsuario varchar(36), 
	@IdPatente varchar(36)
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	INSERT INTO Usuario_Patente (
		IdUsuario, 
		IdPatente
	) VALUES (
		@IdUsuario, 
		@IdPatente
	)
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Patente_SelectParticular]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Patente_SelectParticular]
	@IdUsuario varchar (36)
AS
	SELECT 
		IdUsuario, 
		IdPatente
	FROM Usuario_Patente
	WHERE 
		IdUsuario=@IdUsuario
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Select]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Select]
	@IdUsuario varchar (36) 
AS
	SELECT 
		[IdUsuario], 
		[Nombre]
	FROM Usuario
	WHERE 
		IdUsuario=@IdUsuario
GO
/****** Object:  StoredProcedure [dbo].[Usuario_SelectAll]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_SelectAll]
AS
	SELECT 
		[IdUsuario], 
		[Nombre]
	FROM Usuario
GO
/****** Object:  StoredProcedure [dbo].[Usuario_Update]    Script Date: 03/09/2021 19:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Update]
	@IdUsuario varchar(36), 
	@Nombre varchar(1000)
AS
BEGIN
	SET NOCOUNT ON
	BEGIN TRY
	UPDATE Usuario SET 
		[Nombre]=@Nombre
	WHERE
		IdUsuario=@IdUsuario
	END TRY

	BEGIN CATCH
		EXEC RethrowError;
	END CATCH
	SET NOCOUNT OFF
END
GO
