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
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `audit_trail`
--

LOCK TABLES `audit_trail` WRITE;
/*!40000 ALTER TABLE `audit_trail` DISABLE KEYS */;
/*!40000 ALTER TABLE `audit_trail` ENABLE KEYS */;
UNLOCK TABLES;

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
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patient`
--

LOCK TABLES `patient` WRITE;
/*!40000 ALTER TABLE `patient` DISABLE KEYS */;
INSERT INTO `patient` VALUES (1,'Test','Test','Y','Test',5,'Male','Test','Super Admin','2017-11-12 15:55:24','Super Admin','2018-02-08 19:21:12'),(2,'Test','Test','TEST','Qweqrq Qweqwe Qwe',15,'Male','test','Super Admin','2017-11-20 23:41:24',NULL,NULL),(3,'Test','Test','MI','Test',15,'Male','test','Super Admin','2017-11-20 23:43:33',NULL,NULL),(4,'testasd','testasd','testasd','testasd',10,'Male','testasd','testasd','2018-01-29 21:02:03',NULL,NULL),(5,'Qweqwr','Qweqwre','q','Qwe',15,'Male','qweqrq','Super Admin','2018-01-29 21:06:11','Super Admin','2018-01-29 22:47:49'),(6,'Asdasd','Qweqwe','Q','Qweqw',4,'Male','qweqweq','Super Admin','2018-02-08 18:43:21',NULL,NULL);
/*!40000 ALTER TABLE `patient` ENABLE KEYS */;
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
  `amount_paid` float DEFAULT NULL,
  `date` date DEFAULT NULL,
  `created_by` varchar(45) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `updated_by` varchar(45) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payment`
--

LOCK TABLES `payment` WRITE;
/*!40000 ALTER TABLE `payment` DISABLE KEYS */;
INSERT INTO `payment` VALUES (1,1,200,'2018-02-06','admin','2018-02-06 00:51:36',NULL,NULL),(2,1,200,'2018-02-06','admin','2018-02-06 00:51:46',NULL,NULL),(3,2,200,'2018-02-06','admin','2018-02-06 00:54:16',NULL,NULL),(4,2,300,'2018-02-06','admin','2018-02-06 01:01:32',NULL,NULL),(5,2,50,'2018-02-06','admin','2018-02-06 01:03:00',NULL,NULL);
/*!40000 ALTER TABLE `payment` ENABLE KEYS */;
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
  `tooth_id` bigint(8) DEFAULT NULL,
  `amount_to_pay` float DEFAULT NULL,
  `notes` text,
  `date` date DEFAULT NULL,
  `created_by` varchar(45) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `updated_by` varchar(45) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `procedure`
--

