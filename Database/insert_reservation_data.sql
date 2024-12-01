-- Reservation Dummy Data

INSERT INTO Guest (Reservation_ID, Checkin_ID, Checkout_ID, Name, Email, Phone, Room, NumofGuest, Check_in, Check_out, Status, Bill_Amount, Balance, PaymentType_ID, PaymentReference_NO)
VALUES
    (101, NULL, NULL, 'John Doe', 'johndoe@example.com', '123-456-7890', 101, 2, '2024-01-10', '2024-01-15', 'Checked Out', 500.75, 0.00, 1, NULL),
    (102, NULL, NULL, 'Jane Smith', 'janesmith@example.com', '123-456-7891', 102, 1, '2024-02-01', '2024-02-05', 'Checked Out', 300.50, 0.00, 2, NULL),
    (103, NULL, NULL, 'Samuel Green', 'samuel.green@example.com', '123-456-7892', 103, 3, '2024-03-12', '2024-03-18', 'Checked In', 750.30, 100.00, 1, NULL),
    (104, NULL, NULL, 'Emily Clark', 'emily.clark@example.com', '123-456-7893', 104, 2, '2024-04-05', '2024-04-10', 'Checked Out', 450.60, 0.00, 3, NULL),
    (105, NULL, NULL, 'Michael Brown', 'michael.brown@example.com', '123-456-7894', 105, 4, '2024-05-01', '2024-05-07', 'Checked Out', 650.20, 0.00, 2, NULL),
    (106, NULL, NULL, 'Sarah White', 'sarah.white@example.com', '123-456-7895', 106, 2, '2024-06-15', '2024-06-20', 'Checked In', 550.00, 50.00, 1, NULL),
    (107, NULL, NULL, 'David Blue', 'david.blue@example.com', '123-456-7896', 107, 1, '2024-07-10', '2024-07-12', 'Checked Out', 200.75, 0.00, 3, NULL),
    (108, NULL, NULL, 'Olivia Black', 'olivia.black@example.com', '123-456-7897', 108, 3, '2024-08-05', '2024-08-10', 'Checked In', 900.00, 300.00, 2, NULL),
    (109, NULL, NULL, 'James Red', 'james.red@example.com', '123-456-7898', 109, 2, '2024-09-20', '2024-09-25', 'Checked Out', 600.40, 0.00, 1, NULL),
    (110, NULL, NULL, 'Lily Grey', 'lily.grey@example.com', '123-456-7899', 110, 1, '2024-10-10', '2024-10-12', 'Checked Out', 150.00, 0.00, 2, NULL);
