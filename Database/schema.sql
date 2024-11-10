CREATE DATABASE Luna_Bay;
Go
use Luna_Bay;

--Accomodation tables
Create table RoomType(RoomType_ID int primary key, RoomType varchar(25));
Create table Accomodation(Room_ID int primary key, RoomType_ID int foreign key references RoomType(RoomType_ID), Name varchar(100), Pax varchar(20), Price int, Room_status varchar(50) Default 'Available');
insert into RoomType(RoomType_ID, RoomType) values
(01, 'Table'),
(02, 'Cottages'),
(03, 'Pavillion'),
(04, 'PrivateRoom'),
(05, 'RoomWithPool'),
(06, 'EventPlace');

insert into Accomodation(Room_ID, RoomType_ID, name, Pax, Price) values
(1001, 01, 'Round Table With Umbrella', '8 - 10', 600),
(1002, 01, 'Round Table With Umbrella', '8 - 10', 600),
(1003, 01, 'Round Table With Umbrella', '8 - 10', 600),
(1004, 01, 'Round Table With Umbrella', '8 - 10', 600),
(1005, 01, 'Round Table With Umbrella', '8 - 10', 600),
(1006, 01, 'Round Table With Umbrella', '8 - 10', 600),
(1007, 01, 'Round Table With Umbrella', '8 - 10', 600),
(1008, 01, 'Round Table With Umbrella', '8 - 10', 600),
(1011, 01, 'Garden Table', '10 - 12', 600),
(1012, 01, 'Garden Table', '10 - 12', 600),
(1013, 01, 'Garden Table', '10 - 12', 600),
(1014, 01, 'Garden Table', '10 - 12', 600),
(1015, 01, 'Garden Table', '10 - 12', 600),
(1016, 01, 'Garden Table', '10 - 12', 600),
(1017, 01, 'Garden Table', '10 - 12', 600),
(1021, 01, 'Pool Table', '10 - 12', 1000),
(1022, 01, 'Pool Table', '10 - 12', 1000),
(1023, 01, 'Pool Table', '10 - 12', 1000),
(1024, 01, 'Pool Table', '10 - 12', 1000),
(1025, 01, 'Pool Table', '10 - 12', 1000),
(1026, 01, 'Pool Table', '10 - 12', 1000),
(1027, 01, 'Pool Table', '10 - 12', 1000),

