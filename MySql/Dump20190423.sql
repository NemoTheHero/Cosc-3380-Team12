-- MySQL dump 10.13  Distrib 5.7.24, for Win64 (x86_64)
--
-- Host: cosc3380-02-team12.mysql.database.azure.com    Database: zoo
-- ------------------------------------------------------
-- Server version	5.6.39.0

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
-- Table structure for table `animal`
--

DROP TABLE IF EXISTS `animal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `animal` (
  `animal_id` int(10) unsigned NOT NULL,
  `animal_name` varchar(15) NOT NULL,
  `species` int(10) unsigned NOT NULL,
  `health_profile` int(10) unsigned NOT NULL,
  `diet` int(10) unsigned NOT NULL,
  `exhibit` int(10) unsigned NOT NULL,
  `date` date DEFAULT NULL,
  PRIMARY KEY (`animal_id`),
  KEY `ANIMAL_PROFILE_FK` (`health_profile`),
  KEY `ANIMAL_DIET_FK` (`diet`),
  KEY `ANIMAL_EXHIBIT_FK` (`exhibit`),
  KEY `ANIMAL_SPECIES_FK` (`species`),
  CONSTRAINT `ANIMAL_DIET_FK` FOREIGN KEY (`diet`) REFERENCES `diet` (`diet_id`) ON UPDATE CASCADE,
  CONSTRAINT `ANIMAL_EXHIBIT_FK` FOREIGN KEY (`exhibit`) REFERENCES `exhibit` (`exhibit_id`) ON UPDATE CASCADE,
  CONSTRAINT `ANIMAL_PROFILE_FK` FOREIGN KEY (`health_profile`) REFERENCES `health_profile` (`profile_id`) ON UPDATE CASCADE,
  CONSTRAINT `ANIMAL_SPECIES_FK` FOREIGN KEY (`species`) REFERENCES `enum_species` (`species_id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `animal`
--

