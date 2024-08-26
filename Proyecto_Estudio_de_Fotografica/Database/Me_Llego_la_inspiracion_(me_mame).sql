-- Crear Tabla Cliente
CREATE TABLE cliente (
    ClienteID INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Apellido_paterno VARCHAR(100) NOT NULL,
    Apellido_materno VARCHAR(100) NOT NULL,
    NumeroCelular VARCHAR(15),
    Altura DECIMAL(5, 2),
    INDEX(NumeroCelular),
    INDEX(Nombre, Apellido_paterno, Apellido_materno)
);

-- Crear Tabla Servicio
CREATE TABLE servicio (
    ServicioID INT AUTO_INCREMENT PRIMARY KEY,
    NombreServicio VARCHAR(100) NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL
);

-- Crear Tabla Cita
CREATE TABLE cita (
    CitaID INT AUTO_INCREMENT PRIMARY KEY,
    ClienteID INT,
    FechaAgendada DATETIME NOT NULL,
    ServicioID INT,
    EstadoCita ENUM('Pendiente', 'Realizada', 'Cancelada') DEFAULT 'Pendiente',
    FOREIGN KEY (ClienteID) REFERENCES cliente(ClienteID) ON DELETE CASCADE,
    FOREIGN KEY (ServicioID) REFERENCES servicio(ServicioID),
    INDEX(FechaAgendada),
    INDEX(ServicioID)
);

-- Crear Tabla Pago
CREATE TABLE pago (
    PagoID INT AUTO_INCREMENT PRIMARY KEY,
    CitaID INT,
    Monto DECIMAL(10, 2) NOT NULL,
    FechaPago DATETIME NOT NULL,
    MetodoPago ENUM('Efectivo', 'Tarjeta', 'Transferencia') NOT NULL,
    FOREIGN KEY (CitaID) REFERENCES cita(CitaID) ON DELETE CASCADE,
    INDEX(FechaPago)
);

-- Crear Tabla ContabilidadDiaria
CREATE TABLE contabilidad_diaria (
    Dia DATE PRIMARY KEY,
    IngresosTotales DECIMAL(15, 2) NOT NULL DEFAULT 0,
    GastosTotales DECIMAL(15, 2) NOT NULL DEFAULT 0
);

-- Crear Tabla ContabilidadMensual
CREATE TABLE contabilidad_mensual (
    Mes VARCHAR(7) PRIMARY KEY, -- Formato 'YYYY-MM'
    IngresosTotales DECIMAL(15, 2) NOT NULL DEFAULT 0,
    GastosTotales DECIMAL(15, 2) NOT NULL DEFAULT 0
);

-- Crear Tabla ContabilidadAnual
CREATE TABLE contabilidad_anual (
    Anio INT PRIMARY KEY,
    IngresosTotales DECIMAL(15, 2) NOT NULL DEFAULT 0,
    GastosTotales DECIMAL(15, 2) NOT NULL DEFAULT 0
);

-- Definir delimitador para triggers
DELIMITER $$

-- Trigger para actualizar la contabilidad después de un pago insertado
CREATE TRIGGER after_pago_insert
AFTER INSERT ON pago
FOR EACH ROW
BEGIN
    -- Actualización de Contabilidad Diaria
    INSERT INTO contabilidad_diaria (Dia, IngresosTotales, GastosTotales)
    VALUES (DATE(NEW.FechaPago), NEW.Monto, 0)
    ON DUPLICATE KEY UPDATE IngresosTotales = IngresosTotales + NEW.Monto;

    -- Actualización de Contabilidad Mensual
    INSERT INTO contabilidad_mensual (Mes, IngresosTotales, GastosTotales)
    VALUES (DATE_FORMAT(NEW.FechaPago, '%Y-%m'), NEW.Monto, 0)
    ON DUPLICATE KEY UPDATE IngresosTotales = IngresosTotales + NEW.Monto;

    -- Actualización de Contabilidad Anual
    INSERT INTO contabilidad_anual (Anio, IngresosTotales, GastosTotales)
    VALUES (YEAR(NEW.FechaPago), NEW.Monto, 0)
    ON DUPLICATE KEY UPDATE IngresosTotales = IngresosTotales + NEW.Monto;
END $$