LOCK TABLES `procedure` WRITE;
/*!40000 ALTER TABLE `procedure` DISABLE KEYS */;
INSERT INTO `procedure` VALUES (1,1,2,2,500,'test','2018-02-06','Super Admin','2018-02-06 00:36:08',NULL,NULL),(2,1,1,2,550,'test2','2018-02-06','Super Admin','2018-02-06 00:54:05',NULL,NULL),(3,1,3,1,123,'test','2018-02-07','Super Admin','2018-02-07 02:25:33',NULL,NULL),(4,1,2,2,500,'test','2018-02-07','Super Admin','2018-02-07 02:57:47',NULL,NULL);
/*!40000 ALTER TABLE `procedure` ENABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `procedure_type`
--

LOCK TABLES `procedure_type` WRITE;
/*!40000 ALTER TABLE `procedure_type` DISABLE KEYS */;
INSERT INTO `procedure_type` VALUES (1,'Extraction',500,'Full Payment',1,1,'Test User','2017-09-10 22:01:12','Super Admin','2018-02-08 18:47:17'),(2,'Pasta',500,'Full Payment',0,1,'Service Account','2017-09-24 12:42:52',NULL,NULL),(3,'test123',123,'Full Payment',1,1,'Service Account','2017-09-24 13:06:19','Main Menu','2017-10-13 00:06:06'),(4,'Extraction1',550,'Full Payment',1,1,'Service Account','2017-10-05 20:41:05',NULL,NULL),(5,'Extraction444',550,'Full Payment',1,1,'Service Account','2017-10-05 20:50:47','Main Menu','2017-10-13 00:01:56'),(6,'Test2',123,'Full Payment',1,1,'Service Account','2017-10-05 20:52:04','Main Menu','2017-10-13 00:05:30'),(7,'test3',111,'Full Payment',1,1,'Service Account','2017-10-05 20:53:01',NULL,NULL),(8,'Extraction1',550,'Full Payment',1,1,'Main Menu','2017-10-12 23:58:05','Main Menu','2017-10-12 23:58:24'),(9,'testqwe',150,'Full Payment',1,1,'Super Admin','2017-11-20 23:44:24',NULL,NULL);
/*!40000 ALTER TABLE `procedure_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `procedure_view`
--

DROP TABLE IF EXISTS `procedure_view`;
/*!50001 DROP VIEW IF EXISTS `procedure_view`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
CREATE 
    ALGORITHM = UNDEFINED 
    DEFINER = `root`@`localhost` 
    SQL SECURITY DEFINER
VIEW `procedure_view` AS
    SELECT 
        `p`.`id` AS `id`,
        `p`.`patient_id` AS `patient_id`,
        `p`.`procedure_type_id` AS `procedure_type_id`,
        CONCAT(`pa`.`firstname`, ' ', `pa`.`lastname`) AS `full_name`,
        `pt`.`name` AS `procedure_name`,
        `t`.`id` AS `tooth_number`,
        CONCAT('Tooth ',
                `t`.`id`,
                ' - ',
                `t`.`description`) AS `tooth`,
        `p`.`notes` AS `notes`,
        `p`.`date` AS `procedure_date`,
        IF(ISNULL(`p`.`amount_to_pay`),
            0,
            `p`.`amount_to_pay`) AS `amount_to_pay`,
        IF(ISNULL(`py`.`amount_paid`),
            0,
            `py`.`amount_paid`) AS `amount_paid`,
        IF(ISNULL(`py`.`amount_paid`),
            `p`.`amount_to_pay`,
            (`p`.`amount_to_pay` - `py`.`amount_paid`)) AS `balance`,
        IF((`p`.`amount_to_pay` <> IF(ISNULL(`py`.`amount_paid`),
                0,
                `py`.`amount_paid`)),
            'Not Paid',
            'Paid') AS `payment_status`,
        `py`.`date` AS `payment_date`,
        `p`.`created_by` AS `procedure_created_by`,
        `p`.`created_date` AS `procedure_created_date`,
        `p`.`updated_by` AS `procedure_updated_by`,
        `p`.`updated_date` AS `procedure_updated_date`,
        `py`.`created_by` AS `payment_created_by`,
        `py`.`created_date` AS `payment_created_date`,
        `py`.`updated_by` AS `payment_updated_by`,
        `py`.`updated_date` AS `payment_updated_date`
    FROM
        ((((`dental_mis`.`procedure` `p`
        LEFT JOIN `dental_mis`.`procedure_type` `pt` ON ((`p`.`procedure_type_id` = `pt`.`id`)))
        LEFT JOIN `dental_mis`.`tooth` `t` ON ((`p`.`tooth_id` = `t`.`id`)))
        LEFT JOIN (SELECT 
            `dental_mis`.`payment`.`id` AS `id`,
                `dental_mis`.`payment`.`procedure_id` AS `procedure_id`,
                SUM(`dental_mis`.`payment`.`amount_paid`) AS `amount_paid`,
                `dental_mis`.`payment`.`date` AS `date`,
                `dental_mis`.`payment`.`created_by` AS `created_by`,
                `dental_mis`.`payment`.`created_date` AS `created_date`,
                `dental_mis`.`payment`.`updated_by` AS `updated_by`,
                `dental_mis`.`payment`.`updated_date` AS `updated_date`
        FROM
            `dental_mis`.`payment`
        GROUP BY `dental_mis`.`payment`.`procedure_id`) `py` ON ((`py`.`procedure_id` = `p`.`id`)))
        LEFT JOIN `dental_mis`.`patient` `pa` ON ((`p`.`patient_id` = `pa`.`id`)));

SET character_set_client = @saved_cs_client;

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
INSERT INTO `user` VALUES (1,1,'admin','password','Super','Admin',1,'Super Admin','2017-05-10 09:11:00','Super Admin','2017-10-29 17:47:01'),(2,1,'TestUser','password','Test','User',1,'Super Admin','2017-10-05 21:15:28',NULL,NULL);
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
-- Dumping events for database 'dental_mis'
--

--
-- Dumping routines for database 'dental_mis'
--
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
			`p`.`created_by`,
			`p`.`created_date`,
			`p`.`updated_by`,
			`p`.`updated_date`
		FROM `dental_mis`.`patient` `p`
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
			`p`.`created_by`,
			`p`.`created_date`,
			`p`.`updated_by`,
			`p`.`updated_date`
		FROM `dental_mis`.`patient` `p`
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
			`p`.`created_by`,
			`p`.`created_date`,
			`p`.`updated_by`,
			`p`.`updated_date`
		FROM `dental_mis`.`patient` `p`;   
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
	`@date` DATE,
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
    `@date` DATE,
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
	SELECT `payment`.`id`,
		`payment`.`procedure_id`,
        `payment`.`amount_paid`,
		`payment`.`date`,
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
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_payment_search_procedure_id`(IN
	`@procedure_id` BIGINT(8)
)
BEGIN
	SELECT `payment`.`id`,
		`payment`.`procedure_id`,
        `payment`.`amount_paid`,
		`payment`.`date`,
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
	SET @where = CONCAT('WHERE `pv`.`tooth_number` = ''', `@tooth_number`, '''');
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
/*!50001 VIEW `procedure_view` AS select `p`.`id` AS `id`,`p`.`patient_id` AS `patient_id`,`p`.`procedure_type_id` AS `procedure_type_id`,concat(`pa`.`firstname`,' ',`pa`.`lastname`) AS `full_name`,`pt`.`name` AS `procedure_name`,`t`.`id` AS `tooth_number`,concat('Tooth ',`t`.`id`,' - ',`t`.`description`) AS `tooth`,`p`.`notes` AS `notes`,`p`.`date` AS `procedure_date`,if(isnull(`p`.`amount_to_pay`),0,`p`.`amount_to_pay`) AS `amount_to_pay`,if(isnull(`py`.`amount_paid`),0,`py`.`amount_paid`) AS `amount_paid`,if(isnull(`py`.`amount_paid`),`p`.`amount_to_pay`,(`p`.`amount_to_pay` - `py`.`amount_paid`)) AS `balance`,if((`p`.`amount_to_pay` <> if(isnull(`py`.`amount_paid`),0,`py`.`amount_paid`)),'Not Paid','Paid') AS `payment_status`,`py`.`date` AS `payment_date`,`p`.`created_by` AS `procedure_created_by`,`p`.`created_date` AS `procedure_created_date`,`p`.`updated_by` AS `procedure_updated_by`,`p`.`updated_date` AS `procedure_updated_date`,`py`.`created_by` AS `payment_created_by`,`py`.`created_date` AS `payment_created_date`,`py`.`updated_by` AS `payment_updated_by`,`py`.`updated_date` AS `payment_updated_date` from ((((`dental_mis`.`procedure` `p` left join `dental_mis`.`procedure_type` `pt` on((`p`.`procedure_type_id` = `pt`.`id`))) left join `dental_mis`.`tooth` `t` on((`p`.`tooth_id` = `t`.`id`))) left join (select `dental_mis`.`payment`.`id` AS `id`,`dental_mis`.`payment`.`procedure_id` AS `procedure_id`,sum(`dental_mis`.`payment`.`amount_paid`) AS `amount_paid`,`dental_mis`.`payment`.`date` AS `date`,`dental_mis`.`payment`.`created_by` AS `created_by`,`dental_mis`.`payment`.`created_date` AS `created_date`,`dental_mis`.`payment`.`updated_by` AS `updated_by`,`dental_mis`.`payment`.`updated_date` AS `updated_date` from `dental_mis`.`payment` group by `dental_mis`.`payment`.`procedure_id`) `py` on((`py`.`procedure_id` = `p`.`id`))) left join `dental_mis`.`patient` `pa` on((`p`.`patient_id` = `pa`.`id`))) */;
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

-- Dump completed on 2018-02-09  2:47:21
