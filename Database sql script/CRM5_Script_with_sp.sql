
CREATE TABLE organization(
id INT PRIMARY KEY IDENTITY(1,1),
logo VARBINARY(MAX) NULL,
name VARCHAR(255) NOT NULL,
email VARCHAR(255) NOT NULL,
phone VARCHAR(255) NOT NULL,
address VARCHAR(255) NOT NULL,
)


CREATE TABLE team(
id	INT PRIMARY KEY IDENTITY(1,1),
picture	VARBINARY(MAX) NULL,
name VARCHAR(255) NOT NULL,
gender	VARCHAR(255) NOT NULL,
email	VARCHAR(255) NOT NULL,
password VARCHAR(255) NOT NULL,
type VARCHAR(255) NOT NULL,
department VARCHAR(255) NOT NULL,
role VARCHAR(255) NOT NULL,
status bit NOT NULL, -- bit
)

CREATE TABLE customers(
id INT PRIMARY KEY IDENTITY(1,1),
name VARCHAR(255) NOT NULL,
email VARCHAR(255) NOT NULL,
mobile VARCHAR(255) NOT NULL,
city VARCHAR(255) NOT NULL,
zip VARCHAR(255) NOT NULL,
country VARCHAR(255) NOT NULL,
added_date DATETIME NOT NULL,
photo VARBINARY(MAX) NULL,
website VARCHAR(255) NULL,
status BIT,
promoted_leadsId INT NOT NULL,  -- Q FOREIGN KEY REFERENCES leads(id),
addedBy_teamId INT FOREIGN KEY REFERENCES team(id)
)


CREATE TABLE leads(
id INT PRIMARY KEY IDENTITY(1,1),
name VARCHAR(255) NOT NULL,
email VARCHAR(255) NOT NULL,
source VARCHAR(255) NOT NULL,
status VARCHAR(255) NOT NULL,
note VARCHAR(MAX) NULL,
createDate DATETIME,
addedBy_teamId INT FOREIGN KEY REFERENCES team(id),
customerId INT NULL,
)

ALTER TABLE leads ALTER COLUMN customerId INT FOREIGN KEY REFERENCES customers(id) Null,

CREATE TABLE events(
id INT PRIMARY KEY IDENTITY(1,1),
topic VARCHAR(255) NOT NULL,
type VARCHAR(255) NOT NULL,
status VARCHAR(255) NOT NULL,
note VARCHAR(MAX) NOT NULL,
startDate date NOT NULL,
start_time time NOT NULL,
end_date date NOT NULL,
end_time time NOT NULL,
addedBy_teamId INT FOREIGN KEY REFERENCES team(id),
)



CREATE TABLE tasks(
id INT PRIMARY KEY IDENTITY(1,1),
name VARCHAR(255) NOT NULL, -- new column
status VARCHAR(255) NOT NULL,
refer_type VARCHAR(255) NOT NULL,
refer_name VARCHAR(255) NOT NULL,
priority VARCHAR(255) NOT NULL,
note VARCHAR(MAX) NULL,
addedBy_teamId INT FOREIGN KEY REFERENCES team(id)
)


CREATE TABLE guest(
id INT PRIMARY KEY IDENTITY(1,1),
eventId INT Foreign Key REFERENCES events(id) NOT NULL,
customerId INT FOREIGN KEY REFERENCES customers(id) NOT NULL
)



GO
-- PROCEDURE ON ORGANIZATION ( select, update, or delete )

GO
-- Select organization

 CREATE PROC spGetOrganization_byIdOrName
 @idOrName varchar(255)

 AS
 BEGIN

  SELECT id, name, email,phone, address 
  FROM organization
  WHERE (id = @idOrName or name = @idOrName)
  ORDER BY name

 END


 GO
 -- Update organization

 CREATE PROC spUpdateOrganization_byId
 @orgId int,
 @newName varchar(255),
 @newEmail varchar(255),
 @newPhone varchar(255),
 @newAddress varchar(255)

 AS
 BEGIN

  UPDATE organization
  SET name = @newName, email = @newEmail, phone = @newPhone, address = @newAddress
  WHERE organization.id = @orgId

 END

-- if it's only one organization , there shouldn't be any proc for delete

-- GO
-- -- Delete organization
 
-- CREATE PROC spDeleteOrganization_byIdOrName
-- @idOrName varchar(255)

-- AS
-- BEGIN

--  DELETE FROM organization 
--  WHERE (id = @idOrName or name = @idOrName)

-- END



GO
 -- PROCEDURE ON TEAM ( select, update, or delete )