(2001, 02, 'Green Wooden Cottage', '12 - 15', 800),
(2002, 02, 'Green Wooden Cottage', '12 - 15', 800),
(2003, 02, 'Green Wooden Cottage', '12 - 15', 800),
(2004, 02, 'Green Wooden Cottage', '12 - 15', 800),
(2011, 02, 'Kalesa Type Cottage', '15 – 20', 1000),
(2012, 02, 'Kalesa Type Cottage', '15 – 20', 1000),
(2013, 02, 'Kalesa Type Cottage', '15 – 20', 1000),
(2021, 02, 'Swing Type Cottage', '10 – 20', 1000),
(2022, 02, 'Swing Type Cottage', '10 – 20', 1000),
(2023, 02, 'Swing Type Cottage', '10 – 20', 1000),
(2031, 02, 'Red Wooden Cottage', '12 – 20', 1000),
(2032, 02, 'Red Wooden Cottage', '12 – 20', 1000),
(2033, 02, 'Red Wooden Cottage', '12 – 20', 1000),
(2034, 02, 'Red Wooden Cottage', '12 – 20', 1000),
(2041, 02, 'Veranda Cottage', '12 – 20', 1000),
(2042, 02, 'Veranda Cottage', '12 – 20', 1000),
(2043, 02, 'Veranda Cottage', '12 – 20', 1000),
(2044, 02, 'Veranda Cottage', '12 – 20', 1000),
(2051, 02, 'Special Wooden Cottage','20 – 25', 1500),
(2052, 02, 'Special Wooden Cottage','20 – 25', 1500),
(2053, 02, 'Special Wooden Cottage','20 – 25', 1500),
(2054, 02, 'Special Wooden Cottage','20 – 25', 1500),
(2061, 02, 'Family Cottage','30 – 40', 1500),
(2062, 02, 'Family Cottage','30 – 40', 1500),
(2063, 02, 'Family Cottage','30 – 40', 1500),
(2071, 02, 'Family Wooden Cottage','20 – 25', 1500),
(2072, 02, 'Family Wooden Cottage','20 – 25', 1500),
(2073, 02, 'Family Wooden Cottage','20 – 25', 1500),
(2074, 02, 'Family Wooden Cottage','20 – 25', 1500),
(2081, 02, 'Team Cottage','20 – 25',1500),
(2082, 02, 'Team Cottage','20 – 25',1500),
(2083, 02, 'Team Cottage','20 – 25',1500),
(2091, 02, 'Club Cottage','20 – 25',1500),
(2092, 02, 'Club Cottage','20 – 25',1500),
(2093, 02, 'Club Cottage','20 – 25',1500),
(2101, 02, 'Double Wooden Cottage','30 – 35',2000),
(2102, 02,'Double Wooden Cottage','30 – 35',2000),
(2103, 02, 'Double Wooden Cottage','30 – 35',2000),
(2111, 02, 'Pool Cottage','20 - 25',2000),
(2112, 02, 'Pool Cottage','20 - 25',2000),
(2113, 02, 'Pool Cottage','20 - 25',2000),
(2121, 02, 'Trilles House','25 - 30',2500),
(2122, 02, 'Trilles House','25 - 30',2500),
(2123, 02, 'Trilles House','25 - 30',2500),
(2131, 02, 'Trio Cottage','25 - 30',3000),
(2132, 02, 'Trio Cottage','25 - 30',3000),
(2133, 02, 'Trio Cottage','25 - 30',3000),
(2141, 02, 'Tree House ','50 - 60',3000),

(3001, 03, 'Pavillion I (non-aircon)','80 - 100', 8000),
(3002, 03, 'Pavillion I (air-conditioned)','80 - 100', 10000),
(3003, 03, 'Paviilion II (open-type)','100 - 120', 12000),

(4001, 04, 'VIP Room (air-conditioned)','2 - 6', 2000),
(4002, 04, 'VIP Room (air-conditioned)','2 - 6', 2000),
(4003, 04, 'VIP Room (air-conditioned)','2 - 6', 2000),
(4004, 04, 'VIP Room (air-conditioned)','2 - 6', 2000),
(4005, 04, 'VIP Room (air-conditioned)','2 - 6', 2000),
(4006, 04, 'VIP Room (air-conditioned)','2 - 6', 2000),
(4007, 04, 'VIP Room (air-conditioned)','2 - 6', 2000),
(4008, 04, 'VIP Room (air-conditioned)','2 - 6', 2000),
(4011, 04, 'Executive Rooms','10 - 15', 3500 ),
(4012, 04, 'Executive Rooms','10 - 15', 3500),
(4013, 04, 'Executive Rooms','10 - 15', 3500),
(4014, 04, 'Executive Rooms','10 - 15', 3500),
(4015, 04, 'Executive Rooms','10 - 15', 4000),
(4016, 04, 'Executive Rooms','10 - 15', 4000),
(4017, 04, 'Executive Rooms','10 - 15', 4000),
(4018, 04, 'Executive Rooms','10 - 15', 4000),
(4021, 04, 'Veranda I (open type) with 3 VIP Rooms downstairs','30 - 40', 9000),
(4022, 04, 'Veranda I (open type) with 3 VIP Rooms downstairs','30 - 40', 9000),
(4023, 04, 'Veranda I (open type) with 3 VIP Rooms downstairs','30 - 40', 9000),
(4024, 04, 'Veranda I (open type) with 3 VIP Rooms downstairs','30 - 40', 9000),
(4025, 04, 'Veranda I (open type) with 3 VIP Rooms downstairs','30 - 40', 9000),
(4031, 04, 'Veranda II (air-conditioned) | Conference & VIP Room','20 - 25 & 6-8', 7500),
(4032, 04, 'Veranda II (air-conditioned) | Conference & VIP Room','20 - 25 & 6-8', 7500),
(4033, 04, 'Veranda II (air-conditioned) | Conference & VIP Room','20 - 25 & 6-8', 7500),
(4034, 04, 'Veranda II (air-conditioned) | Conference & VIP Room','20 - 25 & 6-8', 7500),
(4041, 04, 'Veranda III-Inclusive of 1 VIP Room','20 - 25', 7000),
(4042, 04, 'Veranda III-Inclusive of 1 VIP Room','20 - 25', 7000),
(4043, 04, 'Veranda III-Inclusive of 1 VIP Room','20 - 25', 7000),
(4051, 04, 'Veranda IV-Inclusive of 3 VIP Rooms','50 - 80', 7000),
(4052, 04, 'Veranda IV-Inclusive of 3 VIP Rooms','50 - 80', 7000),
(4053, 04, 'Veranda IV-Inclusive of 3 VIP Rooms','50 - 80', 7000),

