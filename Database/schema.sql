CREATE DATABASE LunaBayResortDB;
GO
USE LunaBayResortDB;

-- Accommodation tables
CREATE TABLE RoomType (
    RoomType_ID INT PRIMARY KEY,
    RoomType VARCHAR(25)
);

CREATE TABLE Accommodation (
    Room_ID INT PRIMARY KEY,
    RoomType_ID INT FOREIGN KEY REFERENCES RoomType(RoomType_ID),
    Name VARCHAR(100),
    Pax VARCHAR(20),
    Price INT,
    Room_status VARCHAR(50) DEFAULT 'Available'
);

INSERT INTO RoomType (RoomType_ID, RoomType) VALUES
    (01, 'Table'),
    (02, 'Cottages'),
    (03, 'Pavillion'),
    (04, 'PrivateRoom'),
    (05, 'RoomWithPool'),
    (06, 'EventPlace');

INSERT INTO Accommodation (Room_ID, RoomType_ID, Name, Pax, Price) VALUES
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

    -- Cottages
    (2001, 02, 'Green Wooden Cottage', '12 - 15', 800),
    (2002, 02, 'Green Wooden Cottage', '12 - 15', 800),
    (2003, 02, 'Green Wooden Cottage', '12 - 15', 800),
    (2004, 02, 'Green Wooden Cottage', '12 - 15', 800),
    (2011, 02, 'Kalesa Type Cottage', '15 - 20', 1000),
    (2012, 02, 'Kalesa Type Cottage', '15 - 20', 1000),
    (2013, 02, 'Kalesa Type Cottage', '15 - 20', 1000),
    (2021, 02, 'Swing Type Cottage', '10 - 20', 1000),
    (2022, 02, 'Swing Type Cottage', '10 - 20', 1000),
    (2023, 02, 'Swing Type Cottage', '10 - 20', 1000),
    (2031, 02, 'Red Wooden Cottage', '12 - 20', 1000),
    (2032, 02, 'Red Wooden Cottage', '12 - 20', 1000),
    (2033, 02, 'Red Wooden Cottage', '12 - 20', 1000),
    (2034, 02, 'Red Wooden Cottage', '12 - 20', 1000),
    (2041, 02, 'Veranda Cottage', '12 - 20', 1000),
    (2042, 02, 'Veranda Cottage', '12 - 20', 1000),
    (2043, 02, 'Veranda Cottage', '12 - 20', 1000),
    (2044, 02, 'Veranda Cottage', '12 - 20', 1000),
    (2051, 02, 'Special Wooden Cottage', '20 - 25', 1500),
    (2052, 02, 'Special Wooden Cottage', '20 - 25', 1500),
    (2053, 02, 'Special Wooden Cottage', '20 - 25', 1500),
    (2054, 02, 'Special Wooden Cottage', '20 - 25', 1500),
    (2061, 02, 'Family Cottage', '30 - 40', 1500),
    (2062, 02, 'Family Cottage', '30 - 40', 1500),
    (2063, 02, 'Family Cottage', '30 - 40', 1500),
    (2071, 02, 'Family Wooden Cottage', '20 - 25', 1500),
    (2072, 02, 'Family Wooden Cottage', '20 - 25', 1500),
    (2073, 02, 'Family Wooden Cottage', '20 - 25', 1500),
    (2074, 02, 'Family Wooden Cottage', '20 - 25', 1500),
    (2081, 02, 'Team Cottage', '20 - 25', 1500),
    (2082, 02, 'Team Cottage', '20 - 25', 1500),
    (2083, 02, 'Team Cottage', '20 - 25', 1500),
    (2091, 02, 'Club Cottage', '20 - 25', 1500),
    (2092, 02, 'Club Cottage', '20 - 25', 1500),
    (2093, 02, 'Club Cottage', '20 - 25', 1500),
    (2101, 02, 'Double Wooden Cottage', '30 - 35', 2000),
    (2102, 02, 'Double Wooden Cottage', '30 - 35', 2000),
    (2103, 02, 'Double Wooden Cottage', '30 - 35', 2000),
    (2111, 02, 'Pool Cottage', '20 - 25', 2000),
    (2112, 02, 'Pool Cottage', '20 - 25', 2000),
    (2113, 02, 'Pool Cottage', '20 - 25', 2000),
    (2121, 02, 'Trilles House', '25 - 30', 2500),
    (2122, 02, 'Trilles House', '25 - 30', 2500),
    (2123, 02, 'Trilles House', '25 - 30', 2500),
    (2131, 02, 'Trio Cottage', '25 - 30', 3000),
    (2132, 02, 'Trio Cottage', '25 - 30', 3000),
    (2133, 02, 'Trio Cottage', '25 - 30', 3000),
    (2141, 02, 'Tree House', '50 - 60', 3000),
    (3001, 03, 'Pavillion I (non-aircon)','80 - 100', 8000),
    (3002, 03, 'Pavillion I (air-conditioned)','80 - 100', 10000),
    (3003, 03, 'Paviilion II (open-type)','100 - 120', 12000),

    -- VIP Rooms
    (4001, 04, 'VIP Room (air-conditioned)','2 - 6', 2000),
    (4002, 04, 'VIP Room (air-conditioned)','2 - 6', 2000),
    (4003, 04, 'VIP Room (air-conditioned)','2 - 6', 2000),
    (4004, 04, 'VIP Room (air-conditioned)','2 - 6', 2000),
    (4005, 04, 'VIP Room (air-conditioned)','2 - 6', 2000),
    (4006, 04, 'VIP Room (air-conditioned)','2 - 6', 2000),
    (4007, 04, 'VIP Room (air-conditioned)','2 - 6', 2000),
    (4008, 04, 'VIP Room (air-conditioned)','2 - 6', 2000),

    -- Executive Rooms
    (4011, 04, 'Executive Rooms','10 - 15', 3500 ),
    (4012, 04, 'Executive Rooms','10 - 15', 3500),
    (4013, 04, 'Executive Rooms','10 - 15', 3500),
    (4014, 04, 'Executive Rooms','10 - 15', 3500),
    (4015, 04, 'Executive Rooms','10 - 15', 4000),
    (4016, 04, 'Executive Rooms','10 - 15', 4000),
    (4017, 04, 'Executive Rooms','10 - 15', 4000),
    (4018, 04, 'Executive Rooms','10 - 15', 4000),

    -- Miscelleneous
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
    (6001, 06, 'Clubhouse','400 � 450', 30000),
    (6002, 06, 'Clubhouse','400 � 450', 40000),
    (6011, 06, 'Conference A','20 � 25', 6000),
    (6021, 06, 'Conference B','30 � 35', 8000),
    (6031, 06, 'Conference C','40 � 45', 15000),
    (6041, 06, 'Convention Hall','600 - 700', 125000);