GO
-- Select team

 CREATE PROC spGetTeam_byIdOrName
 @idOrName varchar(255)

 AS
 BEGIN

  SELECT id, name, gender, email, password, type, department, role, status 
  FROM team
  WHERE (id = @idOrName or name = @idOrName)
  ORDER BY name

 END


 GO
 -- Update team

 CREATE PROC spUpdateTeam_byId
 @teamId int,
 @newPicture varbinary(max),
 @newName varchar(255),
 @newGender varchar(255),
 @newEmail varchar(255),
 @newPassword varchar(255),
 @newType varchar(255),
 @newDepartment varchar(255),
 @newRole varchar(255),
 @newStatus bit

 AS
 BEGIN

  UPDATE team
  SET picture = @newPicture, name = @newName, gender = @newGender, email = @newEmail, password = @newPassword, type = @newType, department = @newDepartment, role = @newRole, status = @newStatus
  WHERE team.id = @teamId

 END


 GO
 -- Delete team
 
 CREATE PROC spDeleteTeam_byIdOrName
 @idOrName varchar(255)

 AS
 BEGIN

  -- we shouldn't delete a team member, just make their status false 0
  UPDATE team
  SET status = 0  -- bit ( false )
  WHERE (id = @idOrName or name = @idOrName)

 END



 
GO
-- PROCEDURE ON CUSTOMERS ( select, update, or delete )

GO
-- Select customers

 CREATE PROC spGetCustomers_byIdOrName
 @idOrName varchar(255)

 AS
 BEGIN
 select * from customers
  SELECT c.id, c.name, c.email, c.mobile, c.city, c.zip, c.country, c.added_date, c.website, c.status, t.name AS [Added By] -- Q l.id AS [Leads Id]
  FROM customers c
  join team t
  ON c.addedBy_teamId = t.id
  WHERE (c.id = @idOrName or c.name = @idOrName)
  -- ORDER BY c.name

 END


 GO
 -- Update customers

 CREATE PROC spUpdateCustomers_byId
 @customerId int,
 @newName varchar(255),
 @newEmail varchar(255),
 @newMobile varchar(255),
 @newCity varchar(255),
 @newZip varchar(255),
 @newCountry varchar(255),
 @newAdded_date datetime,
 @newPhoto varbinary(max),
 @newWebsite varchar(255),
 @newAddedBy_teamId int,
 @newStatus bit
 

 AS
 BEGIN

  UPDATE customers
  SET name = @newName, email = @newEmail, mobile = @newMobile, city = @newCity, 
      zip = @newZip, country = @newCountry, added_date = @newAdded_date, photo = @newPhoto
	  website = @newWebsite, addedBy_teamId = @newAddedBy_teamId, status = @newStatus

  WHERE customers.id = @customerId

 END


 GO
 -- Delete customers
 
 CREATE PROC spDeleteCustomers_byIdOrName
 @idOrName varchar(255)

 AS
 BEGIN

  UPDATE customers
  SET status = 0
  WHERE (id = @idOrName or name = @idOrName)

 END




GO
-- PROCEDURE ON LEADS ( select, update, or delete )
GO

-- select leads

CREATE PROC spGetLeads_byIdOrName
 @idOrName varchar(255)

 AS
 BEGIN
  SELECT l.id, l.name, l.email, l.source, l.status, l.note, l.createDate, t.name, c.id
  FROM leads l
  join team t
  ON l.addedBy_teamId = t.id
  join customers c
  on l.customerId = c.id
  WHERE (l.id = @idOrName or l.name = @idOrName)
  ORDER BY l.id

 END


 GO
 -- Update leads

 CREATE PROC spUpdateLeads_byIdOrName
 @leadsIdOrName varchar(255),
 @newName varchar(255),
 @newEmail varchar(255),
 @newSources varchar(255),
 @newStatus varchar(255),
 @newNote varchar(max),
 @newCreateDate datetime, 
 @newAddedBy_teamId int,
 @newCustomerId int
 

 AS
 BEGIN

  UPDATE leads
  SET name = @newName, email = @newEmail, source = @newSources, status = @newStatus, 
      note = @newNote, createDate = @newCreateDate, addedBy_teamId = @newAddedBy_teamId, 
	  customerId = @newCustomerId

  WHERE (leads.id = @leadsIdOrName or leads.name = @leadsIdOrName)

 END


 GO
 -- Delete leads
 
 CREATE PROC spDeleteLeads_byIdOrName
 @leadsIdOrName varchar(255)

 AS
 BEGIN

  UPDATE leads
  SET status = 'Lost'
  WHERE (leads.id = @leadsIdOrName or leads.name = @leadsIdOrName)

 END