-- Trigger para actualizar la contabilidad después de un pago eliminado
CREATE TRIGGER after_pago_delete
AFTER DELETE ON pago
FOR EACH ROW
BEGIN
    -- Actualización de Contabilidad Diaria
    UPDATE contabilidad_diaria
    SET IngresosTotales = IngresosTotales - OLD.Monto
    WHERE Dia = DATE(OLD.FechaPago);

    -- Actualización de Contabilidad Mensual
    UPDATE contabilidad_mensual
    SET IngresosTotales = IngresosTotales - OLD.Monto
    WHERE Mes = DATE_FORMAT(OLD.FechaPago, '%Y-%m');

    -- Actualización de Contabilidad Anual
    UPDATE contabilidad_anual
    SET IngresosTotales = IngresosTotales - OLD.Monto
    WHERE Anio = YEAR(OLD.FechaPago);
END $$

-- Definir delimitador por defecto
DELIMITER ;

-- Crear Vista para clientes que deben
CREATE VIEW view_clientes_deben AS
SELECT c.ClienteID, c.Nombre, c.Apellido_paterno, c.Apellido_materno, SUM(p.Monto) AS DeudaTotal
FROM cliente c
JOIN cita ci ON c.ClienteID = ci.ClienteID
LEFT JOIN pago p ON ci.CitaID = p.CitaID
LEFT JOIN servicio s ON ci.ServicioID = s.ServicioID
GROUP BY c.ClienteID
HAVING SUM(p.Monto) < COALESCE(SUM(s.Precio), 0);

-- Crear Vista para citas pendientes
CREATE VIEW view_citas_pendientes AS
SELECT ci.CitaID, c.Nombre, c.Apellido_paterno, c.Apellido_materno, ci.FechaAgendada, s.NombreServicio
FROM cita ci
JOIN cliente c ON ci.ClienteID = c.ClienteID
JOIN servicio s ON ci.ServicioID = s.ServicioID
WHERE ci.EstadoCita = 'Pendiente' AND ci.FechaAgendada >= NOW();

-- Crear Vista para citas vencidas
CREATE VIEW view_citas_vencidas AS
SELECT ci.CitaID, c.Nombre, c.Apellido_paterno, c.Apellido_materno, ci.FechaAgendada, s.NombreServicio
FROM cita ci
JOIN cliente c ON ci.ClienteID = c.ClienteID
JOIN servicio s ON ci.ServicioID = s.ServicioID
WHERE ci.EstadoCita = 'Pendiente' AND ci.FechaAgendada < NOW();

-- Crear vista para mostrar el nombre completo y ClienteID
CREATE VIEW view_nombre_telefono AS
SELECT 
    ClienteID,
    CONCAT(Nombre, ' ', Apellido_paterno, ' ', Apellido_materno) AS NombreCompleto,
    NumeroCelular
FROM 
    cliente;

-- Definir delimitador para procedimientos
DELIMITER $$

-- Procedimiento para consultar la contabilidad diaria
CREATE PROCEDURE consultar_contabilidad_diaria (
    IN p_Dia DATE
)
BEGIN
    SELECT * FROM contabilidad_diaria WHERE Dia = p_Dia;
END $$

-- Procedimiento para consultar la contabilidad mensual
CREATE PROCEDURE consultar_contabilidad_mensual (
    IN p_Mes VARCHAR(7)
)
BEGIN
    SELECT * FROM contabilidad_mensual WHERE Mes = p_Mes;
END $$

-- Procedimiento para consultar la contabilidad anual
CREATE PROCEDURE consultar_contabilidad_anual (
    IN p_Anio INT
)
BEGIN
    SELECT * FROM contabilidad_anual WHERE Anio = p_Anio;
END $$

-- Definir delimitador por defecto
DELIMITER ;

