CREATE DATABASE Luna_Bay;
Go
use Luna_Bay;
--Accomodation tables
CREATE TABLE Tables(ID int Primary Key, Name varchar(100), Pax varchar(20), Price int,Room_status varchar(50) Default 'Available');
CREATE TABLE Cottages(ID int Primary Key, Name varchar(100), Pax varchar (20), Price int,Room_status varchar(50) Default 'Available');
CREATE TABLE Pavillion(ID int Primary Key, Name varchar(100), Pax varchar(20), Price int,Room_status varchar(50) Default 'Available');
CREATE TABLE PrivateRoom(ID int Primary Key, Name varchar(100), Pax varchar(20), Price int,Room_status varchar(50) Default 'Available');
CREATE TABLE RoomWithPool(ID int Primary Key, Name varchar(100), Pax varchar(20), Price int,Room_status varchar(50) Default 'Available');
CREATE TABLE EventPlace(ID int Primary Key, Name varchar(100), Pax varchar(20), Price int,Room_status varchar(50) Default 'Available');
--Secondary tables
CREATE TABLE Breakfast(Food_Name varchar(40), Serving varchar(30), Price int);
CREATE TABLE Lunch(Food_Name varchar(40), Serving varchar(30), Price int);
CREATE TABLE Dinner(Food_Name varchar(40), Serving varchar(30), Price int);
CREATE TABLE RiceAddons(RiceAddon_Name varchar(40), Serving varchar(30), Price int);
CREATE TABLE SnacksAndDesserts(Food_Name varchar(40), Serving varchar(30), Price int);
CREATE TABLE Beverages(Beverage_Name varchar(40), Serving varchar(30), Price int);
CREATE TABLE Addons(ID int primary key,Name varchar(20), Pax varchar(25), Price int, Status varchar(20) Default 'Available');
--Products table
Create table Products(Product_ID int primary key ,Name varchar(40), Price int, Stock int default 50);
--Guest Table
Create table Guest(Guest_ID int primary key identity (1, 1), Name varchar(50), Phone int, Room int);
--Employee Table
Create table Employees(Emp_ID varchar(20) primary key, Position varchar (40), Name varchar(50),  Password varchar(30), Auth_ID int);
--Insert Accomodation data
insert into Tables(id, name, Pax, Price) values 
(1001, 'Round Table With Umbrella', '8 - 10', 600),
(1002, 'Round Table With Umbrella', '8 - 10', 600),
(1003, 'Round Table With Umbrella', '8 - 10', 600),
(1004, 'Round Table With Umbrella', '8 - 10', 600),
(1005, 'Round Table With Umbrella', '8 - 10', 600),
(1006, 'Round Table With Umbrella', '8 - 10', 600),
(1007, 'Round Table With Umbrella', '8 - 10', 600),
(1008, 'Round Table With Umbrella', '8 - 10', 600),
(1011, 'Garden Table', '10 - 12', 600),
(1012, 'Garden Table', '10 - 12', 600),
(1013, 'Garden Table', '10 - 12', 600),
(1014, 'Garden Table', '10 - 12', 600),
(1015, 'Garden Table', '10 - 12', 600),
(1016, 'Garden Table', '10 - 12', 600),
(1017, 'Garden Table', '10 - 12', 600),
(1021, 'Pool Table', '10 - 12', 1000),
(1022, 'Pool Table', '10 - 12', 1000),
(1023, 'Pool Table', '10 - 12', 1000),
(1024, 'Pool Table', '10 - 12', 1000),
(1025, 'Pool Table', '10 - 12', 1000),
(1026, 'Pool Table', '10 - 12', 1000),
(1027, 'Pool Table', '10 - 12', 1000),
(1028, 'Pool Table', '10 - 12', 1000),
(1029, 'Pool Table', '10 - 12', 1000);
insert into Cottages(id, name, Pax, Price) values 
(2001, 'Green Wooden Cottage', '12 - 15', 800),
(2002, 'Green Wooden Cottage', '12 - 15', 800),
(2003, 'Green Wooden Cottage', '12 - 15', 800),
(2004, 'Green Wooden Cottage', '12 - 15', 800),
(2011, 'Kalesa Type Cottage', '15 – 20', 1000),
(2012, 'Kalesa Type Cottage', '15 – 20', 1000),
(2013, 'Kalesa Type Cottage', '15 – 20', 1000),
(2021, 'Swing Type Cottage', '10 – 20', 1000),
(2022, 'Swing Type Cottage', '10 – 20', 1000),
(2023, 'Swing Type Cottage', '10 – 20', 1000),
(2031, 'Red Wooden Cottage', '12 – 20', 1000),
(2032, 'Red Wooden Cottage', '12 – 20', 1000),
(2033, 'Red Wooden Cottage', '12 – 20', 1000),
(2034, 'Red Wooden Cottage', '12 – 20', 1000),
(2041, 'Veranda Cottage', '12 – 20', 1000),
(2042, 'Veranda Cottage', '12 – 20', 1000),
(2043, 'Veranda Cottage', '12 – 20', 1000),
(2044, 'Veranda Cottage', '12 – 20', 1000),
(2051, 'Special Wooden Cottage','20 – 25', 1500),
(2052, 'Special Wooden Cottage','20 – 25', 1500),
(2053, 'Special Wooden Cottage','20 – 25', 1500),
(2054, 'Special Wooden Cottage','20 – 25', 1500),
(2061, 'Family Cottage','30 – 40', 1500),
(2062, 'Family Cottage','30 – 40', 1500),
(2063, 'Family Cottage','30 – 40', 1500),
(2071, 'Family Wooden Cottage','20 – 25', 1500),
(2072, 'Family Wooden Cottage','20 – 25', 1500),
(2073, 'Family Wooden Cottage','20 – 25', 1500),
(2074, 'Family Wooden Cottage','20 – 25', 1500),
(2081, 'Team Cottage','20 – 25',1500),
(2082, 'Team Cottage','20 – 25',1500),
(2083, 'Team Cottage','20 – 25',1500),
(2091, 'Club Cottage','20 – 25',1500),
(2092, 'Club Cottage','20 – 25',1500),
(2093, 'Club Cottage','20 – 25',1500),
(2101, 'Double Wooden Cottage','30 – 35',2000),
(2102, 'Double Wooden Cottage','30 – 35',2000),
(2103, 'Double Wooden Cottage','30 – 35',2000),
(2111, 'Pool Cottage','20 - 25',2000),
(2112, 'Pool Cottage','20 - 25',2000),
(2113, 'Pool Cottage','20 - 25',2000),
(2121, 'Trilles House','25 - 30',2500),
(2122, 'Trilles House','25 - 30',2500),
(2123, 'Trilles House','25 - 30',2500),
(2131, 'Trio Cottage','25 - 30',3000),
(2132, 'Trio Cottage','25 - 30',3000),
(2133, 'Trio Cottage','25 - 30',3000),
(2141, 'Tree House ','50 - 60',3000);
insert into Pavillion(id, name, Pax, Price) values 
(3001, 'Pavillion I (non-aircon)','80 - 100', 8000),
(3002, 'Pavillion I (air-conditioned)','80 - 100', 10000),
(3003, 'Paviilion II (open-type)','100 - 120', 12000);
insert into PrivateRoom(id, name, Pax, Price) values 
(4001, 'VIP Room (air-conditioned)','2 - 6', 2000),
(4002, 'VIP Room (air-conditioned)','2 - 6', 2000),
(4003, 'VIP Room (air-conditioned)','2 - 6', 2000),
(4004, 'VIP Room (air-conditioned)','2 - 6', 2000),
(4005, 'VIP Room (air-conditioned)','2 - 6', 2000),
(4006, 'VIP Room (air-conditioned)','2 - 6', 2000),
(4007, 'VIP Room (air-conditioned)','2 - 6', 2000),
(4008, 'VIP Room (air-conditioned)','2 - 6', 2000),
(4011, 'Executive Rooms','10 - 15', 3500 ),
(4012, 'Executive Rooms','10 - 15', 3500),
(4013, 'Executive Rooms','10 - 15', 3500),
(4014, 'Executive Rooms','10 - 15', 3500),
(4015, 'Executive Rooms','10 - 15', 4000),
(4016, 'Executive Rooms','10 - 15', 4000),
(4017, 'Executive Rooms','10 - 15', 4000),
(4018, 'Executive Rooms','10 - 15', 4000),
(4021, 'Veranda I (open type) with 3 VIP Rooms downstairs','30 - 40', 9000),
(4022, 'Veranda I (open type) with 3 VIP Rooms downstairs','30 - 40', 9000),
(4023, 'Veranda I (open type) with 3 VIP Rooms downstairs','30 - 40', 9000),
(4024, 'Veranda I (open type) with 3 VIP Rooms downstairs','30 - 40', 9000),
(4025, 'Veranda I (open type) with 3 VIP Rooms downstairs','30 - 40', 9000),
(4031, 'Veranda II (air-conditioned) | Conference & VIP Room','20 - 25 & 6-8', 7500),
(4032, 'Veranda II (air-conditioned) | Conference & VIP Room','20 - 25 & 6-8', 7500),
(4033, 'Veranda II (air-conditioned) | Conference & VIP Room','20 - 25 & 6-8', 7500),
(4034, 'Veranda II (air-conditioned) | Conference & VIP Room','20 - 25 & 6-8', 7500),
(4041, 'Veranda III-Inclusive of 1 VIP Room','20 - 25', 7000),
(4042, 'Veranda III-Inclusive of 1 VIP Room','20 - 25', 7000),
(4043, 'Veranda III-Inclusive of 1 VIP Room','20 - 25', 7000),
(4051, 'Veranda IV-Inclusive of 3 VIP Rooms','50 - 80', 7000),
(4052, 'Veranda IV-Inclusive of 3 VIP Rooms','50 - 80', 7000),
(4053, 'Veranda IV-Inclusive of 3 VIP Rooms','50 - 80', 7000);
insert into RoomWithPool(id, name, Pax, Price) values 
(5001, 'Private Pool I With Jacuzzi (Veranda & Private Room)','30 - 40', 12000),
(5002, 'Private Pool I With Jacuzzi (Veranda & Private Room)','30 - 40', 12000),
(5003, 'Private Pool I With Jacuzzi (Veranda & Private Room)','30 - 40', 12000),
(5004, 'Private Pool I With Jacuzzi (Veranda & Private Room)','30 - 40', 12000),
(5011, 'Private Pool II With Jacuzzi (Private Room)','20 - 30', 8000),
(5012, 'Private Pool II With Jacuzzi (Private Room)','20 - 30', 8000),
(5013, 'Private Pool II With Jacuzzi (Private Room)','20 - 30', 8000),
(5021, 'Private Pool III With Jacuzzi (2 Private Room)','30 - 40', 12000),
(5022, 'Private Pool III With Jacuzzi (2 Private Room)','30 - 40', 12000),
(5023, 'Private Pool III With Jacuzzi (2 Private Room)','30 - 40', 12000),
(5024, 'Private Pool III With Jacuzzi (2 Private Room)','30 - 40', 12000);
insert into EventPlace(id, name, Pax, Price) values
(6001, 'Clubhouse','400 – 450', 30000),
(6002, 'Clubhouse','400 – 450', 40000),
(6011, 'Conference A','20 – 25', 6000),
(6021, 'Conference B','30 – 35', 8000),
(6031, 'Conference C','40 – 45', 15000),
(6041, 'Convention Hall','600 - 700', 125000);
--Insert Addon data
insert into Addons(ID, Name, Pax, Price) values
(7001, 'Karaoke', '10-20',700),
(7002, 'Karaoke', '10-20',700),
(7003, 'Karaoke', '10-20',700),
(7004, 'Karaoke', '10-20',700),
(7005, 'Karaoke', '10-20',700),
(8001, 'Court', '5-10',300),
(8002, 'Court', '5-10',300),
(8003, 'Court', '5-10',300),
(8004, 'Court', '5-10',300);
----Insert Foods and Beverages data
Insert into Breakfast(Food_Name, Serving, Price) values 
('Tapsilog', '1', 105), 
('Tosilog', '1', 105), 
('Bangsilog', '1', 135), 
('Cornbeef silog', '1', 125),
('Sopas', '1 - 2', 120), 
('Champorado', '1 - 2', 120);
Insert into Lunch(Food_Name, Serving, Price) values 
( 'Chicken Adobo', '3 - 4', 350), 
('Sinigang na Bangus', '3 - 4', 380), 
('Pork Sisig', '2 - 3', 250), 
('Pork Liempo', ' 3 - 4', 350),
('Pinakbet', '3 - 4', 280), 
('Daing na Bangus', '3', 320),
('Pork Bistek','2 - 3', 320);
Insert into Dinner(Food_Name, Serving, Price) values
('Special Laing', '3 - 4', 320), 
('Kare kare', '3 - 4', 380),
('Buttered Shrimp', '3', 320),
('Adobong Pusit', '3 - 4',350),
('Chicken Tinola', '3 - 4', 380),
('Pork Caldereta', '3 - 4', 350),
('Lechon Kawali', '3', 320);
Insert into RiceAddons(RiceAddon_Name, Serving, Price) values
('Plain Rice', '1', 30),
('Garlic Rice', '2', 40),
('Java Rice', '3', 50),
('Rice Platter', '3 - 6', 180);
Insert into SnacksAndDesserts(Food_Name, Serving, Price) values
('Chicken Skin', '2 - 3', 150),
('Chicharon', '2 - 3', 130),
('Banana Chips', '2 - 3', 80),
('Halo-halo', '1', 80),
('Mangga with bagoong', '1 - 2', 70),
('Bibingka', '1 - 2', 50),
('Vigan Empanada', '1 - 2', 60),
('Buko Pandan', '1 - 2', 80);
Insert into Beverages(Beverage_Name, Serving, Price) values
('Bottled Water', '350 ml', 30),
('Hot Coffee', '250 ml', 50),
('Hot Choco', '250 ml', 50),
('Mango Shake', '500 ml',100),
('Buko Juice', '1 coconut shell', 80),
('San Mig Light', '330 ml', 60),
('San Mig Pale Palsen', '320 ml', 60),
('Red Horse', '500 ml', 70);
----Insert Products data
insert into Products(Product_ID,Name, Price) values
(0001, 'Rashguard(Women)', 450),
(0002, 'Trunks (Men)', 250),
(0003, 'One Piece (Girls)', 300),
(0004, 'Two Piece (Girls)', 300),
(0005, 'One Piece (Women)', 375),
(0006, 'Two Piece  (Women)', 375),
(0007, 'Rashguard(Men)', 450),
(0008, 'Cycling(Women)', 150),
(0009, 'Summer shorts (Boys)', 200),
(0010, 'Tee(Boys)', 150),
(0011, 'Float', 100),
(0012, 'Goggles', 175),
(0013, 'Ear Plugs', 320),
(0014, 'Necklace', 150),
(0015, 'Ref Magnet', 50);
--Employees para may laman
insert into Employees(Emp_ID, Position, Name,  Password, Auth_ID) values
('EMP-001', 'Admin','Loraine', 'Admin123', 0),
('EMP-002', 'Manager', 'Sykiel', 'Manager123', 1),
('EMP-003', 'Front Desk', 'Marshall', 'Staff123', 2);