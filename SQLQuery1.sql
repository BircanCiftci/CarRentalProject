CREATE TABLE Cars (
   CarId INT NOT NULL,
   BrandId INT NOT NULL,
   ColorId INT NOT NULL,
   ModelYear INT NOT NULL,
   DailyPrice FLOAT NULL,
   Description VARCHAR(200) NULL,
   PRIMARY KEY (CarId, BrandId, ColorId),
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