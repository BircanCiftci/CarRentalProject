create table CarImages (
	CarImageId INT NOT NULL,
	CarId INT,
	ImagePath varchar(500),
	Date date,
	PRIMARY KEY (CarImageId)
);

DROP TABLE CarImages;