-- Food Type Table
CREATE TABLE FoodType (
    FoodType_ID INT PRIMARY KEY,
    FoodType VARCHAR(25)
);

INSERT INTO FoodType (FoodType_ID, FoodType) VALUES
    (1, 'Breakfast'),
    (2, 'Lunch'),
    (3, 'Dinner'),
    (4, 'RiceAddons'),
    (5, 'Snacks And Desserts'),
    (6, 'Beverages');

-- Food Table
CREATE TABLE Food (
    Food_ID INT PRIMARY KEY,
    FoodType_ID INT FOREIGN KEY REFERENCES FoodType(FoodType_ID),
    Food_Name VARCHAR(40),
    Serving VARCHAR(30),
	Quantity INT,
    Price INT
);

INSERT INTO Food (Food_ID, FoodType_ID, Food_Name, Serving, Quantity, Price) VALUES
    -- Breakfast Items
    (101, 1, 'Tapsilog', '1', 50, 105), 
    (102, 1, 'Tosilog', '1', 50, 105), 
    (103, 1, 'Bangsilog', '1', 50, 135), 
    (104, 1, 'Cornbeef Silog', '1', 50, 125),
    (105, 1, 'Sopas', '1 - 2', 50, 120), 
    (106, 1, 'Champorado', '1 - 2', 50, 120),

    -- Lunch Items
    (201, 2, 'Chicken Adobo', '3 - 4', 50, 350), 
    (202, 2, 'Sinigang na Bangus', '3 - 4', 50, 380), 
    (203, 2, 'Pork Sisig', '2 - 3', 50, 250), 
    (204, 2, 'Pork Liempo', '3 - 4', 50, 350),
    (205, 2, 'Pinakbet', '3 - 4', 50, 280), 
    (206, 2, 'Daing na Bangus', '3', 50, 320),
    (207, 2, 'Pork Bistek', '2 - 3', 50, 320),

    -- Dinner Items
    (301, 3, 'Special Laing', '3 - 4', 50, 320), 
    (302, 3, 'Kare Kare', '3 - 4', 50, 380),
    (304, 3, 'Buttered Shrimp', '3', 50, 320),
    (305, 3, 'Adobong Pusit', '3 - 4', 50, 350),
    (306, 3, 'Chicken Tinola', '3 - 4', 50, 380),
    (307, 3, 'Pork Caldereta', '3 - 4', 50, 350),
    (308, 3, 'Lechon Kawali', '3', 50, 320),

    -- Rice Addons
    (401, 4, 'Plain Rice', '1', 50, 30),
    (402, 4, 'Garlic Rice', '2', 50, 40),
    (403, 4, 'Java Rice', '3', 50, 50),
    (404, 4, 'Rice Platter', '3 - 6', 50, 180),

    -- Snacks And Desserts
    (501, 5, 'Chicken Skin', '2 - 3', 50, 150),
    (502, 5, 'Chicharon', '2 - 3', 50, 130),
    (503, 5, 'Banana Chips', '2 - 3', 50, 80),
    (504, 5, 'Halo-halo', '1', 50, 80),
    (505, 5, 'Mangga with Bagoong', '1 - 2', 50, 70),
    (506, 5, 'Bibingka', '1 - 2', 50, 50),
    (507, 5, 'Vigan Empanada', '1 - 2', 50, 60),
    (508, 5, 'Buko Pandan', '1 - 2', 50, 80),

    -- Beverages
    (601, 6, 'Bottled Water', '350 ml', 50, 30),
    (602, 6, 'Hot Coffee', '250 ml', 50, 50),
    (603, 6, 'Hot Choco', '250 ml', 50, 50),
    (604, 6, 'Mango Shake', '500 ml', 50, 100),
    (605, 6, 'Buko Juice', '1 Coconut Shell', 50, 80),
    (606, 6, 'San Mig Light', '330 ml', 50, 60),
    (607, 6, 'San Mig Pale Pilsen', '320 ml', 50, 60),
    (608, 6, 'Red Horse', '500 ml', 50, 70);