LOCK TABLES `animal` WRITE;
/*!40000 ALTER TABLE `animal` DISABLE KEYS */;
INSERT INTO `animal` VALUES (1,'Buddy',1,1,1,1,'2019-04-21'),(2,'ALISTAR',2,4,1,3,'2019-04-21'),(3,'Leo',1,5,1,1,'2019-04-21'),(4,'BIG JAW',77,6,3,3,'2019-04-22'),(5,'Lil Wayne',26,7,1,3,'2019-04-22'),(6,'Newt',67,8,2,4,'2019-04-22'),(7,'Kesha',35,9,2,1,'2019-04-22'),(8,'Cocobongo',1,10,1,1,'2019-04-22'),(12,'Buggy',1,11,1,1,'2019-04-22'),(13,'TIREN',67,12,1,1,'2019-04-22');
/*!40000 ALTER TABLE `animal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `animal_handler`
--

DROP TABLE IF EXISTS `animal_handler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `animal_handler` (
  `animal_id` int(10) unsigned NOT NULL,
  `empl_id` int(10) unsigned NOT NULL,
  KEY `ANIMAL_ID_FK` (`animal_id`),
  KEY `EMPL_ID_FK` (`empl_id`),
  CONSTRAINT `ANIMAL_ID_FK` FOREIGN KEY (`animal_id`) REFERENCES `animal` (`animal_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `EMPL_ID_FK` FOREIGN KEY (`empl_id`) REFERENCES `employee` (`empl_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `animal_handler`
--

LOCK TABLES `animal_handler` WRITE;
/*!40000 ALTER TABLE `animal_handler` DISABLE KEYS */;
INSERT INTO `animal_handler` VALUES (1,1);
/*!40000 ALTER TABLE `animal_handler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `contact`
--

DROP TABLE IF EXISTS `contact`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `contact` (
  `phone_no` varchar(10) NOT NULL,
  `email_addr` varchar(30) NOT NULL,
  `addr_line` varchar(30) NOT NULL,
  `city` varchar(15) NOT NULL,
  `state` char(2) NOT NULL,
  `zip_code` varchar(9) NOT NULL,
  PRIMARY KEY (`phone_no`),
  KEY `CONTACT_STATE_FK` (`state`),
  CONSTRAINT `CONTACT_STATE_FK` FOREIGN KEY (`state`) REFERENCES `enum_state` (`state_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contact`
--

LOCK TABLES `contact` WRITE;
/*!40000 ALTER TABLE `contact` DISABLE KEYS */;
INSERT INTO `contact` VALUES ('0','mary@bakeoff.co.uk','4321 Tent Rd','London','TX','54321'),('1111111111','colten@zoologic.com','4400 Cullen','Houston','TX','77004'),('1112223333','alan@qi.co.uk','1234 Interesting Blvd','London','TX','12345'),('1231231230','judah@att.net','123 Judea Ave','Canaan','NV','12345'),('1234123455','nemo@zoologic.com','4400 Calhoun','Houston','TX','77004'),('1234567890','sandi@qi.co.uk','1234 Interesting Blvd','London','TX','12345'),('1324354657','sue@bakeoff.co.uk','4321 Tent Rd','London','TX','54321'),('2343429434','TheIronHandle@Grip.com','ManLand','The Pit','KS','77054'),('2818069649','ryancarlos1997@gmail.com','8101 Kirchner Rd','Manvel','TX','77578'),('3332221111','david@wilty.co.uk','1111 Truth Or Lie Ln','London','TX','11111'),('4294967295','stephen@qi.co.uk','1234 Interesting Blvd','London','TX','12345'),('7131112222','paul@bakeoff.co.uk','4321 Tent Rd','London','TX','54321');
/*!40000 ALTER TABLE `contact` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `diet`
--

DROP TABLE IF EXISTS `diet`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `diet` (
  `diet_id` int(10) unsigned NOT NULL,
  `diet_type` int(10) unsigned NOT NULL,
  `feeding_size` decimal(6,3) NOT NULL,
  `feeding_unit` varchar(2) NOT NULL,
  `feedings_per_day` int(10) unsigned NOT NULL,
  PRIMARY KEY (`diet_id`),
  KEY `DIET_TYPE_FK` (`diet_type`),
  KEY `DIET_UNIT_FK` (`feeding_unit`),
  CONSTRAINT `DIET_TYPE_FK` FOREIGN KEY (`diet_type`) REFERENCES `enum_diet_type` (`diet_type_id`) ON UPDATE CASCADE,
  CONSTRAINT `DIET_UNIT_FK` FOREIGN KEY (`feeding_unit`) REFERENCES `enum_unit_measure` (`unit_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `diet`
--

LOCK TABLES `diet` WRITE;
/*!40000 ALTER TABLE `diet` DISABLE KEYS */;
INSERT INTO `diet` VALUES (1,1,4.000,'kg',3),(2,2,1.000,'kg',3),(3,1,3.000,'kg',2),(4,2,5.000,'oz',3),(5,2,4.000,'lb',3),(6,1,3.000,'kg',2);
/*!40000 ALTER TABLE `diet` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `employee` (
  `empl_id` int(10) unsigned NOT NULL,
  `first_name` varchar(15) NOT NULL,
  `last_name` varchar(15) NOT NULL,
  `contact_info` varchar(10) NOT NULL,
  `job_position` int(10) unsigned NOT NULL,
  `department` int(10) unsigned NOT NULL,
  PRIMARY KEY (`empl_id`),
  KEY `EMPL_POSITION_FK` (`job_position`),
  KEY `EMPL_DEPT_FK` (`department`),
  KEY `EMPL_CONTACT_FK` (`contact_info`),
  CONSTRAINT `EMPL_CONTACT_FK` FOREIGN KEY (`contact_info`) REFERENCES `contact` (`phone_no`) ON UPDATE CASCADE,
  CONSTRAINT `EMPL_DEPT_FK` FOREIGN KEY (`department`) REFERENCES `enum_department` (`dept_id`) ON UPDATE CASCADE,
  CONSTRAINT `EMPL_POSITION_FK` FOREIGN KEY (`job_position`) REFERENCES `enum_job_position` (`position_id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee` VALUES (1,'Sandi','Toksvig','1234567890',1,1),(2,'Sue','Perkins','1324354657',2,2),(3,'Alan','Davies','1112223333',3,3),(4,'David','Mitchell','3332221111',4,4),(5,'Colten','Thompson','1111111111',4,4),(6,'Nemo','Robles','1234123455',3,4),(7,'Leroy','Jenkins','4294967295',5,6),(8,'Mary','Berry','0',2,2),(9,'Paul','Hollywood','7131112222',2,2);
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`team12admin`@`%`*/ /*!50003 TRIGGER generate_user_login
AFTER INSERT ON employee
FOR EACH ROW
INSERT INTO user_login VALUES
	(NEW.empl_id, CONCAT(NEW.first_name, NEW.last_name), CONCAT(NEW.first_name, NEW.last_name)) */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `enum_department`
--

