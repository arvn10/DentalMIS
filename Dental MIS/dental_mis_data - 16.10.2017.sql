CREATE DATABASE  IF NOT EXISTS `dental_mis` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `dental_mis`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: dental_mis
-- ------------------------------------------------------
-- Server version	5.7.19-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `doctor`
--

DROP TABLE IF EXISTS `doctor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `doctor` (
  `id` bigint(8) NOT NULL,
  `firstname` varchar(45) DEFAULT NULL,
  `lastname` varchar(45) DEFAULT NULL,
  `middle_initial` varchar(45) DEFAULT NULL,
  `status` tinyint(4) DEFAULT NULL,
  `created_by` varchar(45) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `updated_by` varchar(45) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `doctor`
--

LOCK TABLES `doctor` WRITE;
/*!40000 ALTER TABLE `doctor` DISABLE KEYS */;
/*!40000 ALTER TABLE `doctor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patient`
--

DROP TABLE IF EXISTS `patient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `patient` (
  `id` bigint(8) NOT NULL,
  `patient_marital_status_id` bigint(8) NOT NULL,
  `firstname` varchar(45) DEFAULT NULL,
  `lastname` varchar(45) DEFAULT NULL,
  `middle_initial` varchar(45) DEFAULT NULL,
  `address` text,
  `age` int(11) DEFAULT NULL,
  `gender` varchar(45) DEFAULT NULL,
  `occupation` text,
  `created_by` varchar(45) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `updated_by` varchar(45) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patient`
--

LOCK TABLES `patient` WRITE;
/*!40000 ALTER TABLE `patient` DISABLE KEYS */;
/*!40000 ALTER TABLE `patient` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patient_marital_status`
--

DROP TABLE IF EXISTS `patient_marital_status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `patient_marital_status` (
  `id` bigint(8) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `status` tinyint(4) DEFAULT NULL,
  `created_by` varchar(45) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `updated_by` varchar(45) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patient_marital_status`
--

LOCK TABLES `patient_marital_status` WRITE;
/*!40000 ALTER TABLE `patient_marital_status` DISABLE KEYS */;
INSERT INTO `patient_marital_status` VALUES (1,'Single',1,'Test User','2017-09-22 15:20:16',NULL,NULL),(2,'Married',1,'','2017-09-22 15:20:34','Service Account','2017-09-24 15:51:26'),(3,'test',0,'Service Account','2017-10-05 21:00:43',NULL,NULL);
/*!40000 ALTER TABLE `patient_marital_status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payment`
--

DROP TABLE IF EXISTS `payment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `payment` (
  `id` bigint(8) NOT NULL AUTO_INCREMENT,
  `procedure_id` bigint(8) NOT NULL,
  `amount_to_pay` float DEFAULT NULL,
  `date` date DEFAULT NULL,
  `status` varchar(45) DEFAULT NULL,
  `created_by` varchar(45) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `updated_by` varchar(45) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payment`
--

LOCK TABLES `payment` WRITE;
/*!40000 ALTER TABLE `payment` DISABLE KEYS */;
/*!40000 ALTER TABLE `payment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payment_breakdown`
--

DROP TABLE IF EXISTS `payment_breakdown`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `payment_breakdown` (
  `id` bigint(8) NOT NULL,
  `payment_id` bigint(8) DEFAULT NULL,
  `amount_paid` float DEFAULT NULL,
  `amount_balance` float DEFAULT NULL,
  `date` date DEFAULT NULL,
  `created_by` varchar(45) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `updated_by` varchar(45) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payment_breakdown`
--

LOCK TABLES `payment_breakdown` WRITE;
/*!40000 ALTER TABLE `payment_breakdown` DISABLE KEYS */;
/*!40000 ALTER TABLE `payment_breakdown` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `procedure`
--

DROP TABLE IF EXISTS `procedure`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `procedure` (
  `id` bigint(8) NOT NULL AUTO_INCREMENT,
  `patient_id` bigint(8) NOT NULL,
  `procedure_type_id` bigint(8) NOT NULL,
  `doctor_id` bigint(8) NOT NULL,
  `notes` varchar(255) DEFAULT NULL,
  `prescription` varchar(255) DEFAULT NULL,
  `date` date DEFAULT NULL,
  `status` varchar(45) DEFAULT NULL,
  `created_by` varchar(45) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `updated_by` varchar(45) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `procedure`
--

LOCK TABLES `procedure` WRITE;
/*!40000 ALTER TABLE `procedure` DISABLE KEYS */;
/*!40000 ALTER TABLE `procedure` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `procedure_tooth`
--

DROP TABLE IF EXISTS `procedure_tooth`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `procedure_tooth` (
  `id` bigint(8) NOT NULL AUTO_INCREMENT,
  `procedure_id` bigint(8) NOT NULL,
  `tooth_number` varchar(45) DEFAULT NULL,
  `created_by` varchar(45) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `updated_by` varchar(45) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `procedure_tooth`
--

LOCK TABLES `procedure_tooth` WRITE;
/*!40000 ALTER TABLE `procedure_tooth` DISABLE KEYS */;
/*!40000 ALTER TABLE `procedure_tooth` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `procedure_type`
--

DROP TABLE IF EXISTS `procedure_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `procedure_type` (
  `id` bigint(8) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) DEFAULT NULL,
  `base_price` float DEFAULT NULL,
  `payment_type` varchar(45) DEFAULT NULL,
  `require_med_cert` tinyint(4) DEFAULT NULL,
  `status` tinyint(4) DEFAULT NULL,
  `created_by` varchar(45) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `updated_by` varchar(45) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `procedure_type`
--

LOCK TABLES `procedure_type` WRITE;
/*!40000 ALTER TABLE `procedure_type` DISABLE KEYS */;
INSERT INTO `procedure_type` VALUES (1,'Extraction',550,'Full Payment',1,1,'Test User','2017-09-10 22:01:12','Service Account','2017-09-24 15:53:21'),(2,'Pasta',500,'Full Payment',0,1,'Service Account','2017-09-24 12:42:52',NULL,NULL),(3,'test123',123,'Full Payment',1,1,'Service Account','2017-09-24 13:06:19','Main Menu','2017-10-13 00:06:06'),(4,'Extraction1',550,'Full Payment',1,1,'Service Account','2017-10-05 20:41:05',NULL,NULL),(5,'Extraction444',550,'Full Payment',1,1,'Service Account','2017-10-05 20:50:47','Main Menu','2017-10-13 00:01:56'),(6,'Test2',123,'Full Payment',1,1,'Service Account','2017-10-05 20:52:04','Main Menu','2017-10-13 00:05:30'),(7,'test3',111,'Full Payment',1,1,'Service Account','2017-10-05 20:53:01',NULL,NULL),(8,'Extraction1',550,'Full Payment',1,1,'Main Menu','2017-10-12 23:58:05','Main Menu','2017-10-12 23:58:24');
/*!40000 ALTER TABLE `procedure_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `schedule`
--

DROP TABLE IF EXISTS `schedule`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `schedule` (
  `id` bigint(8) NOT NULL AUTO_INCREMENT,
  `patient_id` bigint(8) DEFAULT NULL,
  `doctor_id` bigint(8) NOT NULL,
  `date` date DEFAULT NULL,
  `created_by` varchar(45) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `updated_by` varchar(45) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `schedule`
--

LOCK TABLES `schedule` WRITE;
/*!40000 ALTER TABLE `schedule` DISABLE KEYS */;
/*!40000 ALTER TABLE `schedule` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user` (
  `id` bigint(8) NOT NULL AUTO_INCREMENT,
  `user_type_id` bigint(8) NOT NULL,
  `username` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `firstname` varchar(45) DEFAULT NULL,
  `lastname` varchar(45) DEFAULT NULL,
  `status` tinyint(4) DEFAULT NULL,
  `created_by` varchar(45) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `updated_by` varchar(45) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,1,'admina','password','Super','Admin',1,'Super Admin','2017-05-10 09:11:00','Super Admin','2017-10-15 00:58:58'),(2,1,'TestUser','password','Test','User',1,'Super Admin','2017-10-05 21:15:28',NULL,NULL);
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_type`
--

DROP TABLE IF EXISTS `user_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user_type` (
  `id` bigint(8) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) DEFAULT NULL,
  `created_by` varchar(45) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `updated_by` varchar(45) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_type`
--

LOCK TABLES `user_type` WRITE;
/*!40000 ALTER TABLE `user_type` DISABLE KEYS */;
INSERT INTO `user_type` VALUES (1,'Administrator','Service Account','2017-09-14 03:04:00',NULL,NULL),(2,'Doctor','Service Account','2017-10-01 00:13:00',NULL,NULL),(3,'Secretary','Service Account','2017-10-01 00:13:00',NULL,NULL);
/*!40000 ALTER TABLE `user_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'dental_mis'
--
/*!50003 DROP PROCEDURE IF EXISTS `usp_doctor_create` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_doctor_create`(IN
	`@firstname` VARCHAR(45),
	`@lastname` VARCHAR(45),
	`@middle_initial` VARCHAR(45),
	`@status` TINYINT,
	`@created_by` VARCHAR(45)
)
BEGIN
	DECLARE `@if_exist` INT;
	SET `@if_exist`  = (SELECT 1 FROM `dental_mis`.`doctor`
						WHERE `firstname` = `@firstname` AND
							  `lastname` = `@lastname` AND
							  `middle_initial` = `@middle_initial`);
          
	IF `@if_exist` = 0 THEN
		SELECT 0;
	ELSE
		INSERT INTO `dental_mis`.`doctor`
		(
			`firstname`,
			`lastname`,
			`middle_initial`,
			`staus`,
			`created_by`,
			`created_date`
		)
		VALUES
		(
			`@firstname`,
			`@lastname`,
			`@middle_initial`,
			`@status`,
			`@created_by`,
			NOW()
		);
		SELECT LAST_INSERT_ID();
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_doctor_edit` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_doctor_edit`(IN
	`@id` VARCHAR(45),
	`@firstname` VARCHAR(45),
	`@lastname` VARCHAR(45),
	`@middle_initial` VARCHAR(45),
	`@status` TINYINT,
    `@updated_by` VARCHAR(45)
)
BEGIN
	UPDATE `dental_mis`.`doctor`
	SET
	`firstname` = `@firstname`,
	`lastname` = `@lastname`,
	`middle_initial` = `@middle_initial`,
	`staus` = `@status`,
	`updated_by` = `@updated_by`,
	`updated_date` = NOW()
	WHERE `id` = `@id`;
    
    SELECT `@id`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_doctor_search_id` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_doctor_search_id`(IN 
	`@id` BIGINT(8)
)
BEGIN
	SELECT `doctor`.`id`,
		`doctor`.`firstname`,
		`doctor`.`lastname`,
		`doctor`.`middle_initial`,
		IF(`doctor`.`staus` = 1, 'Active', 'Not Active') `status`,
		`doctor`.`created_by`,
		`doctor`.`created_date`,
		`doctor`.`updated_by`,
		`doctor`.`updated_date`
	FROM `dental_mis`.`doctor`
    WHERE `doctor`.`id` = `@id`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_doctor_search_like` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_doctor_search_like`(IN 
	`@search_text` TEXT
)
BEGIN
	IF `@search_text` <> '' THEN
		SELECT `doctor`.`id`,
			`doctor`.`firstname`,
			`doctor`.`lastname`,
			`doctor`.`middle_initial`,
			IF(`doctor`.`staus` = 1, 'Active', 'Not Active') `status`,
			`doctor`.`created_by`,
			`doctor`.`created_date`,
			`doctor`.`updated_by`,
			`doctor`.`updated_date`
		FROM `dental_mis`.`doctor`
		WHERE 
			(`doctor`.`firstname` LIKE CONCAT('%', `@search_text`, '%')) OR
			(`doctor`.`lastname` LIKE CONCAT('%', `@search_text`, '%')) OR
			(`doctor`.`middle_initial` LIKE CONCAT('%', `@search_text`, '%'));
	ELSE
		SELECT `doctor`.`id`,
			`doctor`.`firstname`,
			`doctor`.`lastname`,
			`doctor`.`middle_initial`,
			IF(`doctor`.`staus` = 1, 'Active', 'Not Active') `status`,
			`doctor`.`created_by`,
			`doctor`.`created_date`,
			`doctor`.`updated_by`,
			`doctor`.`updated_date`
		FROM `dental_mis`.`doctor`;    
    END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_doctor_search_status` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_doctor_search_status`(IN 
	`@status` TINYINT
)
BEGIN
	SELECT `doctor`.`id`,
		`doctor`.`firstname`,
		`doctor`.`lastname`,
		`doctor`.`middle_initial`,
		IF(`doctor`.`staus` = 1, 'Active', 'Not Active') `status`,
		`doctor`.`created_by`,
		`doctor`.`created_date`,
		`doctor`.`updated_by`,
		`doctor`.`updated_date`
	FROM `dental_mis`.`doctor`
    WHERE `doctor`.`staus` = `@status`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_patient_create` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_patient_create`(IN 
	`@patient_marital_status_id` BIGINT(8),
    `@firstname` VARCHAR(45),
    `@lastname` VARCHAR(45),
    `@middle_initial` VARCHAR(45),
    `@address` VARCHAR(255),
    `@age` INT, 
    `@gender` VARCHAR(45),
    `@occupation` TEXT,
    `@created_by` VARCHAR(45)
)
BEGIN
	INSERT INTO `dental_mis`.`patient`
	(`patient_marital_status_id`,
	`firstname`,
	`lastname`,
	`middle_initial`,
	`address`,
	`age`,
    `gender`,
    `occupation`,
	`created_by`,
	`created_date`)
	VALUES
	(
		`@patient_marital_status_id`,
        `@firstname`,
        `@lastname`,
        `@middle_initial`,
        `@address`,
        `@age`,
        `@gender`,
        `@occupation`,
        `@created_by`,
        NOW()
	);
    SELECT LAST_INSERT_ID();
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_patient_edit` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_patient_edit`(IN 
	`@id` BIGINT(8),
	`@patient_marital_status_id` BIGINT(8),
    `@firstname` VARCHAR(45),
    `@lastname` VARCHAR(45),
    `@middle_initial` VARCHAR(45),
    `@address` VARCHAR(255),
    `@age` INT,
    `@gender` VARCHAR(45),
    `@occupation` TEXT,
    `@update_by` VARCHAR(45)
)
BEGIN
	UPDATE `dental_mis`.`patient`
	SET
	`patient_marital_status_id` = `@patient_marital_status_id`,
	`firstname` = `@firstname`,
	`lastname` = `@lastname`,
	`middle_initial` = `@middle_initial`,
	`address` = `@address`,
	`age` = `@age`,
    `gender` = `@gender`,
    `occupation` = `@occupation`,
	`updated_by` = `@update_by`,
	`updated_date` = NOW()
	WHERE `id` = `@id`;
    
    SELECT `@id`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_patient_marital_status_create` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_patient_marital_status_create`(IN 
	`@name` VARCHAR(125),
	`@status` TINYINT,
	`@created_by` VARCHAR(45)
)
BEGIN
	DECLARE `@if_exist` int;
    SET `@if_exist` = (SELECT 1 FROM `dental_mis`.`patient_marital_status` WHERE `name` = `@name`);
    
    IF `@if_exist` = 1 THEN
		SELECT 0;
	ELSE
		INSERT INTO `dental_mis`.`patient_marital_status`
		(
			`name`,
			`status`,
			`created_by`,
			`created_date`
		)
		VALUES
		(
			`@name`,
			`@status`,
			`@created_by`,
			NOW()
		);
        SELECT LAST_INSERT_ID();
    END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_patient_marital_status_edit` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_patient_marital_status_edit`(IN
	`@id` BIGINT(8),
	`@name` VARCHAR(125),
	`@status` TINYINT,
	`@updated_by` VARCHAR(45)
)
BEGIN
	UPDATE `dental_mis`.`patient_marital_status`
	SET
	`id` = `@id`,
	`name` = `@name`,
	`status` = `@status`,
	`updated_by` = `@updated_by`,
	`updated_date` = NOW()
	WHERE `id` = `@id`;
    
    SELECT `@id`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_patient_marital_status_search_id` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_patient_marital_status_search_id`(IN 
    `@id` BIGINT(8)
)
BEGIN
	SELECT `patient_marital_status`.`id`,
		`patient_marital_status`.`name`,
		IF(`patient_marital_status`.`status` = 1, 'Active', 'Not Active') `status`,
		`patient_marital_status`.`created_by`,
		`patient_marital_status`.`created_date`,
		`patient_marital_status`.`updated_by`,
		`patient_marital_status`.`updated_date`
	FROM `dental_mis`.`patient_marital_status`
    WHERE `patient_marital_status`.`id` = `@id`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_patient_marital_status_search_like` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_patient_marital_status_search_like`(IN 
    `@search_value` TEXT
)
BEGIN
	IF `@search_value` <> '' THEN
		SELECT `patient_marital_status`.`id`,
			`patient_marital_status`.`name`,
			IF(`patient_marital_status`.`status` = 1, 'Active', 'Not Active') `status`,
			`patient_marital_status`.`created_by`,
			`patient_marital_status`.`created_date`,
			`patient_marital_status`.`updated_by`,
			`patient_marital_status`.`updated_date`
		FROM `dental_mis`.`patient_marital_status`
		WHERE `patient_marital_status`.`name` LIKE CONCAT('%', `@search_value`, '%');   
    ELSE
		SELECT `patient_marital_status`.`id`,
			`patient_marital_status`.`name`,
			IF(`patient_marital_status`.`status` = 1, 'Active', 'Not Active') `status`,
			`patient_marital_status`.`created_by`,
			`patient_marital_status`.`created_date`,
			`patient_marital_status`.`updated_by`,
			`patient_marital_status`.`updated_date`
		FROM `dental_mis`.`patient_marital_status`;
    END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_patient_marital_status_search_status` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_patient_marital_status_search_status`(IN 
    `@status` TINYINT
)
BEGIN
	SELECT `patient_marital_status`.`id`,
		`patient_marital_status`.`name`,
		IF(`patient_marital_status`.`status` = 1, 'Active', 'Not Active') `status`,
		`patient_marital_status`.`created_by`,
		`patient_marital_status`.`created_date`,
		`patient_marital_status`.`updated_by`,
		`patient_marital_status`.`updated_date`
	FROM `dental_mis`.`patient_marital_status`
    WHERE `patient_marital_status`.`status` = `@status`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_patient_search_age` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_patient_search_age`(IN 
    `@age` INT
)
BEGIN
		SELECT 
			`p`.`id`,
			`p`.`patient_marital_status_id`,
			`p`.`firstname`,
			`p`.`lastname`,
			`p`.`middle_initial`,
			`p`.`address`,
			`p`.`age`,
            `p`.`gender`,
            `p`.`occupation`,
			`p`.`created_by`,
			`p`.`created_date`,
			`p`.`updated_by`,
			`p`.`updated_date`,
            `pt`.`name`
		FROM `dental_mis`.`patient` `p`
        LEFT JOIN `dental_mis`.`patient_marital_status` `ps` 
        ON `p`.`patient_marital_status_id` = `ps`.`id`
        WHERE `patient`.`age` = `@age`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_patient_search_id` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_patient_search_id`(IN 
    `@id` TINYINT
)
BEGIN
		SELECT 
			`p`.`id`,
			`p`.`patient_marital_status_id`,
			`p`.`firstname`,
			`p`.`lastname`,
			`p`.`middle_initial`,
			`p`.`address`,
			`p`.`age`,
            `p`.`gender`,
            `p`.`occupation`,
			`p`.`created_by`,
			`p`.`created_date`,
			`p`.`updated_by`,
			`p`.`updated_date`,
            `pt`.`name`
		FROM `dental_mis`.`patient` `p`
        LEFT JOIN `dental_mis`.`patient_marital_status` `ps` 
        ON `p`.`patient_marital_status_id` = `ps`.`id`
        WHERE `patient`.`id` = `@id`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_patient_search_like` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_patient_search_like`(IN 
    `@search_value` TEXT
)
BEGIN
	IF `@search_value` <> '' THEN
		SELECT 
			`p`.`id`,
			`p`.`patient_marital_status_id`,
			`p`.`firstname`,
			`p`.`lastname`,
			`p`.`middle_initial`,
			`p`.`address`,
			`p`.`age`,
            `p`.`gender`,
            `p`.`occupation`,
			`p`.`created_by`,
			`p`.`created_date`,
			`p`.`updated_by`,
			`p`.`updated_date`,
            `pt`.`name`
		FROM `dental_mis`.`patient` `p`
        LEFT JOIN `dental_mis`.`patient_marital_status` `ps` 
        ON `p`.`patient_marital_status_id` = `ps`.`id`
		WHERE (`p`.`firstname` LIKE CONCAT('%', `@search_value`, '%')) OR
			  (`p`.`lastname` LIKE CONCAT('%', `@search_value`, '%')) OR
			  (`p`.`address` LIKE CONCAT('%', `@search_value`, '%')) OR
              (`p`.`occupation` LIKE CONCAT('%', `@search_value`, '%'));
	ELSE
 		SELECT 
			`p`.`id`,
			`p`.`patient_marital_status_id`,
			`p`.`firstname`,
			`p`.`lastname`,
			`p`.`middle_initial`,
			`p`.`address`,
			`p`.`age`,
            `p`.`gender`,
            `p`.`occupation`,
			`p`.`created_by`,
			`p`.`created_date`,
			`p`.`updated_by`,
			`p`.`updated_date`,
            `pt`.`name`
		FROM `dental_mis`.`patient` `p`
        LEFT JOIN `dental_mis`.`patient_marital_status` `ps` 
        ON `p`.`patient_marital_status_id` = `ps`.`id`;   
    END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_payment_breakdown_create` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_payment_breakdown_create`(IN
	`@payment_id` BIGINT(8),
    `@amount_paid` FLOAT,
    `@amount_balance` FLOAT,
    `@date` DATE,
    `@created_by` VARCHAR(45)
)
BEGIN
	INSERT INTO `dental_mis`.`payment_breakdown`
	(	
		`payment_id`,
		`amount_paid`,
		`amount_balance`,
		`date`,
		`created_by`,
		`created_date`
	)
	VALUES
	(
		`@payment_id`,
		`@amount_paid`,
		`@amount_balance`,
		`@date`,
		`@created_by`,
		NOW()
	);
    
    SELECT LAST_INSERT_ID();
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_payment_breakdown_edit` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_payment_breakdown_edit`(IN
	`@id` BIGINT(8),
	`@payment_id` BIGINT(8),
    `@amount_paid` FLOAT,
    `@amount_balance` FLOAT,
    `@date` DATE,
    `@updated_by` VARCHAR(45)
)
BEGIN
	UPDATE `dental_mis`.`payment_breakdown`
	SET
		`payment_id` = `@payment_id`,
		`amount_paid` = `@amount_paid`,
		`amount_balance` = `@amount_balance`,
		`date` = `@date`,
		`updated_by` = `@updated_by`,
		`updated_date` = NOW()
	WHERE `ID` = `@id`;    
    
    SELECT `@id`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_payment_breakdown_search_id` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_payment_breakdown_search_id`(IN
	`@id` BIGINT(8)
)
BEGIN
	SELECT `payment_breakdown`.`id`,
		`payment_breakdown`.`payment_id`,
		`payment_breakdown`.`amount_paid`,
		`payment_breakdown`.`amount_balance`,
		`payment_breakdown`.`date`,
		`payment_breakdown`.`created_by`,
		`payment_breakdown`.`created_date`,
		`payment_breakdown`.`updated_by`,
		`payment_breakdown`.`updated_date`
	FROM `dental_mis`.`payment_breakdown`
    WHERE `id` = `@id`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_payment_breakdown_search_payment_id` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_payment_breakdown_search_payment_id`(IN
	`@payment_id` BIGINT(8)
)
BEGIN
	SELECT `payment_breakdown`.`id`,
		`payment_breakdown`.`payment_id`,
		`payment_breakdown`.`amount_paid`,
		`payment_breakdown`.`amount_balance`,
		`payment_breakdown`.`date`,
		`payment_breakdown`.`created_by`,
		`payment_breakdown`.`created_date`,
		`payment_breakdown`.`updated_by`,
		`payment_breakdown`.`updated_date`
	FROM `dental_mis`.`payment_breakdown`
    WHERE `payment_id` = `@payment_id`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_payment_create` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_payment_create`(IN
	`@procedure_id` BIGINT(8),
	`@amount_to_pay` FLOAT,
	`@date` DATE,
	`@status` TINYINT,
	`@created_by` VARCHAR(45)
)
BEGIN
	INSERT INTO `dental_mis`.`payment`
	(
		`procedure_id`,
		`amount_to_pay`,
		`date`,
		`status`,
		`created_by`,
		`created_date`
    )
	VALUES
	(
		`@procedure_id`,
		`@amount_to_pay`,
		`@date`,
		`@status`,
		`@created_by`,
		NOW()
    );
    
    SELECT mysql_inserted_row();
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_payment_edit` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_payment_edit`(IN
	`@id` BIGINT(8),
	`@procedure_id` BIGINT(8),
    `@amount_to_pay` FLOAT,
    `@date` DATE,
	`@status` VARCHAR(45),
	`@updated_by` VARCHAR(45)
)
BEGIN
	UPDATE `dental_mis`.`payment`
	SET
	`procedure_id` = `@procedure_id`,
    `amount_to_pay` = `@amount_to_pay`,
	`date` = `@date`,
	`status` = `@status`,
	`updated_by` = `@updated_by`,
	`updated_date` = NOW()
	WHERE `id` = `@id`;

    SELECT `@id`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_payment_search_id` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_payment_search_id`(IN
	`@id` BIGINT(8)
)
BEGIN
	SELECT `payment`.`id`,
		`payment`.`procedure_id`,
		`payment`.`amount_to_pay`,
		`payment`.`date`,
		IF(`payment`.`status` = 1, 'Active', 'Not Active') `status`,
		`payment`.`created_by`,
		`payment`.`created_date`,
		`payment`.`updated_by`,
		`payment`.`updated_date`
	FROM `dental_mis`.`payment`
	WHERE `id` = `@id`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_payment_search_procedure_id` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_payment_search_procedure_id`(IN
	`@procedure_id` BIGINT(8)
)
BEGIN
	SELECT `payment`.`id`,
		`payment`.`procedure_id`,
		`payment`.`amount_to_pay`,
		`payment`.`date`,
		IF(`payment`.`status` = 1, 'Active', 'Not Active') `status`,
		`payment`.`created_by`,
		`payment`.`created_date`,
		`payment`.`updated_by`,
		`payment`.`updated_date`
	FROM `dental_mis`.`payment`
	WHERE `procedure_id` = `@procedure_id`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_payment_search_status` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_payment_search_status`(IN
	`@status` VARCHAR(45)
)
BEGIN
	SELECT `payment`.`id`,
		`payment`.`procedure_id`,
		`payment`.`amount_to_pay`,
		`payment`.`date`,
		IF(`payment`.`status` = 1, 'Active', 'Not Active') `status`,
		`payment`.`created_by`,
		`payment`.`created_date`,
		`payment`.`updated_by`,
		`payment`.`updated_date`
	FROM `dental_mis`.`payment`
	WHERE `status` = `@status`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_procedure_create` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_procedure_create`(IN
	`@patient_id` BIGINT(8),
	`@procedure_type_id` BIGINT(8),
	`@doctor_id` BIGINT(8),
	`@notes` TEXT,
	`@prescription` TEXT,
	`@date` DATE,
	`@status` VARCHAR(45),
	`@created_by` VARCHAR(45)
)
BEGIN
	INSERT INTO `dental_mis`.`procedure`
	(
		`patient_id`,
		`procedure_type_id`,
		`doctor_id`,
		`notes`,
		`prescription`,
		`date`,
		`status`,
		`created_by`,
		`created_date`
    )
	VALUES
	(
		`@patient_id`,
		`@procedure_type_id`,
		`@doctor_id`,
		`@notes`,
		`@prescription`,
		`@date`,
		`@status`,
		`@created_by`,
        NOW()
    );
    
    SELECT LAST_INSERT_ID();
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_procedure_edit` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_procedure_edit`(IN
	`@id` BIGINT(8),
	`@patient_id` BIGINT(8),
	`@procedure_type_id` BIGINT(8),
	`@doctor_id` BIGINT(8),
	`@notes` TEXT,
	`@prescription` TEXT,
	`@date` DATE,
	`@status` VARCHAR(45),
	`@updated_by` VARCHAR(45)
)
BEGIN
	UPDATE `dental_mis`.`procedure`
	SET
	`patient_id` = `@patient_id`,
	`procedure_type_id` = `@procedure_type_id`,
	`doctor_id` = `@doctor_id`,
	`notes` = `@notes`,
	`prescription` = `@prescription`,
	`date` = `@date`,
	`status` = `@status`,
	`updated_by` = `@updated_by`,
	`updated_date` = NOW()
	WHERE `id` = `@id`;
    
    SELECT `@id`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_procedure_search_id` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_procedure_search_id`(IN
	`@id` BIGINT(8)
)
BEGIN
	SELECT `procedure`.`id`,
		`procedure`.`patient_id`,
		`procedure`.`procedure_type_id`,
		`procedure`.`doctor_id`,
		`procedure`.`notes`,
		`procedure`.`prescription`,
		`procedure`.`date`,
		IF(`procedure`.`status` = 1, 'Active', 'Not Active') `status`,
		`procedure`.`created_by`,
		`procedure`.`created_date`,
		`procedure`.`updated_by`,
		`procedure`.`updated_date`
	FROM `dental_mis`.`procedure`
    WHERE `id` = `@id`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_procedure_search_patient_id` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_procedure_search_patient_id`(IN
	`@patient_id` BIGINT(8)
)
BEGIN
	SELECT `procedure`.`id`,
		`procedure`.`patient_id`,
		`procedure`.`procedure_type_id`,
		`procedure`.`doctor_id`,
		`procedure`.`notes`,
		`procedure`.`prescription`,
		`procedure`.`date`,
		IF(`procedure`.`status` = 1, 'Active', 'Not Active') `status`,
		`procedure`.`created_by`,
		`procedure`.`created_date`,
		`procedure`.`updated_by`,
		`procedure`.`updated_date`
	FROM `dental_mis`.`procedure`
    WHERE `patient_id` = `@patient_id`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_procedure_tooth_create` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_procedure_tooth_create`(IN
	`@procedure_id` BIGINT(8),
	`@tooth_number` INT,
	`@created_by` VARCHAR(45)
)
BEGIN
	INSERT INTO `dental_mis`.`procedure_tooth`
	(
		`procedure_id`,
		`tooth_number`,
		`created_by`,
		`created_date`
    )
	VALUES
	(
		`@procedure_id`,
		`@tooth_number`,
		`@created_by`
    );
    
    SELECT LAST_INSERT_ID();
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_procedure_tooth_edit` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_procedure_tooth_edit`(IN
	`@id` BIGINT(8),
	`@procedure_id` BIGINT(8),
	`@tooth_number` INT,
	`@updated_by` VARCHAR(45)
)
BEGIN
	UPDATE `dental_mis`.`procedure_tooth`
	SET
		`procedure_id` = `@procedure_id`,
		`tooth_number` = `@tooth_number`,
		`updated_by` = `@updated_by`,
		`updated_date` = NOW()
	WHERE `id` = `@id`;

    SELECT mysql_inserted_row();
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_procedure_tooth_search_id` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_procedure_tooth_search_id`(IN
	`@id` BIGINT(8),
	`@procedure_id` BIGINT(8),
	`@tooth_number` INT,
	`@updated_by` VARCHAR(45)
)
BEGIN
	SELECT 
		`procedure_tooth`.`id`,
		`procedure_tooth`.`procedure_id`,
		`procedure_tooth`.`tooth_number`,
		`procedure_tooth`.`created_by`,
		`procedure_tooth`.`created_date`,
		`procedure_tooth`.`updated_by`,
		`procedure_tooth`.`updated_date`
	FROM `dental_mis`.`procedure_tooth`
    WHERE `id` = `@id`;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_procedure_tooth_search_procedure_id` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_procedure_tooth_search_procedure_id`(IN
	`@id` BIGINT(8),
	`@procedure_id` BIGINT(8),
	`@tooth_number` INT,
	`@updated_by` VARCHAR(45)
)
BEGIN
	SELECT 
		`procedure_tooth`.`id`,
		`procedure_tooth`.`procedure_id`,
		`procedure_tooth`.`tooth_number`,
		`procedure_tooth`.`created_by`,
		`procedure_tooth`.`created_date`,
		`procedure_tooth`.`updated_by`,
		`procedure_tooth`.`updated_date`
	FROM `dental_mis`.`procedure_tooth`
    WHERE `procedure_id` = `@procedure_id`;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_procedure_type_create` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_procedure_type_create`(IN
	`@name` VARCHAR(45),
	`@base_price` FLOAT,
	`@payment_type` VARCHAR(45),
	`@require_med_cert` TINYINT,
	`@status` TINYINT,
	`@created_by` VARCHAR(45)
)
BEGIN
	DECLARE `@if_exist` INT;
    SET `@if_exist` = (SELECT 1 FROM `dental_mis`.`procedure_type` WHERE
						`name` = `@name` AND
                        `base_price` = `@base_price` AND
                        `payment_type` = `@payment_type` AND
                        `require_med_cert` = `@require_med_cert`);
                        
	IF `@if_exist` = 1 THEN
		SELECT 0;
	ELSE
		INSERT INTO `dental_mis`.`procedure_type`
		(
			`name`,
			`base_price`,
			`payment_type`,
			`require_med_cert`,
			`status`,
			`created_by`,
			`created_date`
		)
		VALUES
		(
			`@name`,
			`@base_price`,
			`@payment_type`,
			`@require_med_cert`,
			`@status`,
			`@created_by`,
            NOW()
		);
		
		SELECT LAST_INSERT_ID();
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_procedure_type_edit` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_procedure_type_edit`(IN
	`@id` BIGINT(8),
	`@name` VARCHAR(45),
	`@base_price` FLOAT,
	`@payment_type` VARCHAR(45),
	`@require_med_cert` TINYINT,
	`@status` VARCHAR(45),
	`@updated_by` VARCHAR(45)
)
BEGIN
	UPDATE `dental_mis`.`procedure_type`
	SET
	`name` = `@name`,
	`base_price` = `@base_price`,
	`payment_type` = `@payment_type`,
	`require_med_cert` = `@require_med_cert`,
	`status` = `@status`,
	`updated_by` = `@updated_by`,
	`updated_date` = NOW()
	WHERE `id` = `@id`;
    
    SELECT `@id`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_procedure_type_search_id` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_procedure_type_search_id`(IN
	`@id` BIGINT(8)
)
BEGIN
	SELECT `procedure_type`.`id`,
		`procedure_type`.`name`,
		`procedure_type`.`base_price`,
		`procedure_type`.`payment_type`,
		IF(`procedure_type`.`require_med_cert` = 1, 'Yes','No') `require_med_cert`,
		IF(`procedure_type`.`status`,'Active', 'Not Active') `status`,
		`procedure_type`.`created_by`,
		`procedure_type`.`created_date`,
		`procedure_type`.`updated_by`,
		`procedure_type`.`updated_date`
	FROM `dental_mis`.`procedure_type`
    WHERE `id` = `@id`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_procedure_type_search_like` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_procedure_type_search_like`(IN
	`@search_text` TEXT
)
BEGIN
	IF `@search_text` <> '' THEN
		SELECT `procedure_type`.`id`,
			`procedure_type`.`name`,
			`procedure_type`.`base_price`,
			`procedure_type`.`payment_type`,
			IF(`procedure_type`.`require_med_cert` = 1, 'Yes','No') `require_med_cert`,
			IF(`procedure_type`.`status` = 1, 'Active', 'Not Active') `status`,
			`procedure_type`.`created_by`,
			`procedure_type`.`created_date`,
			`procedure_type`.`updated_by`,
			`procedure_type`.`updated_date`
		FROM `dental_mis`.`procedure_type`
		WHERE (`procedure_type`.`name` LIKE CONCAT('%', `@search_text`, '%')) OR
			  (`procedure_type`.`payment_type` LIKE CONCAT('%', `@search_text`, '%'));
	ELSE
		SELECT `procedure_type`.`id`,
			`procedure_type`.`name`,
			`procedure_type`.`base_price`,
			`procedure_type`.`payment_type`,
			IF(`procedure_type`.`require_med_cert` = 1, 'Yes','No') `require_med_cert`,
			IF(`procedure_type`.`status` = 1, 'Active', 'Not Active') `status`,
			`procedure_type`.`created_by`,
			`procedure_type`.`created_date`,
			`procedure_type`.`updated_by`,
			`procedure_type`.`updated_date`
		FROM `dental_mis`.`procedure_type`;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_procedure_type_search_require_med_cert` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_procedure_type_search_require_med_cert`(IN
	`@require_med_cert` TINYINT
)
BEGIN
	SELECT `procedure_type`.`id`,
		`procedure_type`.`name`,
		`procedure_type`.`base_price`,
		`procedure_type`.`payment_type`,
		IF(`procedure_type`.`require_med_cert` = 1, 'Yes','No') `require_med_cert`,
		IF(`procedure_type`.`status`,'Active', 'Not Active') `status`,
		`procedure_type`.`created_by`,
		`procedure_type`.`created_date`,
		`procedure_type`.`updated_by`,
		`procedure_type`.`updated_date`
	FROM `dental_mis`.`procedure_type`
    WHERE `procedure_type`.`require_med_cert` = `@require_med_cert`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_procedure_type_search_status` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_procedure_type_search_status`(IN
	`@status` TINYINT
)
BEGIN
	SELECT `procedure_type`.`id`,
		`procedure_type`.`name`,
		`procedure_type`.`base_price`,
		`procedure_type`.`payment_type`,
		IF(`procedure_type`.`require_med_cert` = 1, 'Yes','No') `require_med_cert`,
		IF(`procedure_type`.`status`,'Active', 'Not Active') `status`,
		`procedure_type`.`created_by`,
		`procedure_type`.`created_date`,
		`procedure_type`.`updated_by`,
		`procedure_type`.`updated_date`
	FROM `dental_mis`.`procedure_type`
    WHERE `procedure_type`.`status` = `@status`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_user_create` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_user_create`(IN
	`@user_type_id` BIGINT(8),
	`@username` VARCHAR(45),
	`@password` VARCHAR(45),
	`@firstname` VARCHAR(45),
	`@lastname` VARCHAR(45),
	`@status` TINYINT,
	`@created_by` VARCHAR(45)
)
BEGIN
	DECLARE `@exist` INT;
    SET `@exist` = (SELECT 1 FROM `dental_mis`.`user` 
					WHERE `user_type_id` = `@user_type_id` AND 
                          `username` = `@username` AND
                          `firstname` = `@firstname` AND
                          `lastname` = `@lastname`);
	IF `@exist` = 1 THEN
		SELECT 0;
	ELSE
    
    	INSERT INTO `dental_mis`.`user`
		(
			`user_type_id`,
			`username`,
			`password`,
			`firstname`,
			`lastname`,
			`status`,
			`created_by`,
			`created_date`
		)
		VALUES
		(
			`@user_type_id`,
			`@username`,
			`@password`,
			`@firstname`,
			`@lastname`,
			`@status`,
			`@created_by`,
			NOW()
		);
		
		SELECT LAST_INSERT_ID();

	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_user_edit` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_user_edit`(IN
	`@id` BIGINT(8),
	`@user_type_id` BIGINT(8),
	`@username` VARCHAR(45),
	`@password` VARCHAR(45),
	`@firstname` VARCHAR(45),
	`@lastname` VARCHAR(45),
	`@status` TINYINT,
	`@updated_by` VARCHAR(45)
)
BEGIN
	UPDATE `dental_mis`.`user`
	SET
	`user_type_id` = `@user_type_id`,
	`username` = `@username`,
	`password` = `@password`,
	`firstname` = `@firstname`,
	`lastname` = `@lastname`,
	`status` = `@status`,
	`updated_by` = `@updated_by`,
	`updated_date` = NOW()
	WHERE `id` = `@id`;
		
    SELECT `@id`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_user_login` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_user_login`(IN
	`@username` VARCHAR(45),
    `@password` VARCHAR(45)
)
BEGIN
	SELECT `u`.`id`,
		`u`.`user_type_id`,
        `ut`.`name` `user_type`,
		`u`.`username`,
		`u`.`password`,
		`u`.`firstname`,
		`u`.`lastname`,
		IF(`u`.`status` = 1, 'Active', 'Not Active') `status`,
		`u`.`created_by`,
		`u`.`created_date`,
		`u`.`updated_by`,
		`u`.`updated_date`
	FROM `dental_mis`.`user` `u`
    LEFT JOIN `dental_mis`.`user_type` `ut` ON
    `u`.`user_type_id` = `ut`.`id`
    WHERE `u`.`username` = `@username` AND
		  `u`.`password` = `@password` AND
          `u`.`status` = 1;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_user_search_id` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_user_search_id`(IN
	`@id` BIGINT(8)
)
BEGIN
	SELECT `u`.`id`,
		`u`.`user_type_id`,
        `ut`.`name` `user_type`,
		`u`.`username`,
		`u`.`password`,
		`u`.`firstname`,
		`u`.`lastname`,
		IF(`u`.`status` = 1, 'Active', 'Not Active') `status`,
		`u`.`created_by`,
		`u`.`created_date`,
		`u`.`updated_by`,
		`u`.`updated_date`
	FROM `dental_mis`.`user` `u`
    LEFT JOIN `dental_mis`.`user_type` `ut` ON
    `u`.`user_type_id` = `ut`.`id`
    WHERE `u`.`id` = `@id`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_user_search_like` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_user_search_like`(IN
	`@search_text` TEXT
)
BEGIN
	IF `@search_text` <> '' THEN
		SELECT `u`.`id`,
			`u`.`user_type_id`,
			`ut`.`name` `user_type`,
			`u`.`username`,
			`u`.`password`,
			`u`.`firstname`,
			`u`.`lastname`,
			IF(`u`.`status` = 1, 'Active', 'Not Active') `status`,
			`u`.`created_by`,
			`u`.`created_date`,
			`u`.`updated_by`,
			`u`.`updated_date`
		FROM `dental_mis`.`user` `u`
		LEFT JOIN `dental_mis`.`user_type` `ut` ON
		`u`.`user_type_id` = `ut`.`id`
		WHERE (`u`.`username` LIKE CONCAT('%', `@search_text`, '%')) OR
			  (`u`.`firstname` LIKE CONCAT('%', `@search_text`, '%')) OR
			  (`u`.`lastname` LIKE CONCAT('%', `@search_text`, '%'));
	ELSE
		SELECT `u`.`id`,
			`u`.`user_type_id`,
			`ut`.`name` `user_type`,
			`u`.`username`,
			`u`.`password`,
			`u`.`firstname`,
			`u`.`lastname`,
			IF(`u`.`status` = 1, 'Active', 'Not Active') `status`,
			`u`.`created_by`,
			`u`.`created_date`,
			`u`.`updated_by`,
			`u`.`updated_date`
		FROM `dental_mis`.`user` `u`
		LEFT JOIN `dental_mis`.`user_type` `ut` ON
		`u`.`user_type_id` = `ut`.`id`;    
    END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_user_search_status` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_user_search_status`(IN
	`@status` BIGINT(8)
)
BEGIN
	SELECT `u`.`id`,
		`u`.`user_type_id`,
		`ut`.`name` `user_type`,
		`u`.`username`,
		`u`.`password`,
		`u`.`firstname`,
		`u`.`lastname`,
		IF(`u`.`status` = 1, 'Active', 'Not Active') `status`,
		`u`.`created_by`,
		`u`.`created_date`,
		`u`.`updated_by`,
		`u`.`updated_date`
	FROM `dental_mis`.`user` `u`
	LEFT JOIN `dental_mis`.`user_type` `ut` ON
	`u`.`user_type_id` = `ut`.`id`
    WHERE `u`.`status` = `@status`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_user_type_create` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_user_type_create`(IN
	`@name` VARCHAR(45),
	`@created_by` VARCHAR(45)
)
BEGIN
	INSERT INTO `dental_mis`.`user_type`
	(
		`name`,
		`created_by`,
		`created_date`
	)
	VALUES
	(
		`@name`,
		`@created_by`,
		NOW()
	);
    
    SELECT LAST_INSERT_ID();
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_user_type_edit` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_user_type_edit`(IN
	`@id` BIGINT(8),
	`@name` VARCHAR(45),
	`@updated_by` VARCHAR(45)
)
BEGIN
	UPDATE `dental_mis`.`user_type`
	SET
	`name` = `@name`,
	`updated_by` = `@updated_by`,
	`updated_date` = NOW()
	WHERE `id` = `@id`;
    
    SELECT `@id`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_user_type_search_id` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_user_type_search_id`(IN
	`@id` BIGINT(8)
)
BEGIN
	SELECT `user_type`.`id`,
		`user_type`.`name`,
		`user_type`.`created_by`,
		`user_type`.`created_date`,
		`user_type`.`updated_by`,
		`user_type`.`updated_date`
	FROM `dental_mis`.`user_type`
    WHERE `user_type`.`id` = `@id`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-10-16  4:48:00
