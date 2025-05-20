# 📚 Bücherei\_Windows\_App

![Screenshot 2025-05-20 112836](https://github.com/user-attachments/assets/d4575199-d851-49d1-8d0f-0403b70aa273)

A Windows Forms application for efficient library management using C#, .NET 7, MySQL, and Entity Framework Core.

![.NET](https://img.shields.io/badge/.NET-7.0-blue)
![Platform](https://img.shields.io/badge/Platform-Windows-lightgrey)

---

## Table of Contents

* [Technologies Used](#technologies-used)
* [Architecture and Structure](#architecture-and-structure)
* [User Interface](#user-interface)
* [Functionalities](#functionalities)
* [Database Design](#database-design)
* [User Controls](#user-controls)
* [Security](#security)
* [Installation and Setup](#installation-and-setup)
* [Future Enhancements](#future-enhancements)

---

## Technologies Used

This project leverages modern tools to build a performant and maintainable Windows Forms application:

* **Programming Language**: C#
* **Framework**: .NET 7
* **GUI**: Windows Forms
* **Database**: MySQL
* **ORM**: Entity Framework Core
* **IDE**: Visual Studio 2022

---

## Architecture and Structure

The application uses a modular design where each major feature (e.g., books, users, borrowings) is encapsulated in its own `UserControl`. The `MainForm` acts as the container, dynamically loading the appropriate control into its central panel based on user navigation.

This approach enables:

* Clear separation of concerns
* Better maintainability
* Easier feature expansion

---

## User Interface

The UI is designed for simplicity and usability, and includes:

* **Login Window**: Secure login via username and password
* **Main Window**: Menu-driven navigation
* **Central Panel**: Dynamically shows selected features via UserControls

> Screenshots coming soon!

---

## Functionalities

### 🔐 Login

* Login via database query
* Password hashing using SHA-256
* Role-based access control (admin vs. employee)

### 📖 Book Management

* Add, edit, and delete book entries
* Book attributes: title, author, ISBN, category, and availability
* Search and filter books

### 👤 User Management

* Manage library users
* View borrowed books per user
* Create, edit, and delete users

### ✉️ Borrowing & Returning

* Select user and books to borrow
* Track borrowing status
* Manage returns and update availability

---

## Database Design

The database is designed for normalized, relational storage with core entities:

### Users Table

| Field        | Type   | Description         |
| ------------ | ------ | ------------------- |
| ID (PK)      | int    | Primary key         |
| Username     | string | Login name          |
| PasswordHash | string | SHA-256 hashed pass |
| Role         | string | Access level        |

### Books Table

| Field      | Type   | Description       |
| ---------- | ------ | ----------------- |
| ID (PK)    | int    | Primary key       |
| Title      | string | Book title        |
| Author     | string | Book author       |
| ISBN       | string | International ID  |
| Category   | string | Genre or category |
| IsBorrowed | bool   | Borrowed status   |

### LibraryUsers Table

| Field       | Type   | Description       |
| ----------- | ------ | ----------------- |
| ID (PK)     | int    | Primary key       |
| FirstName   | string | User's first name |
| LastName    | string | User's last name  |
| Address     | string | Home address      |
| DateOfBirth | date   | Date of birth     |

### Borrowings Table

| Field         | Type   | Description            |
| ------------- | ------ | ---------------------- |
| ID (PK)       | int    | Primary key            |
| LibraryUserID | int FK | Foreign key to user    |
| BookID        | int FK | Foreign key to book    |
| BorrowDate    | date   | When borrowed          |
| ReturnDate    | date   | When returned (if any) |
| IsReturned    | bool   | Return status          |

---

## User Controls

Each module is represented as a `UserControl` for encapsulated logic:

* `UC_Login`: Handles secure authentication
* `UC_Home`: Default dashboard view
* `UC_Books`: Book list, search, and management
* `UC_Users`: Manage library users
* `UC_Borrowing`: Handle lending and returns
* `UC_Statistics` (planned): Data analytics and charts

---

## Security

* Passwords are hashed using SHA-256 and never stored in plain text
* Role-based access limits sensitive functions to admins
* Entity Framework Core reduces SQL injection risk

---

## Installation and Setup

1. **Clone the repository**:

   ```bash
   git clone https://github.com/your-username/Buecherei_Windows_App.git
   ```
2. **Set up the MySQL database** using the provided SQL script
3. **Edit `appsettings.json`** to match your database credentials
4. **Open in Visual Studio 2022**
5. **Build and run the solution**

---

## Future Enhancements

* Add statistics dashboard (most borrowed books, active users, etc.)
* Implement reminders for overdue returns
* Track multiple copies of the same book
* Enable email notifications for users
* Add report printing and exporting (PDF/Excel)

---

## License

This project is licensed under the [MIT Liecense](#license)

Copyright (c) [2023] [Marvin Hauser]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

---

> Made with ❤️ in C# and .NET 7
