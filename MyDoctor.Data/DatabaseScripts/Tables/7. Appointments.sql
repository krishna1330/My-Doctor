CREATE TABLE Appointments (
    AppointmentId SERIAL PRIMARY KEY,
    PatientId INT REFERENCES Patients(PatientId),
    DoctorId INT REFERENCES Doctors(DoctorId),
    Token INT,
    Diagnosis VARCHAR,
    Medicine VARCHAR,
    StatusId INT REFERENCES Statuses(StatusId),
    CreatedDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    CreatedBy INT,
    ModifiedDate TIMESTAMP,
    ModifiedBy INT
);
