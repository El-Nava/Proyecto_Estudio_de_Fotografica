-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: localhost    Database: uninstante
-- ------------------------------------------------------
-- Server version	8.0.39

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `citas`
--

DROP TABLE IF EXISTS `citas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `citas` (
  `CitaID` int NOT NULL AUTO_INCREMENT,
  `ClienteID` int DEFAULT NULL,
  `FechaAgendada` varchar(10) NOT NULL,
  `HoraAgendada` varchar(6) NOT NULL,
  `ServicioID` int DEFAULT NULL,
  `Pago` double DEFAULT NULL,
  `EstadoCita` enum('Pendiente','Realizada','Cancelada','Vencida','Eliminada') DEFAULT 'Pendiente',
  PRIMARY KEY (`CitaID`),
  KEY `ClienteID` (`ClienteID`),
  KEY `FechaAgendada` (`FechaAgendada`),
  KEY `ServicioID` (`ServicioID`),
  CONSTRAINT `citas_ibfk_1` FOREIGN KEY (`ClienteID`) REFERENCES `clientes` (`ClienteID`) ON DELETE CASCADE,
  CONSTRAINT `citas_ibfk_2` FOREIGN KEY (`ServicioID`) REFERENCES `servicio` (`ServicioID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `citas`
--

LOCK TABLES `citas` WRITE;
/*!40000 ALTER TABLE `citas` DISABLE KEYS */;
INSERT INTO `citas` VALUES (1,8,'25/09/2024','19:43',2,500,'Pendiente');
/*!40000 ALTER TABLE `citas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clientes` (
  `ClienteID` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(100) NOT NULL,
  `Apellido_paterno` varchar(100) NOT NULL,
  `Apellido_materno` varchar(100) NOT NULL,
  `NumeroCelular` varchar(15) DEFAULT NULL,
  `Altura` decimal(2,1) DEFAULT NULL,
  PRIMARY KEY (`ClienteID`),
  KEY `NumeroCelular` (`NumeroCelular`),
  KEY `Nombre` (`Nombre`,`Apellido_paterno`,`Apellido_materno`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` VALUES (8,'Jesus','Nava','','12345',1.4);
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `servicio`
--

DROP TABLE IF EXISTS `servicio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `servicio` (
  `ServicioID` int NOT NULL AUTO_INCREMENT,
  `NombreServicio` varchar(100) NOT NULL,
  `Precio` decimal(10,2) NOT NULL,
  PRIMARY KEY (`ServicioID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `servicio`
--

LOCK TABLES `servicio` WRITE;
/*!40000 ALTER TABLE `servicio` DISABLE KEYS */;
INSERT INTO `servicio` VALUES (1,'Paquete 1',1000.00),(2,'Paquete 2',1200.00),(3,'Paquete 3',1500.00);
/*!40000 ALTER TABLE `servicio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `view_citashoy`
--

DROP TABLE IF EXISTS `view_citashoy`;
/*!50001 DROP VIEW IF EXISTS `view_citashoy`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_citashoy` AS SELECT 
 1 AS `CitaID`,
 1 AS `NombreCompletoCliente`,
 1 AS `FechaAgendada`,
 1 AS `HoraAgendada`,
 1 AS `ServicioID`,
 1 AS `Pago`,
 1 AS `EstadoCita`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `view_citaspendientes`
--

DROP TABLE IF EXISTS `view_citaspendientes`;
/*!50001 DROP VIEW IF EXISTS `view_citaspendientes`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_citaspendientes` AS SELECT 
 1 AS `CitaID`,
 1 AS `NombreCompletoCliente`,
 1 AS `FechaAgendada`,
 1 AS `HoraAgendada`,
 1 AS `ServicioID`,
 1 AS `Pago`,
 1 AS `EstadoCita`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `view_citasvencidas`
--

DROP TABLE IF EXISTS `view_citasvencidas`;
/*!50001 DROP VIEW IF EXISTS `view_citasvencidas`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_citasvencidas` AS SELECT 
 1 AS `CitaID`,
 1 AS `NombreCompletoCliente`,
 1 AS `FechaAgendada`,
 1 AS `HoraAgendada`,
 1 AS `ServicioID`,
 1 AS `Pago`,
 1 AS `EstadoCita`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `view_todascitas`
--

DROP TABLE IF EXISTS `view_todascitas`;
/*!50001 DROP VIEW IF EXISTS `view_todascitas`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_todascitas` AS SELECT 
 1 AS `CitaID`,
 1 AS `NombreCompletoCliente`,
 1 AS `FechaAgendada`,
 1 AS `HoraAgendada`,
 1 AS `ServicioID`,
 1 AS `Pago`,
 1 AS `EstadoCita`*/;
SET character_set_client = @saved_cs_client;

--
-- Dumping events for database 'uninstante'
--

