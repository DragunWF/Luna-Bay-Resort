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
    Pax INT,
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
    (1001, 01, 'Round Table With Umbrella', 10, 600),
    (1002, 01, 'Round Table With Umbrella', 10, 600),
    (1003, 01, 'Round Table With Umbrella', 10, 600),
    (1004, 01, 'Round Table With Umbrella', 10, 600),
    (1005, 01, 'Round Table With Umbrella', 10, 600),
    (1006, 01, 'Round Table With Umbrella', 10, 600),
    (1007, 01, 'Round Table With Umbrella', 10, 600),
    (1008, 01, 'Round Table With Umbrella', 10, 600),
    (1011, 01, 'Garden Table', 12, 600),
    (1012, 01, 'Garden Table', 12, 600),
    (1013, 01, 'Garden Table', 12, 600),
    (1014, 01, 'Garden Table', 12, 600),
    (1015, 01, 'Garden Table', 12, 600),
    (1016, 01, 'Garden Table', 12, 600),
    (1017, 01, 'Garden Table', 12, 600),
    (1021, 01, 'Pool Table', 12, 1000),
    (1022, 01, 'Pool Table', 12, 1000),
    (1023, 01, 'Pool Table', 12, 1000),
    (1024, 01, 'Pool Table', 12, 1000),
    (1025, 01, 'Pool Table', 12, 1000),
    (1026, 01, 'Pool Table', 12, 1000),
    (1027, 01, 'Pool Table', 12, 1000),

    -- Cottages
    (2001, 02, 'Green Wooden Cottage', 15, 800),
    (2002, 02, 'Green Wooden Cottage', 15, 800),
    (2003, 02, 'Green Wooden Cottage', 15, 800),
    (2004, 02, 'Green Wooden Cottage', 15, 800),
    (2011, 02, 'Kalesa Type Cottage', 20, 1000),
    (2012, 02, 'Kalesa Type Cottage', 20, 1000),
    (2013, 02, 'Kalesa Type Cottage', 20, 1000),
    (2021, 02, 'Swing Type Cottage', 20, 1000),
    (2022, 02, 'Swing Type Cottage', 20, 1000),
    (2023, 02, 'Swing Type Cottage', 20, 1000),
    (2031, 02, 'Red Wooden Cottage', 20, 1000),
    (2032, 02, 'Red Wooden Cottage', 20, 1000),
    (2033, 02, 'Red Wooden Cottage', 20, 1000),
    (2034, 02, 'Red Wooden Cottage', 20, 1000),
    (2041, 02, 'Veranda Cottage', 20, 1000),
    (2042, 02, 'Veranda Cottage', 20, 1000),
    (2043, 02, 'Veranda Cottage', 20, 1000),
    (2044, 02, 'Veranda Cottage', 20, 1000),
    (2051, 02, 'Special Wooden Cottage', 25, 1500),
    (2052, 02, 'Special Wooden Cottage', 25, 1500),
    (2053, 02, 'Special Wooden Cottage', 25, 1500),
    (2054, 02, 'Special Wooden Cottage', 25, 1500),
    (2061, 02, 'Family Cottage', 40, 1500),
    (2062, 02, 'Family Cottage', 40, 1500),
    (2063, 02, 'Family Cottage', 40, 1500),
    (2071, 02, 'Family Wooden Cottage', 25, 1500),
    (2072, 02, 'Family Wooden Cottage', 25, 1500),
    (2073, 02, 'Family Wooden Cottage', 25, 1500),
    (2074, 02, 'Family Wooden Cottage', 25, 1500),
    (2081, 02, 'Team Cottage', 25, 1500),
    (2082, 02, 'Team Cottage', 25, 1500),
    (2083, 02, 'Team Cottage', 25, 1500),
    (2091, 02, 'Club Cottage', 25, 1500),
    (2092, 02, 'Club Cottage', 25, 1500),
    (2093, 02, 'Club Cottage', 25, 1500),
    (2101, 02, 'Double Wooden Cottage', 35, 2000),
    (2102, 02, 'Double Wooden Cottage', 35, 2000),
    (2103, 02, 'Double Wooden Cottage', 35, 2000),
    (2111, 02, 'Pool Cottage', 25, 2000),
    (2112, 02, 'Pool Cottage', 25, 2000),
    (2113, 02, 'Pool Cottage', 25, 2000),
    (2121, 02, 'Trilles House', 30, 2500),
    (2122, 02, 'Trilles House', 30, 2500),
    (2123, 02, 'Trilles House', 30, 2500),
    (2131, 02, 'Trio Cottage', 30, 3000),
    (2132, 02, 'Trio Cottage', 30, 3000),
    (2133, 02, 'Trio Cottage', 30, 3000),
    (2141, 02, 'Tree House', 60, 3000),
    (3001, 03, 'Pavillion I (non-aircon)', 100, 8000),
    (3002, 03, 'Pavillion I (air-conditioned)', 100, 10000),
    (3003, 03, 'Paviilion II (open-type)', 120, 12000),

    -- VIP Rooms
    (4001, 04, 'VIP Room (air-conditioned)', 6, 2000),
    (4002, 04, 'VIP Room (air-conditioned)', 6, 2000),
    (4003, 04, 'VIP Room (air-conditioned)', 6, 2000),
    (4004, 04, 'VIP Room (air-conditioned)', 6, 2000),
    (4005, 04, 'VIP Room (air-conditioned)', 6, 2000),
    (4006, 04, 'VIP Room (air-conditioned)', 6, 2000),
    (4007, 04, 'VIP Room (air-conditioned)', 6, 2000),
    (4008, 04, 'VIP Room (air-conditioned)', 6, 2000),

    -- Executive Rooms
    (4011, 04, 'Executive Rooms', 15, 3500 ),
    (4012, 04, 'Executive Rooms', 15, 3500),
    (4013, 04, 'Executive Rooms', 15, 3500),
    (4014, 04, 'Executive Rooms', 15, 3500),
    (4015, 04, 'Executive Rooms', 15, 4000),
    (4016, 04, 'Executive Rooms', 15, 4000),
    (4017, 04, 'Executive Rooms', 15, 4000),
    (4018, 04, 'Executive Rooms', 15, 4000),

    -- Miscelleneous
    (4021, 04, 'Veranda I (open type) with 3 VIP Rooms downstairs', 40, 9000),
    (4022, 04, 'Veranda I (open type) with 3 VIP Rooms downstairs', 40, 9000),
    (4023, 04, 'Veranda I (open type) with 3 VIP Rooms downstairs', 40, 9000),
    (4024, 04, 'Veranda I (open type) with 3 VIP Rooms downstairs', 40, 9000),
    (4025, 04, 'Veranda I (open type) with 3 VIP Rooms downstairs', 40, 9000),
    (4031, 04, 'Veranda II (air-conditioned) | Conference & VIP Room', 33, 7500),
    (4032, 04, 'Veranda II (air-conditioned) | Conference & VIP Room', 33, 7500),
    (4033, 04, 'Veranda II (air-conditioned) | Conference & VIP Room', 33, 7500),
    (4034, 04, 'Veranda II (air-conditioned) | Conference & VIP Room', 33, 7500),
    (4041, 04, 'Veranda III-Inclusive of 1 VIP Room', 25, 7000),
    (4042, 04, 'Veranda III-Inclusive of 1 VIP Room', 25, 7000),
    (4043, 04, 'Veranda III-Inclusive of 1 VIP Room', 25, 7000),
    (4051, 04, 'Veranda IV-Inclusive of 3 VIP Rooms', 80, 7000),
    (4052, 04, 'Veranda IV-Inclusive of 3 VIP Rooms', 80, 7000),
    (4053, 04, 'Veranda IV-Inclusive of 3 VIP Rooms', 80, 7000),
    (5001, 05, 'Private Pool I With Jacuzzi (Veranda & Private Room)', 40, 12000),
    (5002, 05, 'Private Pool I With Jacuzzi (Veranda & Private Room)', 40, 12000),
    (5003, 05, 'Private Pool I With Jacuzzi (Veranda & Private Room)', 40, 12000),
    (5004, 05, 'Private Pool I With Jacuzzi (Veranda & Private Room)', 40, 12000),
    (5011, 05, 'Private Pool II With Jacuzzi (Private Room)', 30, 8000),
    (5012, 05, 'Private Pool II With Jacuzzi (Private Room)', 30, 8000),
    (5013, 05, 'Private Pool II With Jacuzzi (Private Room)', 30, 8000),
    (5021, 05, 'Private Pool III With Jacuzzi (2 Private Room)', 40, 12000),
    (5022, 05, 'Private Pool III With Jacuzzi (2 Private Room)', 40, 12000),
    (5023, 05, 'Private Pool III With Jacuzzi (2 Private Room)', 40, 12000),
    (5024, 05, 'Private Pool III With Jacuzzi (2 Private Room)', 40, 12000),
    (6001, 06, 'Clubhouse', 450, 30000),
    (6002, 06, 'Clubhouse', 450, 40000),
    (6011, 06, 'Conference A', 25, 6000),
    (6021, 06, 'Conference B', 35, 8000),
    (6031, 06, 'Conference C', 45, 15000),
    (6041, 06, 'Convention Hall', 700, 125000);

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
    Name VARCHAR(40),
    Serving VARCHAR(30),
	Stock INT,
    Price DOUBLE PRECISION
);

