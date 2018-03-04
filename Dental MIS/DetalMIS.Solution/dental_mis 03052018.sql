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
-- Table structure for table `audit_trail`
--

DROP TABLE IF EXISTS `audit_trail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `audit_trail` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `action` text,
  `created_by` varchar(45) DEFAULT NULL,
  `created_date` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `audit_trail`
--

LOCK TABLES `audit_trail` WRITE;
/*!40000 ALTER TABLE `audit_trail` DISABLE KEYS */;
INSERT INTO `audit_trail` VALUES (1,'Patient Create Test Qwe','1','2018-02-22 01:13:54'),(2,'Patient Edit Test Qwea','1','2018-02-22 01:14:25'),(3,'Procedure Type Create Extraction','1','2018-02-22 01:17:16'),(4,'Procedure Type Edit Extraction','1','2018-02-22 01:17:28'),(5,'Procedure Type Edit Extraction','1','2018-02-22 22:59:44'),(6,'Procedure Type Create qwe','1','2018-02-22 22:59:53'),(7,'User Edit User ID 1','1','2018-03-04 23:44:31'),(8,'User Edit User ID 2','1','2018-03-04 23:44:31');
/*!40000 ALTER TABLE `audit_trail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `audit_trail_view`
--

DROP TABLE IF EXISTS `audit_trail_view`;
/*!50001 DROP VIEW IF EXISTS `audit_trail_view`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `audit_trail_view` AS SELECT 
 1 AS `id`,
 1 AS `action`,
 1 AS `created_by`,
 1 AS `created_date`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `patient`
--

DROP TABLE IF EXISTS `patient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `patient` (
  `id` bigint(8) NOT NULL AUTO_INCREMENT,
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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patient`
--

LOCK TABLES `patient` WRITE;
/*!40000 ALTER TABLE `patient` DISABLE KEYS */;
INSERT INTO `patient` VALUES (2,'Test','Qwea','A','qwe',5,'Male','Qwe','1','2018-02-22 01:13:54','1','2018-02-22 01:14:25');
/*!40000 ALTER TABLE `patient` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER patient_create
AFTER INSERT
   ON `patient` FOR EACH ROW

BEGIN
   -- Find username of person performing the INSERT into table
	
   -- Insert record into audit table
	INSERT INTO `dental_mis`.`audit_trail`
	(`action`,
	 `created_by`)
	VALUES
	(CONCAT('Patient Create ', NEW.`firstname`, ' ', NEW.`lastname`),
	 NEW.`created_by`);

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER patient_update
AFTER UPDATE
   ON `patient` FOR EACH ROW

BEGIN
   -- Find username of person performing the INSERT into table
	
   -- Insert record into audit table
	INSERT INTO `dental_mis`.`audit_trail`
	(`action`,
	 `created_by`)
	VALUES
	(CONCAT('Patient Edit ', NEW.`firstname`, ' ', NEW.`lastname`),
	 NEW.`updated_by`);

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `payment`
--

DROP TABLE IF EXISTS `payment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `payment` (
  `id` bigint(8) NOT NULL AUTO_INCREMENT,
  `procedure_id` bigint(8) NOT NULL,
  `amount_paid` float DEFAULT NULL,
  `date` date DEFAULT NULL,
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
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER payment_create
AFTER INSERT
   ON payment FOR EACH ROW

BEGIN
   -- Find username of person performing the INSERT into table
	
   -- Insert record into audit table
	INSERT INTO `dental_mis`.`audit_trail`
	(`action`,
	 `created_by`)
	VALUES
	(CONCAT('Payment Create  Procedure ID ', NEW.`procedure_id`),
	 NEW.`created_by`);

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER payment_edit
AFTER UPDATE
   ON payment FOR EACH ROW

BEGIN
   -- Find username of person performing the INSERT into table
	
   -- Insert record into audit table
	INSERT INTO `dental_mis`.`audit_trail`
	(`action`,
	 `created_by`)
	VALUES
	(CONCAT('Payment Edit Procedure ID ', NEW.`procedure_id`),
	 NEW.`updated_by`);

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

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
  `tooth_id` bigint(8) DEFAULT NULL,
  `amount_to_pay` float DEFAULT NULL,
  `notes` text,
  `date` date DEFAULT NULL,
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
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER procedure_create
AFTER INSERT
   ON `procedure` FOR EACH ROW

BEGIN
   -- Find username of person performing the INSERT into table
	
   -- Insert record into audit table
	INSERT INTO `dental_mis`.`audit_trail`
	(`action`,
	 `created_by`)
	VALUES
	(CONCAT('Procedure Create Patient ID ', NEW.`patient_id`),
	 NEW.`created_by`);

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER procedure_edit
AFTER UPDATE
   ON `procedure` FOR EACH ROW

BEGIN
   -- Find username of person performing the INSERT into table
	
   -- Insert record into audit table
	INSERT INTO `dental_mis`.`audit_trail`
	(`action`,
	 `created_by`)
	VALUES
	(CONCAT('Procedure Edit Patient ID ', NEW.`patient_id`),
	 NEW.`updated_by`);

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

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
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `procedure_type`
--

LOCK TABLES `procedure_type` WRITE;
/*!40000 ALTER TABLE `procedure_type` DISABLE KEYS */;
INSERT INTO `procedure_type` VALUES (6,'Extraction',500,'Full Payment',1,0,'1','2018-02-22 01:17:16','1','2018-02-22 22:59:44'),(7,'qwe',500,'Installment',1,1,'1','2018-02-22 22:59:53',NULL,NULL);
/*!40000 ALTER TABLE `procedure_type` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `dental_mis`.`procedure_type_AFTER_INSERT` AFTER INSERT ON `procedure_type` FOR EACH ROW
BEGIN
	INSERT INTO `dental_mis`.`audit_trail`
	(`action`,
	 `created_by`)
	VALUES
	(CONCAT('Procedure Type Create ', NEW.`name`),
	 NEW.`created_by`);
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `dental_mis`.`procedure_type_AFTER_UPDATE` AFTER UPDATE ON `procedure_type` FOR EACH ROW
BEGIN
	INSERT INTO `dental_mis`.`audit_trail`
	(`action`,
	 `created_by`)
	VALUES
	(CONCAT('Procedure Type Edit ', NEW.`name`),
	 NEW.`updated_by`);
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `procedure_type_not_allowed`
--

DROP TABLE IF EXISTS `procedure_type_not_allowed`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `procedure_type_not_allowed` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `procedure_type_id` bigint(20) DEFAULT NULL,
  `procedure_type_id_not_allowed` bigint(20) DEFAULT NULL,
  `status` tinyint(4) DEFAULT NULL,
  `created_by` varchar(45) DEFAULT NULL,
  `created_date` datetime DEFAULT CURRENT_TIMESTAMP,
  `updated_by` varchar(45) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `procedure_type_not_allowed`
--

LOCK TABLES `procedure_type_not_allowed` WRITE;
/*!40000 ALTER TABLE `procedure_type_not_allowed` DISABLE KEYS */;
INSERT INTO `procedure_type_not_allowed` VALUES (2,6,6,1,'Admin User','2018-02-22 01:17:59',NULL,NULL);
/*!40000 ALTER TABLE `procedure_type_not_allowed` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `procedure_view`
--

DROP TABLE IF EXISTS `procedure_view`;
/*!50001 DROP VIEW IF EXISTS `procedure_view`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `procedure_view` AS SELECT 
 1 AS `id`,
 1 AS `patient_id`,
 1 AS `procedure_type_id`,
 1 AS `full_name`,
 1 AS `age`,
 1 AS `address`,
 1 AS `gender`,
 1 AS `procedure_name`,
 1 AS `tooth_number`,
 1 AS `tooth`,
 1 AS `notes`,
 1 AS `procedure_date`,
 1 AS `amount_to_pay`,
 1 AS `amount_paid`,
 1 AS `balance`,
 1 AS `payment_status`,
 1 AS `payment_date`,
 1 AS `procedure_created_by`,
 1 AS `procedure_created_date`,
 1 AS `procedure_updated_by`,
 1 AS `procedure_updated_date`,
 1 AS `payment_created_by`,
 1 AS `payment_created_date`,
 1 AS `payment_updated_by`,
 1 AS `payment_updated_date`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `schedule`
--

DROP TABLE IF EXISTS `schedule`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `schedule` (
  `id` bigint(8) NOT NULL AUTO_INCREMENT,
  `title` text,
  `description` text,
  `start_time` datetime DEFAULT NULL,
  `end_time` datetime DEFAULT NULL,
  `background_color` varchar(45) DEFAULT NULL,
  `is_deleted` tinyint(4) DEFAULT '0',
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
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `dental_mis`.`schedule_AFTER_INSERT` AFTER INSERT ON `schedule` FOR EACH ROW
BEGIN
	INSERT INTO `dental_mis`.`audit_trail`
	(`action`,
	 `created_by`)
	VALUES
	(CONCAT('Schedule Create Schedule ID ', NEW.`id`),
	 NEW.`created_by`);
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `dental_mis`.`schedule_AFTER_UPDATE` AFTER UPDATE ON `schedule` FOR EACH ROW
BEGIN
	INSERT INTO `dental_mis`.`audit_trail`
	(`action`,
	 `created_by`)
	VALUES
	(CONCAT('Schedule Edit Schedule ID ', NEW.`id`),
	 NEW.`updated_by`);
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `secret_question`
--

DROP TABLE IF EXISTS `secret_question`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `secret_question` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `question` text,
  `created_by` varchar(45) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `updated_by` varchar(45) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `secret_question`
--

LOCK TABLES `secret_question` WRITE;
/*!40000 ALTER TABLE `secret_question` DISABLE KEYS */;
INSERT INTO `secret_question` VALUES (1,'What is your favorite color?','1','2018-02-19 02:56:07',NULL,NULL);
/*!40000 ALTER TABLE `secret_question` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tooth`
--

DROP TABLE IF EXISTS `tooth`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tooth` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `description` varchar(45) DEFAULT NULL,
  `created_by` varchar(45) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `updated_by` varchar(45) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tooth`
--

LOCK TABLES `tooth` WRITE;
/*!40000 ALTER TABLE `tooth` DISABLE KEYS */;
INSERT INTO `tooth` VALUES (1,'(R) Third Molar','admin','2018-02-02 00:43:00',NULL,NULL),(2,'(R) Second Molar','admin','2018-02-02 00:43:00',NULL,NULL),(3,'(R) First Molar','admin','2018-02-02 00:43:00',NULL,NULL),(4,'(R) Second Bicuspid','admin','2018-02-02 00:43:00',NULL,NULL),(5,'(R) First Bicuspid','admin','2018-02-02 00:43:00',NULL,NULL),(6,'(R) Bicuspid','admin','2018-02-02 00:43:00',NULL,NULL),(7,'(R) Lateral Incisor','admin','2018-02-02 00:43:00',NULL,NULL),(8,'(R) Central Incisor','admin','2018-02-02 00:43:00',NULL,NULL),(9,'(L) Central Incisor','admin','2018-02-02 00:43:00',NULL,NULL),(10,'(L) Lateral Incisor','admin','2018-02-02 00:43:00',NULL,NULL),(11,'(L) Bicuspid','admin','2018-02-02 00:43:00',NULL,NULL),(12,'(L) First Bicuspid','admin','2018-02-02 00:43:00',NULL,NULL),(13,'(L) Second Bicuspid','admin','2018-02-02 00:43:00',NULL,NULL),(14,'(L) First Molar','admin','2018-02-02 00:43:00',NULL,NULL),(15,'(L) Second Molar','admin','2018-02-02 00:43:00',NULL,NULL),(16,'(L) Third Molar','admin','2018-02-02 00:43:00',NULL,NULL),(17,'(L) Third Molar','admin','2018-02-02 00:43:00',NULL,NULL),(18,'(L) Second Molar','admin','2018-02-02 00:43:00',NULL,NULL),(19,'(L) First Molar','admin','2018-02-02 00:43:00',NULL,NULL),(20,'(L) Second Bicuspid','admin','2018-02-02 00:43:00',NULL,NULL),(21,'(L) First Bicuspid','admin','2018-02-02 00:43:00',NULL,NULL),(22,'(L) Bicuspid','admin','2018-02-02 00:43:00',NULL,NULL),(23,'(L) Lateral Incisor','admin','2018-02-02 00:43:00',NULL,NULL),(24,'(L) Central Incisor','admin','2018-02-02 00:43:00',NULL,NULL),(25,'(R) Central Incisor','admin','2018-02-02 00:43:00',NULL,NULL),(26,'(R) Lateral Incisor','admin','2018-02-02 00:43:00',NULL,NULL),(27,'(R) Bicuspid','admin','2018-02-02 00:43:00',NULL,NULL),(28,'(R) First Bicuspid','admin','2018-02-02 00:43:00',NULL,NULL),(29,'(R) Second Bicuspid','admin','2018-02-02 00:43:00',NULL,NULL),(30,'(R) First Molar','admin','2018-02-02 00:43:00',NULL,NULL),(31,'(R) Second Molar','admin','2018-02-02 00:43:00',NULL,NULL),(32,'(R) Third Molar','admin','2018-02-02 00:43:00',NULL,NULL);
/*!40000 ALTER TABLE `tooth` ENABLE KEYS */;
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
  `secret_question_id` bigint(20) DEFAULT NULL,
  `username` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `secret_question_answer` text,
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
INSERT INTO `user` VALUES (1,1,1,'admin','password','red','Admin','User',1,'1',NULL,NULL,NULL),(2,2,1,'secretary','password','blackq','Secretary','Account',1,'1','2018-02-19 03:07:41','Admin User','2018-02-19 05:55:41');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `dental_mis`.`user_AFTER_INSERT` AFTER INSERT ON `user` FOR EACH ROW
BEGIN
	INSERT INTO `dental_mis`.`audit_trail`
	(`action`,
	 `created_by`)
	VALUES
	(CONCAT('User Create User ID ', NEW.`id`),
	 NEW.`created_by`);
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `dental_mis`.`user_AFTER_UPDATE` AFTER UPDATE ON `user` FOR EACH ROW
BEGIN
	INSERT INTO `dental_mis`.`audit_trail`
	(`action`,
	 `created_by`)
	VALUES
	(CONCAT('User Edit User ID ', NEW.`id`),
	 NEW.`created_by`);
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_type`
--

LOCK TABLES `user_type` WRITE;
/*!40000 ALTER TABLE `user_type` DISABLE KEYS */;
INSERT INTO `user_type` VALUES (1,'Doctor','Service Account','2017-10-01 00:13:00',NULL,NULL),(2,'Secretary','Service Account','2017-10-01 00:13:00',NULL,NULL);
/*!40000 ALTER TABLE `user_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `user_view`
--