DROP TABLE IF EXISTS `enum_department`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `enum_department` (
  `dept_id` int(10) unsigned NOT NULL,
  `dept_name` varchar(30) NOT NULL,
  PRIMARY KEY (`dept_id`),
  UNIQUE KEY `ENUM_DEPARTMENT_CK` (`dept_name`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enum_department`
--

LOCK TABLES `enum_department` WRITE;
/*!40000 ALTER TABLE `enum_department` DISABLE KEYS */;
INSERT INTO `enum_department` VALUES (4,'admin'),(6,'Animal Handling'),(2,'maintenance'),(1,'member services'),(3,'veterinary'),(5,'working');
/*!40000 ALTER TABLE `enum_department` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enum_diet_type`
--

DROP TABLE IF EXISTS `enum_diet_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `enum_diet_type` (
  `diet_type_id` int(10) unsigned NOT NULL,
  `diet_type_name` varchar(15) NOT NULL,
  PRIMARY KEY (`diet_type_id`),
  UNIQUE KEY `ENUM_DIET_TYPE_CK` (`diet_type_name`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enum_diet_type`
--

LOCK TABLES `enum_diet_type` WRITE;
/*!40000 ALTER TABLE `enum_diet_type` DISABLE KEYS */;
INSERT INTO `enum_diet_type` VALUES (2,'Carnivore'),(1,'Herbivore'),(4,'Live Prey'),(3,'Omnivore');
/*!40000 ALTER TABLE `enum_diet_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enum_ecosystem`
--

DROP TABLE IF EXISTS `enum_ecosystem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `enum_ecosystem` (
  `ecosystem_id` int(10) unsigned NOT NULL,
  `ecosystem_name` varchar(30) NOT NULL,
  PRIMARY KEY (`ecosystem_id`),
  UNIQUE KEY `ENUM_ECOSYSTEM_CK` (`ecosystem_name`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enum_ecosystem`
--

LOCK TABLES `enum_ecosystem` WRITE;
/*!40000 ALTER TABLE `enum_ecosystem` DISABLE KEYS */;
INSERT INTO `enum_ecosystem` VALUES (13,'Aquatic'),(17,'Benthic'),(20,'Coral reef'),(8,'Desert'),(19,'Estuary'),(2,'Forest'),(23,'Freshwater'),(9,'Grassland'),(22,'Hydrothermal vent'),(18,'Inter-tidal'),(24,'Lentic'),(25,'Lotic'),(14,'Marine'),(12,'Mountain'),(15,'Oceanic'),(11,'Prairie'),(16,'Profundal'),(27,'Rain Forest'),(21,'Salt marsh'),(10,'Savanna'),(7,'Taiga'),(6,'Temperate deciduous forest'),(5,'Temperate evergreen forest'),(1,'Terrestrial'),(4,'Tropical deciduous forest'),(3,'Tropical evergreen forest'),(26,'Wetland');
/*!40000 ALTER TABLE `enum_ecosystem` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enum_facility_status`
--

DROP TABLE IF EXISTS `enum_facility_status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `enum_facility_status` (
  `facility_status_id` int(10) unsigned NOT NULL,
  `facility_status_name` varchar(15) NOT NULL,
  PRIMARY KEY (`facility_status_id`),
  UNIQUE KEY `ENUM_FACILITY_STATUS_CK` (`facility_status_name`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enum_facility_status`
--

LOCK TABLES `enum_facility_status` WRITE;
/*!40000 ALTER TABLE `enum_facility_status` DISABLE KEYS */;
INSERT INTO `enum_facility_status` VALUES (2,'out of order'),(1,'working');
/*!40000 ALTER TABLE `enum_facility_status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enum_facility_type`
--

DROP TABLE IF EXISTS `enum_facility_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `enum_facility_type` (
  `facility_type_id` int(10) unsigned NOT NULL,
  `facility_type_name` varchar(30) NOT NULL,
  PRIMARY KEY (`facility_type_id`),
  UNIQUE KEY `ENUM_FACILITY_TYPE_CK` (`facility_type_name`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enum_facility_type`
--

LOCK TABLES `enum_facility_type` WRITE;
/*!40000 ALTER TABLE `enum_facility_type` DISABLE KEYS */;
INSERT INTO `enum_facility_type` VALUES (2,'animal attraction'),(1,'restroom');
/*!40000 ALTER TABLE `enum_facility_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enum_health_condition`
--

DROP TABLE IF EXISTS `enum_health_condition`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `enum_health_condition` (
  `condition_id` int(10) unsigned NOT NULL,
  `condition_name` varchar(50) NOT NULL,
  PRIMARY KEY (`condition_id`),
  UNIQUE KEY `ENUM_HEALTH_CONDITION_CK` (`condition_name`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enum_health_condition`
--

LOCK TABLES `enum_health_condition` WRITE;
/*!40000 ALTER TABLE `enum_health_condition` DISABLE KEYS */;
INSERT INTO `enum_health_condition` VALUES (1,'Asthma'),(2,'Bacterial Infection'),(3,'Diabetes'),(4,'Fungal Infection'),(10,'Healthy'),(5,'Heartworms'),(6,'Intestinal Parasites'),(7,'Pregnant'),(8,'Severe Injury'),(9,'Stomach Virus');
/*!40000 ALTER TABLE `enum_health_condition` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enum_job_position`
--

DROP TABLE IF EXISTS `enum_job_position`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `enum_job_position` (
  `position_id` int(10) unsigned NOT NULL,
  `job_title` varchar(30) NOT NULL,
  PRIMARY KEY (`position_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enum_job_position`
--

LOCK TABLES `enum_job_position` WRITE;
/*!40000 ALTER TABLE `enum_job_position` DISABLE KEYS */;
INSERT INTO `enum_job_position` VALUES (1,'receptionist'),(2,'repairman'),(3,'veterinarian'),(4,'admin'),(5,'Animal Handler');
/*!40000 ALTER TABLE `enum_job_position` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enum_medication`
--

DROP TABLE IF EXISTS `enum_medication`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `enum_medication` (
  `med_id` int(10) unsigned NOT NULL,
  `med_name` varchar(30) NOT NULL,
  PRIMARY KEY (`med_id`),
  UNIQUE KEY `ENUM_MEDICATION_CK` (`med_name`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enum_medication`
--

LOCK TABLES `enum_medication` WRITE;
/*!40000 ALTER TABLE `enum_medication` DISABLE KEYS */;
INSERT INTO `enum_medication` VALUES (1,'amoxicillin'),(2,'fipronil'),(9,'Glycerine'),(3,'ketamine'),(4,'morphine'),(5,'nystatin'),(6,'praziquantal'),(8,'sucralfate'),(7,'tramadol');
/*!40000 ALTER TABLE `enum_medication` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enum_membership_status`
--

DROP TABLE IF EXISTS `enum_membership_status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `enum_membership_status` (
  `member_status_id` int(10) unsigned NOT NULL,
  `member_status_name` varchar(15) NOT NULL,
  PRIMARY KEY (`member_status_id`),
  UNIQUE KEY `ENUM_MEMBERSHIP_STATUS_CK` (`member_status_name`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enum_membership_status`
--

LOCK TABLES `enum_membership_status` WRITE;
/*!40000 ALTER TABLE `enum_membership_status` DISABLE KEYS */;
INSERT INTO `enum_membership_status` VALUES (1,'active'),(2,'inactive');
/*!40000 ALTER TABLE `enum_membership_status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enum_membership_type`
--

DROP TABLE IF EXISTS `enum_membership_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `enum_membership_type` (
  `member_type_id` int(10) unsigned NOT NULL,
  `member_type_name` varchar(15) NOT NULL,
  PRIMARY KEY (`member_type_id`),
  UNIQUE KEY `ENUM_MEMBER_TYPE_CK` (`member_type_name`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enum_membership_type`
--

LOCK TABLES `enum_membership_type` WRITE;
/*!40000 ALTER TABLE `enum_membership_type` DISABLE KEYS */;
INSERT INTO `enum_membership_type` VALUES (3,'Annual'),(2,'Seasonal'),(1,'Weekly');
/*!40000 ALTER TABLE `enum_membership_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enum_section`
--

DROP TABLE IF EXISTS `enum_section`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `enum_section` (
  `section_id` int(10) unsigned NOT NULL,
  `section_name` varchar(30) NOT NULL,
  PRIMARY KEY (`section_id`),
  UNIQUE KEY `ENUM_SECTION_CK` (`section_name`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enum_section`
--

LOCK TABLES `enum_section` WRITE;
/*!40000 ALTER TABLE `enum_section` DISABLE KEYS */;
INSERT INTO `enum_section` VALUES (4,'African Forest'),(5,'Bird Exhibits'),(2,'Cats, Hoofed Animals, & More'),(6,'Children\'s Zoo'),(1,'Elephants, Reptiles, & More'),(9,'Polar Caverns'),(8,'South America\'s Pantanal'),(7,'Texas Wetlands'),(3,'Wortham World of Primates');
/*!40000 ALTER TABLE `enum_section` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enum_species`
--

DROP TABLE IF EXISTS `enum_species`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `enum_species` (
  `species_id` int(10) unsigned NOT NULL,
  `species_name` varchar(45) NOT NULL,
  PRIMARY KEY (`species_id`),
  UNIQUE KEY `ENUM_SPECIES_CK` (`species_name`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enum_species`
--

LOCK TABLES `enum_species` WRITE;
/*!40000 ALTER TABLE `enum_species` DISABLE KEYS */;
INSERT INTO `enum_species` VALUES (35,'African Lion'),(21,'Amazon Milk Frog'),(2,'Ankole Cattle'),(17,'Asian Elephant'),(50,'Asian Small-Clawed Otter'),(73,'Attwater\'s Prairie Chicken'),(67,'Baird\'s Tapir'),(4,'Bald Eagle'),(5,'Bat'),(6,'Batfish'),(7,'Black Bear'),(28,'Black Howler Monkey'),(39,'Black Mamba'),(74,'Blue-Billed Curassow'),(38,'Blue-Throated Macaw'),(32,'Blue-Winged Kookaburra'),(9,'Capybara'),(10,'Cheeta'),(18,'Chilean Flamingo'),(11,'Chimpanzee'),(34,'Clouded Leopard'),(13,'Common Clownfish'),(69,'Common Warthog'),(63,'Coquerel\'s Sifaka'),(14,'Cougar'),(15,'Cownose Ray'),(8,'Eastern Bongo'),(71,'Flamingo'),(19,'Fossa'),(23,'Galapagos Tortoise'),(3,'Giant Anteater'),(46,'Giant Pacific Octopus'),(66,'Golden Lion Tamarin'),(65,'Golden-Headed Lion Tamarin'),(70,'Gorilla'),(72,'Grant\'s Zebra'),(1,'Green Anaconda'),(75,'Grey Crowned Crane'),(77,'Hippopotamus'),(27,'Houston Toad'),(29,'Jaguar'),(30,'King Cobra'),(31,'Komodo Dragon'),(61,'Lined Seahorse'),(36,'Lionfish'),(37,'Long Horned Cowfish'),(68,'Malayan Tiger'),(52,'Malaysian Painted River Terrapin'),(40,'Mariana Fruit Dove'),(25,'Masai Giraffe'),(41,'Meercat'),(42,'Micronesian Kingfisher'),(43,'Moon Jelly'),(44,'Naked Mole Rat'),(54,'North American Porcupine'),(51,'North American River Otter'),(24,'Northern White-Cheeked Gibbon'),(26,'Nubian Goat'),(45,'Ocelot'),(47,'Okapi'),(48,'Orangutan'),(49,'Ostrich'),(22,'Panamanian Golden Frog'),(76,'Pangolin'),(56,'Red Panda'),(53,'Red-Bellied Piranha'),(55,'Reticulated Python'),(33,'Ring-tailed Lemur'),(12,'San Esteban Island Chuckwalla'),(59,'Sea Lion'),(60,'Sea Turtle'),(62,'Siamang'),(57,'Southern White Rhinocerous'),(64,'St. Vincent Amazon Parrot'),(20,'Swift Fox'),(16,'Wattled Curassow'),(58,'White-faced Saki Monkey');
/*!40000 ALTER TABLE `enum_species` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enum_state`
--

DROP TABLE IF EXISTS `enum_state`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `enum_state` (
  `state_id` char(2) NOT NULL,
  `state_name` varchar(30) NOT NULL,
  PRIMARY KEY (`state_id`),
  UNIQUE KEY `ENUM_STATE_CK` (`state_name`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enum_state`
--

LOCK TABLES `enum_state` WRITE;
/*!40000 ALTER TABLE `enum_state` DISABLE KEYS */;
INSERT INTO `enum_state` VALUES ('AL','Alabama'),('AK','Alaska'),('AS','American Samoa'),('AZ','Arizona'),('AR','Arkansas'),('CA','California'),('CO','Colorado'),('CT','Connecticut'),('DE','Delaware'),('DC','District of Columbia'),('FM','Federated States of Micronesia'),('FL','Florida'),('GA','Georgia'),('GU','Guam'),('HI','Hawaii'),('ID','Idaho'),('IL','Illinois'),('IN','Indiana'),('IA','Iowa'),('KS','Kansas'),('KY','Kentucky'),('LA','Louisiana'),('ME','Maine'),('MH','Marshall Islands'),('MD','Maryland'),('MA','Massachusetts'),('MI','Michigan'),('MN','Minnesota'),('MS','Mississippi'),('MO','Missouri'),('MT','Montana'),('NE','Nebraska'),('NV','Nevada'),('NH','New Hampshire'),('NJ','New Jersey'),('NM','New Mexico'),('NY','New York'),('NC','North Carolina'),('ND','North Dakota'),('MP','Northern Mariana Islands'),('OH','Ohio'),('OK','Oklahoma'),('OR','Oregon'),('PW','Palau'),('PA','Pennsylvania'),('PR','Puerto Rico'),('RI','Rhode Island'),('SC','South Carolina'),('SD','South Dakota'),('TN','Tennessee'),('TX','Texas'),('UT','Utah'),('VT','Vermont'),('VI','Virgin Islands'),('VA','Virginia'),('WA','Washington'),('WV','West Virginia'),('WI','Wisconsin'),('WY','Wyoming');
/*!40000 ALTER TABLE `enum_state` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enum_unit_measure`
--

DROP TABLE IF EXISTS `enum_unit_measure`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `enum_unit_measure` (
  `unit_id` varchar(2) NOT NULL,
  `unit_name` varchar(15) NOT NULL,
  PRIMARY KEY (`unit_id`),
  UNIQUE KEY `ENUM_UNIT_MEASURE_CK` (`unit_name`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enum_unit_measure`
--

LOCK TABLES `enum_unit_measure` WRITE;
/*!40000 ALTER TABLE `enum_unit_measure` DISABLE KEYS */;
INSERT INTO `enum_unit_measure` VALUES ('bg','bag(s)'),('cc','cc(s)'),('cm','centimeter(s)'),('c','cup(s)'),('ft','feet'),('ga','gallon(s)'),('g','gram(s)'),('kg','kilogram(s)'),('km','kilometer(s)'),('l','liter(s)'),('m','meter(s)'),('mg','milligram'),('ml','milliliter(s)'),('mm','millimeter(s)'),('oz','ounce(s)'),('pk','pack(s)'),('p','pint(s)'),('lb','pound(s)'),('qt','quart(s)'),('un','unit(s)'),('yd','yard(s)');
/*!40000 ALTER TABLE `enum_unit_measure` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enum_work_order_type`
--

DROP TABLE IF EXISTS `enum_work_order_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `enum_work_order_type` (
  `order_type_id` int(10) unsigned NOT NULL,
  `order_type_name` varchar(30) NOT NULL,
  `facility_type` int(10) unsigned NOT NULL,
  PRIMARY KEY (`order_type_id`),
  UNIQUE KEY `ENUM_WORK_ORDER_TYPE_CK` (`order_type_name`),
  KEY `ORDER_FACILITY_TYPE_FK` (`facility_type`),
  CONSTRAINT `ORDER_FACILITY_TYPE_FK` FOREIGN KEY (`facility_type`) REFERENCES `enum_facility_type` (`facility_type_id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enum_work_order_type`
--

LOCK TABLES `enum_work_order_type` WRITE;
/*!40000 ALTER TABLE `enum_work_order_type` DISABLE KEYS */;
INSERT INTO `enum_work_order_type` VALUES (1,'cleaning',1),(2,'broken water fountain',1),(3,'broken sink',1),(4,'broken toilet',1),(5,'broken gate',2);
/*!40000 ALTER TABLE `enum_work_order_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `exhibit`
--

DROP TABLE IF EXISTS `exhibit`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `exhibit` (
  `exhibit_id` int(10) unsigned NOT NULL,
  `exhibit_name` varchar(30) NOT NULL,
  `exhibit_size` decimal(6,3) NOT NULL,
  `exhibit_unit` varchar(2) NOT NULL,
  `ecosystem` int(10) unsigned NOT NULL,
  `section` int(10) unsigned NOT NULL,
  PRIMARY KEY (`exhibit_id`),
  KEY `EXHIBIT_UNIT_FK` (`exhibit_unit`),
  KEY `EXHIBIT_ECOSYSTEM_FK` (`ecosystem`),
  KEY `EXHIBIT_SECTION_FK` (`section`),
  CONSTRAINT `EXHIBIT_ECOSYSTEM_FK` FOREIGN KEY (`ecosystem`) REFERENCES `enum_ecosystem` (`ecosystem_id`) ON UPDATE CASCADE,
  CONSTRAINT `EXHIBIT_SECTION_FK` FOREIGN KEY (`section`) REFERENCES `enum_section` (`section_id`) ON UPDATE CASCADE,
  CONSTRAINT `EXHIBIT_UNIT_FK` FOREIGN KEY (`exhibit_unit`) REFERENCES `enum_unit_measure` (`unit_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `exhibit`
--

LOCK TABLES `exhibit` WRITE;
/*!40000 ALTER TABLE `exhibit` DISABLE KEYS */;
INSERT INTO `exhibit` VALUES (1,'Lions Den',300.000,'m',9,4),(2,'Tiger Den',300.000,'m',4,1),(3,'Penguin Habitat',500.000,'m',1,6),(4,'Rain Forest',300.000,'yd',1,1),(5,'Reptile Hut',500.000,'m',1,1);
/*!40000 ALTER TABLE `exhibit` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `facility`
--

DROP TABLE IF EXISTS `facility`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `facility` (
  `facility_id` int(10) unsigned NOT NULL,
  `facility_type` int(10) unsigned NOT NULL,
  `facility_status` int(10) unsigned NOT NULL,
  `section` int(10) unsigned NOT NULL,
  `facility_name` varchar(30) NOT NULL,
  PRIMARY KEY (`facility_id`),
  KEY `FACILITY_TYPE_FK` (`facility_type`),
  KEY `FACILITY_STATUS_FK` (`facility_status`),
  KEY `FACILITY_SECTION_FK` (`section`),
  CONSTRAINT `FACILITY_SECTION_FK` FOREIGN KEY (`section`) REFERENCES `enum_section` (`section_id`) ON UPDATE CASCADE,
  CONSTRAINT `FACILITY_STATUS_FK` FOREIGN KEY (`facility_status`) REFERENCES `enum_facility_status` (`facility_status_id`) ON UPDATE CASCADE,
  CONSTRAINT `FACILITY_TYPE_FK` FOREIGN KEY (`facility_type`) REFERENCES `enum_facility_type` (`facility_type_id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `facility`
--

LOCK TABLES `facility` WRITE;
/*!40000 ALTER TABLE `facility` DISABLE KEYS */;
INSERT INTO `facility` VALUES (1,1,1,1,'restroom 1A'),(2,1,1,1,'restroom 1B'),(3,2,1,6,'petting zoo'),(4,2,1,1,'reptile house'),(5,1,1,2,'restroom 2A'),(6,1,1,2,'restroom 2B'),(7,1,1,3,'restroom 3A'),(8,1,1,3,'restroom 3B'),(9,1,1,4,'restroom 4A'),(10,1,1,4,'restroom 4B'),(11,1,1,5,'restroom 5A'),(12,1,1,5,'restroom 5B'),(13,1,1,6,'restroom 6A'),(14,1,1,6,'restroom 6B'),(15,1,1,7,'restroom 7A'),(16,1,1,7,'restroom 7B'),(17,1,1,8,'restroom 8A'),(18,1,1,8,'restroom 8B');
/*!40000 ALTER TABLE `facility` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `health_profile`
--

DROP TABLE IF EXISTS `health_profile`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `health_profile` (
  `profile_id` int(10) unsigned NOT NULL,
  `sex` enum('M','F') NOT NULL,
  `DOB` date NOT NULL,
  `weight` decimal(6,3) NOT NULL,
  `weight_unit` varchar(2) NOT NULL,
  `height` decimal(6,3) NOT NULL,
  `height_unit` varchar(2) NOT NULL,
  `health_condition` int(10) unsigned NOT NULL,
  PRIMARY KEY (`profile_id`),
  KEY `PROFILE_WUNIT_FK` (`weight_unit`),
  KEY `PROFILE_HUNIT_FK` (`height_unit`),
  KEY `PROFILE_CONDITION_FK` (`health_condition`),
  CONSTRAINT `PROFILE_CONDITION_FK` FOREIGN KEY (`health_condition`) REFERENCES `enum_health_condition` (`condition_id`) ON UPDATE CASCADE,
  CONSTRAINT `PROFILE_HUNIT_FK` FOREIGN KEY (`height_unit`) REFERENCES `enum_unit_measure` (`unit_id`),
  CONSTRAINT `PROFILE_WUNIT_FK` FOREIGN KEY (`weight_unit`) REFERENCES `enum_unit_measure` (`unit_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `health_profile`
--

LOCK TABLES `health_profile` WRITE;
/*!40000 ALTER TABLE `health_profile` DISABLE KEYS */;
INSERT INTO `health_profile` VALUES (1,'M','2018-01-01',500.000,'lb',1.500,'m',9),(2,'M','2018-02-04',500.000,'lb',1.000,'m',1),(3,'M','0000-00-00',0.000,'lb',0.000,'m',1),(4,'M','0000-00-00',0.000,'lb',0.000,'m',1),(5,'M','2016-01-02',400.000,'lb',5.000,'ft',1),(6,'M','0000-00-00',0.000,'lb',0.000,'m',1),(7,'M','0000-00-00',0.000,'lb',0.000,'m',1),(8,'M','0000-00-00',0.000,'lb',0.000,'m',1),(9,'M','0000-00-00',0.000,'lb',0.000,'m',1),(10,'M','2018-11-22',2.000,'kg',1.000,'m',1),(11,'M','0000-00-00',0.000,'lb',0.000,'m',1),(12,'M','0000-00-00',0.000,'lb',0.000,'m',1);
/*!40000 ALTER TABLE `health_profile` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `membership`
--

DROP TABLE IF EXISTS `membership`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `membership` (
  `member_id` int(10) unsigned NOT NULL,
  `member_type` int(10) unsigned NOT NULL,
  `first_name` varchar(15) NOT NULL,
  `last_name` varchar(15) NOT NULL,
  `primary_contact` varchar(10) NOT NULL,
  `registration_date` date NOT NULL,
  `member_status` int(10) unsigned NOT NULL,
  PRIMARY KEY (`member_id`),
  UNIQUE KEY `membership_unique_contact` (`primary_contact`),
  KEY `MEMBER_TYPE_FK` (`member_type`),
  KEY `MEMBER_STATUS_FK` (`member_status`),
  CONSTRAINT `MEMBER_PCONTACT_FK` FOREIGN KEY (`primary_contact`) REFERENCES `contact` (`phone_no`) ON UPDATE CASCADE,
  CONSTRAINT `MEMBER_STATUS_FK` FOREIGN KEY (`member_status`) REFERENCES `enum_membership_status` (`member_status_id`) ON UPDATE CASCADE,
  CONSTRAINT `MEMBER_TYPE_FK` FOREIGN KEY (`member_type`) REFERENCES `enum_membership_type` (`member_type_id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `membership`
--

LOCK TABLES `membership` WRITE;
/*!40000 ALTER TABLE `membership` DISABLE KEYS */;
INSERT INTO `membership` VALUES (1,2,'Stephen','Fry','4294967295','2019-04-12',1),(2,1,'Judah','Ben-Hur','1231231230','1999-04-21',2),(3,3,'Ryan','San Miguel','2818069649','2019-04-22',1);
/*!40000 ALTER TABLE `membership` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prescription`
--

DROP TABLE IF EXISTS `prescription`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prescription` (
  `prescription_id` int(10) unsigned NOT NULL,
  `health_profile` int(10) unsigned NOT NULL,
  `medication` int(10) unsigned NOT NULL,
  `dosage_size` decimal(6,3) NOT NULL,
  `dosage_unit` varchar(2) NOT NULL,
  `doses_per_week` int(10) unsigned NOT NULL,
  PRIMARY KEY (`prescription_id`),
  KEY `PRESCRIPTION_PROFILE_FK` (`health_profile`),
  KEY `PRESCRIPTION_MEDICATION_FK` (`medication`),
  KEY `PRESCRIPTION_UNIT_FK` (`dosage_unit`),
  CONSTRAINT `PRESCRIPTION_MEDICATION_FK` FOREIGN KEY (`medication`) REFERENCES `enum_medication` (`med_id`) ON UPDATE CASCADE,
  CONSTRAINT `PRESCRIPTION_PROFILE_FK` FOREIGN KEY (`health_profile`) REFERENCES `health_profile` (`profile_id`),
  CONSTRAINT `PRESCRIPTION_UNIT_FK` FOREIGN KEY (`dosage_unit`) REFERENCES `enum_unit_measure` (`unit_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prescription`
--

LOCK TABLES `prescription` WRITE;
/*!40000 ALTER TABLE `prescription` DISABLE KEYS */;
/*!40000 ALTER TABLE `prescription` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_login`
--

DROP TABLE IF EXISTS `user_login`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user_login` (
  `user_id` int(10) unsigned NOT NULL,
  `username` varchar(15) NOT NULL,
  `user_password` varchar(30) NOT NULL,
  PRIMARY KEY (`user_id`),
  CONSTRAINT `USER_ID_FK` FOREIGN KEY (`user_id`) REFERENCES `employee` (`empl_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_login`
--

LOCK TABLES `user_login` WRITE;
/*!40000 ALTER TABLE `user_login` DISABLE KEYS */;
INSERT INTO `user_login` VALUES (1,'member_services','member_services'),(2,'fixit','fixit'),(3,'vet','vet'),(4,'admin','admin'),(5,'Colt','12345'),(7,'handler','handler'),(8,'test','test'),(9,'PaulHollywood','PaulHollywood');
/*!40000 ALTER TABLE `user_login` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `work_order`
--

DROP TABLE IF EXISTS `work_order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `work_order` (
  `order_id` int(10) unsigned NOT NULL,
  `order_type` int(10) unsigned NOT NULL,
  `order_date` date NOT NULL,
  `facility` int(10) unsigned NOT NULL,
  `ordered_by` int(10) unsigned NOT NULL,
  `assigned_to` int(10) unsigned NOT NULL,
  PRIMARY KEY (`order_id`),
  KEY `WORK_ORDER_TYPE_FK` (`order_type`),
  KEY `WORK_ORDER_FACILITY_FK` (`facility`),
  KEY `WORK_ORDERED_BY_FK` (`ordered_by`),
  KEY `WORK_ASSIGNED_TO_FK` (`assigned_to`),
  CONSTRAINT `WORK_ASSIGNED_TO_FK` FOREIGN KEY (`assigned_to`) REFERENCES `employee` (`empl_id`) ON UPDATE CASCADE,
  CONSTRAINT `WORK_ORDERED_BY_FK` FOREIGN KEY (`ordered_by`) REFERENCES `employee` (`empl_id`) ON UPDATE CASCADE,
  CONSTRAINT `WORK_ORDER_FACILITY_FK` FOREIGN KEY (`facility`) REFERENCES `facility` (`facility_id`) ON UPDATE CASCADE,
  CONSTRAINT `WORK_ORDER_TYPE_FK` FOREIGN KEY (`order_type`) REFERENCES `enum_work_order_type` (`order_type_id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `work_order`
--

LOCK TABLES `work_order` WRITE;
/*!40000 ALTER TABLE `work_order` DISABLE KEYS */;
/*!40000 ALTER TABLE `work_order` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`team12admin`@`%`*/ /*!50003 TRIGGER update_facility_status
BEFORE INSERT ON work_order
FOR EACH ROW
UPDATE facility AS f, enum_facility_status AS s
SET f.facility_status = s.facility_status_id
WHERE s.facility_status_name = 'out of order' AND f.facility_id = NEW.facility */;;
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
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`team12admin`@`%`*/ /*!50003 TRIGGER on_delete_work_order
BEFORE DELETE ON work_order
FOR EACH ROW
UPDATE facility AS f, enum_facility_status AS s
SET f.facility_status = s.facility_status_id
WHERE s.facility_status_name = 'working' AND f.facility_id = OLD.facility */;;
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

-- Dump completed on 2019-04-23 22:20:31