-- Products table
CREATE TABLE Products (
    Product_ID INT PRIMARY KEY,
    Name VARCHAR(40),
    Price INT,
    Stock INT DEFAULT 50
);
INSERT INTO Products (Product_ID, Name, Price) VALUES
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

-- Payment Method
CREATE TABLE PaymentMethod (
    PaymentType_ID INT PRIMARY KEY,
    Payment_Type VARCHAR(20)
);
INSERT INTO PaymentMethod (PaymentType_ID, Payment_Type) VALUES
    (01, 'Cash'),
    (02, 'Online Payment'),
    (03, 'Debit/Credit Card');

-- POS Receipt
CREATE TABLE POSReceipt (
    Receipt_No INT PRIMARY KEY,
    Date DATE NOT NULL,
    Items VARCHAR(500) NOT NULL,
    PaymentType_ID INT FOREIGN KEY REFERENCES PaymentMethod(PaymentType_ID),
    Total INT NOT NULL
);

-- Guest Table 
CREATE TABLE Guest (
    Guest_ID INT IDENTITY(1, 1) PRIMARY KEY,
    Reservation_ID INT NULL,
    Checkin_ID INT NULL,
    Checkout_ID INT NULL,
    Name VARCHAR(500) NOT NULL,
    Email VARCHAR(500),
    Phone VARCHAR(20) NOT NULL,
    Room INT NOT NULL,
    NumofGuest INT NOT NULL,
    Check_in VARCHAR(50) NOT NULL,
    Check_out VARCHAR(50) NOT NULL,
    Status VARCHAR(25),
    Bill_Amount INT NOT NULL,
    Balance INT NOT NULL,
    PaymentType_ID INT FOREIGN KEY REFERENCES PaymentMethod(PaymentType_ID),
	PaymentReference_NO INT NULL
);

-- Employee Table
CREATE TABLE Employees (
    Emp_ID INT IDENTITY(1000, 1) PRIMARY KEY NOT NULL,
    Position VARCHAR(40) NOT NULL,
    Name VARCHAR(50) NOT NULL,
    Password VARCHAR(30) NOT NULL,
    Auth_ID INT NOT NULL
);
INSERT INTO Employees (Position, Name, Password, Auth_ID) VALUES
    ('Admin', 'Loraine', 'Admin123', 0),
    ('Manager', 'Sykiel', 'Manager123', 1),
    ('Front Desk', 'Marshall', 'Frontdesk123', 2),
	('Cashier', 'Sean', 'Cashier123', 3);

-- Finance
CREATE TABLE Revenue (
    RevenueID INT PRIMARY KEY NOT NULL,
    Date DATE NOT NULL,
    Revenue INT NOT NULL
);

--Activities
CREATE TABLE Activities(
	ActivityID INT PRIMARY KEY NOT NULL,
	Descritpion VARCHAR(500) NOT NULL,
	Date VARCHAR(50) NOT NULL
);