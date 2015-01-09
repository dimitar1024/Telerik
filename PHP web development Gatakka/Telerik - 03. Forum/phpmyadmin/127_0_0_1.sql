-- phpMyAdmin SQL Dump
-- version 4.2.7.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jan 08, 2015 at 10:49 PM
-- Server version: 5.6.20
-- PHP Version: 5.5.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `telerik-03-forum`
--

-- --------------------------------------------------------

--
-- Table structure for table `messages`
--

CREATE TABLE IF NOT EXISTS `messages` (
  `user` varchar(50) NOT NULL,
  `title` varchar(50) NOT NULL,
  `message` text NOT NULL,
  `group` int(4) NOT NULL,
  `date` datetime NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `messages`
--

INSERT INTO `messages` (`user`, `title`, `message`, `group`, `date`) VALUES
('dimitar1024', '3443343434', 'ghfggnfd', 3, '2014-12-31 05:46:13'),
('dimitar1024', 'Ð’ÑŠÐ²ÐµÐ´ÐµÐ½Ð¸Ðµ Ð² PHP', 'ÐœÐ½Ð¾Ð³Ð¾Ñ„ÑƒÐ½ÐºÑ†Ð¸Ð¾Ð½Ð°Ð»ÐµÐ½ ÐµÐ·Ð¸Ðº Ð¸Ð·Ð¿ÑŠÐ»Ð½ÐµÐ½ Ñ Ð¼Ð½Ð¾Ð³Ð¾ ÑÑŠÐºÑ€Ð°Ñ‚ÐµÐ½Ð¸ Ñ„ÑƒÐ½ÐºÑ†Ð¸Ð¸', 6, '2014-12-31 05:48:02'),
('dimitar1024', 'Ð’ÑŠÐ²ÐµÐ´ÐµÐ½Ð¸Ðµ Ð² C#', 'Ð£ÑÐ»Ð¾Ð²Ð½Ð¸ ÐºÐ¾Ð½ÑÑ‚Ñ€ÑƒÐºÑ†Ð¸Ð¸ if Ð¸ if-else Ð£ÑÐ»Ð¾Ð²Ð½Ð¸Ñ‚Ðµ ÐºÐ¾Ð½ÑÑ‚Ñ€ÑƒÐºÑ†Ð¸Ð¸ if Ð¸ if-else Ð¿Ñ€ÐµÐ´Ð¾ÑÑ‚Ð°Ð²ÑÑ‚ ÑƒÑÐ»Ð¾Ð²ÐµÐ½ Ñ‚Ð¸Ð¿ ÐºÐ¾Ð½Ñ‚Ñ€Ð¾Ð», Ñ‡Ñ€ÐµÐ· ÐºÐ¾Ð¹Ñ‚Ð¾ Ð¿Ñ€Ð¾Ð³Ñ€Ð°Ð¼Ð°Ñ‚Ð° Ð¼Ð¾Ð¶Ðµ Ð´Ð° Ð¸Ð·Ð¿ÑŠÐ»Ð½ÑÐ²Ð° Ñ€Ð°Ð·Ð»Ð¸Ñ‡Ð½Ð¸ Ñ„ÑƒÐ½ÐºÑ†Ð¸Ð¸ Ð² Ð·Ð°Ð²Ð¸ÑÐ¸Ð¼Ð¾ÑÑ‚ Ð¾Ñ‚ Ð½ÑÐºÐ°ÐºÐ²Ð¾ ÑƒÑÐ»Ð¾Ð²Ð¸Ðµ, ÐºÐ¾ÐµÑ‚Ð¾ ÑÐµ Ð¿Ñ€Ð¾Ð²ÐµÑ€ÑÐ²Ð° Ð¿Ð¾ Ð²Ñ€ÐµÐ¼Ðµ Ð½Ð° Ð¸Ð·Ð¿ÑŠÐ»Ð½ÐµÐ½Ð¸Ðµ Ð½Ð° ÐºÐ¾Ð½ÑÑ‚Ñ€ÑƒÐºÑ†Ð¸ÑÑ‚Ð°.', 1, '2014-12-31 05:48:58'),
('dimitar1024', 'if-else', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras massa odio, fringilla sed placerat at, pretium dictum ligula. Sed non tristique est.', 2, '2014-12-31 20:43:16'),
('alibaba', 'Lorem ipsum dolor sit amet', 'Maecenas quis diam at magna lobortis finibus. Etiam euismod dui at mattis scelerisque. Nunc non facilisis nisi, eget vestibulum sapien. Nullam scelerisque, erat laoreet porta laoreet', 2, '2014-12-31 22:55:50'),
('dimitar1024', 'capling', 'ÐœÐ°Ð½Ð¸Ð¿ÑƒÐ»Ð¸Ñ€Ð°Ð½Ðµ Ð½Ð° Ð´Ð¾Ð¼Ð°ÑˆÐ½Ð¸Ñ‚Ðµ/Ñ€ÐµÐ·ÑƒÐ»Ñ‚Ð°Ñ‚Ð¸Ñ‚Ðµ Ð¿Ð¾ ÐºÐ°ÐºÑŠÐ²Ñ‚Ð¾ Ð¸ Ð´Ð° Ðµ\r\nÐ±Ð¸Ð»Ð¾ Ð½Ð°Ñ‡Ð¸Ð½', 1, '2015-01-01 17:37:28'),
('petranka', 'Ð¡Ð¸Ð»Ð½Ð¾ ÑÑ€ÐµÐ´ÑÑ‚Ð²Ð¾ Ð·Ð° ÑÐ¿Ð»Ð¸Ñ‚Ð²Ð°Ð½Ð', '"/(.+)-(.+)/"', 8, '2015-01-01 17:42:08');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `date` datetime NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COMMENT='registration on users in forum';

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`username`, `password`, `email`, `date`) VALUES
('dimitar1024', 'password', 'dimitar1024@abv.bg', '2014-12-31 01:24:34'),
('localhost', 'phpqwerty', 'damqn@danchev.bg', '2014-12-31 01:58:28'),
('ivanRosenov', 'baiivan', 'ivan@petrov.bg', '2014-12-31 02:00:30'),
('alibaba', 'alibaba', 'alibaba@baba.bg', '2014-12-31 22:54:20'),
('petranka', 'petranka', 'petranka@abv.bg', '2015-01-01 17:40:17'),
('localivan', 'localivan', 'ivan@petrov.bg', '2015-01-01 18:12:04');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
