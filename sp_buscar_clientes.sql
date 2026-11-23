/* ==========================================================
   Procedimiento almacenado que usan los 5 proyectos WPF (botón 3).
   Ejecutar UNA vez en SQL Server Management Studio o DBeaver.
   ========================================================== */
USE tecnohogar;
GO

-- CREATE OR ALTER: lo crea si no existe y lo reemplaza si ya existe (SQL Server 2016 SP1 o superior).
CREATE OR ALTER PROCEDURE dbo.sp_buscar_clientes
    @texto NVARCHAR(50)          -- parámetro de entrada: parte del nombre o apellido a buscar
AS
BEGIN
    SET NOCOUNT ON;              -- no enviar el mensaje "(n filas afectadas)"

    SELECT id_cliente, nombres, apellidos, telefono, email
    FROM dbo.clientes
    WHERE activo = 1
      AND (nombres LIKE '%' + @texto + '%' OR apellidos LIKE '%' + @texto + '%')
    ORDER BY apellidos, nombres;
END
GO

-- Prueba desde SQL Server: debe devolver 5 clientes.
EXEC dbo.sp_buscar_clientes @texto = N'Rojas';
