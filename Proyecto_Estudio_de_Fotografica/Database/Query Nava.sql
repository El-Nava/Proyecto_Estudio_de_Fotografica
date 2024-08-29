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
    EstadoCita ENUM('Pendiente', 'Realizada', 'Cancelada') DEFAULT 'Pendiente',
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

# ------------------------------------------------------------------------------------------------------------------------------------------------------------------

#select * from clientes;
#select * from citas;
select * from servicio;