(5001, 05, 'Private Pool I With Jacuzzi (Veranda & Private Room)','30 - 40', 12000),
(5002, 05, 'Private Pool I With Jacuzzi (Veranda & Private Room)','30 - 40', 12000),
(5003, 05, 'Private Pool I With Jacuzzi (Veranda & Private Room)','30 - 40', 12000),
(5004, 05, 'Private Pool I With Jacuzzi (Veranda & Private Room)','30 - 40', 12000),
(5011, 05, 'Private Pool II With Jacuzzi (Private Room)','20 - 30', 8000),
(5012, 05, 'Private Pool II With Jacuzzi (Private Room)','20 - 30', 8000),
(5013, 05, 'Private Pool II With Jacuzzi (Private Room)','20 - 30', 8000),
(5021, 05, 'Private Pool III With Jacuzzi (2 Private Room)','30 - 40', 12000),
(5022, 05, 'Private Pool III With Jacuzzi (2 Private Room)','30 - 40', 12000),
(5023, 05, 'Private Pool III With Jacuzzi (2 Private Room)','30 - 40', 12000),
(5024, 05, 'Private Pool III With Jacuzzi (2 Private Room)','30 - 40', 12000),

(6001, 06, 'Clubhouse','400 – 450', 30000),
(6002, 06, 'Clubhouse','400 – 450', 40000),
(6011, 06, 'Conference A','20 – 25', 6000),
(6021, 06, 'Conference B','30 – 35', 8000),
(6031, 06, 'Conference C','40 – 45', 15000),
(6041, 06, 'Convention Hall','600 - 700', 125000);

--Addons
Create table Addons(ID int primary key,Name varchar(20), Pax varchar(25), Price int, Status varchar(20) Default 'Available');
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

--Food
Create table FoodType(FoodType_ID int primary key, FoodType varchar(25));
insert into FoodType(FoodType_ID, FoodType) values
(01, 'Breakfast'),
(02, 'Lunch'),
(03, 'Dinner'),
(04, 'RiceAddons'),
(05, 'Snacks And Desserts'),
(06, 'Bevarages');

Create table Food(Food_ID int primary key, FoodType_ID int foreign key references FoodType(FoodType_ID), Food_Name varchar(40), Serving varchar(30), Price int);
insert into Food(Food_ID, FoodType_ID, Food_Name, Serving, Price) values
(0101, 01, 'Tapsilog', '1', 105), 
(0102, 01, 'Tosilog', '1', 105), 
(0103, 01, 'Bangsilog', '1', 135), 
(0104, 01, 'Cornbeef silog', '1', 125),
(0105, 01, 'Sopas', '1 - 2', 120), 
(0106, 01,'Champorado', '1 - 2', 120),

