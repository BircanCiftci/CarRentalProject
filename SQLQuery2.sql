CREATE TABLE Users (
   UserId INT NOT NULL,
   FirstName VARCHAR(200) NULL,
   LastName VARCHAR(200) NULL,
   Email VARCHAR(200) NULL,
   Password VARCHAR(200) NULL,
   PRIMARY KEY (UserId));

INSERT INTO Users VALUES(1, 'Bircan', 'ÇİFTÇİ', 'bircan@gmail.com', '12345b');
INSERT INTO Users VALUES(2, 'Serhat', 'DEVECİ', 'serhat@gmail.com', '12345s');
INSERT INTO Users VALUES(3, 'Yaren', 'DERİN', 'yaren@gmail.com', '12345y');
INSERT INTO Users VALUES(4, 'Onur', 'ÇAKIR', 'onur@gmail.com', '12345o');
INSERT INTO Users VALUES(5, 'Zeynep', 'ŞEN', 'zeynep@gmail.com', '12345z');

select * from Users;

CREATE TABLE Customers (
   CustomerId INT NOT NULL,
   UserId INT NOT NULL,
   CompanyName VARCHAR(200) NULL,
   PRIMARY KEY (UserId),
   FOREIGN KEY (UserId) references Users(UserId));

INSERT INTO Customers VALUES(1, 1, 'Bircan Araç Kiralama');
INSERT INTO Customers VALUES(2, 2, 'Serhat DEVECİ Rent A Car');
INSERT INTO Customers VALUES(3, 3, 'Yaren Oto Kiralama');

select * from Customers;

CREATE TABLE Rentals (
   RentalId INT NOT NULL,
   CarId INT NOT NULL,
   CustomerId INT NOT NULL,
   RentDate DATE NOT NULL,
   ReturnDate DATE NULL,
   PRIMARY KEY (RentalId),
   FOREIGN KEY (CustomerId) references Users(UserId),
   FOREIGN KEY (CarId) references Brands(BrandId));

INSERT INTO Rentals VALUES(1, 1, 1, '2021-01-01', '2021-01-10');
INSERT INTO Rentals VALUES(2, 2, 2, '2021-02-12', null);
INSERT INTO Rentals VALUES(3, 3, 3, '2020-12-15', '2020-12-21');

select * from Rentals;