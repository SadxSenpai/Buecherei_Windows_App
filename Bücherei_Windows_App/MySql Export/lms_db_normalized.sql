-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 05, 2025 at 03:26 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

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
  `password` varchar(256) NOT NULL,
  `user_type` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `app_users`
--

INSERT INTO `app_users` (`id`, `first_name`, `last_name`, `email`, `password`, `user_type`) VALUES
(1, 'Marvin', 'Hauser', 'Admin@LMS.de', 'admin', 'admin'),
(10, 'Test', 'Test', 'test@test.de', '9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

CREATE TABLE `books` (
  `id` int(100) NOT NULL,
  `book_name` varchar(100) NOT NULL,
  `book_author` varchar(100) NOT NULL,
  `book_type` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`id`, `book_name`, `book_author`, `book_type`) VALUES
(2, 'Eindingsbums', 'Bobby', 'Heft'),
(3, 'PC Gaymes', 'Krampus', ''),
(4, 'not PC Gaymes', 'Krampus 2.0', 'Buch'),
(6, 'Test', 'Test', 'Buch');

-- --------------------------------------------------------

--
-- Table structure for table `book_loans`
--

CREATE TABLE `book_loans` (
  `id` int(100) NOT NULL,
  `book_id` int(100) NOT NULL,
  `user_id` int(11) NOT NULL,
  `book_out_since` date NOT NULL,
  `book_back_when` date NOT NULL,
  `book_out` tinyint(1) NOT NULL,
  `book_note` varchar(100) NOT NULL,
  FOREIGN KEY (`book_id`) REFERENCES `books`(`id`),
  FOREIGN KEY (`user_id`) REFERENCES `app_users`(`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `book_loans`
--

INSERT INTO `book_loans` (`id`, `book_id`, `user_id`, `book_out_since`, `book_back_when`, `book_out`, `book_note`) VALUES
(1, 2, 1, '2023-02-10', '2023-02-17', 1, 'Riss auf seite 2, Kaffeefleck'),
(2, 3, 1, NULL, NULL, 0, 'Knick auf dem Cover, lsjkdfjksa'),
(3, 4, 1, '2023-02-10', '2023-02-17', 1, '-----'),
(4, 6, 1, '2023-02-15', '2023-02-22', 1, 'Test, test 2');

-- --------------------------------------------------------

--
-- Table structure for table `deleted_books`
--

CREATE TABLE `deleted_books` (
  `id` int(100) NOT NULL,
  `book_name` varchar(100) NOT NULL,
  `book_author` varchar(100) NOT NULL,
  `book_type` varchar(100) NOT NULL,
  `del_when` date NOT NULL,
  `del_why` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `main_inventory`
--

CREATE TABLE `main_inventory` (
  `id` int(11) NOT NULL,
  `item_name` varchar(256) NOT NULL,
  `item_origin` varchar(256) NOT NULL,
  `item_id` varchar(256) NOT NULL,
  `item_count` int(11) NOT NULL,
  `item_note` varchar(256) NOT NULL,
  `item_type` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `main_inventory`
--

INSERT INTO `main_inventory` (`id`, `item_name`, `item_origin`, `item_id`, `item_count`, `item_note`, `item_type`) VALUES
(1, 'test', 'testauthor', '123456789', 1, 'none', 'book');

-- --------------------------------------------------------

--
-- Table structure for table `out_of_house`
--

CREATE TABLE `out_of_house` (
  `id` int(255) NOT NULL,
  `item_name` varchar(256) NOT NULL,
  `item_type` varchar(256) NOT NULL,
  `item_date_out` date NOT NULL,
  `item_date_in` date NOT NULL,
  `item_with_who` varchar(256) NOT NULL,
  `item_note` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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
-- Indexes for table `book_loans`
--
ALTER TABLE `book_loans`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `deleted_books`
--
ALTER TABLE `deleted_books`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `main_inventory`
--
ALTER TABLE `main_inventory`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `out_of_house`
--
ALTER TABLE `out_of_house`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `app_users`
--
ALTER TABLE `app_users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `books`
--
ALTER TABLE `books`
  MODIFY `id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `book_loans`
--
ALTER TABLE `book_loans`
  MODIFY `id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `deleted_books`
--
ALTER TABLE `deleted_books`
  MODIFY `id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `main_inventory`
--
ALTER TABLE `main_inventory`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `out_of_house`
--
ALTER TABLE `out_of_house`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
