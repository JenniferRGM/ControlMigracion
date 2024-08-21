USE MIGRACION;
GO

-- Creación del trigger para validar la Fecha_Salida
CREATE TRIGGER trg_ValidarFechaSalida
ON SalidasViajes
FOR INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM Inserted i
        JOIN EntradasViajes e ON i.ID_Viajero = e.ID_Viajero
        WHERE i.Fecha_Salida < e.Fecha_Entrada
    )
    BEGIN
        RAISERROR ('Fecha de salida no puede ser anterior a la fecha de entrada.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
GO