INSERT INTO Food (Food_ID, FoodType_ID, Name, Serving, Stock, Price) VALUES
    -- Breakfast Items
    (101, 1, 'Tapsilog', '1', NULL, 105), 
    (102, 1, 'Tosilog', '1', NULL, 105), 
    (103, 1, 'Bangsilog', '1', NULL, 135), 
    (104, 1, 'Cornbeef Silog', '1', NULL, 125),
    (105, 1, 'Sopas', '1 - 2', NULL, 120), 
    (106, 1, 'Champorado', '1 - 2', NULL, 120),

    -- Lunch Items
    (201, 2, 'Chicken Adobo', '3 - 4', NULL, 350), 
    (202, 2, 'Sinigang na Bangus', '3 - 4', NULL, 380), 
    (203, 2, 'Pork Sisig', '2 - 3', NULL, 250), 
    (204, 2, 'Pork Liempo', '3 - 4', NULL, 350),
    (205, 2, 'Pinakbet', '3 - 4', NULL, 280), 
    (206, 2, 'Daing na Bangus', '3', NULL, 320),
    (207, 2, 'Pork Bistek', '2 - 3', NULL, 320),

    -- Dinner Items
    (301, 3, 'Special Laing', '3 - 4', NULL, 320), 
    (302, 3, 'Kare Kare', '3 - 4', NULL, 380),
    (304, 3, 'Buttered Shrimp', '3', NULL, 320),
    (305, 3, 'Adobong Pusit', '3 - 4', NULL, 350),
    (306, 3, 'Chicken Tinola', '3 - 4', NULL, 380),
    (307, 3, 'Pork Caldereta', '3 - 4', NULL, 350),
    (308, 3, 'Lechon Kawali', '3', NULL, 320),

    -- Rice Addons
    (401, 4, 'Plain Rice', '1', NULL, 30),
    (402, 4, 'Garlic Rice', '2', NULL, 40),
    (403, 4, 'Java Rice', '3', NULL, 50),
    (404, 4, 'Rice Platter', '3 - 6', NULL, 180),

    -- Snacks And Desserts
    (501, 5, 'Chicken Skin', '2 - 3', 50, 150),
    (502, 5, 'Chicharon', '2 - 3', 70, 130),
    (503, 5, 'Banana Chips', '2 - 3', 30, 80),
    (504, 5, 'Halo-halo', '1', NULL, 80),
    (505, 5, 'Mangga with Bagoong', '1 - 2', 80, 70),
    (506, 5, 'Bibingka', '1 - 2', 90, 50),
    (507, 5, 'Vigan Empanada', '1 - 2', 70, 60),
    (508, 5, 'Buko Pandan', '1 - 2', 60, 80),

    -- Beverages
    (601, 6, 'Bottled Water', '350 ml', 30, 30),
    (602, 6, 'Hot Coffee', '250 ml', NULL, 50),
    (603, 6, 'Hot Choco', '250 ml', NULL, 50),
    (604, 6, 'Mango Shake', '500 ml', 80, 100),
    (605, 6, 'Buko Juice', '1 Coconut Shell', 30, 80),
    (606, 6, 'San Mig Light', '330 ml', 50, 60),
    (607, 6, 'San Mig Pale Pilsen', '320 ml',80, 60),
    (608, 6, 'Red Horse', '500 ml', 70, 70);

