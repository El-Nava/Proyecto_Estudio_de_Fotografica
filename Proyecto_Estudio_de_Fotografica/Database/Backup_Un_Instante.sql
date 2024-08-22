-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: localhost    Database: un_instante
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
-- Table structure for table `cita`
--

DROP TABLE IF EXISTS `cita`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cita` (
  `CitaID` int NOT NULL AUTO_INCREMENT,
  `ClienteID` int DEFAULT NULL,
  `FechaAgendada` datetime NOT NULL,
  `ServicioID` int DEFAULT NULL,
  `EstadoCita` enum('Pendiente','Realizada','Cancelada') DEFAULT 'Pendiente',
  PRIMARY KEY (`CitaID`),
  KEY `ClienteID` (`ClienteID`),
  KEY `FechaAgendada` (`FechaAgendada`),
  KEY `ServicioID` (`ServicioID`),
  CONSTRAINT `cita_ibfk_1` FOREIGN KEY (`ClienteID`) REFERENCES `cliente` (`ClienteID`) ON DELETE CASCADE,
  CONSTRAINT `cita_ibfk_2` FOREIGN KEY (`ServicioID`) REFERENCES `servicio` (`ServicioID`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente` (
  `ClienteID` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(100) NOT NULL,
  `Apellido_paterno` varchar(100) NOT NULL,
  `Apellido_materno` varchar(100) NOT NULL,
  `NumeroCelular` varchar(15) DEFAULT NULL,
  `Altura` decimal(5,2) DEFAULT NULL,
  PRIMARY KEY (`ClienteID`),
  KEY `NumeroCelular` (`NumeroCelular`),
  KEY `Nombre` (`Nombre`,`Apellido_paterno`,`Apellido_materno`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `contabilidad_anual`
--

DROP TABLE IF EXISTS `contabilidad_anual`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `contabilidad_anual` (
  `Anio` int NOT NULL,
  `IngresosTotales` decimal(15,2) NOT NULL DEFAULT '0.00',
  `GastosTotales` decimal(15,2) NOT NULL DEFAULT '0.00',
  PRIMARY KEY (`Anio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `contabilidad_diaria`
--

DROP TABLE IF EXISTS `contabilidad_diaria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `contabilidad_diaria` (
  `Dia` date NOT NULL,
  `IngresosTotales` decimal(15,2) NOT NULL DEFAULT '0.00',
  `GastosTotales` decimal(15,2) NOT NULL DEFAULT '0.00',
  PRIMARY KEY (`Dia`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `contabilidad_mensual`
--

DROP TABLE IF EXISTS `contabilidad_mensual`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `contabilidad_mensual` (
  `Mes` varchar(7) NOT NULL,
  `IngresosTotales` decimal(15,2) NOT NULL DEFAULT '0.00',
  `GastosTotales` decimal(15,2) NOT NULL DEFAULT '0.00',
  PRIMARY KEY (`Mes`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `pago`
--

DROP TABLE IF EXISTS `pago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pago` (
  `PagoID` int NOT NULL AUTO_INCREMENT,
  `CitaID` int DEFAULT NULL,
  `Monto` decimal(10,2) NOT NULL,
  `FechaPago` datetime NOT NULL,
  `MetodoPago` enum('Efectivo','Tarjeta','Transferencia') NOT NULL,
  PRIMARY KEY (`PagoID`),
  KEY `CitaID` (`CitaID`),
  KEY `FechaPago` (`FechaPago`),
  CONSTRAINT `pago_ibfk_1` FOREIGN KEY (`CitaID`) REFERENCES `cita` (`CitaID`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `after_pago_insert` AFTER INSERT ON `pago` FOR EACH ROW BEGIN
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
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `after_pago_delete` AFTER DELETE ON `pago` FOR EACH ROW BEGIN
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
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

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
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Temporary view structure for view `view_citas_pendientes`
--

DROP TABLE IF EXISTS `view_citas_pendientes`;
/*!50001 DROP VIEW IF EXISTS `view_citas_pendientes`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_citas_pendientes` AS SELECT 
 1 AS `CitaID`,
 1 AS `Nombre`,
 1 AS `Apellido_paterno`,
 1 AS `Apellido_materno`,
 1 AS `FechaAgendada`,
 1 AS `NombreServicio`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `view_citas_vencidas`
--

DROP TABLE IF EXISTS `view_citas_vencidas`;
/*!50001 DROP VIEW IF EXISTS `view_citas_vencidas`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_citas_vencidas` AS SELECT 
 1 AS `CitaID`,
 1 AS `Nombre`,
 1 AS `Apellido_paterno`,
 1 AS `Apellido_materno`,
 1 AS `FechaAgendada`,
 1 AS `NombreServicio`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `view_clientes_deben`
--

DROP TABLE IF EXISTS `view_clientes_deben`;
/*!50001 DROP VIEW IF EXISTS `view_clientes_deben`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_clientes_deben` AS SELECT 
 1 AS `ClienteID`,
 1 AS `Nombre`,
 1 AS `Apellido_paterno`,
 1 AS `Apellido_materno`,
 1 AS `DeudaTotal`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `view_nombre_telefono`
--

DROP TABLE IF EXISTS `view_nombre_telefono`;
/*!50001 DROP VIEW IF EXISTS `view_nombre_telefono`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view_nombre_telefono` AS SELECT 
 1 AS `ClienteID`,
 1 AS `NombreCompleto`,
 1 AS `NumeroCelular`*/;
SET character_set_client = @saved_cs_client;

--
-- Dumping events for database 'un_instante'
--

--
-- Dumping routines for database 'un_instante'
--
/*!50003 DROP PROCEDURE IF EXISTS `ADD_cita` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ADD_cita`(
    IN p_ClienteID INT,
    IN p_FechaAgendada DATETIME,
    IN p_ServicioID INT
)
BEGIN
    INSERT INTO cita (ClienteID, FechaAgendada, ServicioID)
    VALUES (p_ClienteID, p_FechaAgendada, p_ServicioID);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `add_clientecita` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `add_clientecita`(
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
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `consultar_contabilidad_anual` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultar_contabilidad_anual`(
    IN p_Anio INT
)
BEGIN
    SELECT * FROM contabilidad_anual WHERE Anio = p_Anio;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `consultar_contabilidad_diaria` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultar_contabilidad_diaria`(
    IN p_Dia DATE
)
BEGIN
    SELECT * FROM contabilidad_diaria WHERE Dia = p_Dia;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `consultar_contabilidad_mensual` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultar_contabilidad_mensual`(
    IN p_Mes VARCHAR(7)
)
BEGIN
    SELECT * FROM contabilidad_mensual WHERE Mes = p_Mes;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `view_citas_pendientes`
--

/*!50001 DROP VIEW IF EXISTS `view_citas_pendientes`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_citas_pendientes` AS select `ci`.`CitaID` AS `CitaID`,`c`.`Nombre` AS `Nombre`,`c`.`Apellido_paterno` AS `Apellido_paterno`,`c`.`Apellido_materno` AS `Apellido_materno`,`ci`.`FechaAgendada` AS `FechaAgendada`,`s`.`NombreServicio` AS `NombreServicio` from ((`cita` `ci` join `cliente` `c` on((`ci`.`ClienteID` = `c`.`ClienteID`))) join `servicio` `s` on((`ci`.`ServicioID` = `s`.`ServicioID`))) where ((`ci`.`EstadoCita` = 'Pendiente') and (`ci`.`FechaAgendada` >= now())) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view_citas_vencidas`
--

/*!50001 DROP VIEW IF EXISTS `view_citas_vencidas`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_citas_vencidas` AS select `ci`.`CitaID` AS `CitaID`,`c`.`Nombre` AS `Nombre`,`c`.`Apellido_paterno` AS `Apellido_paterno`,`c`.`Apellido_materno` AS `Apellido_materno`,`ci`.`FechaAgendada` AS `FechaAgendada`,`s`.`NombreServicio` AS `NombreServicio` from ((`cita` `ci` join `cliente` `c` on((`ci`.`ClienteID` = `c`.`ClienteID`))) join `servicio` `s` on((`ci`.`ServicioID` = `s`.`ServicioID`))) where ((`ci`.`EstadoCita` = 'Pendiente') and (`ci`.`FechaAgendada` < now())) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view_clientes_deben`
--

/*!50001 DROP VIEW IF EXISTS `view_clientes_deben`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_clientes_deben` AS select `c`.`ClienteID` AS `ClienteID`,`c`.`Nombre` AS `Nombre`,`c`.`Apellido_paterno` AS `Apellido_paterno`,`c`.`Apellido_materno` AS `Apellido_materno`,sum(`p`.`Monto`) AS `DeudaTotal` from (((`cliente` `c` join `cita` `ci` on((`c`.`ClienteID` = `ci`.`ClienteID`))) left join `pago` `p` on((`ci`.`CitaID` = `p`.`CitaID`))) left join `servicio` `s` on((`ci`.`ServicioID` = `s`.`ServicioID`))) group by `c`.`ClienteID` having (sum(`p`.`Monto`) < coalesce(sum(`s`.`Precio`),0)) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view_nombre_telefono`
--

/*!50001 DROP VIEW IF EXISTS `view_nombre_telefono`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view_nombre_telefono` AS select `cliente`.`ClienteID` AS `ClienteID`,concat(`cliente`.`Nombre`,' ',`cliente`.`Apellido_paterno`,' ',`cliente`.`Apellido_materno`) AS `NombreCompleto`,`cliente`.`NumeroCelular` AS `NumeroCelular` from `cliente` */;
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

-- Dump completed on 2024-08-21 14:44:50
