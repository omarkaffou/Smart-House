-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jan 22, 2022 at 12:16 PM
-- Server version: 5.7.31
-- PHP Version: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `exam`
--

-- --------------------------------------------------------

--
-- Table structure for table `capteur`
--

DROP TABLE IF EXISTS `capteur`;
CREATE TABLE IF NOT EXISTS `capteur` (
  `id` int(22) NOT NULL AUTO_INCREMENT,
  `nom` varchar(22) COLLATE utf8_bin NOT NULL,
  `description` varchar(22) COLLATE utf8_bin NOT NULL,
  `connexion` varchar(22) COLLATE utf8_bin NOT NULL,
  `demarrage` varchar(22) COLLATE utf8_bin NOT NULL,
  `zoneType` varchar(22) COLLATE utf8_bin NOT NULL,
  `locationX` int(80) NOT NULL,
  `locationY` int(80) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=86 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `capteur`
--

INSERT INTO `capteur` (`id`, `nom`, `description`, `connexion`, `demarrage`, `zoneType`, `locationX`, `locationY`) VALUES
(47, '47', 'capteur de son', 'connecter', 'arreter', 'diningroom', 583, 347),
(85, '85', 'description', 'connecter', 'arreter', 'bin', 173, 667),
(56, '56', 'capteur de feu', 'connecter', 'arreter', 'bedroom1', 848, 31),
(51, '51', 'capteur de son', 'connecter', 'arreter', 'bedroom2', 150, 25),
(77, '77', 'description', 'connecter', 'arreter', 'bin', 177, 659),
(84, '84', 'description', 'connecter', 'arreter', 'bedroom1', 688, 196),
(83, '83', 'capteur de feu', 'connecter', 'arreter', 'bin', 183, 680),
(57, '57', 'capteur de pression', 'connecter', 'arreter', 'bedroom1', 653, 43),
(82, '82', 'description', 'connecter', 'arreter', 'kitchen', 839, 527),
(81, '81', 'capteur de mouvement', 'connecter', 'arreter', 'bin', 184, 665),
(80, '80', 'capteur de son', 'connecter', 'arreter', 'bin', 168, 673),
(79, '79', 'capteur de feu', 'connecter', 'arreter', 'bedroom2', 160, 246),
(72, '72', 'capteur de feu', 'connecter', 'arreter', 'livingroom', 348, 525),
(66, '66', 'capteur de son', 'connecter', 'arreter', 'kitchen', 845, 353),
(78, '78', 'capteur de son', 'connecter', 'arreter', 'bedroom1', 846, 201),
(71, '71', 'capteur de feu', 'connecter', 'arreter', 'livingroom', 75, 310),
(75, '75', 'description', 'connecter', 'arreter', 'bin', 187, 664),
(76, '76', 'description', 'connecter', 'arreter', 'bin', 173, 640),
(74, '74', 'capteur de mouvement', 'connecter', 'arreter', 'kitchen', 719, 355),
(70, '70', 'capteur de son', 'connecter', 'arreter', 'bedroom2', 280, 247),
(73, '73', 'capteur de feu', 'connecter', 'arreter', 'bedroom2', 299, 27);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