-- Procedimiento para agregar un cliente y una cita, y registrar el pago
DELIMITER //
CREATE PROCEDURE add_clientecita(
    IN p_nombre VARCHAR(100),
    IN p_apellidoP VARCHAR(100),
    IN p_apellidoM VARCHAR(100),
    IN p_telefono VARCHAR(15),
    IN p_altura DECIMAL(5,2),
    IN p_fecha_cita DATETIME,
    IN p_servicio_id INT,
    IN p_monto DECIMAL(10,2),
    IN p_fecha_pago DATETIME,
    IN p_metodo_pago ENUM('Efectivo', 'Tarjeta', 'Transferencia')
)
BEGIN
    DECLARE v_cliente_id INT;
    DECLARE v_cita_id INT;

    -- Insertar el cliente y obtener el ClienteID generado
    INSERT INTO cliente (Nombre, Apellido_paterno, Apellido_materno, NumeroCelular, Altura)
    VALUES (p_nombre, p_apellidoP, p_apellidoM, p_telefono, p_altura);

    SET v_cliente_id = LAST_INSERT_ID();

    -- Insertar la cita y obtener el CitaID generado
    INSERT INTO cita (ClienteID, FechaAgendada, ServicioID)
    VALUES (v_cliente_id, p_fecha_cita, p_servicio_id);

    SET v_cita_id = LAST_INSERT_ID();

    -- Registrar el pago
    INSERT INTO pago (CitaID, Monto, FechaPago, MetodoPago)
    VALUES (v_cita_id, p_monto, p_fecha_pago, p_metodo_pago);

    -- El trigger de la tabla pago se encargará de actualizar la contabilidad automáticamente
END //

DELIMITER ;

DELIMITER //
CREATE PROCEDURE ADD_cita (
    IN p_ClienteID INT,
    IN p_FechaAgendada DATETIME,
    IN p_ServicioID INT
)
BEGIN
    INSERT INTO cita (ClienteID, FechaAgendada, ServicioID)
    VALUES (p_ClienteID, p_FechaAgendada, p_ServicioID);
END //

-- Insertar datos de ejemplo usando el procedimiento almacenado add_clientecita

INSERT INTO servicio (NombreServicio, Precio) 
	VALUES 
			('Paquete 1', 1000.00),
			('Paquete 2', 1200.00),
			('Paquete 3', 1500.00); 


-- Ejemplo 1
CALL add_clientecita(
    'Juan', 
    'Pérez', 
    'Gómez', 
    '555-1234', 
    1.75, 
    '2024-08-25 10:00:00', 
    1, 
    150.00, 
    '2024-08-25 10:30:00', 
    'Efectivo'
);

-- Ejemplo 2
CALL add_clientecita(
    'Ana', 
    'Rodríguez', 
    'Martínez', 
    '555-5678', 
    1.60, 
    '2024-08-26 14:00:00', 
    2, 
    200.00, 
    '2024-08-26 14:15:00', 
    'Tarjeta'
);

-- Ejemplo 3
CALL add_clientecita(
    'Carlos', 
    'López', 
    'Mendoza', 
    '555-8765', 
    1.85, 
    '2024-08-27 09:00:00', 
    3, 
    120.00, 
    '2024-08-27 09:30:00', 
    'Transferencia'
);

-- Ejemplo 4
CALL add_clientecita(
    'Laura', 
    'Hernández', 
    'Pérez', 
    '555-4321', 
    1.70, 
    '2024-08-28 16:00:00', 
    1, 
    150.00, 
    '2024-08-28 16:20:00', 
    'Efectivo'
);

-- Ejemplo 5
CALL add_clientecita(
    'José', 
    'García', 
    'Vázquez', 
    '555-6789', 
    1.78, 
    '2024-08-29 11:00:00', 
    2, 
    200.00, 
    '2024-08-29 11:45:00', 
    'Tarjeta'
);
-- Insertar citas usando el procedimiento almacenado agregar_citas
-- Ejemplo 1
CALL agregar_cita(
    1,               -- ClienteID
    '2024-08-25 10:00:00',  -- FechaAgendada
    1                -- ServicioID
);

-- Ejemplo 2
CALL agregar_cita(
    2,               -- ClienteID
    '2024-08-26 14:00:00',  -- FechaAgendada
    2                -- ServicioID
);

-- Ejemplo 3
CALL agregar_cita(
    3,               -- ClienteID
    '2024-08-27 09:00:00',  -- FechaAgendada
    3                -- ServicioID
);

-- Ejemplo 4
CALL agregar_cita(
    4,               -- ClienteID
    '2024-08-28 16:00:00',  -- FechaAgendada
    1                -- ServicioID
);

-- Ejemplo 5
CALL agregar_cita(
    5,               -- ClienteID
    '2024-08-29 11:00:00',  -- FechaAgendada
    2                -- ServicioID
);


select * from cliente;
select * from cita;
select * from view_nombre_telefono;