GO
-- PROCEDURE ON EVENTS ( select, update, or delete )

GO
-- Select events

 CREATE PROC spGetEvents_byIdOrName
 @idOrTopic varchar(255)

 AS
 BEGIN
  SELECT e.id, e.topic, e.type, e.status, e.note, e.startDate, e.start_time, e.end_date, e.end_time, t.name
  FROM events e
  join team t
  ON e.addedBy_teamId = t.id
  WHERE (e.id = @idOrTopic or e.topic = @idOrTopic)
  ORDER BY e.id 

 END


 GO
 -- Update events

 CREATE PROC spUpdateEvents_byId
 @eventId int,
 @newTopic varchar(255),
 @newType varchar(255),
 @newStatus varchar(255),
 @newNote varchar(MAX),
 @newStart_date date,
 @newStart_time time,
 @newEnd_date date,
 @newEnd_time time,
 @newAddedBy_teamId int,
 

 AS
 BEGIN

  UPDATE events
  SET topic = @newTopic, type = @newType, status = @newStatus, note = @newNote, 
      startDate = @newStart_date, start_time = @newStart_time, end_date = @newEnd_date, 
	  end_time = @newEnd_time, addedBy_teamId = @newAddedBy_teamId

  WHERE events.id = @eventId

 END


 GO
 -- Delete event
 
 CREATE PROC spDeleteEvent_byIdOrName
 @idOrTopic varchar(255)

 AS
 BEGIN

  UPDATE events
  SET status = 'not_heled'
  WHERE (id = @idOrTopic or topic = @idOrTopic)

 END


 
GO
-- PROCEDURE ON TASKS ( select, update, or delete )

GO
-- Select tasks

 CREATE PROC spGetTasks_byIdOrName
 @idOrName varchar(255)

 AS
 BEGIN
  SELECT t.id, t.name, t.status, t.refer_type, t.refer_name, t.priority, t.note, tm.name as [Added By]
  FROM tasks t
  join team tm
  ON t.addedBy_teamId = tm.id
  WHERE (t.id = @idOrName or t.name = @idOrName)

 END


 GO
 -- Update events

 CREATE PROC spUpdateTasks_byId
 @taskIdOrName varchar(255),
 @newName varchar(255),
 @newStatus varchar(255),
 @newRefer_type varchar(255),
 @newRefer_name varchar(255),
 @newPriority varchar(255),
 @newNote varchar(MAX),
 @newAddedBy_teamId int
 
 AS
 BEGIN

  UPDATE tasks
  SET name = @newName, status = @newStatus, refer_type = @newRefer_type, refer_name = @newRefer_name, priority = @newPriority, note = @newNote, addedBy_teamId = @newAddedBy_teamId

  WHERE (tasks.id = @taskIdOrName or tasks.name = @taskIdOrName)

 END


 GO
 -- Delete event
 
 CREATE PROC spDeleteTasks_byId
 @taskIdOrName varchar(255)

 AS
 BEGIN

  UPDATE tasks
  SET status = 'DONE'
  WHERE id = @taskIdOrName

 END




GO
-- PROCEDURE ON Guest ( select, update, or delete )

GO
-- Select guest

 CREATE PROC spGetGuest_byId
 @guestOrEventorCustomer_id int

 AS
 BEGIN
  SELECT g.id, e.topic [Event Topic], c.name as [Customers Name]
  FROM guest g
  join customers c
  ON g.customerId = c.id
  join events e
  ON g.eventId = e.id
  WHERE (g.id = @guestOrEventorCustomer_id or e.id = @guestOrEventorCustomer_id or c.id = @guestOrEventorCustomer_id)
  
 END


 GO
 -- Update guest

 CREATE PROC spUpdateGuest_byId
 @guestId int,
 @newEventId int,
 @newCustomerId int
 
 AS
 BEGIN

  UPDATE guest
  SET eventId = @newEventId, customerId = @newCustomerId

  WHERE guest.id = @guestId

 END


 GO
 -- Delete guest
 
 CREATE PROC spDeleteGuest_byId
 @id int

 AS
 BEGIN

  DELETE FROM guest
  WHERE id = @id

 END


 -- Creating a Login
 Go

CREATE LOGIN CRM WITH PASSWORD = 'crm123'

CREATE USER TeamAdmin FOR LOGIN CRM  -- ADMIN

CREATE USER Team FOR LOGIN CRM -- EMPLOYEES

