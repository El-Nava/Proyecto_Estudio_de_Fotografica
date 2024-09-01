## -------------------------------------------------------------------------------------------------
## ---------------------- CONSULTAS ----------------------------------------------------------------
## -------------------------------------------------------------------------------------------------
select * from citas;

select * from clientes;

select * from servicio;

SELECT * FROM view_ver_citas;

## Ver Todas las Citas
SELECT CitaID, ClienteID, FechaAgendada, HoraAgendada, ServicioID, Pago, EstadoCita FROM citas;



## -------------------------------------------------------------------------------------------------
## ---------------------- Pruebas de Inserción -----------------------------------------------------
## -------------------------------------------------------------------------------------------------

## -------------------------------------------------------------------------------------------------
## ---------------------- CREACIÓN DE LA LIST VIEW PARA CONSULTAS ----------------------------------
## -------------------------------------------------------------------------------------------------
## PARA VER TODAS LAS CITAS
CREATE VIEW view_Ver_Citas AS
SELECT 
    c.CitaID,
    cl.Nombre,
    cl.Apellido_paterno,
    cl.Apellido_materno,
    c.FechaAgendada,
    s.NombreServicio
FROM 
    citas c
JOIN 
    clientes cl ON c.ClienteID = cl.ClienteID
JOIN 
    servicio s ON c.ServicioID = s.ServicioID
    ;

## PARA VER CITAS DEL DÍA
CREATE OR REPLACE VIEW view_ver_citas_hoy AS
SELECT 
    c.CitaID,
    cl.Nombre,
    cl.Apellido_paterno,
    cl.Apellido_materno,
    c.FechaAgendada,
    c.HoraAgendada,
    s.NombreServicio,
    c.EstadoCita
FROM 
    citas c
JOIN 
    clientes cl ON c.ClienteID = cl.ClienteID
JOIN 
    servicio s ON c.ServicioID = s.ServicioID
WHERE 
    DATE(c.FechaAgendada) = CURDATE();

## PARA VER CITAS PENDIENTES
CREATE OR REPLACE VIEW view_ver_citas_pendientes AS
SELECT 
    c.CitaID,
    cl.Nombre,
    cl.Apellido_paterno,
    cl.Apellido_materno,
    c.FechaAgendada,
    c.HoraAgendada,
    s.NombreServicio,
    c.EstadoCita
FROM 
    citas c
JOIN 
    clientes cl ON c.ClienteID = cl.ClienteID
JOIN 
    servicio s ON c.ServicioID = s.ServicioID
WHERE 
    c.EstadoCita = 'Pendiente';

## PARA VER CITAS VENCIDAS
CREATE OR REPLACE VIEW view_ver_citas_vencidas AS
SELECT 
    c.CitaID,
    cl.Nombre,
    cl.Apellido_paterno,
    cl.Apellido_materno,
    c.FechaAgendada,
    c.HoraAgendada,
    s.NombreServicio,
    c.EstadoCita
FROM 
    citas c
JOIN 
    clientes cl ON c.ClienteID = cl.ClienteID
JOIN 
    servicio s ON c.ServicioID = s.ServicioID
WHERE 
    c.FechaAgendada < CURDATE() 
    AND c.EstadoCita != 'Completado';

## -------------------------------------------------------------------------------------------------