CREATE TABLE Doctors (
    DoctorId SERIAL PRIMARY KEY,
    UserId INT REFERENCES Users(UserId),
    Hospital INT REFERENCES Hospitals(HospitalId),
    Education VARCHAR(50),
    Status INT REFERENCES Statuses(StatusId),
    CreatedDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    CreatedBy INT,
    ModifiedDate TIMESTAMP,
    ModifiedBy INT
);
