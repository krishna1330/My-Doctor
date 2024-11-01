CREATE TABLE Statuses (
    StatusId SERIAL PRIMARY KEY,
    Status VARCHAR(20)
);

INSERT INTO Statuses (Status) VALUES ('Active');
INSERT INTO Statuses (Status) VALUES ('Inactive');
INSERT INTO Statuses (Status) VALUES ('Deleted');
INSERT INTO Statuses (Status) VALUES ('Pending');
INSERT INTO Statuses (Status) VALUES ('Consulted');