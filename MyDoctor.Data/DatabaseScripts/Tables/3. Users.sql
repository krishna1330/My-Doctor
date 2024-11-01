CREATE TABLE Users (
    UserId SERIAL PRIMARY KEY,
    UserType INT REFERENCES UserTypes(UserTypeId),
    FirstName VARCHAR(40),
    LastName VARCHAR(15),
    EmailId VARCHAR,
    Phone VARCHAR(15),
    Password VARCHAR,
    Status INT REFERENCES Statuses(StatusId),
    LastLogin TIMESTAMP,
    CreatedDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    CreatedBy INT,
    ModifiedDate TIMESTAMP,
    ModifiedBy INT
);

INSERT INTO Users (
    UserType,
    FirstName,
    LastName,
    EmailId,
    Phone,
    Password,
    Status,
    LastLogin,
    CreatedDate,
    CreatedBy,
    ModifiedDate,
    ModifiedBy
)
VALUES (
    1,
    'Krishna Murali',
    'Andiboyina',
    'kmandiboyina@gmail.com',
    '+917799373373',
    'Admin@123',
    1,
    '2023-10-11 08:30:00',
    '2023-10-11 08:30:00',
    NULL,
    NULL,
    NULL
);