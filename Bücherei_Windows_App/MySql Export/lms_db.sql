-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 09, 2023 at 04:37 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `lms_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `app_users`
--

CREATE TABLE `app_users` (
  `id` int(11) NOT NULL,
  `first_name` varchar(100) NOT NULL,
  `last_name` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `password` varchar(50) NOT NULL,
  `user_type` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `app_users`
--

INSERT INTO `app_users` (`id`, `first_name`, `last_name`, `email`, `password`, `user_type`) VALUES
(1, 'Marvin', 'Hauser', 'Admin@LMS.de', 'Admin', 'admin'),
(5, '1', '1', 'qwer@qwer.de', '1', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

CREATE TABLE `books` (
  `id` int(100) NOT NULL,
  `book_name` varchar(100) NOT NULL,
  `book_author` varchar(100) NOT NULL,
  `book_type` varchar(100) NOT NULL,
  `book_out_with` varchar(100) NOT NULL,
  `book_out_since` varchar(100) NOT NULL,
  `book_back_when` varchar(100) NOT NULL,
  `book_out` tinyint(1) NOT NULL,
  `book_note` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`id`, `book_name`, `book_author`, `book_type`, `book_out_with`, `book_out_since`, `book_back_when`, `book_out`, `book_note`) VALUES
(1, 'Buch1', 'Bob', 'booktype', 'bookuser', 'dateout', 'dateback', 1, 'bookinfo'),
(2, 'Eindingsbums', 'Bobby', 'booktype', 'bookuser', 'dateout', 'dateback', 1, 'bookinfo'),
(3, 'PC Gaymes', 'Krampus', 'booktype', 'bookuser', 'dateout', 'dateback', 1, 'bookinfo'),
(4, 'not PC Gaymes', 'Krampus 2.0', 'booktype', 'bookuser', 'dateout', 'dateback', 1, 'bookinfo');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `app_users`
--
ALTER TABLE `app_users`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `app_users`
--
ALTER TABLE `app_users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `books`
--
ALTER TABLE `books`
  MODIFY `id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
