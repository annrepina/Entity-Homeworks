--USE ADOHomework

CREATE TABLE Users
(
	Id int PRIMARY KEY IDENTITY NOT NULL,
	[Name] varchar(100) NOT NULL,
	PhoneNumber varchar(11) UNIQUE NOT NULL
)

CREATE TABLE Orders
(
	Id int PRIMARY KEY IDENTITY NOT NULL,
	CustomerId int REFERENCES Users (Id) NOT NULL,
	Summ int NOT NULL,
	[Date] date NOT NULL
)

