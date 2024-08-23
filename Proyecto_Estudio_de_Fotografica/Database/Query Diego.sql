-- Insertar Paquetes de Fotografias
INSERT INTO servicio (NombreServicio, Precio) 
    VALUES 
            ('Paquete 1', 1000.00),
            ('Paquete 2', 1200.00),
            ('Paquete 3', 1500.00);

-- Ver tabla de Servicios (Paquetes)
Select * from servicio;

-- Agrergar un Cliente y Cita a la Vez
CALL add_clientecita(
    'Pedro', 
    'Lozano', 
    'Gamez', 
    '555-1234', 
    1.75, 
    '2024-09-25 10:00:00', 
    1, 
    150.00, 
    '2024-09-25 10:30:00', 
    'Efectivo'
);

-- Ver Tabla de Pagos
select * from pago

-- Ver Lista de Clientes
select * from view_nombre_telefono;

-- Ver Tabla de Clientes
select * from cliente;

-- Ver Citas
select * from view_citas_pendientes