-- Products table
CREATE TABLE Products (
    Product_ID INT IDENTITY(700, 1) PRIMARY KEY,
    Name VARCHAR(40),
    Price DOUBLE PRECISION,
    Stock INT DEFAULT 100
);
INSERT INTO Products (Name, Price) VALUES
    ('Rashguard(Women)', 450),
    ('Trunks (Men)', 250),
    ('One Piece (Girls)', 300),
    ('Two Piece (Girls)', 300),
    ('One Piece (Women)', 375),
    ('Two Piece  (Women)', 375),
    ('Rashguard(Men)', 450),
    ('Cycling(Women)', 150),
    ('Summer shorts (Boys)', 200),
    ('Tee(Boys)', 150),
    ('Float', 100),
    ('Goggles', 175),
    ('Ear Plugs', 320);

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
    Bill_Amount DOUBLE PRECISION NOT NULL,
    Balance DOUBLE PRECISION NOT NULL,
    PaymentType_ID INT FOREIGN KEY REFERENCES PaymentMethod(PaymentType_ID),
	PaymentReference_NO VARCHAR(30) NULL
);

--Walk In Table
CREATE TABLE WalkIn(
	WalkIn_ID INT IDENTITY(4000, 1) PRIMARY KEY NOT NULL,
	Name VARCHAR(50) NOT NULL,
	NumOfPerson INT NOT NULL,
	Duration VARCHAR(50) NOT NULL,
	Date VARCHAR(50) NOT NULL,
	Total int NOT NULL,
	PaymentType_ID INT FOREIGN KEY REFERENCES PaymentMethod(PaymentType_ID),
	PaymentReference_NO VARCHAR(30) NULL
);

