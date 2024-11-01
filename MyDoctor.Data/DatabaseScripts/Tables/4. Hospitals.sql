CREATE TABLE Hospitals (
    HospitalId SERIAL PRIMARY KEY,
    HospitalName VARCHAR(255),
    Address VARCHAR(255),
    Status INT REFERENCES Statuses(StatusId),
    CreatedDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    CreatedBy INT,
    ModifiedDate TIMESTAMP,
    ModifiedBy INT
);

--INSERT INTO Hospitals (HospitalName, Address, Status, CreatedBy, ModifiedDate, ModifiedBy)
--VALUES 
--    ('City Hospital', '123 Main St, Springfield', 1, 1, NULL, NULL),
--    ('Community Health Center', '456 Oak Rd, Centerville', 1, 1, NULL, NULL),
--    ('General Medical Hospital', '789 Pine Ln, Riverside', 1, 1, NULL, NULL),
--    ('Downtown Clinic', '101 Maple Ave, Lakeview', 1, 1, NULL, NULL),
--    ('Eastside Medical', '202 Birch St, Hilltop', 1, 1, NULL, NULL),
--    ('Westside Health Center', '303 Cedar Dr, Meadowbrook', 1, 1, NULL, NULL),
--    ('Northside Hospital', '404 Willow Blvd, Brookfield', 1, 1, NULL, NULL),
--    ('Southside Clinic', '505 Elm St, Bayside', 1, 1, NULL, NULL),
--    ('Lakeshore Medical', '606 Ash St, Edgewater', 1, 1, NULL, NULL),
--    ('Valley Health Center', '707 Cherry Ave, Valleyview', 1, 1, NULL, NULL);