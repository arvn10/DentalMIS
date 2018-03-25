-- MySqlBackup.NET 2.0.9.2
-- Dump Time: 2018-03-26 02:23:18
-- --------------------------------------
-- Server version 5.7.19-log MySQL Community Server (GPL)

-- 
-- Create schema dental_mis
-- 

CREATE DATABASE IF NOT EXISTS `dental_mis` /*!40100 DEFAULT CHARACTER SET utf8 */;
Use `dental_mis`;



/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of audit_trail
-- 

DROP TABLE IF EXISTS `audit_trail`;
CREATE TABLE IF NOT EXISTS `audit_trail` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `action` text,
  `created_by` varchar(45) DEFAULT NULL,
  `created_date` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table audit_trail
-- 

/*!40000 ALTER TABLE `audit_trail` DISABLE KEYS */;
INSERT INTO `audit_trail`(`id`,`action`,`created_by`,`created_date`) VALUES
(1,'Patient Create Test Qwe','1','2018-02-22 01:13:54'),
(2,'Patient Edit Test Qwea','1','2018-02-22 01:14:25'),
(3,'Procedure Type Create Extraction','1','2018-02-22 01:17:16'),
(4,'Procedure Type Edit Extraction','1','2018-02-22 01:17:28'),
(5,'Procedure Type Edit Extraction','1','2018-02-22 22:59:44'),
(6,'Procedure Type Create qwe','1','2018-02-22 22:59:53'),
(7,'User Edit User ID 1','1','2018-03-04 23:44:31'),
(8,'User Edit User ID 2','1','2018-03-04 23:44:31'),
(9,'Procedure Type Edit Extraction','1','2018-03-07 22:04:02'),
(10,'Procedure Type Edit Extraction','1','2018-03-07 22:04:10'),
(11,'Procedure Create Patient ID 2','1','2018-03-07 22:47:24'),
(12,'User Edit User ID 1','1','2018-03-12 00:57:27'),
(13,'User Edit User ID 1','1','2018-03-12 00:59:53'),
(14,'User Edit User ID 1','1','2018-03-12 01:04:56'),
(15,'User Edit User ID 1','1','2018-03-12 23:33:20'),
(16,'User Edit User ID 1','1','2018-03-12 23:33:34'),
(17,'Payment Create  Procedure ID 1','1','2018-03-13 18:56:20'),
(18,'Patient Edit Test Qwea','1','2018-03-26 02:17:07'),
(19,'Patient Create Qwe Qwe','1','2018-03-26 02:17:31'),
(20,'Procedure Create Patient ID 2','1','2018-03-26 02:18:03'),
(21,'Add Remarks on Procedure ID 14','1','2018-03-26 02:18:03'),
(22,'Add Tooth on Procedure ID 14','1','2018-03-26 02:18:03'),
(23,'Add Tooth on Procedure ID 14','1','2018-03-26 02:18:03'),
(24,'Payment Create  Procedure ID 14','1','2018-03-26 02:18:26'),
(25,'Payment Edit Procedure ID 13','1','2018-03-26 02:19:02'),
(26,'Schedule Create Schedule ID 2','1','2018-03-26 02:19:21'),
(27,'Procedure Type Create qwe','1','2018-03-26 02:19:40'),
(28,'Procedure Type Edit qwe','1','2018-03-26 02:19:54'),
(29,'User Edit User ID 2','1','2018-03-26 02:20:18'),
(30,'User Edit User ID 2','1','2018-03-26 02:20:27'),
(31,'User Create User ID 3','1','2018-03-26 02:22:59');
/*!40000 ALTER TABLE `audit_trail` ENABLE KEYS */;

-- 
-- Definition of patient
-- 

