CREATE TABLE clientes (
    ClienteID INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Apellido_paterno VARCHAR(100) NOT NULL,
    Apellido_materno VARCHAR(100) NOT NULL,
    NumeroCelular VARCHAR(15),
    Altura DECIMAL(2, 1),
    INDEX(NumeroCelular),
    INDEX(Nombre, Apellido_paterno, Apellido_materno)
);

CREATE TABLE servicio (
    ServicioID INT AUTO_INCREMENT PRIMARY KEY,
    NombreServicio VARCHAR(100) NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL
);

-- Crear Tabla Cita
CREATE TABLE citas (
    CitaID INT AUTO_INCREMENT PRIMARY KEY,
    ClienteID INT,
    FechaAgendada varchar(10) NOT NULL,
    HoraAgendada varchar(6) NOT NULL,
    ServicioID INT,
    Pago double,
    EstadoCita ENUM('Pendiente', 'Realizada', 'Cancelada', 'Vencida', 'Eliminada') DEFAULT 'Pendiente',
    FOREIGN KEY (ClienteID) REFERENCES clientes(ClienteID) ON DELETE CASCADE,
    FOREIGN KEY (ServicioID) REFERENCES servicio(ServicioID),
    INDEX(FechaAgendada),
    INDEX(ServicioID)
);

DELIMITER //
CREATE PROCEDURE InsertarDatos_AgendarCitas(
    IN p_nombre VARCHAR(100),
    IN p_apellidoP VARCHAR(100),
    IN p_apellidoM VARCHAR(100),
    IN p_telefono VARCHAR(15),
    IN p_altura DECIMAL(5,2),
    IN p_fecha_cita varchar(10),
    IN p_Hora_cita varchar(6),
    IN p_servicio_id INT,
    IN Pago double
)
BEGIN
    DECLARE v_cliente_id INT;
    DECLARE v_cita_id INT;

    -- Insertar el cliente y obtener el ClienteID generado
    INSERT INTO clientes (Nombre, Apellido_paterno, Apellido_materno, NumeroCelular, Altura)
    VALUES (p_nombre, p_apellidoP, p_apellidoM, p_telefono, p_altura);

    SET v_cliente_id = LAST_INSERT_ID();

    -- Insertar la cita y obtener el CitaID generado
    INSERT INTO citas (ClienteID, FechaAgendada, HoraAgendada, ServicioID, Pago)
    VALUES (v_cliente_id, p_fecha_cita, p_Hora_cita, p_servicio_id, Pago);

    SET v_cita_id = LAST_INSERT_ID();
    
END //
DELIMITER $$

CREATE PROCEDURE Citasrepetidas(
    IN fecha varchar(10),
    IN hora varchar(6),
    OUT totalCitas INT
)
BEGIN
    SELECT COUNT(*)
    INTO totalCitas
    FROM Citas
    WHERE FechaAgendada = fecha
    AND HoraAgendada = hora;
END $$

DELIMITER ;

CREATE VIEW View_Todascitas AS
SELECT 
    c.CitaID, 
    CONCAT(cl.Nombre, ' ', cl.Apellido_paterno, ' ', cl.Apellido_materno) AS NombreCompletoCliente,
    c.FechaAgendada, 
    c.HoraAgendada, 
    c.ServicioID, 
    c.Pago, 
    c.EstadoCita
FROM citas c
JOIN clientes cl ON c.ClienteID = cl.ClienteID
WHERE c.EstadoCita <> 'Eliminada'; -- Excluye las citas con estado 'Eliminado'



 DELIMITER $$

CREATE PROCEDURE actualizar_estado_citas()
BEGIN
    -- Actualizar el estado de las citas directamente
    UPDATE citas
    SET EstadoCita = 'Vencida'
    WHERE EstadoCita = 'Pendiente'
    AND STR_TO_DATE(CONCAT(SUBSTR(FechaAgendada, 7, 4), '-', SUBSTR(FechaAgendada, 4, 2), '-', SUBSTR(FechaAgendada, 1, 2), ' ', HoraAgendada), '%Y-%m-%d %H:%i') < NOW();
END $$

DELIMITER ;

CREATE VIEW View_CitasHoy AS
SELECT 
    c.CitaID, 
    CONCAT(cl.Nombre, ' ', cl.Apellido_paterno, ' ', cl.Apellido_materno) AS NombreCompletoCliente,
    c.FechaAgendada, 
    c.HoraAgendada, 
    c.ServicioID, 
    c.Pago, 
    c.EstadoCita
FROM citas c
JOIN clientes cl ON c.ClienteID = cl.ClienteID
WHERE c.FechaAgendada = CURDATE() -- Filtra las citas del día de hoy
  AND STR_TO_DATE(CONCAT(c.FechaAgendada, ' ', c.HoraAgendada), '%Y-%m-%d %H:%i:%s') >= NOW() -- Filtra las citas que no se han pasado
  AND c.EstadoCita <> 'Eliminada'; -- Excluye las citas con estado 'Eliminado'



CREATE VIEW View_CitasPendientes AS
SELECT 
    c.CitaID, 
    CONCAT(cl.Nombre, ' ', cl.Apellido_paterno, ' ', cl.Apellido_materno) AS NombreCompletoCliente,
    c.FechaAgendada, 
    c.HoraAgendada, 
    c.ServicioID, 
    c.Pago, 
    c.EstadoCita
FROM citas c
JOIN clientes cl ON c.ClienteID = cl.ClienteID
WHERE c.EstadoCita = 'Pendiente';


CREATE VIEW view_citasvencidas AS
SELECT 
    c.CitaID, 
    CONCAT(cl.Nombre, ' ', cl.Apellido_paterno, ' ', cl.Apellido_materno) AS NombreCompletoCliente,
    c.FechaAgendada, 
    c.HoraAgendada, 
    c.ServicioID, 
    c.Pago, 
    c.EstadoCita
FROM citas c
JOIN clientes cl ON c.ClienteID = cl.ClienteID
WHERE c.EstadoCita = 'Vencida';



DELIMITER $$

CREATE PROCEDURE Eliminarcliente(
    IN p_CitaID INT
)
BEGIN
    -- Actualizar el estado de la cita especificada a 'Eliminado'
    UPDATE citas
    SET EstadoCita = 'Eliminada'
    WHERE CitaID = p_CitaID;
END $$


DELIMITER ;

DELIMITER //

CREATE PROCEDURE MostrarCitasPorCliente(IN cliente_id INT)
BEGIN
    SELECT FechaAgendada, HoraAgendada
    FROM citas
    WHERE ClienteID = cliente_id;
END //

DELIMITER ;

# ------------------------------------------------------------------------------------------------------------------------------------------------------------------

select * from clientes;
select * from citas;
select * from servicio;
CALL actualizar_estado_citas;
SELECT * FROM View_Todascitas;
SELECT * FROM view_citashoy;
select * from view_citaspendientes;

CALL Eliminarcliente(1);

SET SQL_SAFE_UPDATES = 0;
CALL actualizar_estado_citas();
SET SQL_SAFE_UPDATES = 1;