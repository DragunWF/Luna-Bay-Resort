USE LunaBayResortDB;

-- Drop tables in the correct order to avoid dependency issues
BEGIN
	BEGIN TRANSACTION
    
	BEGIN TRY
		IF OBJECT_ID('Bookings', 'U') IS NOT NULL
			DROP TABLE Bookings;

		IF OBJECT_ID('Guest', 'U') IS NOT NULL
			DROP TABLE Guest;

		IF OBJECT_ID('Payments', 'U') IS NOT NULL
			DROP TABLE Payments;

		IF OBJECT_ID('Positions', 'U') IS NOT NULL
			DROP TABLE Positions;

		IF OBJECT_ID('Employees', 'U') IS NOT NULL
			DROP TABLE Employees;

		IF OBJECT_ID('Food', 'U') IS NOT NULL
			DROP TABLE Food;

		IF OBJECT_ID('Products', 'U') IS NOT NULL
			DROP TABLE Products;

		IF OBJECT_ID('POSReceipt', 'U') IS NOT NULL
			DROP TABLE POSReceipt;

		IF OBJECT_ID('Revenue', 'U') IS NOT NULL
			DROP TABLE Revenue;

		IF OBJECT_ID('Activities', 'U') IS NOT NULL
			DROP TABLE Activities;

		IF OBJECT_ID('Accommodation', 'U') IS NOT NULL
			DROP TABLE Accommodation;

		IF OBJECT_ID('PaymentMethod', 'U') IS NOT NULL
			DROP TABLE PaymentMethod;

		IF OBJECT_ID('FoodType', 'U') IS NOT NULL
			DROP TABLE FoodType;

		IF OBJECT_ID('RoomType', 'U') IS NOT NULL
			DROP TABLE RoomType;
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH

	COMMIT
END