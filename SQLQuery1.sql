CREATE TABLE Cars (
   CarId INT NOT NULL,
   BrandId INT NOT NULL,
   ColorId INT NOT NULL,
   ModelYear INT NOT NULL,
   DailyPrice FLOAT NULL,
   Description VARCHAR(200) NULL,
   PRIMARY KEY (CarId),
   FOREIGN KEY (BrandId) references Brands(BrandId),
   FOREIGN KEY (ColorId) references Colors(ColorId));

INSERT INTO Cars VALUES(1, 1 , 1, 2018, 800, 'Benzinli');
INSERT INTO Cars VALUES(2, 1 , 1, 2010, 200, 'Dizel');
INSERT INTO Cars VALUES(3, 2 , 2, 2005, 100, 'Benzinli');
INSERT INTO Cars VALUES(4, 3 , 2, 2013, 300, 'Dizel');
INSERT INTO Cars VALUES(5, 3 , 2, 2020, 500, 'Tüplü');

select * from Cars;

create table Brands (
   BrandId INT NOT NULL,
   BrandName VARCHAR(200) NULL,
   PRIMARY KEY (BrandId));

INSERT INTO Brands VALUES(1, 'Audi');
INSERT INTO Brands VALUES(2, 'BMW');
INSERT INTO Brands VALUES(3, 'Range Rover');

select * from Brands;

create table Colors (
   ColorId INT NOT NULL,
   ColorName VARCHAR(200) NULL,
   PRIMARY KEY (ColorId));

INSERT INTO Colors VALUES(1, 'Siyah');
INSERT INTO Colors VALUES(2, 'Beyaz');

select * from Colors;

create table CarImages (
	CarImageId INT NOT NULL,
	CarId INT NOT NULL,
	ImagePath varchar(500) NULL,
	Date date NULL,
	PRIMARY KEY (CarImageId),
	FOREIGN KEY (CarId) references Cars(CarId)
);

select * from CarImages;

create table Users (
	UserId INT NOT NULL,
	FirstName VARCHAR(200) NULL,
	LastName VARCHAR(200) NULL,
	Email VARCHAR(200) NULL,
	Password VARCHAR(200) NULL,
	PRIMARY KEY (UserId)
);

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
INSERT INTO Rentals VALUES(2, 2, 2, '2021-02-12', '2021-02-15');
INSERT INTO Rentals VALUES(3, 3, 3, '2020-12-15', '2020-12-21');

select * from Rentals;