(0201, 02, 'Chicken Adobo', '3 - 4', 350), 
(0202, 02, 'Sinigang na Bangus', '3 - 4', 380), 
(0203, 02, 'Pork Sisig', '2 - 3', 250), 
(0204, 02, 'Pork Liempo', ' 3 - 4', 350),
(0205, 02, 'Pinakbet', '3 - 4', 280), 
(0206, 02,'Daing na Bangus', '3', 320),
(0207, 02, 'Pork Bistek','2 - 3', 320),

(0301, 03, 'Special Laing', '3 - 4', 320), 
(0302, 03, 'Kare kare', '3 - 4', 380),
(0304, 03, 'Buttered Shrimp', '3', 320),
(0305, 03, 'Adobong Pusit', '3 - 4',350),
(0306, 03,  'Chicken Tinola', '3 - 4', 380),
(0307, 03, 'Pork Caldereta', '3 - 4', 350),
(0308, 03, 'Lechon Kawali', '3', 320),

(0401, 04, 'Plain Rice', '1', 30),
(0402, 04, 'Garlic Rice', '2', 40),
(0403, 04, 'Java Rice', '3', 50),
(0404, 04, 'Rice Platter', '3 - 6', 180),

(0501, 05, 'Chicken Skin', '2 - 3', 150),
(0502, 05, 'Chicharon', '2 - 3', 130),
(0503, 05, 'Banana Chips', '2 - 3', 80),
(0504, 05, 'Halo-halo', '1', 80),
(0505, 05, 'Mangga with bagoong', '1 - 2', 70),
(0506, 05, 'Bibingka', '1 - 2', 50),
(0507, 05, 'Vigan Empanada', '1 - 2', 60),
(0508, 05, 'Buko Pandan', '1 - 2', 80),

(0601, 06, 'Bottled Water', '350 ml', 30),
(0602, 06, 'Hot Coffee', '250 ml', 50),
(0603, 06, 'Hot Choco', '250 ml', 50),
(0604, 06, 'Mango Shake', '500 ml',100),
(0605, 06, 'Buko Juice', '1 coconut shell', 80),
(0606, 06, 'San Mig Light', '330 ml', 60),
(0607, 06, 'San Mig Pale Palsen', '320 ml', 60),
(0608, 06, 'Red Horse', '500 ml', 70);

--Products table
Create table Products(Product_ID int primary key ,Name varchar(40), Price int, Stock int default 50);
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

--Payment Method
Create table PaymentMethod(PaymentType_ID int primary key, Payment_Type varchar(20));
insert into PaymentMethod(PaymentType_ID, Payment_Type) values
(01, 'Cash'),
(02, 'Online Payment'),
(03, 'Debit/Credit Card');

--POS Receipt
Create table POSReceipt(Receipt_No int primary key, Date date not null, Items varchar(500) not null, PaymentType_ID int foreign key references PaymentMethod(PaymentType_ID), Total int not null);

--Guest Table 
Create table Guest(Receipt_No int primary key, Reservation_ID int NULL, Checkin_ID int NULL, Checkout_ID int NULL, Name varchar(50) not null, Email varchar(50), Phone varchar(20)not null, Room int not null, NumofGuest int not null, Check_in datetime not null, Check_out datetime not null, Status varchar(25), Bill_Amount int not null, Balance int not null, PaymentType_ID int foreign key references PaymentMethod(PaymentType_ID));

--Employee Table
Create table Employees(Emp_ID varchar(20) primary key not null, Position varchar (40)not null, Name varchar(50)not null,  Password varchar(30)not null, Auth_ID int not null);
insert into Employees(Emp_ID, Position, Name,  Password, Auth_ID) values
('EMP-001', 'Admin', 'Loraine', 'Admin123', 0),
('EMP-002', 'Manager', 'Sykiel', 'Manager123', 1),
('EMP-003', 'Front Desk', 'Marshall', 'Staff123', 2);

--Finance
Create table Revenue(RevenueID int primary key not null, Date date not null, Revenue int not null);