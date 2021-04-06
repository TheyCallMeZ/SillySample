CREATE DATABASE SillySample
GO

USE SillySample
GO

CREATE TABLE Vendors (
ID INT IDENTITY PRIMARY KEY,
Name VARCHAR(50),
Address VARCHAR(200),
City VARCHAR(100),
State VARCHAR(25),
Zip VARCHAR(10),
Contact VARCHAR(100),
Contact_Phone VARCHAR(15)
)
GO

CREATE TABLE Products (
ID INT IDENTITY PRIMARY KEY,
Name VARCHAR(100),
Description VARCHAR(255),
MSRP MONEY,
VendorID INT
)
GO

CREATE VIEW VendorProducts AS
SELECT p.ID, p.Name, p.Description, p.MSRP, v.Name as 'Vendor_Name'
FROM Vendors v
INNER JOIN Products p
	ON v.ID = p.VendorID

GO

CREATE PROCEDURE GetVendorProductByVendorName
@VendorName VARCHAR(50)
AS
SELECT p.ID, p.Name, p.Description, p.MSRP, v.Name as 'Vendor_Name'
FROM Vendors v
INNER JOIN Products p
	ON v.ID = p.VendorID
WHERE v.Name = @VendorName
GO

INSERT INTO Vendors
VALUES
('Nontindo', '123 Bits n Bytes Way', 'Mainframe', 'Ohio', '12345', 'Bob Bobbertson', '216-512-9999'),
('Saga', '0 Null Reference St.', 'Floppy', 'Arizona', '55502', 'Jennifer Jennings', '523-867-5309'),
('Sewknee', '1010220 Phone Reference Ln', 'Imold', 'Utah', '32411', 'Kentoshi Nakamura', '501-555-1234'),
('Fjord', 'Any Open Field', 'Cahs', 'Washington', '00123', 'Herein Micah', '123-456-7890'),
('Gatari', '1107064001 Fret Not Circle', 'Pickton', 'Georgia', '96734', 'May Thehaironyourtoesneverfallout', '701-222-4321')
GO

INSERT INTO Products
VALUES
('Nontindo Edutainment Platform', 'Teachers Love it!', 99.99, 1),
('Hub', 'The latest innovation', 299.99, 1),
('Gamekid', 'Games for kids, on the go', 199.99, 1),
('Needle Mouse Box', 'Plays Needle Mouse Games Exclusively', 99.99, 2),
('Uranus', 'Expensive as a planet', 39999999.99, 2),
('Convoy', 'Plays Needle Mouse Box games, on the go!', 199.99, 2),
('Needlestation', 'The Latest In Needle Technology (or it was...)', 99.99, 3),
('Needlestation 2', 'Better than the Original Needlestation', 299.99, 3),
('Needlestation 3', 'First Generation can use Needles from the previous models', 499.99, 3),
('Horse', 'Price does not include Barding', 34999.99, 4),
('Two Headed Horse', 'Twice the heads means twice the power, Right?', 59999.99, 4),
('Fleet', 'Big enough to count as it''s own entourage', 81999.99, 4),
('Telemadoushi', 'Sounds like magic', 2999.99, 5),
('Stratamadoushi', 'Sounds like space magic', 4999.99, 5),
('Stratamadoushi XXL', 'You can hear it from other planets', 8999.99, 5)
GO