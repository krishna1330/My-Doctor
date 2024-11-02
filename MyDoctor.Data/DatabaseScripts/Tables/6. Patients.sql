CREATE TABLE Patients (
    PatientId SERIAL PRIMARY KEY,
    UserId INT REFERENCES Users(UserId),
    PatientName VARCHAR NOT NULL,
    PatientDOB TIMESTAMP NOT NULL,
    StatusId INT REFERENCES Statuses(StatusId),
    CreatedDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
	CreatedBy INT,
    ModifiedDate TIMESTAMP,
    ModifiedBy INT
);