--
-- Dumping routines for database 'uninstante'
--
/*!50003 DROP PROCEDURE IF EXISTS `actualizar_estado_citas` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `actualizar_estado_citas`()
BEGIN
    -- Actualizar el estado de las citas directamente
    UPDATE citas
    SET EstadoCita = 'Vencida'
    WHERE EstadoCita = 'Pendiente'
    AND STR_TO_DATE(CONCAT(SUBSTR(FechaAgendada, 7, 4), '-', SUBSTR(FechaAgendada, 4, 2), '-', SUBSTR(FechaAgendada, 1, 2), ' ', HoraAgendada), '%Y-%m-%d %H:%i') < NOW();
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Citasrepetidas` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Citasrepetidas`(
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
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Eliminarcliente` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Eliminarcliente`(
    IN p_CitaID INT
)
BEGIN
    -- Actualizar el estado de la cita especificada a 'Eliminado'
    UPDATE citas
    SET EstadoCita = 'Eliminada'
    WHERE CitaID = p_CitaID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `InsertarDatos_AgendarCitas` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarDatos_AgendarCitas`(
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
    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `MostrarCitasPorCliente` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `MostrarCitasPorCliente`(IN cliente_id INT)
BEGIN
    SELECT FechaAgendada, HoraAgendada
    FROM citas
    WHERE ClienteID = cliente_id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `view_citashoy`
--

/*!50001 DROP VIEW IF EXISTS `view_citashoy`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_citashoy` AS select `c`.`CitaID` AS `CitaID`,concat(`cl`.`Nombre`,' ',`cl`.`Apellido_paterno`,' ',`cl`.`Apellido_materno`) AS `NombreCompletoCliente`,`c`.`FechaAgendada` AS `FechaAgendada`,`c`.`HoraAgendada` AS `HoraAgendada`,`c`.`ServicioID` AS `ServicioID`,`c`.`Pago` AS `Pago`,`c`.`EstadoCita` AS `EstadoCita` from (`citas` `c` join `clientes` `cl` on((`c`.`ClienteID` = `cl`.`ClienteID`))) where ((`c`.`FechaAgendada` = curdate()) and (str_to_date(concat(`c`.`FechaAgendada`,' ',`c`.`HoraAgendada`),'%Y-%m-%d %H:%i:%s') >= now()) and (`c`.`EstadoCita` <> 'Eliminada')) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view_citaspendientes`
--

/*!50001 DROP VIEW IF EXISTS `view_citaspendientes`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_citaspendientes` AS select `c`.`CitaID` AS `CitaID`,concat(`cl`.`Nombre`,' ',`cl`.`Apellido_paterno`,' ',`cl`.`Apellido_materno`) AS `NombreCompletoCliente`,`c`.`FechaAgendada` AS `FechaAgendada`,`c`.`HoraAgendada` AS `HoraAgendada`,`c`.`ServicioID` AS `ServicioID`,`c`.`Pago` AS `Pago`,`c`.`EstadoCita` AS `EstadoCita` from (`citas` `c` join `clientes` `cl` on((`c`.`ClienteID` = `cl`.`ClienteID`))) where (`c`.`EstadoCita` = 'Pendiente') */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view_citasvencidas`
--

/*!50001 DROP VIEW IF EXISTS `view_citasvencidas`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_citasvencidas` AS select `c`.`CitaID` AS `CitaID`,concat(`cl`.`Nombre`,' ',`cl`.`Apellido_paterno`,' ',`cl`.`Apellido_materno`) AS `NombreCompletoCliente`,`c`.`FechaAgendada` AS `FechaAgendada`,`c`.`HoraAgendada` AS `HoraAgendada`,`c`.`ServicioID` AS `ServicioID`,`c`.`Pago` AS `Pago`,`c`.`EstadoCita` AS `EstadoCita` from (`citas` `c` join `clientes` `cl` on((`c`.`ClienteID` = `cl`.`ClienteID`))) where (`c`.`EstadoCita` = 'Vencida') */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view_todascitas`
--

/*!50001 DROP VIEW IF EXISTS `view_todascitas`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_todascitas` AS select `c`.`CitaID` AS `CitaID`,concat(`cl`.`Nombre`,' ',`cl`.`Apellido_paterno`,' ',`cl`.`Apellido_materno`) AS `NombreCompletoCliente`,`c`.`FechaAgendada` AS `FechaAgendada`,`c`.`HoraAgendada` AS `HoraAgendada`,`c`.`ServicioID` AS `ServicioID`,`c`.`Pago` AS `Pago`,`c`.`EstadoCita` AS `EstadoCita` from (`citas` `c` join `clientes` `cl` on((`c`.`ClienteID` = `cl`.`ClienteID`))) where (`c`.`EstadoCita` <> 'Eliminada') */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-09-04 23:07:24