-- Employees & Positions Table
CREATE TABLE Positions (
    Auth_ID INT PRIMARY KEY NOT NULL,
    Name VARCHAR(50) NOT NULL,
);
INSERT INTO Positions VALUES
    (1, 'Admin'),
    (2, 'Manager'),
    (3, 'Front Desk'),
    (4, 'Cashier')

CREATE TABLE Employees (
    Emp_ID INT IDENTITY(1000, 1) PRIMARY KEY NOT NULL,
    Name VARCHAR(50) NOT NULL,
    Password VARCHAR(30) NOT NULL,
    Auth_ID INT FOREIGN KEY REFERENCES Positions(Auth_ID)
);
INSERT INTO Employees (Name, Password, Auth_ID) VALUES
    ('Loraine', 'Admin123', 1),
    ('Sykiel', 'Manager123', 2),
    ('Marshall', 'Frontdesk123', 3),
	('Sean', 'Cashier123', 4);

-- Finance
CREATE TABLE Revenue (
    RevenueID INT IDENTITY(5000, 1) PRIMARY KEY NOT NULL,
    Date VARCHAR(30) NOT NULL,
    Revenue DOUBLE PRECISION NOT NULL
);

-- Activities
CREATE TABLE Activities(
	ActivityID INT IDENTITY(1000, 1) PRIMARY KEY NOT NULL,
	Description VARCHAR(500) NOT NULL,
	Date VARCHAR(50) NOT NULL
);