DROP TABLE IF EXISTS `patient`;
CREATE TABLE IF NOT EXISTS `patient` (
  `id` bigint(8) NOT NULL AUTO_INCREMENT,
  `firstname` varchar(45) DEFAULT NULL,
  `lastname` varchar(45) DEFAULT NULL,
  `middle_name` varchar(45) DEFAULT NULL,
  `suffix` varchar(45) DEFAULT NULL,
  `address_house_number` varchar(45) DEFAULT NULL,
  `address_street_building` varchar(255) DEFAULT NULL,
  `address_municipality` varchar(255) DEFAULT NULL,
  `birthday` date DEFAULT NULL,
  `age` int(11) DEFAULT NULL,
  `gender` varchar(45) DEFAULT NULL,
  `occupation` text,
  `contact_number` varchar(45) DEFAULT NULL,
  `civil_status` varchar(45) DEFAULT NULL,
  `created_by` varchar(45) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `updated_by` varchar(45) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table patient
-- 

/*!40000 ALTER TABLE `patient` DISABLE KEYS */;
INSERT INTO `patient`(`id`,`firstname`,`lastname`,`middle_name`,`suffix`,`address_house_number`,`address_street_building`,`address_municipality`,`birthday`,`age`,`gender`,`occupation`,`contact_number`,`civil_status`,`created_by`,`created_date`,`updated_by`,`updated_date`) VALUES
(2,'Test','Qwea','test test','II','123','asdasd','qweqweq','2013-03-17 00:00:00',5,'Male','Qwe','0922222221','Maried','1','2018-02-22 01:13:54','1','2018-03-26 02:17:07'),
(3,'Qweqweq','Qweqwe','Qwe Qwe',NULL,'123123','Qweqwe','Qweqwe','1994-03-17 00:00:00',24,'Male','qweqweqwe','123','Single','1','2018-03-16 17:15:55','1','2018-03-19 17:07:41'),
(4,'Qweqwe','Qweqwe','Qqq Q',NULL,'123123','123123Qweqwe','Qweqweq123123','2014-02-13 00:00:00',4,'Male','13123123qweqwe','1321313','Single','1','2018-03-16 00:48:36',NULL,NULL),
(5,'Test','Qwea','Test Test',NULL,'123','Asdasd','Qweqweq','2013-03-18 00:00:00',4,'Male','Qwe','0922222221','Maried','1','2018-03-16 01:36:34',NULL,NULL),
(6,'Arlene','Vivas','D',NULL,'165','Rosario','Cavite','1981-06-13 00:00:00',37,'Female','Teacher','4380961','Maried','1','2018-03-17 10:47:06',NULL,NULL),
(7,'Kris Aireal','Manongdo','C',NULL,'41','P. Gomez, Samonte Park, Cavite City','Cavite','1997-10-27 00:00:00',20,'Male','Student','09058098666','Single','1','2018-03-17 10:48:21',NULL,NULL),
(8,'Roderick','Go',NULL,NULL,'610','Hermanos St., Cavite City','Cavite','1980-12-24 00:00:00',38,'Male',NULL,'09052703045','Maried','1','2018-03-17 10:51:10',NULL,NULL),
(9,'Frian Joshua','Albahos','S',NULL,'2007','Saturn St., Rosario','Cavite','1997-02-12 00:00:00',21,'Male','Student','09157457721','Single','1','2018-03-17 10:52:28',NULL,NULL),
(10,'Victorino','Rivera','U',NULL,'716','Generillo, Cavite City','Cavite','1942-11-16 00:00:00',76,'Male',NULL,'09271346725','Maried','1','2018-03-17 10:54:03',NULL,NULL),
(11,'Pot','Pot','Pot',NULL,'pot','Pot','Pot','2015-06-16 00:00:00',2,'Female','','12345','Single','1','2018-03-19 16:46:36',NULL,NULL),
(12,'Pot','Pot','Keempie',NULL,'pot','Pot','Pot','2015-06-16 00:00:00',2,'Female','','12345','Single','1','2018-03-19 16:47:45',NULL,NULL),
(13,'Arel Louise Junivel Cardo Domingo','Pleta/','Pot',NULL,'pot','Pot','Po','2018-03-13 00:00:00',0,'Male','','122345465','Single','1','2018-03-19 16:52:55',NULL,NULL),
(14,'Qwe','Qwe','Qwe','I','123','Qwe','Qwe','2018-03-26 00:00:00',0,'Male','','123123123','Single','1','2018-03-26 02:17:31',NULL,NULL);
/*!40000 ALTER TABLE `patient` ENABLE KEYS */;

-- 
-- Definition of payment
-- 

DROP TABLE IF EXISTS `payment`;
CREATE TABLE IF NOT EXISTS `payment` (
  `id` bigint(8) NOT NULL AUTO_INCREMENT,
  `procedure_id` bigint(8) NOT NULL,
  `amount_paid` float DEFAULT NULL,
  `date` date DEFAULT NULL,
  `created_by` varchar(45) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `updated_by` varchar(45) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table payment
-- 

/*!40000 ALTER TABLE `payment` DISABLE KEYS */;
INSERT INTO `payment`(`id`,`procedure_id`,`amount_paid`,`date`,`created_by`,`created_date`,`updated_by`,`updated_date`) VALUES
(1,1,600,'2018-03-13 00:00:00','1','2018-03-13 18:56:20',NULL,NULL),
(2,2,500,'2018-03-18 00:00:00','1','2018-03-18 04:22:34',NULL,NULL),
(3,3,900,'2018-03-19 00:00:00','1','2018-03-19 02:01:05','1','2018-03-19 02:47:56'),
(5,3,99,'2018-03-19 00:00:00','1','2018-03-19 02:04:32',NULL,NULL),
(6,3,1,'2018-03-19 00:00:00','1','2018-03-19 02:04:41',NULL,NULL),
(7,4,200,'2018-03-19 00:00:00','1','2018-03-19 13:43:44',NULL,NULL),
(8,7,230,'2018-03-19 00:00:00','1','2018-03-19 13:50:46',NULL,NULL),
(9,5,500,'2018-03-19 00:00:00','1','2018-03-19 15:25:55',NULL,NULL),
(10,10,10000,'2008-04-22 00:00:00','1','2018-03-19 15:31:56',NULL,NULL),
(11,10,5000,'2008-05-18 00:00:00','1','2018-03-19 15:33:02',NULL,NULL),
(12,10,2000,'2008-08-18 00:00:00','1','2018-03-19 15:33:13',NULL,NULL),
(13,10,1500,'2008-09-28 00:00:00','1','2018-03-19 15:33:26',NULL,NULL),
(14,10,2000,'2008-11-28 00:00:00','1','2018-03-19 15:33:41',NULL,NULL),
(15,10,1000,'2008-12-19 00:00:00','1','2018-03-19 15:33:51',NULL,NULL),
(16,10,1000,'2009-03-18 00:00:00','1','2018-03-19 15:34:07',NULL,NULL),
(17,10,1000,'2009-04-20 00:00:00','1','2018-03-19 15:34:20',NULL,NULL),
(18,10,1000,'2009-05-10 00:00:00','1','2018-03-19 15:34:27',NULL,NULL),
(19,10,1000,'2009-06-02 00:00:00','1','2018-03-19 15:34:45',NULL,NULL),
(20,10,4500,'2010-05-24 00:00:00','1','2018-03-19 15:35:14',NULL,NULL),
(21,4,400,'2018-03-19 00:00:00','1','2018-03-19 15:50:10',NULL,NULL),
(22,6,1,'2018-03-19 00:00:00','1','2018-03-19 15:50:34',NULL,NULL),
(23,8,340,'2018-03-19 00:00:00','1','2018-03-19 15:50:46',NULL,NULL),
(24,9,230,'2018-03-19 00:00:00','1','2018-03-19 15:50:57',NULL,NULL),
(25,11,1000,'2018-03-19 00:00:00','1','2018-03-19 16:59:54',NULL,NULL),
(26,11,500,'2018-03-19 00:00:00','1','2018-03-19 17:02:37',NULL,NULL),
(27,12,550,'2018-03-25 00:00:00','1','2018-03-25 02:14:21',NULL,NULL),
(28,13,1112,'2018-03-25 00:00:00','1','2018-03-25 02:17:26','1','2018-03-25 02:17:33'),
(29,13,1115,'2018-03-25 00:00:00','1','2018-03-25 02:17:43','1','2018-03-25 02:17:51'),
(30,13,5000,'2018-03-25 00:00:00','1','2018-03-25 02:18:17',NULL,NULL),
(31,13,2000,'2018-03-25 00:00:00','1','2018-03-25 02:18:41',NULL,NULL),
(32,13,500,'2018-03-25 00:00:00','1','2018-03-25 02:18:57',NULL,NULL),
(33,13,100,'2018-03-26 00:00:00','1','2018-03-25 02:19:19','1','2018-03-26 02:19:02'),
(34,13,55,'2018-03-25 00:00:00','1','2018-03-25 02:20:08','1','2018-03-25 02:20:18'),
(35,14,1231,'2018-03-26 00:00:00','1','2018-03-26 02:18:26',NULL,NULL);
/*!40000 ALTER TABLE `payment` ENABLE KEYS */;

-- 
-- Definition of procedure
-- 

DROP TABLE IF EXISTS `procedure`;
CREATE TABLE IF NOT EXISTS `procedure` (
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
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table procedure
-- 

/*!40000 ALTER TABLE `procedure` DISABLE KEYS */;
INSERT INTO `procedure`(`id`,`patient_id`,`procedure_type_id`,`tooth_id`,`amount_to_pay`,`notes`,`date`,`created_by`,`created_date`,`updated_by`,`updated_date`) VALUES
(1,2,6,2,600,'qwe','2018-03-07 00:00:00','1','2018-03-07 22:47:24',NULL,NULL),
(2,2,7,2,500,'qwe','2018-03-18 00:00:00','1','2018-03-18 00:54:58',NULL,NULL),
(3,2,8,3,1000,'','2018-02-18 00:00:00','1','2018-03-18 04:30:12','1','2018-03-19 11:10:07'),
(4,2,6,NULL,600,NULL,'2018-03-19 00:00:00','1','2018-03-19 11:13:04',NULL,NULL),
(5,5,6,NULL,500,NULL,'2018-03-19 00:00:00','1','2018-03-19 13:37:03',NULL,NULL),
(6,5,6,NULL,1,NULL,'2018-03-19 00:00:00','1','2018-03-19 13:37:19',NULL,NULL),
(7,2,7,NULL,230,NULL,'2018-03-19 00:00:00','1','2018-03-19 13:48:52',NULL,NULL),
(8,4,8,NULL,340,NULL,'2018-03-19 00:00:00','1','2018-03-19 13:52:49',NULL,NULL),
(9,4,9,NULL,230,NULL,'2018-03-19 00:00:00','1','2018-03-19 13:53:47',NULL,NULL),
(10,6,13,NULL,30000,NULL,'2008-04-22 00:00:00','1','2018-03-17 10:48:50','1','2018-03-19 15:23:22'),
(11,11,9,NULL,1500,NULL,'2018-03-19 00:00:00','1','2018-03-19 16:59:14',NULL,NULL),
(12,13,6,NULL,550,NULL,'2018-03-25 00:00:00','1','2018-03-25 02:14:14',NULL,NULL),
(13,12,8,NULL,10000,NULL,'2018-03-25 00:00:00','1','2018-03-25 02:17:14',NULL,NULL),
(14,2,7,NULL,1231,NULL,'2018-03-26 00:00:00','1','2018-03-26 02:18:03',NULL,NULL);
/*!40000 ALTER TABLE `procedure` ENABLE KEYS */;

-- 
-- Definition of procedure_remark
-- 

DROP TABLE IF EXISTS `procedure_remark`;
CREATE TABLE IF NOT EXISTS `procedure_remark` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `procedure_id` bigint(20) DEFAULT NULL,
  `value` text,
  `date_added` date DEFAULT NULL,
  `created_by` varchar(45) DEFAULT NULL,
  `created_date` datetime DEFAULT CURRENT_TIMESTAMP,
  `updated_by` varchar(45) DEFAULT NULL,
  `updated_Date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table procedure_remark
-- 

/*!40000 ALTER TABLE `procedure_remark` DISABLE KEYS */;
INSERT INTO `procedure_remark`(`id`,`procedure_id`,`value`,`date_added`,`created_by`,`created_date`,`updated_by`,`updated_Date`) VALUES
(1,3,'qweqwe','2018-03-19 00:00:00','1','2018-03-19 05:06:00','1','2018-03-19 11:10:07'),
(2,3,'qwea','2018-03-19 00:00:00','1','2018-03-19 05:09:49','1','2018-03-19 11:10:07'),
(3,12,'qwe','2018-03-25 00:00:00','1','2018-03-25 02:14:14',NULL,NULL),
(4,13,'qwe','2018-03-25 00:00:00','1','2018-03-25 02:17:14',NULL,NULL),
(5,14,'qweqweqwe','2018-03-26 00:00:00','1','2018-03-26 02:18:03',NULL,NULL);
/*!40000 ALTER TABLE `procedure_remark` ENABLE KEYS */;

-- 
-- Definition of procedure_tooth
-- 

DROP TABLE IF EXISTS `procedure_tooth`;
CREATE TABLE IF NOT EXISTS `procedure_tooth` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `procedure_id` bigint(20) DEFAULT NULL,
  `tooth_id` bigint(20) DEFAULT NULL,
  `created_by` varchar(45) DEFAULT NULL,
  `created_date` datetime DEFAULT CURRENT_TIMESTAMP,
  `updated_by` varchar(45) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table procedure_tooth
-- 

/*!40000 ALTER TABLE `procedure_tooth` DISABLE KEYS */;
INSERT INTO `procedure_tooth`(`id`,`procedure_id`,`tooth_id`,`created_by`,`created_date`,`updated_by`,`updated_date`) VALUES
(1,1,1,'1','2018-03-18 18:48:21',NULL,NULL),
(2,1,2,'1','2018-03-18 18:48:22',NULL,NULL),
(3,3,2,'1','2018-03-19 09:54:34','1','2018-03-19 11:10:11'),
(4,3,3,'1','2018-03-19 09:54:34','1','2018-03-19 11:10:11'),
(5,4,1,'1','2018-03-19 11:13:04',NULL,NULL),
(6,5,22,'1','2018-03-19 13:37:04',NULL,NULL),
(7,6,22,'1','2018-03-19 13:37:19',NULL,NULL),
(8,7,25,'1','2018-03-19 13:48:52',NULL,NULL),
(9,8,26,'1','2018-03-19 13:52:49',NULL,NULL),
(10,9,26,'1','2018-03-19 13:53:47',NULL,NULL),
(11,10,1,'1','2018-03-19 15:17:32','1','2018-03-19 15:23:22'),
(12,10,33,'1','2018-03-19 15:23:22',NULL,NULL),
(13,11,33,'1','2018-03-19 16:59:14',NULL,NULL),
(14,12,1,'1','2018-03-25 02:14:14',NULL,NULL),
(15,12,2,'1','2018-03-25 02:14:14',NULL,NULL),
(16,12,3,'1','2018-03-25 02:14:14',NULL,NULL),
(17,13,3,'1','2018-03-25 02:17:14',NULL,NULL),
(18,14,1,'1','2018-03-26 02:18:03',NULL,NULL),
(19,14,2,'1','2018-03-26 02:18:03',NULL,NULL);
/*!40000 ALTER TABLE `procedure_tooth` ENABLE KEYS */;

-- 
-- Definition of procedure_type
-- 

DROP TABLE IF EXISTS `procedure_type`;
CREATE TABLE IF NOT EXISTS `procedure_type` (
  `id` bigint(8) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) DEFAULT NULL,
  `base_price` float DEFAULT NULL,
  `payment_type` varchar(45) DEFAULT NULL,
  `require_med_cert` tinyint(4) DEFAULT NULL,
  `require_tooth` varchar(45) DEFAULT NULL,
  `status` tinyint(4) DEFAULT NULL,
  `created_by` varchar(45) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `updated_by` varchar(45) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table procedure_type
-- 

/*!40000 ALTER TABLE `procedure_type` DISABLE KEYS */;
INSERT INTO `procedure_type`(`id`,`name`,`base_price`,`payment_type`,`require_med_cert`,`require_tooth`,`status`,`created_by`,`created_date`,`updated_by`,`updated_date`) VALUES
(6,'Oral Prophylaxis - Light',550,'Full Payment',0,'Optional',1,'1','2018-02-22 01:17:16','1','2018-03-25 02:13:21'),
(7,'Extraction',550,'Installment',1,'Yes',1,'1','2018-02-22 22:59:53','1','2018-03-19 14:37:58'),
(8,'Denture - Complete Plastic',10000,'Installment',0,'Yes',1,'1','2018-03-18 03:07:29','1','2018-03-19 14:38:33'),
(9,'Oral Prophylaxis - Heavy',1500,'Installment',0,'Optional',1,'1','2018-03-19 11:15:10','1','2018-03-19 14:37:31'),
(10,'Denture - Complete Porcelain',20000,'Installment',0,'Yes',1,'1','2018-03-19 14:38:57',NULL,NULL),
(11,'Denture - Fixed Bridge',5000,'Installment',0,'Yes',1,'1','2018-03-19 14:39:47',NULL,NULL),
(12,'Implant',80000,'Installment',0,'Yes',1,'1','2018-03-19 14:40:21',NULL,NULL),
(13,'Orthodontics',80000,'Installment',0,'Yes',1,'1','2018-03-19 14:41:00',NULL,NULL),
(14,'Restoration - Class 1',550,'Installment',0,'Yes',1,'1','2018-03-19 14:41:31',NULL,NULL),
(15,'Restoration - Class 2',1100,'Installment',0,'Yes',1,'1','2018-03-19 14:41:55',NULL,NULL),
(16,'Restoration - Class 3',550,'Installment',0,'Yes',1,'1','2018-03-19 14:42:12',NULL,NULL),
(17,'Restoration - Class 4',1100,'Installment',0,'Yes',1,'1','2018-03-19 14:42:31',NULL,NULL),
(18,'Restoration - Class 5',550,'Installment',1,'Yes',1,'1','2018-03-19 14:42:51',NULL,NULL),
(19,'Orthodontectomy',8000,'Installment',0,'Yes',1,'1','2018-03-19 14:43:34',NULL,NULL),
(20,'qwe',155,'Full Payment',1,'Yes',0,'1','2018-03-26 02:19:40','1','2018-03-26 02:19:54');
/*!40000 ALTER TABLE `procedure_type` ENABLE KEYS */;

-- 
-- Definition of procedure_type_pair
-- 

DROP TABLE IF EXISTS `procedure_type_pair`;
CREATE TABLE IF NOT EXISTS `procedure_type_pair` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `procedure_type_id` bigint(20) DEFAULT NULL,
  `procedure_type_id_pair` bigint(20) DEFAULT NULL,
  `visibility_type` varchar(255) DEFAULT NULL,
  `status` tinyint(4) DEFAULT NULL,
  `created_by` varchar(45) DEFAULT NULL,
  `created_date` datetime DEFAULT CURRENT_TIMESTAMP,
  `updated_by` varchar(45) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table procedure_type_pair
-- 

/*!40000 ALTER TABLE `procedure_type_pair` DISABLE KEYS */;
INSERT INTO `procedure_type_pair`(`id`,`procedure_type_id`,`procedure_type_id_pair`,`visibility_type`,`status`,`created_by`,`created_date`,`updated_by`,`updated_date`) VALUES
(2,6,6,'Hide',1,'1','2018-02-22 01:17:59','1','2018-03-18 18:51:11'),
(3,6,7,'Show',1,'1','2018-03-18 12:38:19','1','2018-03-18 18:50:56'),
(4,6,8,'Show',1,'1','2018-03-18 12:42:56','1','2018-03-18 18:51:02');
/*!40000 ALTER TABLE `procedure_type_pair` ENABLE KEYS */;

-- 
-- Definition of schedule
-- 

DROP TABLE IF EXISTS `schedule`;
CREATE TABLE IF NOT EXISTS `schedule` (
  `id` bigint(8) NOT NULL AUTO_INCREMENT,
  `title` text,
  `description` text,
  `start_time` datetime DEFAULT NULL,
  `end_time` datetime DEFAULT NULL,
  `background_color` varchar(45) DEFAULT NULL,
  `status` varchar(45) DEFAULT NULL,
  `is_deleted` tinyint(4) DEFAULT '0',
  `created_by` varchar(45) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `updated_by` varchar(45) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table schedule
-- 

/*!40000 ALTER TABLE `schedule` DISABLE KEYS */;
INSERT INTO `schedule`(`id`,`title`,`description`,`start_time`,`end_time`,`background_color`,`status`,`is_deleted`,`created_by`,`created_date`,`updated_by`,`updated_date`) VALUES
(1,'Keempie','Consultation','2018-03-19 16:45:00','2018-03-19 17:15:00','-8355712',NULL,0,'1','2018-03-19 16:42:50',NULL,NULL),
(2,'test','','2018-03-26 08:00:00','2018-03-26 08:30:00','-1',NULL,0,'1','2018-03-26 02:19:21',NULL,NULL);
/*!40000 ALTER TABLE `schedule` ENABLE KEYS */;

-- 
-- Definition of secret_question
-- 

DROP TABLE IF EXISTS `secret_question`;
CREATE TABLE IF NOT EXISTS `secret_question` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `question` text,
  `created_by` varchar(45) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `updated_by` varchar(45) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table secret_question
-- 

/*!40000 ALTER TABLE `secret_question` DISABLE KEYS */;
INSERT INTO `secret_question`(`id`,`question`,`created_by`,`created_date`,`updated_by`,`updated_date`) VALUES
(1,'What is your favorite color?','1','2018-02-19 02:56:07',NULL,NULL),
(2,'What was your childhood nickname?','1','2018-02-19 02:56:07',NULL,NULL),
(3,'In what city did you meet your spouse/significant other?','1','2018-02-19 02:56:07',NULL,NULL),
(4,'What is the name of your favorite childhood friend?','1','2018-02-19 02:56:07',NULL,NULL),
(5,'What street did you live on in third grade?','1','2018-02-19 02:56:07',NULL,NULL),
(6,'What is your oldest sibling’s birthday month and year? (e.g., January 1900)','1','2018-02-19 02:56:07',NULL,NULL),
(7,'What school did you attend for sixth grade?','1','2018-02-19 02:56:07',NULL,NULL),
(8,'What is your oldest cousin''s first and last name?','1','2018-02-19 02:56:07',NULL,NULL),
(9,'In what city or town did your mother and father meet?','1','2018-02-19 02:56:07',NULL,NULL),
(10,'What is the first name of the boy or girl that you first kissed?','1','2018-02-19 02:56:07',NULL,NULL),
(11,'What is your oldest brother’s birthday month and year? (e.g., January 1900)','1','2018-02-19 02:56:07',NULL,NULL),
(12,'What is your maternal grandmother''s maiden name?','1','2018-02-19 02:56:07',NULL,NULL),
(13,'In what city or town was your first job?','1','2018-02-19 02:56:07',NULL,NULL),
(14,'What is the name of the place your wedding reception was held?','1','2018-02-19 02:56:07',NULL,NULL),
(15,'What is the name of a college you applied to but didn''t attend?','1','2018-02-19 02:56:07',NULL,NULL);
/*!40000 ALTER TABLE `secret_question` ENABLE KEYS */;

-- 
-- Definition of tooth
-- 

DROP TABLE IF EXISTS `tooth`;
CREATE TABLE IF NOT EXISTS `tooth` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `description` varchar(45) DEFAULT NULL,
  `created_by` varchar(45) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `updated_by` varchar(45) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table tooth
-- 

/*!40000 ALTER TABLE `tooth` DISABLE KEYS */;
INSERT INTO `tooth`(`id`,`description`,`created_by`,`created_date`,`updated_by`,`updated_date`) VALUES
(1,'(UR) Third Molar','admin','2018-02-02 00:43:00',NULL,NULL),
(2,'(UR) Second Molar','admin','2018-02-02 00:43:00',NULL,NULL),
(3,'(UR) First Molar','admin','2018-02-02 00:43:00',NULL,NULL),
(4,'(UR) Second Bicuspid','admin','2018-02-02 00:43:00',NULL,NULL),
(5,'(UR) First Bicuspid','admin','2018-02-02 00:43:00',NULL,NULL),
(6,'(UR) Bicuspid','admin','2018-02-02 00:43:00',NULL,NULL),
(7,'(UR) Lateral Incisor','admin','2018-02-02 00:43:00',NULL,NULL),
(8,'(UR) Central Incisor','admin','2018-02-02 00:43:00',NULL,NULL),
(9,'(UL) Central Incisor','admin','2018-02-02 00:43:00',NULL,NULL),
(10,'(UL) Lateral Incisor','admin','2018-02-02 00:43:00',NULL,NULL),
(11,'(UL) Bicuspid','admin','2018-02-02 00:43:00',NULL,NULL),
(12,'(UL) First Bicuspid','admin','2018-02-02 00:43:00',NULL,NULL),
(13,'(UL) Second Bicuspid','admin','2018-02-02 00:43:00',NULL,NULL),
(14,'(UL) First Molar','admin','2018-02-02 00:43:00',NULL,NULL),
(15,'(UL) Second Molar','admin','2018-02-02 00:43:00',NULL,NULL),
(16,'(UL) Third Molar','admin','2018-02-02 00:43:00',NULL,NULL),
(17,'(LL) Third Molar','admin','2018-02-02 00:43:00',NULL,NULL),
(18,'(LL) Second Molar','admin','2018-02-02 00:43:00',NULL,NULL),
(19,'(LL) First Molar','admin','2018-02-02 00:43:00',NULL,NULL),
(20,'(LL) Second Bicuspid','admin','2018-02-02 00:43:00',NULL,NULL),
(21,'(LL) First Bicuspid','admin','2018-02-02 00:43:00',NULL,NULL),
(22,'(L) Bicuspid','admin','2018-02-02 00:43:00',NULL,NULL),
(23,'(LL) Lateral Incisor','admin','2018-02-02 00:43:00',NULL,NULL),
(24,'(LL) Central Incisor','admin','2018-02-02 00:43:00',NULL,NULL),
(25,'(LR) Central Incisor','admin','2018-02-02 00:43:00',NULL,NULL),
(26,'(LR) Lateral Incisor','admin','2018-02-02 00:43:00',NULL,NULL),
(27,'(LR) Bicuspid','admin','2018-02-02 00:43:00',NULL,NULL),
(28,'(LR) First Bicuspid','admin','2018-02-02 00:43:00',NULL,NULL),
(29,'(LR) Second Bicuspid','admin','2018-02-02 00:43:00',NULL,NULL),
(30,'(LR) First Molar','admin','2018-02-02 00:43:00',NULL,NULL),
(31,'(LR) Second Molar','admin','2018-02-02 00:43:00',NULL,NULL),
(32,'(LR) Third Molar','admin','2018-02-02 00:43:00',NULL,NULL),
(33,'All Tooths','admin','2018-02-02 00:43:00',NULL,NULL),
(34,'All Upper Tooths','admin','2018-02-02 00:43:00',NULL,NULL),
(35,'All Lower Tooths','admin','2018-02-02 00:43:00',NULL,NULL);
/*!40000 ALTER TABLE `tooth` ENABLE KEYS */;

-- 
-- Definition of user
-- 

DROP TABLE IF EXISTS `user`;
CREATE TABLE IF NOT EXISTS `user` (
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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table user
-- 

/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user`(`id`,`user_type_id`,`secret_question_id`,`username`,`password`,`secret_question_answer`,`firstname`,`lastname`,`status`,`created_by`,`created_date`,`updated_by`,`updated_date`) VALUES
(1,1,2,'Eolaes','password','manny','Emmanuelle','Olaes',1,'1',NULL,'1','2018-03-19 17:06:53'),
(2,2,13,'Asabal','password','manila','Andrea','Sabal',1,'1','2018-02-19 03:07:41','1','2018-03-26 02:20:27'),
(3,1,1,'admin','password','qwe','Asd','Asd',1,'1','2018-03-26 02:22:59',NULL,NULL);
/*!40000 ALTER TABLE `user` ENABLE KEYS */;

-- 
-- Definition of user_type
-- 

DROP TABLE IF EXISTS `user_type`;
CREATE TABLE IF NOT EXISTS `user_type` (
  `id` bigint(8) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) DEFAULT NULL,
  `created_by` varchar(45) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `updated_by` varchar(45) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table user_type
-- 

/*!40000 ALTER TABLE `user_type` DISABLE KEYS */;
INSERT INTO `user_type`(`id`,`name`,`created_by`,`created_date`,`updated_by`,`updated_date`) VALUES
(1,'Doctor','Service Account','2017-10-01 00:13:00',NULL,NULL),
(2,'Secretary','Service Account','2017-10-01 00:13:00',NULL,NULL);
/*!40000 ALTER TABLE `user_type` ENABLE KEYS */;

-- 
-- Dumping functions
-- 

DROP FUNCTION IF EXISTS `ACRONYM`;
DELIMITER |
CREATE FUNCTION `ACRONYM`(str text) RETURNS text CHARSET utf8
begin
    declare result text default '';
    set result = initials( str, '[[:alnum:]]' );
    return result;
end |
DELIMITER ;

DROP FUNCTION IF EXISTS `initials`;
DELIMITER |
CREATE FUNCTION `initials`(str text, expr text) RETURNS text CHARSET utf8
begin
    declare result text default '';
    declare buffer text default '';
    declare i int default 1;
    if(str is null) then
        return null;
    end if;
    set buffer = trim(str);
    while i <= length(buffer) do
        if substr(buffer, i, 1) regexp expr then
            set result = concat( result, substr( buffer, i, 1 ));
            set i = i + 1;
            while i <= length( buffer ) and substr(buffer, i, 1) regexp expr do
                set i = i + 1;
            end while;
            while i <= length( buffer ) and substr(buffer, i, 1) not regexp expr do
                set i = i + 1;
            end while;
        else
            set i = i + 1;
        end if;
    end while;
    return result;
end |
DELIMITER ;

-- 
-- Dumping procedures
-- 

DROP PROCEDURE IF EXISTS `usp_audit_trail_create`;
DELIMITER |
CREATE PROCEDURE `usp_audit_trail_create`(in
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
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_audit_trail_select`;
DELIMITER |
CREATE PROCEDURE `usp_audit_trail_select`(in
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
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_patient_create`;
DELIMITER |
CREATE PROCEDURE `usp_patient_create`(IN 
    `@firstname` VARCHAR(45),
    `@lastname` VARCHAR(45),
    `@middle_name` VARCHAR(45),
    `@suffix` VARCHAR(45),
    `@address_house_number` VARCHAR(255),
    `@address_street_building` VARCHAR(255),
    `@address_municipality` VARCHAR(255),
    `@birthday` VARCHAR(45),
    `@age` VARCHAR(45), 
    `@gender` VARCHAR(45),
    `@occupation` TEXT,
    `@contact_number` VARCHAR(255),
    `@civil_status` VARCHAR(45),
    `@created_by` VARCHAR(45)
)
BEGIN
	DECLARE `@if_exist` INT;
    SET `@if_exist` = (SELECT 1 
					   FROM `dental_mis`.`patient` 
					   WHERE LOWER(`firstname`) = LOWER(`@firstname`) AND
                             LOWER(`lastname`) = LOWER(`@lastname`) AND
                             LOWER(`middle_name`) = LOWER(`@middle_name`) AND
                             LOWER(`suffix`) = LOWER(`@suffix`) AND
                             LOWER(`address_house_number`) = LOWER(`@address_house_number`) AND
                             LOWER(`address_street_building`) = LOWER(`@address_street_building`) AND
                             LOWER(`address_municipality`) = LOWER(`@address_municipality`) AND
                             `birthday` = `@birthday` AND
                             `age` = `@age` AND
                             `gender` = `@gender` AND
                             LOWER(`occupation`) = LOWER(`@occupation`) AND
                             `contact_number` = `@contact_number` AND
                             `civil_status` = `@civil_status`);
	IF `@if_exist` = 1 THEN
		SELECT 0;
	ELSE
		INSERT INTO `dental_mis`.`patient`
		(`firstname`,
		`lastname`,
		`middle_name`,
        `suffix`,
		`address_house_number`,
		`address_street_building`,
		`address_municipality`,
		`birthday`,
		`age`,
		`gender`,
		`occupation`,
		`contact_number`,
		`civil_status`,
		`created_by`,
		`created_date`)
		VALUES
		(
			`@firstname`,
			`@lastname`,
			`@middle_name`,
            `@suffix`,
			`@address_house_number`,
			`@address_street_building`,
			`@address_municipality`,
			`@birthday`,
			`@age`,
			`@gender`,
			`@occupation`,
			`@contact_number`,
			`@civil_status`,
			`@created_by`,
			NOW()
		);

		SELECT LAST_INSERT_ID();
    END IF;
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_patient_edit`;
DELIMITER |
CREATE PROCEDURE `usp_patient_edit`(IN 
	`@id` BIGINT(8),
    `@firstname` VARCHAR(45),
    `@lastname` VARCHAR(45),
    `@middle_name` VARCHAR(45),
    `@suffix` VARCHAR(45),
    `@address_house_number` VARCHAR(255),
    `@address_street_building` VARCHAR(255),
    `@address_municipality` VARCHAR(255),
    `@birthday` VARCHAR(45),
    `@age` INT, 
    `@gender` VARCHAR(45),
    `@occupation` TEXT,
    `@contact_number` VARCHAR(255),
    `@civil_status` VARCHAR(45),
    `@updated_by` VARCHAR(45)
)
BEGIN
	UPDATE `dental_mis`.`patient`
	SET
		`firstname` = `@firstname`,
		`lastname` = `@lastname`,
		`middle_name` = `@middle_name`,
        `suffix` = `@suffix`,
		`address_house_number` = `@address_house_number`,
		`address_street_building` = `@address_street_building`,
		`address_municipality` = `@address_municipality`,
		`birthday` = `@birthday`,
		`age` = `@age`,
		`gender` = `@gender`,
		`occupation` = `@occupation`,
		`contact_number` = `@contact_number`,
		`civil_status` = `@civil_status`,
		`updated_by` = `@updated_by`,
		`updated_date` = now()
	WHERE `id` = `@id`;
        
    SELECT `@id`;
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_patient_search_age`;
DELIMITER |
CREATE PROCEDURE `usp_patient_search_age`(IN 
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
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_patient_search_id`;
DELIMITER |
CREATE PROCEDURE `usp_patient_search_id`(IN 
    `@id` TINYINT
)
BEGIN
		SELECT * FROM dental_mis.patient_view `p`   
        WHERE `p`.`id` = `@id`;
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_patient_search_like`;
DELIMITER |
CREATE PROCEDURE `usp_patient_search_like`(IN 
    `@search_value` TEXT
)
BEGIN
	IF `@search_value` <> '' THEN
		SELECT * FROM dental_mis.patient_view `p`  
		WHERE (`p`.`full_name` LIKE CONCAT('%', `@search_value`, '%')) OR
			  (`p`.`address` LIKE CONCAT('%', `@search_value`, '%'));
	ELSE
 		SELECT * FROM dental_mis.patient_view `p`;
    END IF;
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_patient_search_report`;
DELIMITER |
CREATE PROCEDURE `usp_patient_search_report`(IN 
    `@from` NVARCHAR(20),
    `@to` NVARCHAR(20)
)
BEGIN
	IF `@from` = '' AND `@to` = '' THEN
		SELECT
			patient_number,
			full_name,
			address,
			gender,
			age,
			contact_number
		FROM dental_mis.patient_view `p`
        ORDER BY created_date asc;
    ELSE
		SELECT
			patient_number,
			full_name,
			address,
			gender,
			age,
			contact_number
		FROM dental_mis.patient_view `p`  
		WHERE `p`.`created_date` BETWEEN `@from` AND `@to`;
    END IF;
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_payment_create`;
DELIMITER |
CREATE PROCEDURE `usp_payment_create`(IN
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
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_payment_edit`;
DELIMITER |
CREATE PROCEDURE `usp_payment_edit`(IN
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
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_payment_search_id`;
DELIMITER |
CREATE PROCEDURE `usp_payment_search_id`(IN
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
	WHERE `p`.`id` = `@id`;
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_payment_search_procedure_id`;
DELIMITER |
CREATE PROCEDURE `usp_payment_search_procedure_id`(IN
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
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_procedure_create`;
DELIMITER |
CREATE PROCEDURE `usp_procedure_create`(IN
	`@patient_id` BIGINT(8),
	`@procedure_type_id` BIGINT(8),
    `@amount_to_pay` FLOAT,
    `@date` DATE,
	`@created_by` VARCHAR(45)
)
BEGIN
	INSERT INTO `dental_mis`.`procedure`
	(
		`patient_id`,
		`procedure_type_id`,
        `amount_to_pay`,
		`date`,
		`created_by`,
		`created_date`
    )
	VALUES
	(
		`@patient_id`,
		`@procedure_type_id`,
        `@amount_to_pay`,
		`@date`,
		`@created_by`,
        NOW()
    );
    
    SELECT LAST_INSERT_ID();
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_procedure_edit`;
DELIMITER |
CREATE PROCEDURE `usp_procedure_edit`(IN
	`@id` BIGINT(8),
	`@patient_id` BIGINT(8),
	`@procedure_type_id` BIGINT(8),
    `@amount_to_pay` FLOAT,
	`@date` DATE,
	`@updated_by` VARCHAR(45)
)
BEGIN
	UPDATE `dental_mis`.`procedure`
	SET
	`patient_id` = `@patient_id`,
	`procedure_type_id` = `@procedure_type_id`,
    `amount_to_pay` = `@amount_to_pay`,
	`date` = `@date`,
	`updated_by` = `@updated_by`,
	`updated_date` = NOW()
	WHERE `id` = `@id`;
    
    SELECT `@id`;
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_procedure_payment_search_like`;
DELIMITER |
CREATE PROCEDURE `usp_procedure_payment_search_like`(in
	`@search_text` TEXT
)
BEGIN
	IF `@search_text` <> '' THEN
    
	SELECT *
	FROM `dental_mis`.`procedure_view` `pv`
    WHERE
		`pv`.`payment_status` <> 'Paid' AND
		`pv`.`full_name` LIKE CONCAT('%', `@search_text`, '%')
    ORDER BY `pv`.`procedure_date` DESC;
    ELSE
		SELECT *
		FROM `dental_mis`.`procedure_view` `pv`
		WHERE
			`pv`.`payment_status` <> 'Paid'
		ORDER BY `pv`.`procedure_date` DESC;
    END IF;
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_procedure_payment_search_report`;
DELIMITER |
CREATE PROCEDURE `usp_procedure_payment_search_report`(in
	`@payment_status` TEXT,
    `@from` NVARCHAR(20),
    `@to` NVARCHAR(20)
)
BEGIN

	IF `@from` = '' AND `@to` = '' THEN
    	IF `@payment_status` <> '' THEN
			SELECT 
				*
			FROM `dental_mis`.`procedure_view` `pv`
			WHERE `pv`.`payment_status` = `@payment_status` 
			ORDER BY `pv`.`procedure_date` DESC;
		ELSE
			SELECT 
				*
			FROM `dental_mis`.`procedure_view` `pv`
			ORDER BY `pv`.`procedure_date` DESC;
		END IF;    
    ELSE
    	IF `@payment_status` <> '' THEN
			SELECT 
				*
			FROM `dental_mis`.`procedure_view` `pv`
			WHERE `pv`.`payment_status` = `@payment_status` AND
				   DATE_FORMAT(`pv`.`procedure_date`, '%Y-%m-%d') BETWEEN `@from` AND `@to`
			ORDER BY `pv`.`procedure_date` DESC;
		ELSE
			SELECT 
				*
			FROM `dental_mis`.`procedure_view` `pv`
			WHERE DATE_FORMAT(`pv`.`procedure_date`, '%Y-%m-%d') BETWEEN `@from` AND `@to`;
		END IF;
    END IF;
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_procedure_payment_search_status`;
DELIMITER |
CREATE PROCEDURE `usp_procedure_payment_search_status`(in
	`@payment_status` TEXT
)
BEGIN
	SELECT 
		*
	FROM `dental_mis`.`procedure_view` `pv`
    WHERE `pv`.`payment_status` = `@payment_status`
    ORDER BY `pv`.`procedure_date` DESC;

END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_procedure_payment_status`;
DELIMITER |
CREATE PROCEDURE `usp_procedure_payment_status`(in
	`@payment_status` TEXT
)
BEGIN
	SELECT 
		*
	FROM `dental_mis`.`procedure_view` `pv`
    WHERE `pv`.`payment_status` = `@payment_status`
    ORDER BY `pv`.`procedure_date` DESC;

END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_procedure_remark_create`;
DELIMITER |
CREATE PROCEDURE `usp_procedure_remark_create`(in
`@procedure_id` BIGINT,
`@value` TEXT,
`@date_added` varchar(45),
`@created_by` varchar(45)
)
BEGIN

	INSERT INTO `dental_mis`.`procedure_remark`
	(
	`procedure_id`,
	`value`,
	`date_added`,
	`created_by`,
	`created_date`)
	VALUES
	(`@procedure_id`,
	`@value`,
	`@date_added`,
	`@created_by`,
	now());
    
    SELECT LAST_INSERT_ID();

END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_procedure_remark_edit`;
DELIMITER |
CREATE PROCEDURE `usp_procedure_remark_edit`(in
	`@id` BIGINT,
	`@value` TEXT,
	`@date_added` varchar(45),
	`@updated_by` varchar(45)
)
BEGIN
	UPDATE `dental_mis`.`procedure_remark`
	SET
	`value` = `@value`,
	`date_added` = `@date_added`,
	`updated_by` = `@updated_by`,
	`updated_Date` = now()
	WHERE `id` = `@id`;

	SELECT `@id`;
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_procedure_remark_select_id`;
DELIMITER |
CREATE PROCEDURE `usp_procedure_remark_select_id`(in
	`@id` BIGINT
)
BEGIN
	SELECT * FROM `dental_mis`.`procedure_remark`
	WHERE `id` = `@id`;

END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_procedure_remark_select_procedure_id`;
DELIMITER |
CREATE PROCEDURE `usp_procedure_remark_select_procedure_id`(in
	`@procedure_id` BIGINT
)
BEGIN
	SELECT * FROM `dental_mis`.`procedure_remark`
	WHERE `procedure_id` = `@procedure_id`;
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_procedure_search_id`;
DELIMITER |
CREATE PROCEDURE `usp_procedure_search_id`(IN
	`@id` BIGINT(8)
)
BEGIN
	SELECT 
		*
	FROM `dental_mis`.`procedure_view` `pv`
    WHERE `pv`.`id` = `@id`
    ORDER BY `pv`.`procedure_created_by` DESC;
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_procedure_search_patient_id`;
DELIMITER |
CREATE PROCEDURE `usp_procedure_search_patient_id`(IN
	`@patient_id` BIGINT(8),
    `@tooth_number` nvarchar(255),
    `@from` nvarchar(10),
    `@to` nvarchar(10)
)
BEGIN

IF `@tooth_number` <> '' THEN
	SET @where = CONCAT('WHERE `pv`.`patient_id` = ''', `@patient_id`, ''' AND `pv`.`tooth` LIKE ''%', `@tooth_number`, '%''');
ELSEIF `@tooth_number` = '' AND `@from` = '' AND `@to` = '' THEN
	SET @where = CONCAT('WHERE `pv`.`patient_id` = ''', `@patient_id`, '''');
ELSE
	SET @where = CONCAT('WHERE `pv`.`patient_id` = ''', `@patient_id`, ''' AND `pv`.`procedure_date` BETWEEN ''', `@from`, ''' AND ''', `@to`, '''');
END IF;


SET @queryString = CONCAT('SELECT *
					       FROM `dental_mis`.`procedure_view` `pv` ', @where, ' ORDER BY `pv`.`procedure_created_date` DESC');
                    
PREPARE myquery FROM @queryString;
EXECUTE myquery;
                
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_procedure_search_procedure_id`;
DELIMITER |
CREATE PROCEDURE `usp_procedure_search_procedure_id`(IN
	`@procedure_type_id` BIGINT(8)
)
BEGIN
	SELECT 
		*
	FROM `dental_mis`.`procedure_view` `pv`
    WHERE `pv`.`id` = `@id`
    ORDER BY `pv`.`procedure_created_by` DESC;
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_procedure_tooth_create`;
DELIMITER |
CREATE PROCEDURE `usp_procedure_tooth_create`(IN
	`@procedure_id` BIGINT,
    `@tooth_id` BIGINT,
    `@created_by` varchar(45)
)
BEGIN
	INSERT INTO `dental_mis`.`procedure_tooth`
	(`procedure_id`,
	`tooth_id`,
	`created_by`,
	`created_date`)
	VALUES
	(
		`@procedure_id`,
		`@tooth_id`,
		`@created_by`,
		now()
	);

	SELECT LAST_INSERT_ID();

END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_procedure_tooth_edit`;
DELIMITER |
CREATE PROCEDURE `usp_procedure_tooth_edit`(IN
	`@id` BIGINT,
    `@tooth_id` BIGINT,
    `@updated_by` varchar(45)
)
BEGIN
	UPDATE `dental_mis`.`procedure_tooth`
	SET
	`tooth_id` = `@tooth_id`,
	`updated_by` = `@updated_by`,
	`updated_date` = now()
	WHERE `id` = `@id`;


	SELECT `@id`;

END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_procedure_tooth_select_id`;
DELIMITER |
CREATE PROCEDURE `usp_procedure_tooth_select_id`(IN
	`@id` BIGINT
)
BEGIN
	SELECT 
		pt.`procedure_id`,
        pt.`tooth_id`,
        t.`description` `tooth`
    FROM `dental_mis`.`procedure_tooth` pt 
    LEFT JOIN `dental_mis`.`tooth` t
	ON pt.tooth_id = t.id
	WHERE pt.`id` = `@id`;
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_procedure_tooth_select_procedure_id`;
DELIMITER |
CREATE PROCEDURE `usp_procedure_tooth_select_procedure_id`(IN
	`@procedure_id` BIGINT
)
BEGIN
	SELECT 
		pt.`id`,
		pt.`procedure_id`,
        pt.`tooth_id`,
        t.`description` `tooth`
    FROM `dental_mis`.`procedure_tooth` pt 
    LEFT JOIN `dental_mis`.`tooth` t
	ON pt.tooth_id = t.id
	WHERE pt.`procedure_id` = `@procedure_id`;
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_procedure_type_create`;
DELIMITER |
CREATE PROCEDURE `usp_procedure_type_create`(IN
	`@name` VARCHAR(45),
	`@base_price` FLOAT,
	`@payment_type` VARCHAR(45),
	`@require_med_cert` TINYINT,
    `@require_tooth` VARCHAR(45),
	`@status` TINYINT,
	`@created_by` VARCHAR(45)
)
BEGIN
	DECLARE `@if_exist` INT;
    SET `@if_exist` = (SELECT 1 FROM `dental_mis`.`procedure_type` WHERE
						LOWER(`name`) = LOWER(`@name`) AND
                        `base_price` = `@base_price` AND
                        `payment_type` = `@payment_type` AND
                        `require_med_cert` = `@require_med_cert` AND
                        `require_tooth` = `@require_tooth` AND
                        `status` = `@status`);
                        
	IF `@if_exist` = 1 THEN
		SELECT 0;
	ELSE
		INSERT INTO `dental_mis`.`procedure_type`
		(
			`name`,
			`base_price`,
			`payment_type`,
			`require_med_cert`,
            `require_tooth`,
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
            `@require_tooth`,
			`@status`,
			`@created_by`,
            NOW()
		);
		
		SELECT LAST_INSERT_ID();
	END IF;
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_procedure_type_edit`;
DELIMITER |
CREATE PROCEDURE `usp_procedure_type_edit`(IN
	`@id` BIGINT(8),
	`@name` VARCHAR(45),
	`@base_price` FLOAT,
	`@payment_type` VARCHAR(45),
	`@require_med_cert` TINYINT,
    `@require_tooth` VARCHAR(45),
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
    `require_tooth` = `@require_tooth`,
	`status` = `@status`,
	`updated_by` = `@updated_by`,
	`updated_date` = NOW()
	WHERE `id` = `@id`;
    
    SELECT `@id`;
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_procedure_type_pair_create`;
DELIMITER |
CREATE PROCEDURE `usp_procedure_type_pair_create`(IN
	`@procedure_type_id` BIGINT,
    `@procedure_type_id_pair` BIGINT,
    `@visibility_type` varchar(254),
    `@status` BOOLEAN,
    `@created_by` NVARCHAR(45)
)
BEGIN
	DECLARE `@if_exist` INT;
    SET `@if_exist` = (SELECT 1 FROM `dental_mis`.`procedure_type_pair` WHERE
						`procedure_type_id` = `@procedure_type_id` AND
                        `procedure_type_id_pair` = `@procedure_type_id_pair` AND
                        `status` = `@status`);
                        
	IF `@if_exist` = 1 THEN
		SELECT 0;
	ELSE
		INSERT INTO `dental_mis`.`procedure_type_pair`
		(`procedure_type_id`,
		`procedure_type_id_pair`,
		`visibility_type`,
		`status`,
		`created_by`,
		`created_date`)
		VALUES
		(`@procedure_type_id`,
		`@procedure_type_id_pair`,
        `@visibility_type`,
        `@status`,
		`@created_by`,
        now());

		
		SELECT LAST_INSERT_ID();
	END IF;
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_procedure_type_pair_edit`;
DELIMITER |
CREATE PROCEDURE `usp_procedure_type_pair_edit`(IN
	`@id` BIGINT,
	`@procedure_type_id` BIGINT,
    `@procedure_type_id_pair` BIGINT,
    `@visibility_type` varchar(254),
    `@status` BOOLEAN,
    `@updated_by` NVARCHAR(45)
)
BEGIN
	UPDATE `dental_mis`.`procedure_type_pair`
	SET
	`procedure_type_id` = `@procedure_type_id`,
	`procedure_type_id_pair` = `@procedure_type_id_pair`,
    `visibility_type` = `@visibility_type`,
    `status` = `@status`,
	`updated_by` = `@updated_by`,
	`updated_date` = NOW()
	WHERE `id` = `@id`;
    
    SELECT `@id`;
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_procedure_type_pair_select`;
DELIMITER |
CREATE PROCEDURE `usp_procedure_type_pair_select`(IN
	`@procedure_id` BIGINT 
)
BEGIN
	SELECT
		`ptn`.`id`,
		`ptn`.`procedure_type_id`,
		`ptn`.`procedure_type_id_pair`,
        `ptn`.`visibility_type`,
        `pt`.`name`,
        `ptn`.`status`,
		CONCAT(`cc`.`firstname`,' ', `cc`.`lastname`)  `created_by`,
		`ptn`.`created_date`,
		CONCAT(`cu`.`firstname`,' ', `cu`.`lastname`) `updated_by`,
		`ptn`.`updated_date`
	FROM `dental_mis`.`procedure_type_pair` `ptn`
    LEFT JOIN `dental_mis`.`procedure_type` `pt`
    ON `ptn`.`procedure_type_id_pair` = `pt`.`id`
	LEFT JOIN `dental_mis`.`user` `cc` ON
	`cc`.`id` = `ptn`.`created_by`
	LEFT JOIN `dental_mis`.`user` `cu` ON
	`cu`.`id` = `ptn`.`updated_by`      
    WHERE `ptn`.`procedure_type_id` = `@procedure_id`;
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_procedure_type_pair_select_id`;
DELIMITER |
CREATE PROCEDURE `usp_procedure_type_pair_select_id`(IN
	`@id` BIGINT 
)
BEGIN
	SELECT
		`ptn`.`id`,
		`ptn`.`procedure_type_id`,
		`ptn`.`procedure_type_id_pair`,
        `ptn`.`visibility_type`,
        `pt`.`name`,
        `ptn`.`status`,
		CONCAT(`cc`.`firstname`,' ', `cc`.`lastname`)  `created_by`,
		`ptn`.`created_date`,
		CONCAT(`cu`.`firstname`,' ', `cu`.`lastname`) `updated_by`,
		`ptn`.`updated_date`
	FROM `dental_mis`.`procedure_type_pair` `ptn`
    LEFT JOIN `dental_mis`.`procedure_type` `pt`
    ON `ptn`.`procedure_type_id_pair` = `pt`.`id`
	LEFT JOIN `dental_mis`.`user` `cc` ON
	`cc`.`id` = `ptn`.`created_by`
	LEFT JOIN `dental_mis`.`user` `cu` ON
	`cu`.`id` = `ptn`.`updated_by`      
    WHERE 
		  `ptn`.`id` = `@id`;

END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_procedure_type_search`;
DELIMITER |
CREATE PROCEDURE `usp_procedure_type_search`(
)
BEGIN

		SELECT `pt`.`id`,
			`pt`.`name`,
			`pt`.`base_price`,
			`pt`.`payment_type`,
			IF(`pt`.`require_med_cert` = 1, 'Yes','No') `require_med_cert`,
			`pt`.`require_tooth`,
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
        WHERE `pt`.`status`;
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_procedure_type_search_id`;
DELIMITER |
CREATE PROCEDURE `usp_procedure_type_search_id`(IN
	`@id` BIGINT(8)
)
BEGIN
	SELECT `pt`.`id`,
		`pt`.`name`,
		`pt`.`base_price`,
		`pt`.`payment_type`,
		IF(`pt`.`require_med_cert` = 1, 'Yes','No') `require_med_cert`,
        `pt`.`require_tooth`,
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
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_procedure_type_search_like`;
DELIMITER |
CREATE PROCEDURE `usp_procedure_type_search_like`(IN
	`@search_text` TEXT
)
BEGIN
	IF `@search_text` <> '' THEN
		SELECT `pt`.`id`,
			`pt`.`name`,
			`pt`.`base_price`,
			`pt`.`payment_type`,
			IF(`pt`.`require_med_cert` = 1, 'Yes','No') `require_med_cert`,
            `pt`.`require_tooth`,
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
		WHERE (`pt`.`name` LIKE CONCAT('%', `@search_text`, '%'));
	ELSE 
		SELECT `pt`.`id`,
			`pt`.`name`,
			`pt`.`base_price`,
			`pt`.`payment_type`,
			IF(`pt`.`require_med_cert` = 1, 'Yes','No') `require_med_cert`,
			`pt`.`require_tooth`,
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
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_procedure_type_search_tooth`;
DELIMITER |
CREATE PROCEDURE `usp_procedure_type_search_tooth`(IN
	`@patiend_id` BIGINT,
    `@tooth_number` INT
)
BEGIN
		SELECT `pt`.`id`,
			`pt`.`name`,
			`pt`.`base_price`,
			`pt`.`payment_type`,
			IF(`pt`.`require_med_cert` = 1, 'Yes','No') `require_med_cert`,
			`pt`.`require_tooth`,
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
        WHERE `pt`.`status` AND `pt`.`id` NOT IN(
											SELECT pt.id FROM dental_mis.procedure_type pt
											LEFT JOIN dental_mis.procedure_type_pair ptn
											ON pt.id = ptn.procedure_type_id_pair
											WHERE ptn.status = true AND
												  ptn.procedure_type_id IN(SELECT * FROM dental_mis.procedure p
																		   LEFT JOIN dental_mis.procedure_tooth pto
																		   ON p.id = pto.procedure_id
																		   LEFT JOIN dental_mis.tooth t
																		   ON pto.tooth_id = t.id
																		   WHERE p.patient_id = `@patiend_id` AND 
																				 pto.tooth_id = `@tooth_number`));
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_schedule_create`;
DELIMITER |
CREATE PROCEDURE `usp_schedule_create`(in
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
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_schedule_edit`;
DELIMITER |
CREATE PROCEDURE `usp_schedule_edit`(in
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
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_schedule_select`;
DELIMITER |
CREATE PROCEDURE `usp_schedule_select`(in
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
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_schedule_select_report`;
DELIMITER |
CREATE PROCEDURE `usp_schedule_select_report`(in
	`@from` NVARCHAR(20),
    `@to` NVARCHAR(20)
)
BEGIN
	IF `@from` = '' AND `@to` = '' THEN
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
		WHERE NOT `s`.`is_deleted`
        ORDER BY `s`.`start_time` ASC
	)z, (SELECT @r:=0)y;     
    ELSE
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
		WHERE DATE_FORMAT(`s`.`start_time`, '%Y-%m-%d') BETWEEN `@from` AND `@to` AND
			  NOT `s`.`is_deleted`
        ORDER BY `s`.`start_time` ASC
	)z, (SELECT @r:=0)y; 
    END IF;

END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_secret_question_create`;
DELIMITER |
CREATE PROCEDURE `usp_secret_question_create`(IN
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
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_secret_question_edit`;
DELIMITER |
CREATE PROCEDURE `usp_secret_question_edit`(IN
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
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_secret_question_select`;
DELIMITER |
CREATE PROCEDURE `usp_secret_question_select`(IN
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
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_secret_question_select_id`;
DELIMITER |
CREATE PROCEDURE `usp_secret_question_select_id`(IN
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
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_user_create`;
DELIMITER |
CREATE PROCEDURE `usp_user_create`(IN
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
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_user_edit`;
DELIMITER |
CREATE PROCEDURE `usp_user_edit`(IN
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
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_user_forgot_password`;
DELIMITER |
CREATE PROCEDURE `usp_user_forgot_password`(IN
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
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_user_login`;
DELIMITER |
CREATE PROCEDURE `usp_user_login`(IN
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
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_user_search_id`;
DELIMITER |
CREATE PROCEDURE `usp_user_search_id`(IN
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
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_user_search_like`;
DELIMITER |
CREATE PROCEDURE `usp_user_search_like`(IN
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
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_user_search_status`;
DELIMITER |
CREATE PROCEDURE `usp_user_search_status`(IN
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
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_user_type_create`;
DELIMITER |
CREATE PROCEDURE `usp_user_type_create`(IN
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
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_user_type_edit`;
DELIMITER |
CREATE PROCEDURE `usp_user_type_edit`(IN
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
END |
DELIMITER ;

DROP PROCEDURE IF EXISTS `usp_user_type_search_id`;
DELIMITER |
CREATE PROCEDURE `usp_user_type_search_id`(IN
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
END |
DELIMITER ;

-- 
-- Dumping views
-- 

DROP TABLE IF EXISTS `audit_trail_view`;
DROP VIEW IF EXISTS `audit_trail_view`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `audit_trail_view` AS select `at`.`id` AS `id`,`at`.`action` AS `action`,concat(`u`.`firstname`,' ',`u`.`lastname`) AS `created_by`,`at`.`created_date` AS `created_date` from (`audit_trail` `at` left join `user` `u` on((`at`.`created_by` = `u`.`id`)));

DROP TABLE IF EXISTS `patient_view`;
DROP VIEW IF EXISTS `patient_view`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `patient_view` AS select `p`.`id` AS `id`,concat(date_format(`p`.`created_date`,'%Y'),lpad(`p`.`id`,4,'0')) AS `patient_number`,`p`.`firstname` AS `firstname`,`p`.`lastname` AS `lastname`,`p`.`middle_name` AS `middle_name`,`p`.`suffix` AS `suffix`,concat(`p`.`firstname`,' ',if((isnull(`p`.`middle_name`) or (`p`.`middle_name` = '')),'',concat(`ACRONYM`(`p`.`middle_name`),' ')),`p`.`lastname`,if((isnull(`p`.`suffix`) or (`p`.`suffix` = '')),'',concat(' ',`p`.`suffix`))) AS `full_name`,`p`.`address_house_number` AS `address_house_number`,`p`.`address_street_building` AS `address_street_building`,`p`.`address_municipality` AS `address_municipality`,concat(`p`.`address_house_number`,' ',`p`.`address_street_building`,' ',`p`.`address_municipality`) AS `address`,`p`.`birthday` AS `birthday`,`p`.`age` AS `age`,`p`.`gender` AS `gender`,`p`.`occupation` AS `occupation`,`p`.`contact_number` AS `contact_number`,`p`.`civil_status` AS `civil_status`,concat(`cc`.`firstname`,' ',`cc`.`lastname`) AS `created_by`,`p`.`created_date` AS `created_date`,concat(`cu`.`firstname`,' ',`cu`.`lastname`) AS `updated_by`,`p`.`updated_date` AS `updated_date` from ((`patient` `p` left join `user` `cc` on((`cc`.`id` = `p`.`created_by`))) left join `user` `cu` on((`cu`.`id` = `p`.`updated_by`)));

DROP TABLE IF EXISTS `procedure_view`;
DROP VIEW IF EXISTS `procedure_view`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `procedure_view` AS select `p`.`id` AS `id`,`p`.`patient_id` AS `patient_id`,`pa`.`patient_number` AS `patient_number`,`p`.`procedure_type_id` AS `procedure_type_id`,`pa`.`full_name` AS `full_name`,`pa`.`age` AS `age`,`pa`.`address` AS `address`,`pa`.`gender` AS `gender`,group_concat(`t`.`description` separator ', ') AS `tooth`,`pt`.`name` AS `procedure_name`,`p`.`date` AS `procedure_date`,`pt`.`payment_type` AS `payment_type`,if(isnull(`p`.`amount_to_pay`),0,`p`.`amount_to_pay`) AS `amount_to_pay`,if(isnull(`py`.`amount_paid`),0,`py`.`amount_paid`) AS `amount_paid`,if(isnull(`py`.`amount_paid`),`p`.`amount_to_pay`,(`p`.`amount_to_pay` - `py`.`amount_paid`)) AS `balance`,if((`p`.`amount_to_pay` <> if(isnull(`py`.`amount_paid`),0,`py`.`amount_paid`)),'Not Paid','Paid') AS `payment_status`,`py`.`date` AS `payment_date`,concat(`cc`.`firstname`,' ',`cc`.`lastname`) AS `procedure_created_by`,`p`.`created_date` AS `procedure_created_date`,concat(`cu`.`firstname`,' ',`cu`.`lastname`) AS `procedure_updated_by`,`p`.`updated_date` AS `procedure_updated_date`,concat(`pc`.`firstname`,' ',`pc`.`lastname`) AS `payment_created_by`,`py`.`created_date` AS `payment_created_date`,concat(`pu`.`firstname`,' ',`pu`.`lastname`) AS `payment_updated_by`,`py`.`updated_date` AS `payment_updated_date` from (((((((((`dental_mis`.`procedure` `p` left join `dental_mis`.`procedure_type` `pt` on((`p`.`procedure_type_id` = `pt`.`id`))) left join `dental_mis`.`procedure_tooth` `ptt` on((`p`.`id` = `ptt`.`procedure_id`))) left join `dental_mis`.`tooth` `t` on((`t`.`id` = `ptt`.`tooth_id`))) left join (select `dental_mis`.`payment`.`id` AS `id`,`dental_mis`.`payment`.`procedure_id` AS `procedure_id`,sum(`dental_mis`.`payment`.`amount_paid`) AS `amount_paid`,`dental_mis`.`payment`.`date` AS `date`,`dental_mis`.`payment`.`created_by` AS `created_by`,`dental_mis`.`payment`.`created_date` AS `created_date`,`dental_mis`.`payment`.`updated_by` AS `updated_by`,`dental_mis`.`payment`.`updated_date` AS `updated_date` from `dental_mis`.`payment` group by `dental_mis`.`payment`.`procedure_id`) `py` on((`py`.`procedure_id` = `p`.`id`))) left join `dental_mis`.`patient_view` `pa` on((`p`.`patient_id` = `pa`.`id`))) left join `dental_mis`.`user` `cc` on((`cc`.`id` = `p`.`created_by`))) left join `dental_mis`.`user` `cu` on((`cu`.`id` = `p`.`updated_by`))) left join `dental_mis`.`user` `pc` on((`pc`.`id` = `py`.`created_by`))) left join `dental_mis`.`user` `pu` on((`pu`.`id` = `py`.`updated_by`))) group by `p`.`id`;

DROP TABLE IF EXISTS `user_view`;
DROP VIEW IF EXISTS `user_view`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `user_view` AS select `u`.`id` AS `id`,`u`.`user_type_id` AS `user_type_id`,`u`.`secret_question_id` AS `secret_question_id`,`ut`.`name` AS `user_type`,`u`.`username` AS `username`,`u`.`password` AS `password`,`sc`.`question` AS `secret_question`,`u`.`secret_question_answer` AS `secret_question_answer`,`u`.`firstname` AS `firstname`,`u`.`lastname` AS `lastname`,`u`.`status` AS `status`,concat(`usrc`.`firstname`,' ',`usrc`.`lastname`) AS `created_by`,`u`.`created_date` AS `created_date`,concat(`usru`.`firstname`,' ',`usru`.`lastname`) AS `updated_by`,`u`.`updated_date` AS `updated_date` from ((((`user` `u` left join `user_type` `ut` on((`u`.`user_type_id` = `ut`.`id`))) left join `secret_question` `sc` on((`u`.`secret_question_id` = `sc`.`id`))) left join `user` `usrc` on((`usrc`.`id` = `u`.`created_by`))) left join `user` `usru` on((`usru`.`id` = `u`.`updated_by`)));


-- 
-- Dumping triggers
-- 

DROP TRIGGER /*!50030 IF EXISTS */ `patient_AFTER_INSERT`;
DELIMITER |
CREATE TRIGGER `dental_mis`.`patient_AFTER_INSERT` AFTER INSERT ON `patient` FOR EACH ROW
BEGIN
	INSERT INTO `dental_mis`.`audit_trail`
	(`action`,
	 `created_by`)
	VALUES
	(CONCAT('Patient Create ', NEW.`firstname`, ' ', NEW.`lastname`),
	 NEW.`created_by`);
END |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `patient_AFTER_UPDATE`;
DELIMITER |
CREATE TRIGGER `dental_mis`.`patient_AFTER_UPDATE` AFTER UPDATE ON `patient` FOR EACH ROW
BEGIN
	INSERT INTO `dental_mis`.`audit_trail`
	(`action`,
	 `created_by`)
	VALUES
	(CONCAT('Patient Edit ', NEW.`firstname`, ' ', NEW.`lastname`),
	 NEW.`updated_by`);
END |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `payment_AFTER_INSERT`;
DELIMITER |
CREATE TRIGGER `dental_mis`.`payment_AFTER_INSERT` AFTER INSERT ON `payment` FOR EACH ROW
BEGIN
	INSERT INTO `dental_mis`.`audit_trail`
	(`action`,
	 `created_by`)
	VALUES
	(CONCAT('Payment Create  Procedure ID ', NEW.`procedure_id`),
	 NEW.`created_by`);
END |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `payment_AFTER_UPDATE`;
DELIMITER |
CREATE TRIGGER `dental_mis`.`payment_AFTER_UPDATE` AFTER UPDATE ON `payment` FOR EACH ROW
BEGIN
	INSERT INTO `dental_mis`.`audit_trail`
	(`action`,
	 `created_by`)
	VALUES
	(CONCAT('Payment Edit Procedure ID ', NEW.`procedure_id`),
	 NEW.`updated_by`);
END |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `procedure_AFTER_INSERT`;
DELIMITER |
CREATE TRIGGER `dental_mis`.`procedure_AFTER_INSERT` AFTER INSERT ON `procedure` FOR EACH ROW
BEGIN
	INSERT INTO `dental_mis`.`audit_trail`
	(`action`,
	 `created_by`)
	VALUES
	(CONCAT('Procedure Create Patient ID ', NEW.`patient_id`),
	 NEW.`created_by`);
END |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `procedure_AFTER_UPDATE`;
DELIMITER |
CREATE TRIGGER `dental_mis`.`procedure_AFTER_UPDATE` AFTER UPDATE ON `procedure` FOR EACH ROW
BEGIN
	INSERT INTO `dental_mis`.`audit_trail`
	(`action`,
	 `created_by`)
	VALUES
	(CONCAT('Procedure Edit Patient ID ', NEW.`patient_id`),
	 NEW.`updated_by`);
END |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `procedure_remark_AFTER_INSERT`;
DELIMITER |
CREATE TRIGGER `dental_mis`.`procedure_remark_AFTER_INSERT` AFTER INSERT ON `procedure_remark` FOR EACH ROW
BEGIN
	INSERT INTO `dental_mis`.`audit_trail`
	(`action`,
	 `created_by`)
	VALUES
	(CONCAT('Add Remarks on Procedure ID ', NEW.`procedure_id`),
	 NEW.`created_by`);
END |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `procedure_remark_AFTER_UPDATE`;
DELIMITER |
CREATE TRIGGER `dental_mis`.`procedure_remark_AFTER_UPDATE` AFTER UPDATE ON `procedure_remark` FOR EACH ROW
BEGIN
	INSERT INTO `dental_mis`.`audit_trail`
	(`action`,
	 `created_by`)
	VALUES
	(CONCAT('Update Remarks on Procedure ID ', NEW.`procedure_id`),
	 NEW.`updated_by`);
END |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `procedure_tooth_AFTER_INSERT`;
DELIMITER |
CREATE TRIGGER `dental_mis`.`procedure_tooth_AFTER_INSERT` AFTER INSERT ON `procedure_tooth` FOR EACH ROW
BEGIN
	INSERT INTO `dental_mis`.`audit_trail`
	(`action`,
	 `created_by`)
	VALUES
	(CONCAT('Add Tooth on Procedure ID ', NEW.`procedure_id`),
	 NEW.`created_by`);
END |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `procedure_tooth_AFTER_UPDATE`;
DELIMITER |
CREATE TRIGGER `dental_mis`.`procedure_tooth_AFTER_UPDATE` AFTER UPDATE ON `procedure_tooth` FOR EACH ROW
BEGIN
	INSERT INTO `dental_mis`.`audit_trail`
	(`action`,
	 `created_by`)
	VALUES
	(CONCAT('Update Tooth on Procedure ID ', NEW.`procedure_id`),
	 NEW.`updated_by`);
END |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `procedure_type_AFTER_INSERT`;
DELIMITER |
CREATE TRIGGER `dental_mis`.`procedure_type_AFTER_INSERT` AFTER INSERT ON `procedure_type` FOR EACH ROW
BEGIN
	INSERT INTO `dental_mis`.`audit_trail`
	(`action`,
	 `created_by`)
	VALUES
	(CONCAT('Procedure Type Create ', NEW.`name`),
	 NEW.`created_by`);
END |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `procedure_type_AFTER_UPDATE`;
DELIMITER |
CREATE TRIGGER `dental_mis`.`procedure_type_AFTER_UPDATE` AFTER UPDATE ON `procedure_type` FOR EACH ROW
BEGIN
	INSERT INTO `dental_mis`.`audit_trail`
	(`action`,
	 `created_by`)
	VALUES
	(CONCAT('Procedure Type Edit ', NEW.`name`),
	 NEW.`updated_by`);
END |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `schedule_AFTER_INSERT`;
DELIMITER |
CREATE TRIGGER `dental_mis`.`schedule_AFTER_INSERT` AFTER INSERT ON `schedule` FOR EACH ROW
BEGIN
	INSERT INTO `dental_mis`.`audit_trail`
	(`action`,
	 `created_by`)
	VALUES
	(CONCAT('Schedule Create Schedule ID ', NEW.`id`),
	 NEW.`created_by`);
END |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `schedule_AFTER_UPDATE`;
DELIMITER |
CREATE TRIGGER `dental_mis`.`schedule_AFTER_UPDATE` AFTER UPDATE ON `schedule` FOR EACH ROW
BEGIN
	INSERT INTO `dental_mis`.`audit_trail`
	(`action`,
	 `created_by`)
	VALUES
	(CONCAT('Schedule Edit Schedule ID ', NEW.`id`),
	 NEW.`updated_by`);
END |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `user_AFTER_INSERT`;
DELIMITER |
CREATE TRIGGER `dental_mis`.`user_AFTER_INSERT` AFTER INSERT ON `user` FOR EACH ROW
BEGIN
	INSERT INTO `dental_mis`.`audit_trail`
	(`action`,
	 `created_by`)
	VALUES
	(CONCAT('User Create User ID ', NEW.`id`),
	 NEW.`created_by`);
END |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `user_AFTER_UPDATE`;
DELIMITER |
CREATE TRIGGER `dental_mis`.`user_AFTER_UPDATE` AFTER UPDATE ON `user` FOR EACH ROW
BEGIN
	INSERT INTO `dental_mis`.`audit_trail`
	(`action`,
	 `created_by`)
	VALUES
	(CONCAT('User Edit User ID ', NEW.`id`),
	 NEW.`created_by`);
END |
DELIMITER ;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2018-03-26 02:23:18
-- Total time: 0:0:0:0:99 (d:h:m:s:ms)