DROP TABLE IF EXISTS `user_view`;
/*!50001 DROP VIEW IF EXISTS `user_view`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `user_view` AS SELECT 
 1 AS `id`,
 1 AS `user_type_id`,
 1 AS `secret_question_id`,
 1 AS `user_type`,
 1 AS `username`,
 1 AS `password`,
 1 AS `secret_question`,
 1 AS `secret_question_answer`,
 1 AS `firstname`,
 1 AS `lastname`,
 1 AS `status`,
 1 AS `created_by`,
 1 AS `created_date`,
 1 AS `updated_by`,
 1 AS `updated_date`*/;
SET character_set_client = @saved_cs_client;

--
-- Dumping events for database 'dental_mis'
--

--
-- Dumping routines for database 'dental_mis'
--
/*!50003 DROP PROCEDURE IF EXISTS `usp_audit_trail_create` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_audit_trail_create`(in
	`@action` TEXT,
    `@created_by` NVARCHAR(45)
)
BEGIN
	INSERT INTO `dental_mis`.`audit_trail`
	(`action`,
	`created_by`)
	VALUES
	(
	`@action`,
	`@created_by`);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_audit_trail_select` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_audit_trail_select`(in
	`@from` NVARCHAR(20),
    `@to` NVARCHAR(20)
)
BEGIN
	IF `@from` <> '' OR `@to` <> '' THEN
		SELECT * FROM dental_mis.audit_trail_view
		WHERE created_date BETWEEN `@from` AND `@to`
		ORDER BY created_date ASC;
	ELSE
		SELECT * FROM dental_mis.audit_trail_view
		ORDER BY created_date ASC;
    END IF;
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
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_patient_create`(IN 
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
	DECLARE `@if_exist` INT;
    SET `@if_exist` = (SELECT 1 
					   FROM `dental_mis`.`patient` 
					   WHERE `firstname` = `@firstname` AND
                             `lastname` = `@lastname` AND
                             `middle_initial` = `@middle_initial` AND
                             `address` = `@address` AND
                             `age` = `@age` AND
                             `gender` = `@gender` AND
                             `occupation` = `@occupation`);
	IF `@if_exist` = 1 THEN
		SELECT 0;
	ELSE
		INSERT INTO `dental_mis`.`patient`
		(`firstname`,
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
    END IF;
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
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_patient_edit`(IN 
	`@id` BIGINT(8),
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
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_patient_search_id`(IN 
    `@id` TINYINT
)
BEGIN
		SELECT 
			`p`.`id`,
			`p`.`firstname`,
			`p`.`lastname`,
			`p`.`middle_initial`,
			`p`.`address`,
			`p`.`age`,
            `p`.`gender`,
            `p`.`occupation`,
			CONCAT(`cc`.`firstname`,' ', `cc`.`lastname`)  `created_by`,
			`p`.`created_date`,
			CONCAT(`cu`.`firstname`,' ', `cu`.`lastname`) `updated_by`,
			`p`.`updated_date`
		FROM `dental_mis`.`patient` `p`
        LEFT JOIN `dental_mis`.`user` `cc` ON
        `cc`.`id` = `p`.`created_by`
         LEFT JOIN `dental_mis`.`user` `cu` ON
        `cu`.`id` = `p`.`updated_by`       
        WHERE `p`.`id` = `@id`;
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
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_patient_search_like`(IN 
    `@search_value` TEXT
)
BEGIN
	IF `@search_value` <> '' THEN
		SELECT 
			`p`.`id`,
			`p`.`firstname`,
			`p`.`lastname`,
			`p`.`middle_initial`,
			`p`.`address`,
			`p`.`age`,
            `p`.`gender`,
            `p`.`occupation`,
			CONCAT(`cc`.`firstname`,' ', `cc`.`lastname`)  `created_by`,
			`p`.`created_date`,
			CONCAT(`cu`.`firstname`,' ', `cu`.`lastname`) `updated_by`,
			`p`.`updated_date`
		FROM `dental_mis`.`patient` `p`
        LEFT JOIN `dental_mis`.`user` `cc` ON
        `cc`.`id` = `p`.`created_by`
		LEFT JOIN `dental_mis`.`user` `cu` ON
        `cu`.`id` = `p`.`updated_by`       
		WHERE (`p`.`firstname` LIKE CONCAT('%', `@search_value`, '%')) OR
			  (`p`.`lastname` LIKE CONCAT('%', `@search_value`, '%')) OR
			  (`p`.`address` LIKE CONCAT('%', `@search_value`, '%')) OR
              (`p`.`occupation` LIKE CONCAT('%', `@search_value`, '%'));
	ELSE
 		SELECT 
			`p`.`id`,
			`p`.`firstname`,
			`p`.`lastname`,
			`p`.`middle_initial`,
			`p`.`address`,
			`p`.`age`,
            `p`.`gender`,
            `p`.`occupation`,
			CONCAT(`cc`.`firstname`,' ', `cc`.`lastname`)  `created_by`,
			`p`.`created_date`,
			CONCAT(`cu`.`firstname`,' ', `cu`.`lastname`) `updated_by`,
			`p`.`updated_date`
		FROM `dental_mis`.`patient` `p`
        LEFT JOIN `dental_mis`.`user` `cc` ON
        `cc`.`id` = `p`.`created_by`
		LEFT JOIN `dental_mis`.`user` `cu` ON
        `cu`.`id` = `p`.`updated_by`;
    END IF;
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
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_payment_create`(IN
	`@procedure_id` BIGINT(8),
    `@amount_paid` FLOAT,
	`@date` NVARCHAR(10),
	`@created_by` VARCHAR(45)
)
BEGIN
	INSERT INTO `dental_mis`.`payment`
	(
		`procedure_id`,
        `amount_paid`,
		`date`,
		`created_by`,
		`created_date`
    )
	VALUES
	(
		`@procedure_id`,
        `@amount_paid`,
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
/*!50003 DROP PROCEDURE IF EXISTS `usp_payment_edit` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_payment_edit`(IN
	`@id` BIGINT(8),
	`@procedure_id` BIGINT(8),
    `@amount_paid` FLOAT,
    `@date` NVARCHAR(10),
	`@updated_by` VARCHAR(45)
)
BEGIN
	UPDATE `dental_mis`.`payment`
	SET
	`procedure_id` = `@procedure_id`,
    `amount_paid` = `@amount_paid`,
	`date` = `@date`,
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
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_payment_search_id`(IN
	`@id` BIGINT(8)
)
BEGIN
	SELECT `p`.`id`,
		`p`.`procedure_id`,
        `p`.`amount_paid`,
		`p`.`date`,
		CONCAT(`cc`.`firstname`,' ', `cc`.`lastname`)  `created_by`,
		`p`.`created_date`,
		CONCAT(`cu`.`firstname`,' ', `cu`.`lastname`) `updated_by`,
		`p`.`updated_date`
	FROM `dental_mis`.`payment` `p`
	LEFT JOIN `dental_mis`.`user` `cc` ON
	`cc`.`id` = `p`.`created_by`
	LEFT JOIN `dental_mis`.`user` `cu` ON
	`cu`.`id` = `p`.`updated_by`       
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
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_payment_search_procedure_id`(IN
	`@procedure_id` BIGINT(8)
)
BEGIN
	SELECT `p`.`id`,
		`p`.`procedure_id`,
        `p`.`amount_paid`,
		`p`.`date`,
		CONCAT(`cc`.`firstname`,' ', `cc`.`lastname`)  `created_by`,
		`p`.`created_date`,
		CONCAT(`cu`.`firstname`,' ', `cu`.`lastname`) `updated_by`,
		`p`.`updated_date`
	FROM `dental_mis`.`payment` `p`
	LEFT JOIN `dental_mis`.`user` `cc` ON
	`cc`.`id` = `p`.`created_by`
	LEFT JOIN `dental_mis`.`user` `cu` ON
	`cu`.`id` = `p`.`updated_by`    
	WHERE `procedure_id` = `@procedure_id`;
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
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_procedure_create`(IN
	`@patient_id` BIGINT(8),
	`@procedure_type_id` BIGINT(8),
    `@tooth_id` BIGINT(8),
    `@amount_to_pay` FLOAT,
	`@notes` TEXT,
    `@date` DATE,
	`@created_by` VARCHAR(45)
)
BEGIN
	INSERT INTO `dental_mis`.`procedure`
	(
		`patient_id`,
		`procedure_type_id`,
        `tooth_id`,
        `amount_to_pay`,
		`notes`,
		`date`,
		`created_by`,
		`created_date`
    )
	VALUES
	(
		`@patient_id`,
		`@procedure_type_id`,
        `@tooth_id`,
        `@amount_to_pay`,
		`@notes`,
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
/*!50003 DROP PROCEDURE IF EXISTS `usp_procedure_edit` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_procedure_edit`(IN
	`@id` BIGINT(8),
	`@patient_id` BIGINT(8),
	`@procedure_type_id` BIGINT(8),
    `@tooth_id` BIGINT(8),
    `@amount_to_pay` FLOAT,
	`@notes` TEXT,
	`@date` DATE,
	`@updated_by` VARCHAR(45)
)
BEGIN
	UPDATE `dental_mis`.`procedure`
	SET
	`patient_id` = `@patient_id`,
	`procedure_type_id` = `@procedure_type_id`,
    `tooth_id` = `@tooth_id`,
    `amount_to_pay` = `@amount_to_pay`,
	`notes` = `@notes`,
	`date` = `@date`,
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
/*!50003 DROP PROCEDURE IF EXISTS `usp_procedure_payment_search_like` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_procedure_payment_search_like`(in
	`@search_text` TEXT
)
BEGIN
	IF `@search_text` <> '' THEN
    
	SELECT 
		`pv`.`id`,
		`pv`.`patient_id`,
		`pv`.`procedure_type_id`,
		`pv`.`full_name`,
        `pv`.`age`,
        `pv`.`address`,
        `pv`.`gender`,
		`pv`.`procedure_name`,
		`pv`.`tooth_number`,
		`pv`.`tooth`,
		`pv`.`notes`,
		`pv`.`procedure_date`,
		`pv`.`amount_to_pay`,
		`pv`.`amount_paid`,
		`pv`.`balance`,
		`pv`.`payment_status`,
		`pv`.`procedure_created_by`,
		`pv`.`procedure_created_date`,
		`pv`.`procedure_updated_by`,
		`pv`.`procedure_updated_date`,
		`pv`.`payment_created_by`,
		`pv`.`payment_created_date`,
		`pv`.`payment_updated_by`,
		`pv`.`payment_updated_date`
	FROM `dental_mis`.`procedure_view` `pv`
    WHERE
		`pv`.`payment_status` <> 'Paid' AND
		`pv`.`full_name` LIKE CONCAT('%', `@search_text`, '%')
    ORDER BY `pv`.`procedure_date` DESC;
    ELSE
		SELECT 
			`pv`.`id`,
			`pv`.`patient_id`,
			`pv`.`procedure_type_id`,
			`pv`.`full_name`,
            `pv`.`age`,
			`pv`.`address`,
			`pv`.`gender`,
			`pv`.`procedure_name`,
			`pv`.`tooth_number`,
			`pv`.`tooth`,
			`pv`.`notes`,
			`pv`.`procedure_date`,
			`pv`.`amount_to_pay`,
			`pv`.`amount_paid`,
			`pv`.`balance`,
			`pv`.`payment_status`,
			`pv`.`procedure_created_by`,
			`pv`.`procedure_created_date`,
			`pv`.`procedure_updated_by`,
			`pv`.`procedure_updated_date`,
			`pv`.`payment_created_by`,
			`pv`.`payment_created_date`,
			`pv`.`payment_updated_by`,
			`pv`.`payment_updated_date`
		FROM `dental_mis`.`procedure_view` `pv`
		WHERE
			`pv`.`payment_status` <> 'Paid'
		ORDER BY `pv`.`procedure_date` DESC;
    END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_procedure_payment_search_report` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_procedure_payment_search_report`(in
	`@payment_status` TEXT,
    `@from` NVARCHAR(20),
    `@to` NVARCHAR(20)
)
BEGIN

	IF `@payment_status` <> '' THEN
    
		SELECT 
			`pv`.`id`,
			`pv`.`patient_id`,
			`pv`.`procedure_type_id`,
			`pv`.`full_name`,
			`pv`.`age`,
			`pv`.`address`,
			`pv`.`gender`,
			`pv`.`procedure_name`,
			`pv`.`tooth_number`,
			`pv`.`tooth`,
			`pv`.`notes`,
			`pv`.`procedure_date`,
			`pv`.`amount_to_pay`,
			`pv`.`amount_paid`,
			`pv`.`balance`,
			`pv`.`payment_status`,
			`pv`.`procedure_created_by`,
			`pv`.`procedure_created_date`,
			`pv`.`procedure_updated_by`,
			`pv`.`procedure_updated_date`,
			`pv`.`payment_created_by`,
			`pv`.`payment_created_date`,
			`pv`.`payment_updated_by`,
			`pv`.`payment_updated_date`
		FROM `dental_mis`.`procedure_view` `pv`
		WHERE `pv`.`payment_status` = `@payment_status` AND
			   DATE_FORMAT(`pv`.`procedure_date`, '%Y-%m-%d') BETWEEN `@from` AND `@to`
    ORDER BY `pv`.`procedure_date` DESC;
	ELSE
		SELECT 
			`pv`.`id`,
			`pv`.`patient_id`,
			`pv`.`procedure_type_id`,
			`pv`.`full_name`,
			`pv`.`age`,
			`pv`.`address`,
			`pv`.`gender`,
			`pv`.`procedure_name`,
			`pv`.`tooth_number`,
			`pv`.`tooth`,
			`pv`.`notes`,
			`pv`.`procedure_date`,
			`pv`.`amount_to_pay`,
			`pv`.`amount_paid`,
			`pv`.`balance`,
			`pv`.`payment_status`,
			`pv`.`procedure_created_by`,
			`pv`.`procedure_created_date`,
			`pv`.`procedure_updated_by`,
			`pv`.`procedure_updated_date`,
			`pv`.`payment_created_by`,
			`pv`.`payment_created_date`,
			`pv`.`payment_updated_by`,
			`pv`.`payment_updated_date`
		FROM `dental_mis`.`procedure_view` `pv`
		WHERE DATE_FORMAT(`pv`.`procedure_date`, '%Y-%m-%d') BETWEEN `@from` AND `@to`;
    END IF;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_procedure_payment_search_status` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_procedure_payment_search_status`(in
	`@payment_status` TEXT
)
BEGIN
	SELECT 
		`pv`.`id`,
		`pv`.`patient_id`,
		`pv`.`procedure_type_id`,
		`pv`.`full_name`,
		`pv`.`age`,
		`pv`.`address`,
		`pv`.`gender`,
		`pv`.`procedure_name`,
		`pv`.`tooth_number`,
		`pv`.`tooth`,
		`pv`.`notes`,
		`pv`.`procedure_date`,
		`pv`.`amount_to_pay`,
		`pv`.`amount_paid`,
		`pv`.`balance`,
		`pv`.`payment_status`,
		`pv`.`procedure_created_by`,
		`pv`.`procedure_created_date`,
		`pv`.`procedure_updated_by`,
		`pv`.`procedure_updated_date`,
		`pv`.`payment_created_by`,
		`pv`.`payment_created_date`,
		`pv`.`payment_updated_by`,
		`pv`.`payment_updated_date`
	FROM `dental_mis`.`procedure_view` `pv`
    WHERE `pv`.`payment_status` = `@payment_status`
    ORDER BY `pv`.`procedure_date` DESC;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_procedure_payment_status` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_procedure_payment_status`(in
	`@payment_status` TEXT
)
BEGIN
	SELECT 
		`pv`.`id`,
		`pv`.`patient_id`,
		`pv`.`procedure_type_id`,
		`pv`.`full_name`,
		`pv`.`age`,
		`pv`.`address`,
		`pv`.`gender`,
		`pv`.`procedure_name`,
		`pv`.`tooth_number`,
		`pv`.`tooth`,
		`pv`.`notes`,
		`pv`.`procedure_date`,
		`pv`.`amount_to_pay`,
		`pv`.`amount_paid`,
		`pv`.`balance`,
		`pv`.`payment_status`,
        `pv`.`payment_date`,
		`pv`.`procedure_created_by`,
		`pv`.`procedure_created_date`,
		`pv`.`procedure_updated_by`,
		`pv`.`procedure_updated_date`,
		`pv`.`payment_created_by`,
		`pv`.`payment_created_date`,
		`pv`.`payment_updated_by`,
		`pv`.`payment_updated_date`
	FROM `dental_mis`.`procedure_view` `pv`
    WHERE `pv`.`payment_status` = `@payment_status`
    ORDER BY `pv`.`procedure_date` DESC;

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
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_procedure_search_id`(IN
	`@id` BIGINT(8)
)
BEGIN
	SELECT 
		`pv`.`id`,
		`pv`.`patient_id`,
		`pv`.`procedure_type_id`,
		`pv`.`full_name`,
		`pv`.`age`,
		`pv`.`address`,
		`pv`.`gender`,
		`pv`.`procedure_name`,
		`pv`.`tooth_number`,
		`pv`.`tooth`,
		`pv`.`notes`,
		`pv`.`procedure_date`,
		`pv`.`amount_to_pay`,
		`pv`.`amount_paid`,
		`pv`.`balance`,
		`pv`.`payment_status`,
        `pv`.`payment_date`,
		`pv`.`procedure_created_by`,
		`pv`.`procedure_created_date`,
		`pv`.`procedure_updated_by`,
		`pv`.`procedure_updated_date`,
		`pv`.`payment_created_by`,
		`pv`.`payment_created_date`,
		`pv`.`payment_updated_by`,
		`pv`.`payment_updated_date`
	FROM `dental_mis`.`procedure_view` `pv`
    WHERE `pv`.`id` = `@id`
    ORDER BY `pv`.`procedure_created_by` DESC;
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
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_procedure_search_patient_id`(IN
	`@patient_id` BIGINT(8),
    `@tooth_number` nvarchar(8),
    `@from` nvarchar(10),
    `@to` nvarchar(10)
)
BEGIN

IF `@tooth_number` <> '' THEN
	SET @where = CONCAT('WHERE `pv`.`patient_id` = ''', `@patient_id`, ''' AND `pv`.`tooth_number` = ''', `@tooth_number`, '''');
ELSEIF `@tooth_number` = '' AND `@from` = '' AND `@to` = '' THEN
	SET @where = CONCAT('WHERE `pv`.`patient_id` = ''', `@patient_id`, '''');
ELSE
	SET @where = CONCAT('WHERE `pv`.`patient_id` = ''', `@patient_id`, ''' AND `pv`.`procedure_date` BETWEEN ''', `@from`, ''' AND ''', `@to`, '''');
END IF;


SET @queryString = CONCAT('SELECT 
						`pv`.`id`,
						`pv`.`patient_id`,
						`pv`.`procedure_type_id`,
						`pv`.`full_name`,
						`pv`.`age`,
						`pv`.`address`,
						`pv`.`gender`,
						`pv`.`procedure_name`,
						`pv`.`tooth_number`,
						`pv`.`tooth`,
						`pv`.`notes`,
						`pv`.`procedure_date`,
						`pv`.`amount_to_pay`,
						`pv`.`amount_paid`,
						`pv`.`balance`,
						`pv`.`payment_status`,
						`pv`.`payment_date`,
						`pv`.`procedure_created_by`,
						`pv`.`procedure_created_date`,
						`pv`.`procedure_updated_by`,
						`pv`.`procedure_updated_date`,
						`pv`.`payment_created_by`,
						`pv`.`payment_created_date`,
						`pv`.`payment_updated_by`,
						`pv`.`payment_updated_date`
					FROM `dental_mis`.`procedure_view` `pv` ', @where, ' ORDER BY `pv`.`procedure_created_date` DESC');
                    
PREPARE myquery FROM @queryString;
EXECUTE myquery;
                
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_procedure_search_procedure_id` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_procedure_search_procedure_id`(IN
	`@procedure_type_id` BIGINT(8)
)
BEGIN
	SELECT 
		`pv`.`id`,
		`pv`.`patient_id`,
		`pv`.`procedure_type_id`,
		`pv`.`full_name`,
		`pv`.`age`,
		`pv`.`address`,
		`pv`.`gender`,
		`pv`.`procedure_name`,
		`pv`.`tooth_number`,
		`pv`.`tooth`,
		`pv`.`notes`,
		`pv`.`procedure_date`,
		`pv`.`amount_to_pay`,
		`pv`.`amount_paid`,
		`pv`.`balance`,
		`pv`.`payment_status`,
        `pv`.`payment_date`,
		`pv`.`procedure_created_by`,
		`pv`.`procedure_created_date`,
		`pv`.`procedure_updated_by`,
		`pv`.`procedure_updated_date`,
		`pv`.`payment_created_by`,
		`pv`.`payment_created_date`,
		`pv`.`payment_updated_by`,
		`pv`.`payment_updated_date`
	FROM `dental_mis`.`procedure_view` `pv`
    WHERE `pv`.`id` = `@id`
    ORDER BY `pv`.`procedure_created_by` DESC;
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
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
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
/*!50003 DROP PROCEDURE IF EXISTS `usp_procedure_type_not_allowed_create` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_procedure_type_not_allowed_create`(IN
	`@procedure_type_id` BIGINT,
    `@procedure_type_id_not_allowed` BIGINT,
    `@status` BOOLEAN,
    `@created_by` NVARCHAR(45)
)
BEGIN
	DECLARE `@if_exist` INT;
    SET `@if_exist` = (SELECT 1 FROM `dental_mis`.`procedure_type_not_allowed` WHERE
						`procedure_type_id` = `@procedure_type_id` AND
                        `procedure_type_id_not_allowed` = `@procedure_type_id_not_allowed` AND
                        `status` = `@status`);
                        
	IF `@if_exist` = 1 THEN
		SELECT 0;
	ELSE
		INSERT INTO `dental_mis`.`procedure_type_not_allowed`
		(`procedure_type_id`,
		`procedure_type_id_not_allowed`,
        `status`,
		`created_by`)
		VALUES
		(`@procedure_type_id`,
		`@procedure_type_id_not_allowed`,
        `@status`,
		`@created_by`);

		
		SELECT LAST_INSERT_ID();
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_procedure_type_not_allowed_edit` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_procedure_type_not_allowed_edit`(IN
	`@id` BIGINT,
	`@procedure_type_id` BIGINT,
    `@procedure_type_id_not_allowed` BIGINT,
    `@status` BOOLEAN,
    `@updated_by` NVARCHAR(45)
)
BEGIN
	UPDATE `dental_mis`.`procedure_type_not_allowed`
	SET
	`procedure_type_id` = `@procedure_type_id`,
	`procedure_type_id_not_allowed` = `@procedure_type_id_not_allowed`,
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
/*!50003 DROP PROCEDURE IF EXISTS `usp_procedure_type_not_allowed_select` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_procedure_type_not_allowed_select`(IN
	`@procedure_id` BIGINT 
)
BEGIN
	SELECT
		`ptn`.`id`,
		`ptn`.`procedure_type_id`,
		`ptn`.`procedure_type_id_not_allowed`,
        `pt`.`name`,
        `ptn`.`status`,
		CONCAT(`cc`.`firstname`,' ', `cc`.`lastname`)  `created_by`,
		`ptn`.`created_date`,
		CONCAT(`cu`.`firstname`,' ', `cu`.`lastname`) `updated_by`,
		`ptn`.`updated_date`
	FROM `dental_mis`.`procedure_type_not_allowed` `ptn`
    LEFT JOIN `dental_mis`.`procedure_type` `pt`
    ON `ptn`.`procedure_type_id_not_allowed` = `pt`.`id`
	LEFT JOIN `dental_mis`.`user` `cc` ON
	`cc`.`id` = `ptn`.`created_by`
	LEFT JOIN `dental_mis`.`user` `cu` ON
	`cu`.`id` = `ptn`.`updated_by`      
    WHERE `ptn`.`procedure_type_id` = `@procedure_id`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_procedure_type_not_allowed_select_id` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_procedure_type_not_allowed_select_id`(IN
	`@id` BIGINT 
)
BEGIN
	SELECT
		`ptn`.`id`,
		`ptn`.`procedure_type_id`,
		`ptn`.`procedure_type_id_not_allowed`,
        `pt`.`name`,
        `ptn`.`status`,
		CONCAT(`cc`.`firstname`,' ', `cc`.`lastname`)  `created_by`,
		`ptn`.`created_date`,
		CONCAT(`cu`.`firstname`,' ', `cu`.`lastname`) `updated_by`,
		`ptn`.`updated_date`
	FROM `dental_mis`.`procedure_type_not_allowed` `ptn`
    LEFT JOIN `dental_mis`.`procedure_type` `pt`
    ON `ptn`.`procedure_type_id_not_allowed` = `pt`.`id`
	LEFT JOIN `dental_mis`.`user` `cc` ON
	`cc`.`id` = `ptn`.`created_by`
	LEFT JOIN `dental_mis`.`user` `cu` ON
	`cu`.`id` = `ptn`.`updated_by`      
    WHERE `pt`.`status` = true AND
		  `ptn`.`id` = `@id`;

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
	SELECT `pt`.`id`,
		`pt`.`name`,
		`pt`.`base_price`,
		`pt`.`payment_type`,
		IF(`pt`.`require_med_cert` = 1, 'Yes','No') `require_med_cert`,
		IF(`pt`.`status`,'Active', 'Not Active') `status`,
		CONCAT(`cc`.`firstname`,' ', `cc`.`lastname`)  `created_by`,
		`pt`.`created_date`,
		CONCAT(`cu`.`firstname`,' ', `cu`.`lastname`) `updated_by`,
		`pt`.`updated_date`
	FROM `dental_mis`.`procedure_type` `pt`
	LEFT JOIN `dental_mis`.`user` `cc` ON
	`cc`.`id` = `pt`.`created_by`
	LEFT JOIN `dental_mis`.`user` `cu` ON
	`cu`.`id` = `pt`.`updated_by`    
    WHERE `pt`.`id` = `@id`;
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
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_procedure_type_search_like`(IN
	`@search_text` TEXT
)
BEGIN
	IF `@search_text` <> '' THEN
		SELECT `pt`.`id`,
			`pt`.`name`,
			`pt`.`base_price`,
			`pt`.`payment_type`,
			IF(`pt`.`require_med_cert` = 1, 'Yes','No') `require_med_cert`,
			IF(`pt`.`status`,'Active', 'Not Active') `status`,
			CONCAT(`cc`.`firstname`,' ', `cc`.`lastname`)  `created_by`,
			`pt`.`created_date`,
			CONCAT(`cu`.`firstname`,' ', `cu`.`lastname`) `updated_by`,
			`pt`.`updated_date`
		FROM `dental_mis`.`procedure_type` `pt`
		LEFT JOIN `dental_mis`.`user` `cc` ON
		`cc`.`id` = `pt`.`created_by`
		LEFT JOIN `dental_mis`.`user` `cu` ON
		`cu`.`id` = `pt`.`updated_by`  
		WHERE (`pt`.`name` LIKE CONCAT('%', `@search_text`, '%')) OR
			  (`pt`.`payment_type` LIKE CONCAT('%', `@search_text`, '%'));
	ELSE 
		SELECT `pt`.`id`,
			`pt`.`name`,
			`pt`.`base_price`,
			`pt`.`payment_type`,
			IF(`pt`.`require_med_cert` = 1, 'Yes','No') `require_med_cert`,
			IF(`pt`.`status`,'Active', 'Not Active') `status`,
			CONCAT(`cc`.`firstname`,' ', `cc`.`lastname`)  `created_by`,
			`pt`.`created_date`,
			CONCAT(`cu`.`firstname`,' ', `cu`.`lastname`) `updated_by`,
			`pt`.`updated_date`
		FROM `dental_mis`.`procedure_type` `pt`
		LEFT JOIN `dental_mis`.`user` `cc` ON
		`cc`.`id` = `pt`.`created_by`
		LEFT JOIN `dental_mis`.`user` `cu` ON
		`cu`.`id` = `pt`.`updated_by`;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_procedure_type_search_tooth` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_procedure_type_search_tooth`(IN
	`@patiend_id` BIGINT,
    `@tooth_number` INT
)
BEGIN

		SELECT `pt`.`id`,
			`pt`.`name`,
			`pt`.`base_price`,
			`pt`.`payment_type`,
			IF(`pt`.`require_med_cert` = 1, 'Yes','No') `require_med_cert`,
			IF(`pt`.`status`,'Active', 'Not Active') `status`,
			CONCAT(`cc`.`firstname`,' ', `cc`.`lastname`)  `created_by`,
			`pt`.`created_date`,
			CONCAT(`cu`.`firstname`,' ', `cu`.`lastname`) `updated_by`,
			`pt`.`updated_date`
		FROM `dental_mis`.`procedure_type` `pt`
		LEFT JOIN `dental_mis`.`user` `cc` ON
		`cc`.`id` = `pt`.`created_by`
		LEFT JOIN `dental_mis`.`user` `cu` ON
		`cu`.`id` = `pt`.`updated_by`  
        WHERE `pt`.`id` NOT IN(
											SELECT pt.id FROM dental_mis.procedure_type pt
											LEFT JOIN dental_mis.procedure_type_not_allowed ptn
											ON pt.id = ptn.procedure_type_id_not_allowed
											WHERE ptn.status = true AND
												  ptn.procedure_type_id IN(SELECT procedure_type_id 
																		   FROM dental_mis.procedure_view 
																		   WHERE patient_id = `@patiend_id` AND 
																				 tooth_number = `@tooth_number`));
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_schedule_create` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_schedule_create`(in
	`@title` TEXT,
    `@description` TEXT,
    `@start_time` NVARCHAR(20),
    `@end_time` NVARCHAR(20),
    `@background_color` NVARCHAR(20),
    `@created_by` NVARCHAR(20)
)
BEGIN
	INSERT INTO `dental_mis`.`schedule`
	(`title`,
	`description`,
	`start_time`,
	`end_time`,
    `background_color`,
	`created_by`,
	`created_date`)
	VALUES
	(`@title`,
	`@description`,
	`@start_time`,
	`@end_time`,
    `@background_color`,
	`@created_by`,
	NOW());
	
    SELECT LAST_INSERT_ID();
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_schedule_edit` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_schedule_edit`(in
	`@id` BIGINT,
	`@title` TEXT,
    `@description` TEXT,
    `@start_time` NVARCHAR(20),
    `@end_time` NVARCHAR(20),
    `@background_color` NVARCHAR(45),
    `@is_deleted` BOOLEAN,
    `@updated_by` NVARCHAR(20)
)
BEGIN
	UPDATE `dental_mis`.`schedule`
	SET
	`title` = `@title`,
	`description` = `@description`,
	`start_time` = `@start_time`,
	`end_time` = `@end_time`,
    `background_color` = `@background_color`,
    `is_deleted` = `@is_deleted`,
	`updated_by` = `@end_time`,
	`updated_date` = NOW()
	WHERE `id` = `@id`;

    SELECT `@id`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_schedule_select` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_schedule_select`(in
	`@date` NVARCHAR(20)
)
BEGIN
    SELECT @r := @r+1 `index` , z.* FROM(
		SELECT `s`.`id`,
			`s`.`title`,
			`s`.`description`,
			`s`.`start_time`,
			`s`.`end_time`,
			`s`.`background_color`,
            `s`.`is_deleted`,
			CONCAT(`cc`.`firstname`,' ', `cc`.`lastname`)  `created_by`,
			`s`.`created_date`,
			CONCAT(`cu`.`firstname`,' ', `cu`.`lastname`) `updated_by`,
			`s`.`updated_date`
		FROM `dental_mis`.`schedule` `s`
		LEFT JOIN `dental_mis`.`user` `cc` ON
		`cc`.`id` = `s`.`created_by`
		LEFT JOIN `dental_mis`.`user` `cu` ON
		`cu`.`id` = `s`.`updated_by`  
		WHERE DATE_FORMAT(`s`.`start_time`, '%Y-%m-%d') = `@date` AND
			  Not `s`.`is_deleted`
        ORDER BY `s`.`start_time` ASC
	)z, (SELECT @r:=0)y;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_schedule_select_report` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_schedule_select_report`(in
	`@from` NVARCHAR(20),
    `@to` NVARCHAR(20)
)
BEGIN
    SELECT @r := @r+1 `index` , z.* FROM(
		SELECT `s`.`id`,
			`s`.`title`,
			`s`.`description`,
			`s`.`start_time`,
			`s`.`end_time`,
			`s`.`background_color`,
            `s`.`is_deleted`,
			CONCAT(`cc`.`firstname`,' ', `cc`.`lastname`)  `created_by`,
			`s`.`created_date`,
			CONCAT(`cu`.`firstname`,' ', `cu`.`lastname`) `updated_by`,
			`s`.`updated_date`
		FROM `dental_mis`.`schedule` `s`
		LEFT JOIN `dental_mis`.`user` `cc` ON
		`cc`.`id` = `s`.`created_by`
		LEFT JOIN `dental_mis`.`user` `cu` ON
		`cu`.`id` = `s`.`updated_by`  
		WHERE DATE_FORMAT(`s`.`start_time`, '%Y-%m-%d') = `@date` AND
			  Not `s`.`is_deleted`
        ORDER BY `s`.`start_time` ASC
	)z, (SELECT @r:=0)y;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_secret_question_create` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_secret_question_create`(IN
	`@question` TEXT,
    `@created_by` NVARCHAR(45)
)
BEGIN

	DECLARE `@if_exist` INT;
    SET `@if_exist` = (SELECT 1 FROM `dental_mis`.`secret_question` WHERE
                       `secret_question`.`question` = `@question`);
                       
	IF `@if_exist` = 1 THEN
		SELECT 0;
	ELSE
    	INSERT INTO `dental_mis`.`secret_question`
		(`question`,
		`created_by`,
		`created_date`)
		VALUES
		(`@question`,
		`@created_by`,
		NOW());
        
        SELECT LAST_INSERT_ID();
    END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_secret_question_edit` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_secret_question_edit`(IN
	`@id` BIGINT,
	`@question` TEXT,
    `@updated_by` NVARCHAR(45)
)
BEGIN

	UPDATE `dental_mis`.`secret_question`
	SET
	`question` = `@question`,
	`updated_by` =`@updated_by`,
	`updated_date` = NOW()
	WHERE `id` = `@id`;

	SELECT `@id`;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_secret_question_select` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_secret_question_select`(IN
	`@search_text` TEXT
)
BEGIN
	IF `@search_text` <> '' THEN
		SELECT 
			`sq`.`id`,
			`sq`.`question`,
			CONCAT(`cc`.`firstname`,' ', `cc`.`lastname`)  `created_by`,
			`sq`.`created_date`,
			CONCAT(`cu`.`firstname`,' ', `cu`.`lastname`) `updated_by`,
			`sq`.`updated_date`
		FROM `dental_mis`.`secret_question` `sq`
		LEFT JOIN `dental_mis`.`user` `cc` ON
		`cc`.`id` = `sq`.`created_by`
		LEFT JOIN `dental_mis`.`user` `cu` ON
		`cu`.`id` = `sq`.`updated_by`
		WHERE (`sq`.`question` LIKE CONCAT('%', `@search_text`, '%'));
	ELSE
	SELECT 
		`sq`.`id`,
		`sq`.`question`,
		CONCAT(`cc`.`firstname`,' ', `cc`.`lastname`)  `created_by`,
		`sq`.`created_date`,
		CONCAT(`cu`.`firstname`,' ', `cu`.`lastname`) `updated_by`,
		`sq`.`updated_date`
	FROM `dental_mis`.`secret_question` `sq`
	LEFT JOIN `dental_mis`.`user` `cc` ON
	`cc`.`id` = `sq`.`created_by`
	LEFT JOIN `dental_mis`.`user` `cu` ON
	`cu`.`id` = `sq`.`updated_by`;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `usp_secret_question_select_id` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_secret_question_select_id`(IN
	`@id` BIGINT
)
BEGIN
	SELECT 
		`sq`.`id`,
		`sq`.`question`,
		CONCAT(`cc`.`firstname`,' ', `cc`.`lastname`)  `created_by`,
		`sq`.`created_date`,
		CONCAT(`cu`.`firstname`,' ', `cu`.`lastname`) `updated_by`,
		`sq`.`updated_date`
	FROM `dental_mis`.`secret_question` `sq`
	LEFT JOIN `dental_mis`.`user` `cc` ON
	`cc`.`id` = `sq`.`created_by`
	LEFT JOIN `dental_mis`.`user` `cu` ON
	`cu`.`id` = `sq`.`updated_by`;
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
    `@secret_question_id` BIGINT,
	`@username` VARCHAR(45),
	`@password` VARCHAR(45),
    `@secret_question_answer` TEXT,
	`@firstname` VARCHAR(45),
	`@lastname` VARCHAR(45),
	`@status` TINYINT,
	`@created_by` VARCHAR(45)
)
BEGIN
	DECLARE `@exist` INT;
    SET `@exist` = (SELECT 1 FROM `dental_mis`.`user` 
					WHERE `user_type_id` = `@user_type_id` AND 
                          `secret_question_id` = `@secret_question_id` AND
                          `username` = `@username` AND
                          `firstname` = `@firstname` AND
                          `lastname` = `@lastname`);
	IF `@exist` = 1 THEN
		SELECT 0;
	ELSE
    
    	INSERT INTO `dental_mis`.`user`
		(
			`user_type_id`,
            `secret_question_id`,
			`username`,
			`password`,
            `secret_question_answer`,
			`firstname`,
			`lastname`,
			`status`,
			`created_by`,
			`created_date`
		)
		VALUES
		(
			`@user_type_id`,
            `@secret_question_id`,
			`@username`,
			`@password`,
            `@secret_question_answer`,
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
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_user_edit`(IN
	`@id` BIGINT(8),
	`@user_type_id` BIGINT(8),
    `@secret_question_id` BIGINT,
	`@username` VARCHAR(45),
	`@password` VARCHAR(45),
    `@secret_question_answer` TEXT,
	`@firstname` VARCHAR(45),
	`@lastname` VARCHAR(45),
	`@status` TINYINT,
	`@updated_by` VARCHAR(45)
)
BEGIN
	UPDATE `dental_mis`.`user`
	SET
	`user_type_id` = `@user_type_id`,
    `secret_question_id` = `@secret_question_id`,
	`username` = `@username`,
	`password` = `@password`,
    `secret_question_answer` = `@secret_question_answer`,
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
/*!50003 DROP PROCEDURE IF EXISTS `usp_user_forgot_password` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_user_forgot_password`(IN
	`@username` NVARCHAR(45),
    `@secret_question_id` BIGINT,
    `@secret_question_answer` TEXT
)
BEGIN
	SELECT `user_view`.`id`,
		`user_view`.`user_type_id`,
		`user_view`.`secret_question_id`,
		`user_view`.`user_type`,
		`user_view`.`username`,
		`user_view`.`password`,
		`user_view`.`secret_question`,
		`user_view`.`secret_question_answer`,
		`user_view`.`firstname`,
		`user_view`.`lastname`,
		`user_view`.`status`,
		`user_view`.`created_by`,
		`user_view`.`created_date`,
		`user_view`.`updated_by`,
		`user_view`.`updated_date`
	FROM `dental_mis`.`user_view`
    WHERE 
		`user_view`.`username` = `@username` AND
        `user_view`.`secret_question_id` = `@secret_question_id` AND
        `secret_question_answer` = `@secret_question_answer`;
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
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_user_login`(IN
	`@username` VARCHAR(45),
    `@password` VARCHAR(45)
)
BEGIN
	SELECT `user_view`.`id`,
		`user_view`.`user_type_id`,
		`user_view`.`secret_question_id`,
		`user_view`.`user_type`,
		`user_view`.`username`,
		`user_view`.`password`,
		`user_view`.`secret_question`,
		`user_view`.`secret_question_answer`,
		`user_view`.`firstname`,
		`user_view`.`lastname`,
		`user_view`.`status`,
		`user_view`.`created_by`,
		`user_view`.`created_date`,
		`user_view`.`updated_by`,
		`user_view`.`updated_date`
	FROM `dental_mis`.`user_view`
    WHERE `user_view`.`username` = `@username` AND
		  `user_view`.`password` = `@password` AND
          `user_view`.`status` = 1;
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
	SELECT `user_view`.`id`,
		`user_view`.`user_type_id`,
		`user_view`.`secret_question_id`,
		`user_view`.`user_type`,
		`user_view`.`username`,
		`user_view`.`password`,
		`user_view`.`secret_question`,
		`user_view`.`secret_question_answer`,
		`user_view`.`firstname`,
		`user_view`.`lastname`,
		`user_view`.`status`,
		`user_view`.`created_by`,
		`user_view`.`created_date`,
		`user_view`.`updated_by`,
		`user_view`.`updated_date`
	FROM `dental_mis`.`user_view`
    WHERE `user_view`.`id` = `@id`;
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
		SELECT `user_view`.`id`,
			`user_view`.`user_type_id`,
			`user_view`.`secret_question_id`,
			`user_view`.`user_type`,
			`user_view`.`username`,
			`user_view`.`password`,
			`user_view`.`secret_question`,
			`user_view`.`secret_question_answer`,
			`user_view`.`firstname`,
			`user_view`.`lastname`,
			`user_view`.`status`,
			`user_view`.`created_by`,
			`user_view`.`created_date`,
			`user_view`.`updated_by`,
			`user_view`.`updated_date`
		FROM `dental_mis`.`user_view`
		WHERE (`user_view`.`username` LIKE CONCAT('%', `@search_text`, '%')) OR
			  (`user_view`.`firstname` LIKE CONCAT('%', `@search_text`, '%')) OR
			  (`user_view`.`lastname` LIKE CONCAT('%', `@search_text`, '%'));
	ELSE
		SELECT `user_view`.`id`,
			`user_view`.`user_type_id`,
			`user_view`.`secret_question_id`,
			`user_view`.`user_type`,
			`user_view`.`username`,
			`user_view`.`password`,
			`user_view`.`secret_question`,
			`user_view`.`secret_question_answer`,
			`user_view`.`firstname`,
			`user_view`.`lastname`,
			`user_view`.`status`,
			`user_view`.`created_by`,
			`user_view`.`created_date`,
			`user_view`.`updated_by`,
			`user_view`.`updated_date`
		FROM `dental_mis`.`user_view`;
    END IF;
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

--
-- Final view structure for view `audit_trail_view`
--

/*!50001 DROP VIEW IF EXISTS `audit_trail_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `audit_trail_view` AS select `at`.`id` AS `id`,`at`.`action` AS `action`,concat(`u`.`firstname`,' ',`u`.`lastname`) AS `created_by`,`at`.`created_date` AS `created_date` from (`audit_trail` `at` left join `user` `u` on((`at`.`created_by` = `u`.`id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `procedure_view`
--

/*!50001 DROP VIEW IF EXISTS `procedure_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `procedure_view` AS select `p`.`id` AS `id`,`p`.`patient_id` AS `patient_id`,`p`.`procedure_type_id` AS `procedure_type_id`,concat(`pa`.`firstname`,' ',`pa`.`lastname`) AS `full_name`,`pa`.`age` AS `age`,`pa`.`address` AS `address`,`pa`.`gender` AS `gender`,`pt`.`name` AS `procedure_name`,`t`.`id` AS `tooth_number`,concat('Tooth ',`t`.`id`,' - ',`t`.`description`) AS `tooth`,`p`.`notes` AS `notes`,`p`.`date` AS `procedure_date`,if(isnull(`p`.`amount_to_pay`),0,`p`.`amount_to_pay`) AS `amount_to_pay`,if(isnull(`py`.`amount_paid`),0,`py`.`amount_paid`) AS `amount_paid`,if(isnull(`py`.`amount_paid`),`p`.`amount_to_pay`,(`p`.`amount_to_pay` - `py`.`amount_paid`)) AS `balance`,if((`p`.`amount_to_pay` <> if(isnull(`py`.`amount_paid`),0,`py`.`amount_paid`)),'Not Paid','Paid') AS `payment_status`,`py`.`date` AS `payment_date`,concat(`cc`.`firstname`,' ',`cc`.`lastname`) AS `procedure_created_by`,`p`.`created_date` AS `procedure_created_date`,concat(`cu`.`firstname`,' ',`cu`.`lastname`) AS `procedure_updated_by`,`p`.`updated_date` AS `procedure_updated_date`,concat(`pc`.`firstname`,' ',`pc`.`lastname`) AS `payment_created_by`,`py`.`created_date` AS `payment_created_date`,concat(`pu`.`firstname`,' ',`pu`.`lastname`) AS `payment_updated_by`,`py`.`updated_date` AS `payment_updated_date` from ((((((((`dental_mis`.`procedure` `p` left join `dental_mis`.`procedure_type` `pt` on((`p`.`procedure_type_id` = `pt`.`id`))) left join `dental_mis`.`tooth` `t` on((`p`.`tooth_id` = `t`.`id`))) left join (select `dental_mis`.`payment`.`id` AS `id`,`dental_mis`.`payment`.`procedure_id` AS `procedure_id`,sum(`dental_mis`.`payment`.`amount_paid`) AS `amount_paid`,`dental_mis`.`payment`.`date` AS `date`,`dental_mis`.`payment`.`created_by` AS `created_by`,`dental_mis`.`payment`.`created_date` AS `created_date`,`dental_mis`.`payment`.`updated_by` AS `updated_by`,`dental_mis`.`payment`.`updated_date` AS `updated_date` from `dental_mis`.`payment` group by `dental_mis`.`payment`.`procedure_id`) `py` on((`py`.`procedure_id` = `p`.`id`))) left join `dental_mis`.`patient` `pa` on((`p`.`patient_id` = `pa`.`id`))) left join `dental_mis`.`user` `cc` on((`cc`.`id` = `p`.`created_by`))) left join `dental_mis`.`user` `cu` on((`cu`.`id` = `p`.`updated_by`))) left join `dental_mis`.`user` `pc` on((`pc`.`id` = `py`.`created_by`))) left join `dental_mis`.`user` `pu` on((`pu`.`id` = `py`.`updated_by`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `user_view`
--

/*!50001 DROP VIEW IF EXISTS `user_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `user_view` AS select `u`.`id` AS `id`,`u`.`user_type_id` AS `user_type_id`,`u`.`secret_question_id` AS `secret_question_id`,`ut`.`name` AS `user_type`,`u`.`username` AS `username`,`u`.`password` AS `password`,`sc`.`question` AS `secret_question`,`u`.`secret_question_answer` AS `secret_question_answer`,`u`.`firstname` AS `firstname`,`u`.`lastname` AS `lastname`,`u`.`status` AS `status`,concat(`usrc`.`firstname`,' ',`usrc`.`lastname`) AS `created_by`,`u`.`created_date` AS `created_date`,concat(`usru`.`firstname`,' ',`usru`.`lastname`) AS `updated_by`,`u`.`updated_date` AS `updated_date` from ((((`user` `u` left join `user_type` `ut` on((`u`.`user_type_id` = `ut`.`id`))) left join `secret_question` `sc` on((`u`.`secret_question_id` = `sc`.`id`))) left join `user` `usrc` on((`usrc`.`id` = `u`.`created_by`))) left join `user` `usru` on((`usru`.`id` = `u`.`updated_by`))) */;
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

-- Dump completed on 2018-03-05  0:37:20
