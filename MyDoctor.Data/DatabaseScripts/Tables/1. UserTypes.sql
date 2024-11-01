CREATE TABLE UserTypes (
    UserTypeId SERIAL PRIMARY KEY,
    UserType VARCHAR(20)
);

INSERT INTO UserTypes (UserType) VALUES ('Admin');
INSERT INTO UserTypes (UserType) VALUES ('Doctor');
INSERT INTO UserTypes (UserType) VALUES ('Patient');
