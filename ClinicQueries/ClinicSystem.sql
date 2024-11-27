alter table Patients add foreign key (PersonId) references Persons (Id)
alter table Users add foreign key (PersonId) references Persons (Id)
alter table Employees add foreign key (PersonId) references Persons (Id)
alter table Employees add foreign key (CarrerId) references [Carrer Specializations](Id)
alter table Doctors add foreign key (EmployeeId) references Employees (Id)
alter table Doctors add foreign key (SpecializationId) references [Medical Specialties] (Id)

alter table Appointments add foreign key (PatientId) references Patients (Id)
alter table Appointments add foreign key (DoctorId) references Doctors (Id)
alter table Appointments add foreign key (AppointmentStatusId) references AppointmentStatus (Id)
alter table Appointments add foreign key (PaymentId) references Payments (Id)
alter table Appointments add foreign key (MedicalRecordId) references MedicalRecords (Id)

alter table Prescriptions add foreign key (MedicalRecordId) references MedicalRecords (Id)

alter table Payments add foreign key (PaymentMethodsId) references PaymentMethods (Id)


--adding unique constraint on foreign key 
alter table Patients add constraint PersonId_Unique unique (PersonId)
alter table Users add constraint PersonId_User_Unique unique (PersonId)
alter table Employees add constraint PersonId_Employee_Unique unique (PersonId)
alter table Doctors add constraint PersonId_Doctor_Unique unique (EmployeeId)
alter table Appointments add constraint PaymentId_Unique unique (PaymentId)
alter table Appointments add constraint MedicalRecordId_Unique unique (MedicalRecordId)
alter table Prescriptions add constraint MedicalRecordId_Prescription_Unique unique (MedicalRecordId)

select * from Persons
select * from Employees
select * from View_Employees_Details
select Id from Persons where Name='John Doe'  SELECT SCOPE_IDENTITY();

--create views
create view View_Employees_Details as (
SELECT Employees.Id, Persons.Name, Persons.BirthDate, Persons.Gender, Persons.Phone, Persons.Email, Persons.Address, Persons.ImagePath, Countries.Name AS Country, Employees.Salary, CareerSpecializations.Name AS Career
FROM     Persons INNER JOIN
                  Employees ON Persons.Id = Employees.PersonId INNER JOIN
                  CareerSpecializations ON Employees.CarrerId = CareerSpecializations.Id INNER JOIN
                  Countries ON Persons.Id = Countries.ID)

create view View_Doctors_Details as(
SELECT d.Id, p.Name, p.BirthDate, p.Gender, p.Phone, p.Email, Countries.Name AS Country, p.Address, p.ImagePath, MedicalSpecialties.Name AS Specialization, e.Salary
FROM     Doctors d INNER JOIN
                  Employees e ON d.EmployeeId = e.Id INNER JOIN
                  Persons p ON e.PersonId = p.Id INNER JOIN
                  Countries ON p.CountryId = Countries.ID INNER JOIN
                  MedicalSpecialties ON d.SpecializationId = MedicalSpecialties.id)
create view View_Patient_Details as(
SELECT Patients.Id, Persons.Name, Persons.BirthDate, Persons.Gender, Persons.Phone, Persons.Email, Countries.Name AS Country, Persons.Address, Persons.ImagePath
FROM     Patients INNER JOIN
                  Persons ON Patients.PersonId = Persons.Id INNER JOIN
                  Countries ON Persons.CountryId = Countries.ID)

				  create view View_Payment_Details as (
SELECT Payments.Id, Payments.Date, Payments.Amount, PaymentMethods.Name, Payments.AdditionalNotes
FROM     Payments INNER JOIN
                  PaymentMethods ON Payments.PaymentMethodsId = PaymentMethods.Id)

				  create view View_Appointment_Details as (
	SELECT Appointments.Id, Appointments.DateTime, Appointments.PatientId, Appointments.DoctorId, Appointments.PaymentId, Appointments.MedicalRecordId, AppointmentStatus.Name AS Status
FROM     Appointments INNER JOIN
                  AppointmentStatus ON Appointments.AppointmentStatusId = AppointmentStatus.Id	)
			
			  create view View_Users_Details as (
SELECT Users.Id, Users.Username, Persons.Name, Persons.BirthDate, Persons.Gender, Persons.Phone, Persons.Email, Persons.Address, Countries.Name AS Country, Users.Password, Users.Permission
FROM     Users INNER JOIN
                  Persons ON Users.PersonId = Persons.Id INNER JOIN
                  Countries ON Persons.CountryId = Countries.ID)


				-- إنشاء جدول باسم Countries
CREATE TABLE Countries (
   ID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL
);

-- إدخال أسماء الدول العربية
INSERT INTO Countries (Name) VALUES
('Algeria'),
('Bahrain'),
('Comoros'),
('Djibouti'),
('Egypt'),
('Iraq'),
('Jordan'),
('Kuwait'),
('Lebanon'),
('Libya'),
('Mauritania'),
('Morocco'),
('Oman'),
('Palestine'),
('Qatar'),
('Saudi Arabia'),
('Somalia'),
('Sudan'),
('Syria'),
('Tunisia'),
('United Arab Emirates'),
('Yemen');

-- إدخال أسماء بعض الدول الأجنبية
INSERT INTO Countries (Name) VALUES
('United States'),
('Canada'),
('United Kingdom'),
('Germany'),
('France'),
('Italy'),
('Spain'),
('Australia'),
('Japan'),
('China'),
('South Korea'),
('India'),
('Brazil'),
('Russia'),
('Mexico'),
('Turkey'),
('South Africa');

select * from Countries
alter table Persons add foreign key (CountryId) references Countries (Id)

SELECT Name FROM Countries

---to identity 
alter database scoped configuration set identity_cache =off 
Go
select * from View_Employees_Details