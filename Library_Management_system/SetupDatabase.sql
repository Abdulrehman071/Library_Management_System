-- ============================================================
-- LibraryMS Database Setup Script
-- Run this in SQL Server Management Studio (SSMS) BEFORE
-- running the application for the first time.
-- ============================================================

-- 1. Create the database
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'LibraryDB')
BEGIN
    CREATE DATABASE LibraryDB;
    PRINT 'Database LibraryDB created.';
END
ELSE
    PRINT 'Database LibraryDB already exists.';
GO

USE LibraryDB;
GO

-- 2. Create the Book table
IF NOT EXISTS (
    SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Book'
)
BEGIN
    CREATE TABLE Book (
        Id       NVARCHAR(20)   NOT NULL PRIMARY KEY,
        Title    NVARCHAR(300)  NOT NULL,
        Author   NVARCHAR(200)  NOT NULL,
        ISBN     NVARCHAR(50)   NOT NULL DEFAULT '',
        Category NVARCHAR(50)   NOT NULL,
        Status   NVARCHAR(50)   NOT NULL,
        Copies   INT            NOT NULL DEFAULT 1,
        Year     INT            NOT NULL DEFAULT 0
    );
    PRINT 'Table Book created.';
END
ELSE
    PRINT 'Table Book already exists.';
GO

-- 3. Create the Member table
IF NOT EXISTS (
    SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Member'
)
BEGIN
    CREATE TABLE Member (
        Id      NVARCHAR(30)   NOT NULL PRIMARY KEY,
        Name    NVARCHAR(200)  NOT NULL,
        Phone   NVARCHAR(50)   NOT NULL DEFAULT '',
        Email   NVARCHAR(200)  NOT NULL DEFAULT '',
        Address NVARCHAR(500)  NOT NULL DEFAULT ''
    );
    PRINT 'Table Member created.';
END
ELSE
    PRINT 'Table Member already exists.';
GO

-- 4. Sample books
IF NOT EXISTS (SELECT 1 FROM Book)
BEGIN
    INSERT INTO Book (Id, Title, Author, ISBN, Category, Status, Copies, Year) VALUES
        ('b-SAMP01', 'The Great Gatsby',            'F. Scott Fitzgerald', '978-0-7432-7356-5', 'Fiction',    'Available', 3, 1925),
        ('b-SAMP02', 'A Brief History of Time',     'Stephen Hawking',     '978-0-553-38016-3', 'Science',    'Available', 2, 1988),
        ('b-SAMP03', 'Clean Code',                  'Robert C. Martin',    '978-0-13-235088-4', 'Technology', 'Borrowed',  1, 2008),
        ('b-SAMP04', 'Sapiens',                     'Yuval Noah Harari',   '978-0-06-231609-7', 'History',    'Available', 4, 2011),
        ('b-SAMP05', 'The Alchemist',               'Paulo Coelho',        '978-0-06-112241-5', 'Fiction',    'Available', 5, 1988),
        ('b-SAMP06', 'Introduction to Algorithms',  'Thomas H. Cormen',    '978-0-26-204630-5', 'Technology', 'Available', 2, 2009),
        ('b-SAMP07', 'Quran (Translation)',          'Abdullah Yusuf Ali',  '',                  'Religion',   'Available', 10,1934),
        ('b-SAMP08', 'Charlie and the Chocolate Factory','Roald Dahl',     '978-0-14-130115-4', 'Children',   'Borrowed',  3, 1964);
    PRINT 'Sample books inserted.';
END
GO

-- 5. Sample members
IF NOT EXISTS (SELECT 1 FROM Member)
BEGIN
    INSERT INTO Member (Id, Name, Phone, Email, Address) VALUES
        ('m-SAMP01', 'Ali Hassan',   '0300-1234567', 'ali@email.com',   'Lahore, Punjab'),
        ('m-SAMP02', 'Sara Khan',    '0321-7654321', 'sara@email.com',  'Karachi, Sindh'),
        ('m-SAMP03', 'Usman Tariq',  '0333-9876543', 'usman@email.com', 'Islamabad'),
        ('m-SAMP04', 'Ayesha Malik', '0312-5556789', 'ayesha@email.com','Peshawar, KPK');
    PRINT 'Sample members inserted.';
END
GO

PRINT '========================================';
PRINT 'LibraryDB setup complete!';
PRINT 'You can now run LibraryMS application.';
PRINT '========================================';
