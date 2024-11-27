INSERT INTO AppointmentStatus (Name) VALUES 
('Scheduled'), ('Completed'), ('Cancelled'), ('No Show'), ('Rescheduled');


INSERT INTO [dbo].[Medical Specialties] ([Name]) VALUES 
('Cardiology'), ('Dermatology'), ('Pediatrics'), ('Orthopedics'), ('Neurology');

INSERT INTO [dbo].[Carrer Specializations] ([Name]) VALUES 
('Doctor'), ('Nurse'), ('Technician'), ('Receptionist'), ('Therapist');
-----------------------------
INSERT INTO [dbo].[PaymentMethods] ([Name]) VALUES 
('Credit Card'), ('Cash'), ('Insurance'), ('Bank Transfer'), ('Mobile Payment');

INSERT INTO [dbo].[Persons] ([Name], [BirthDate], [Gender], [Phone], [Email], [Country], [Address], [ImagePath]) VALUES 
('John Doe', '1985-04-12', 'Male', '123-456-7890', 'john.doe@example.com', 'USA', '123 Main St, Springfield', NULL),
('Jane Smith', '1990-07-22', 'Female', '234-567-8901', 'jane.smith@example.com', 'Canada', '456 Maple Ave, Toronto', NULL),
('Robert Brown', '1978-03-15', 'Male', '345-678-9012', 'robert.brown@example.com', 'UK', '789 Oak St, London', NULL),
('Emily White', '1995-11-30', 'Female', '456-789-0123', 'emily.white@example.com', 'Australia', '321 Birch St, Sydney', NULL),
('Michael Green', '1980-09-18', 'Male', '567-890-1234', 'michael.green@example.com', 'New Zealand', '654 Pine St, Auckland', NULL);


INSERT INTO [dbo].[Employees] ([Salary], [CarrerId], [PersonId]) VALUES 
(60000, 1, 1), (50000, 2, 2), (70000, 1, 3), (45000, 3, 4), (55000, 4, 5);


INSERT INTO [dbo].[Doctors] ([SpecializationId], [EmployeeId]) VALUES 
(1, 1), (2, 2), (3, 4), (4, 3), (5, 5);

INSERT INTO [dbo].[Patients] ([PersonId]) VALUES 
(1), (2), (3), (4), (5);

INSERT INTO [dbo].[MedicalRecords] ([VisitDescription], [Diagnosis], [AdditionalNotes]) VALUES 
('Routine check-up', 'Healthy', 'No additional notes'), 
('Skin rash examination', 'Allergic reaction', 'Prescribed ointment'), 
('Child vaccination', 'N/A', 'Recommended next dose in 6 months'), 
('Fracture follow-up', 'Healed fracture', 'Continue exercises'), 
('Memory loss evaluation', 'Early dementia', 'Monitor symptoms');


INSERT INTO [dbo].[Payments] ([Date], [Amount], [AdditionalNotes], [PaymentMethodsId]) VALUES 
('2024-11-01', 100, NULL, 1), 
('2024-11-02', 200, NULL, 2), 
('2024-11-03', 150, 'Insurance covered', 3), 
('2024-11-04', 250, 'Paid in full', 4), 
('2024-11-05', 300, NULL, 5);

INSERT INTO [dbo].[Users] ([Username], [Password], [Permission], [PersonId]) VALUES 
('jdoe', 'password1', 'Doctor', 1), 
('jsmith', 'password2', 'Patient', 2), 
('rbrown', 'password3', 'Doctor', 3), 
('ewhite', 'password4', 'Patient', 4), 
('mgreen', 'password5', 'Receptionist', 5);


INSERT INTO [dbo].[Appointments] ([DateTime], [PatientId], [DoctorId], [AppointmentStatusId], [PaymentId], [MedicalRecordId]) VALUES 
('2024-11-01 10:00:00', 1, 4, 1, 1, 1), 
('2024-11-02 11:00:00', 2, 5, 2, 2, 2), 
('2024-11-03 12:00:00', 3, 6, 3, 3, 3), 
('2024-11-04 13:00:00', 4, 7, 4, 4, 4), 
('2024-11-05 14:00:00', 5, 8, 5, 5, 5);

INSERT INTO [dbo].[Prescriptions] ([MedicationName], [Dosage], [Frequency], [StartDate], [EndDate], [SpecialInstructions], [MedicalRecordId]) VALUES 
('Ibuprofen', '200 mg', 'Twice a day', '2024-11-01', '2024-11-10', 'Take with food', 1), 
('Paracetamol', '500 mg', 'Every 4 hours', '2024-11-02', '2024-11-15', 'Avoid alcohol', 2), 
('Amoxicillin', '250 mg', 'Three times a day', '2024-11-03', '2024-11-10', 'Complete course', 3), 
('Vitamin D', '1000 IU', 'Once daily', '2024-11-04', '2024-11-30', 'Take in the morning', 4), 
('Metformin', '500 mg', 'Twice a day', '2024-11-05', '2024-12-05', 'Take after meals', 5);








--- Verify Appointments table data
SELECT * FROM [dbo].[Appointments];

-- Verify AppointmentStatus table data
SELECT * FROM [dbo].[AppointmentStatus];

-- Verify Carrer Specializations table data
SELECT * FROM [dbo].[CareerSpecializations];

-- Verify Doctors table data
SELECT * FROM [dbo].[Doctors];

-- Verify Employees table data
SELECT * FROM [dbo].[Employees];

-- Verify Medical Specialties table data
SELECT * FROM [dbo].[MedicalSpecialties];

-- Verify MedicalRecords table data
SELECT * FROM [dbo].[MedicalRecords];

-- Verify Patients table data
SELECT * FROM [dbo].[Patients];

-- Verify PaymentMethods table data
SELECT * FROM [dbo].[PaymentMethods];

-- Verify Payments table data
SELECT * FROM [dbo].[Payments];

-- Verify Persons table data
SELECT * FROM [dbo].[Persons];

-- Verify Prescriptions table data
SELECT * FROM [dbo].[Prescriptions];

-- Verify Users table data
SELECT * FROM [dbo].[Users];






