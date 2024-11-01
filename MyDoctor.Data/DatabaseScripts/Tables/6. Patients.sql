CREATE TABLE Patients (
    PatientId SERIAL PRIMARY KEY,
    UserId INT REFERENCES Users(UserId),
    PatientName VARCHAR NOT NULL,
    PatientDOB TIMESTAMP NOT NULL,
    Status INT REFERENCES Statuses(StatusId),
    CreatedDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    ModifiedDate TIMESTAMP,
    ModifiedBy INT
);
