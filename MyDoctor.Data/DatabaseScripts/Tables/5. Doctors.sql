CREATE TABLE Doctors (
    DoctorId SERIAL PRIMARY KEY,
    UserId INT REFERENCES Users(UserId),
    HospitalId INT REFERENCES Hospitals(HospitalId),
    Education VARCHAR(50),
	AvailableFrom TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    AvailableTo TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    StatusId INT REFERENCES Statuses(StatusId),
    CreatedDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    CreatedBy INT,
    ModifiedDate TIMESTAMP,
    ModifiedBy INT
);
