CREATE TABLE Hospitals (
    HospitalId SERIAL PRIMARY KEY,
    HospitalName VARCHAR(255),
    Address VARCHAR(255),
    StatusId INT REFERENCES Statuses(StatusId),
    CreatedDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    CreatedBy INT,
    ModifiedDate TIMESTAMP,
    ModifiedBy INT
);