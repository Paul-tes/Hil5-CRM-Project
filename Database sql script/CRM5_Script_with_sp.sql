CREATE DATABASE CRM_PROJECT

USE CRM_PROJECT


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
promoted_leadsId INT FOREIGN KEY REFERENCES leads(id) Null,
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

--ALTER TABLE leads ALTER COLUMN customerId INT FOREIGN KEY REFERENCES customers(id) Null,

ALTER TABLE leads ADD FOREIGN KEY(customerId) REFERENCES customers(id)

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

ALTER TABLE events DROP COLUMN start_time
ALTER TABLE events DROP COLUMN end_time


select * from events

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


/*--------------------------------------------------------------------------

					 STORE PROCEDURE FOR LOGIN

----------------------------------------------------------------------------*/
CREATE PROC [LOGIN]
      @email varchar(255),
      @pswd varchar(255),
      @status BIT output
      WITH ENCRYPTION
      AS
      BEGIN

            if exists(select * from team where email = @email and password = @pswd)
            BEGIN
			set @status = 1
			END
			ELSE
			BEGIN
			SET @status = 0
			END

			RETURN @status
      END

GO
/*--------------------------------------------------------------------------

   STORE PROCEDURE ON ORGANIZATION ( insert, select, update, delete, Search )

----------------------------------------------------------------------------*/
CREATE PROC [Add organization]   -- insert organization
    @logo varbinary(max),
    @name varchar(255),
    @email varchar(255),
    @phone varchar(255),
    @address varchar(255)
	WITH ENCRYPTION
	AS
    BEGIN

       INSERT INTO organization(logo,name,email,phone,address) 
	   VALUES(@logo, @name, @email, @phone, @address)

    END

GO

CREATE PROC [Get Organization]    -- Select organization
      WITH ENCRYPTION
      AS
	  BEGIN

	       SELECT id, logo, name, email,phone, address 
		   FROM organization

      END

 GO

CREATE PROC [Update Organization_byName]    -- Update organization
      @orgName varchar(255),
	  @newLogo varbinary(max),
      @newName varchar(255),
      @newEmail varchar(255),
      @newPhone varchar(255),
      @newAddress varchar(255)
	  WITH ENCRYPTION
	  AS
      BEGIN

            UPDATE organization
            SET logo = @newLogo, name = @newName, email = @newEmail, phone = @newPhone, address = @newAddress
            WHERE organization.name = @orgName

      END

GO
 
CREATE PROC [Delete Organization_byIdOrName]   -- Delete organization
       WITH ENCRYPTION
       AS
       BEGIN

             DELETE FROM organization 

       END

GO
-- if it's only one organization, there shouldn't be any proc for search
--CREATE PROC [Search Organization_byIdOrName]  -- Search organization
--      @idOrName varchar(255)
 --     WITH ENCRYPTION
--      AS
--      BEGIN

--            SELECT id, logo, name, email, phone, address
--	          FROM organization
--	          WHERE (id = TRIM(*@idOrName) or name = TRIM(@idOrName))

--      END


GO
/*--------------------------------------------------------------------------

   STORED PROCEDURE ON TEAM ( insert, select, update, delete, Search )

----------------------------------------------------------------------------*/
CREATE PROC [Add Team]   -- insert team
    @picture varbinary(max),
    @name varchar(255),
	@gender varchar(255),
	@email varchar(255),
	@password varchar(255),
	@type varchar(255),
	@department varchar(255),
	@role varchar(255),
	@status bit
	WITH ENCRYPTION
	AS
    BEGIN

       INSERT INTO team(picture,name,gender,email,password,type,department,role,status) 
	   VALUES(@picture, @name, @gender, @email, @password, @type, @department, @role, @status)

    END

GO

 CREATE PROC [GetAll Team]   -- Select all team
       WITH ENCRYPTION
       AS
       BEGIN

             SELECT id, picture, name, gender, email, password, type, department, role, status 
             FROM team

       END

 GO

 CREATE PROC [Update Team_byId]     -- Update team
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
		WITH ENCRYPTION
        AS
        BEGIN

			  UPDATE team
			  SET picture = @newPicture, name = @newName, gender = @newGender, email = @newEmail, password = @newPassword, type = @newType, department = @newDepartment, role = @newRole, status = @newStatus
			  WHERE team.id = @teamId

        END

 GO
 
 CREATE PROC [Delete Team_byIdOrName]    -- Delete team
       @idOrName varchar(255)
	   WITH ENCRYPTION
       AS
       BEGIN

			 UPDATE team
			 SET status = 0  -- bit ( false )
			 WHERE (id = TRIM(@idOrName) or name = TRIM(@idOrName))

       END

GO

CREATE PROC [Search Team_byIdOrName]   -- Search team
       @idOrName varchar(255)
	   WITH ENCRYPTION
       AS
       BEGIN

             SELECT id, picture, name, gender, email, password, type, department, role, status 
             FROM team
             WHERE (id = TRIM(@idOrName) or name = TRIM(@idOrName))

       END

GO
/*--------------------------------------------------------------------------

   STORED PROCEDURE ON CUSTOMERS ( insert, select, update, delete, Search )

----------------------------------------------------------------------------*/
CREATE PROC [Add Customers]   -- Add Customers
    @name varchar(255),
	@email varchar(255),
	@mobile varchar(255),
	@city varchar(255),
	@zip varchar(255),
	@country varchar(255),
	@added_date datetime,
	@photo varbinary(max),
	@website varchar(255),
	@status bit,
	@promoted_leadsId int,
	@addedBy_teamId int
	WITH ENCRYPTION
	AS
    BEGIN

       INSERT INTO customers(name,email,mobile,city,zip,country,added_date,photo,website,status,promoted_leadsId,addedBy_teamId) 
	   VALUES(@name, @email, @mobile, @city, @zip, @country, @added_date, @photo, @website, @status, @promoted_leadsId, @addedBy_teamId)

    END

GO

ALTER PROC [GetAll Customers]   -- Select all customers
      WITH ENCRYPTION
      AS
      BEGIN

			 SELECT c.id, c.name, c.email, c.mobile, c.city, c.zip, c.country, c.added_date, c.photo, c.website, c.status, c.promoted_leadsId AS [Leads Id], c.addedBy_teamId AS [Added By] 
			 FROM customers c

	  END

 GO

 CREATE PROC [Update Customers_byId]     -- Update customers
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
		@newStatus bit,
		@newPromoted_leadsId int,
		@newAddedBy_teamId int
		WITH ENCRYPTION
	    AS
	    BEGIN

				UPDATE customers
			    SET name = @newName, email = @newEmail, mobile = @newMobile, city = @newCity, 
				zip = @newZip, country = @newCountry, added_date = @newAdded_date, photo = @newPhoto,
				website = @newWebsite, status = @newStatus, promoted_leadsId = @newPromoted_leadsId, addedBy_teamId = @newAddedBy_teamId
			    WHERE customers.id = @customerId

		END


 GO
 
 CREATE PROC [Delete Customers_byIdOrName]    -- Delete customers
       @idOrName varchar(255)
	   WITH ENCRYPTION
       AS
       BEGIN

             UPDATE customers
             SET status = 0
             WHERE (id = TRIM(@idOrName) or name = TRIM(@idOrName))

       END

 GO

CREATE PROC [Search Customers_byIdOrName]   -- Search customers
       @idOrName varchar(255)
	   WITH ENCRYPTION
       AS
       BEGIN

			 SELECT c.id, c.name, c.email, c.mobile, c.city, c.zip, c.country, c.added_date, c.photo, c.website, c.status, t.name AS [Added By], l.id AS [Leads Id]
			 FROM customers c
		     join team t
		     ON c.addedBy_teamId = t.id
			 inner join leads l
			 ON c.promoted_leadsId = l.id
             WHERE (c.id = TRIM(@idOrName) or c.name = TRIM(@idOrName))

	   END

GO


GO
/*--------------------------------------------------------------------------

   STORED PROCEDURE ON LEADS ( insert, select, update, delete, Search )

----------------------------------------------------------------------------*/
CREATE PROC [Add Leads]   -- Add Leads
    @name varchar(255),
	@email varchar(255),
	@source varchar(255),
	@status varchar(255),
	@note varchar(max),
	@createdDate datetime,
	@addedBy_teamId int,
	@customerId int
	WITH ENCRYPTION
	AS
    BEGIN

       INSERT INTO leads(name,email,source,status,note,createDate,addedBy_teamId,customerId) 
	   VALUES(@name,@email,@source,@status,@note,@createdDate,@addedBy_teamId,@customerId)

    END

GO

ALTER PROC [GetAll Leads]    -- select ALL leads
      WITH ENCRYPTION
      AS
      BEGIN

           SELECT l.id, l.name, l.email, l.source, l.status, l.note, l.createDate, l.addedBy_teamId, l.customerId
           FROM leads l

      END

 GO

 CREATE PROC [Update Leads_byIdOrName]     -- Update leads
		@leadsIdOrName varchar(255),
		@newName varchar(255),
		@newEmail varchar(255),
		@newSources varchar(255),
		@newStatus varchar(255),
		@newNote varchar(max),
		@newCreateDate datetime, 
		@newAddedBy_teamId int,
		@newCustomerId int
		WITH ENCRYPTION
		AS
		BEGIN

			 UPDATE leads
			 SET name = @newName, email = @newEmail, source = @newSources, status = @newStatus, 
		     note = @newNote, createDate = @newCreateDate, addedBy_teamId = @newAddedBy_teamId, 
		     customerId = @newCustomerId
			 WHERE (leads.id = Trim(@leadsIdOrName) or leads.name = Trim(@leadsIdOrName))

		END

 GO
 
 CREATE PROC [Delete Leads_byIdOrName]    -- Delete leads
		@leadsIdOrName varchar(255)
		WITH ENCRYPTION
		AS
		BEGIN

			 UPDATE leads
			 SET status = 'Lost'
			 WHERE (leads.id = Trim(@leadsIdOrName) or leads.name = Trim(@leadsIdOrName))

		END

 GO

 CREATE PROC [Search Leads_byIdOrName]   -- Search leads
       @idOrName varchar(255)
	   WITH ENCRYPTION
       AS
       BEGIN

			SELECT l.id, l.name, l.email, l.source, l.status, l.note, l.createDate, t.name, c.id
            FROM leads l
            join team t
            ON l.addedBy_teamId = t.id
            join customers c
            on l.customerId = c.id
            WHERE (l.id = Trim(@idOrName) or l.name = Trim(@idOrName))
            ORDER BY l.id

	   END

GO
/*--------------------------------------------------------------------------

   STORED PROCEDURE ON EVENTS ( insert, select, update, delete, Search )

----------------------------------------------------------------------------*/
ALTER PROC [Add Events]   -- Add Events
    @topic varchar(255),
	@type varchar(255),
	@status varchar(255),
	@note varchar(max),
	@startDate date,
	-- @startTime time,
	@endDate date,
	-- @endTime time,
	@addedBy_teamId int
	WITH ENCRYPTION
	AS
    BEGIN

       INSERT INTO events(topic,type,status,note,startDate,end_date,addedBy_teamId) 
	   VALUES(@topic,@type,@status,@note,@startDate,@endDate,@addedBy_teamId)

    END

GO

 ALTER PROC [GetAll Events]   -- Select all events
       WITH ENCRYPTION
	   AS
       BEGIN

			 SELECT e.id, e.topic, e.type, e.status, e.note, e.startDate, e.end_date, t.name
			 FROM events e
			 join team t
			 ON e.addedBy_teamId = t.id

	   END

 GO

 ALTER PROC [Update Events_byId]     -- Update events
	    @eventId int,
        @newTopic varchar(255),
        @newType varchar(255),
	    @newStatus varchar(255),
	    @newNote varchar(MAX),
	    @newStart_date date,
	    -- @newStart_time time,
	    @newEnd_date date,
	   --  @newEnd_time time,
		@newAddedBy_teamId int
		WITH ENCRYPTION
        AS
        BEGIN

			 UPDATE events
			 SET topic = @newTopic, type = @newType, status = @newStatus, note = @newNote, 
		     startDate = @newStart_date, end_date = @newEnd_date, addedBy_teamId = @newAddedBy_teamId
             WHERE events.id = @eventId

        END

 GO
 
 CREATE PROC [Delete Event_byIdOrTopic]    -- Delete event
       @idOrTopic varchar(255)
	   WITH ENCRYPTION
       AS
       BEGIN

			 UPDATE events
			 SET status = 'not_heled'
             WHERE (id = Trim(@idOrTopic) or topic = Trim(@idOrTopic))

       END

GO

 ALTER PROC [Search Event_byIdOrTopic]   -- Search event
       @idOrTopic varchar(255)
	   WITH ENCRYPTION
       AS
       BEGIN

			 SELECT e.id, e.topic, e.type, e.status, e.note, e.startDate, e.end_date, t.name AS [Team Name]
			 FROM events e
			 join team t
			 ON e.addedBy_teamId = t.id
			 WHERE (e.id = Trim(@idOrTopic) or e.topic = Trim(@idOrTopic))

	   END
 
GO
/*--------------------------------------------------------------------------

   STORED PROCEDURE ON TASKS ( insert, select, update, delete, Search )

----------------------------------------------------------------------------*/
CREATE PROC [Add Tasks]   -- Add tasks
    @name varchar(255),
	@status varchar(255),
	@refer_type varchar(255),
	@refer_name varchar(255),
	@priority varchar(255),
	@note varchar(max),
	@addedBy_teamId int
	WITH ENCRYPTION
	AS
    BEGIN

       INSERT INTO tasks(name,status,refer_type,refer_name,priority,note,addedBy_teamId) 
	   VALUES(@name, @status, @refer_type, @refer_name, @priority, @note, @addedBy_teamId)

    END

GO

 CREATE PROC [GetAll Tasks]   -- Select all tasks
       WITH ENCRYPTION
       AS
       BEGIN
             SELECT t.id, t.name, t.status, t.refer_type, t.refer_name, t.priority, t.note, tm.name as [Added By]
             FROM tasks t
             join team tm
             ON t.addedBy_teamId = tm.id

       END

 GO

 CREATE PROC [Update Tasks_byIdOrName]    -- Update events
	   @taskIdOrName varchar(255),
	   @newName varchar(255),
	   @newStatus varchar(255),
	   @newRefer_type varchar(255),
	   @newRefer_name varchar(255),
	   @newPriority varchar(255),
	   @newNote varchar(MAX),
	   @newAddedBy_teamId int
	   WITH ENCRYPTION
	   AS
       BEGIN

			UPDATE tasks
			SET name = @newName, status = @newStatus, refer_type = @newRefer_type, refer_name = @newRefer_name, priority = @newPriority, note = @newNote, addedBy_teamId = @newAddedBy_teamId
			WHERE (tasks.id = Trim(@taskIdOrName) or tasks.name = Trim(@taskIdOrName))

       END

 GO
 
 CREATE PROC [Delete Tasks_byId]    -- Delete event
       @taskId int
	   WITH ENCRYPTION
       AS
       BEGIN

             UPDATE tasks
             SET status = 'DONE'
             WHERE id = @taskId

       END

 GO

 CREATE PROC [Search Tasks_byIdOrName]   -- Search Tasks
       @idOrName varchar(255)
	   WITH ENCRYPTION
       AS
       BEGIN

			 SELECT t.id, t.name, t.status, t.refer_type, t.refer_name, t.priority, t.note, tm.name as [Added By]
			 FROM tasks t
			 join team tm
			 ON t.addedBy_teamId = tm.id
			 WHERE (t.id = @idOrName or t.name = @idOrName)

	   END

GO
/*--------------------------------------------------------------------------

   STORED PROCEDURE ON Guest ( insert, select, update, delete, Search )

----------------------------------------------------------------------------*/
CREATE PROC [Add Guest]   -- Add guest
    @eventId int,
	@customerId int
	WITH ENCRYPTION
	AS
    BEGIN

         INSERT INTO guest(eventId,customerId) 
	     VALUES(@eventId, @customerId)

    END

GO

 CREATE PROC [GetAll Guest]   -- Select all guest
        WITH ENCRYPTION
        AS
        BEGIN
              SELECT g.id, e.topic [Event Topic], c.name as [Customers Name]
              FROM guest g
              join customers c
              ON g.customerId = c.id
              join events e
              ON g.eventId = e.id
  
        END

 GO


 CREATE PROC [Update Guest_byId]   -- Update guest
       @guestId int, 
       @newEventId int,
       @newCustomerId int
	   WITH ENCRYPTION
       AS
       BEGIN

             UPDATE guest
             SET eventId = @newEventId, customerId = @newCustomerId
             WHERE guest.id = @guestId

       END

 GO
 
 CREATE PROC [Delete Guest_byId]    -- Delete guest
       @guestId int
	   WITH ENCRYPTION
       AS
       BEGIN

            DELETE FROM guest
            WHERE id = @guestId

       END

 GO

 CREATE PROC [Search Guest_byId]   -- Search guest
        @guestOrEventorCustomer_id int
		WITH ENCRYPTION
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


Go
 /*--------------------------------------------------------------------------

                            creating Functions

----------------------------------------------------------------------------*/
/*-------------------------------------------------

   UDF for the dashboard Counts(4)

---------------------------------------------------*/
GO
CREATE FUNCTION [getCountOfLeads]
()
returns int
WITH ENCRYPTION,
SchemaBinding
AS
BEGIN
DECLARE @cntLeads int 
	SELECT @cntLeads = count(*) FROM dbo.leads
	Return @cntLeads
END

GO
CREATE FUNCTION [getCountOfCustomers]
()
returns int
WITH ENCRYPTION,
SchemaBinding
AS
BEGIN
DECLARE @cntCustomers int 
	SELECT @cntCustomers = count(*) FROM dbo.customers
	Return @cntCustomers
END

GO
CREATE FUNCTION [getCountOfEvents]
()
returns int
WITH ENCRYPTION,
SchemaBinding
AS
BEGIN
DECLARE @cntEvents int 
	SELECT @cntEvents = count(*) FROM dbo.events
	Return @cntEvents
END

GO
CREATE FUNCTION [getCountOfTasks]
()
returns int
WITH ENCRYPTION,
SchemaBinding
AS
BEGIN
DECLARE @cntTasks int 
	SELECT @cntTasks = count(*) FROM dbo.tasks
	Return @cntTasks
END

/*-------------------------------------------------

   UDF for the Customers All, Active Closed, On leave

---------------------------------------------------*/

GO
CREATE FUNCTION [getAllCustomers]
()
returns TABLE
WITH Encryption,
SchemaBinding
AS
RETURN
(
SELECT C.id, C.name, C.mobile, C.city,C.zip, C.country, T.name as AddedBy, C.added_date, C.website, C.promoted_leadsId, C.photo, C.status 
FROM dbo.customers C join dbo.team T
on C.addedBy_teamId = T.id
)

GO
CREATE FUNCTION [getActiveCustomers]
()
returns TABLE
WITH Encryption,
SchemaBinding
AS
RETURN
(
SELECT C.id, C.name, C.mobile, C.city,C.zip, C.country, T.name as AddedBy, C.added_date, C.website, C.promoted_leadsId, C.photo, C.status 
FROM dbo.customers C join dbo.team T
on C.addedBy_teamId = T.id
where c.status = 1 
)


GO
CREATE FUNCTION [getLostCustomers]
()
returns TABLE
WITH Encryption,
SchemaBinding
AS
RETURN
(
SELECT C.id, C.name, C.mobile, C.city,C.zip, C.country, T.name as AddedBy, C.added_date, C.website, C.promoted_leadsId, C.photo, C.status 
FROM dbo.customers C join dbo.team T
on C.addedBy_teamId = T.id
where c.status = 0
)

GO
CREATE FUNCTION [getPromotedCustomers]
()
returns TABLE
WITH Encryption,
SchemaBinding
AS
RETURN
(
SELECT C.id, C.name, C.mobile, C.city,C.zip, C.country, T.name as AddedBy, C.added_date, C.website, C.promoted_leadsId, C.photo, C.status 
FROM dbo.customers C join dbo.team T 
on C.addedBy_teamId = T.id
join dbo.leads L On L.id = C.promoted_leadsId
where L.id = C.promoted_leadsId
)


/*-------------------------------------------------

   UDF for the Leads All, Active, Closed, Onleave

---------------------------------------------------*/


GO
CREATE FUNCTION [getAllLeads]
()
returns TABLE
WITH Encryption,
SchemaBinding
AS
RETURN
(
SELECT L.id, L.name, L.email, L.source, L.status, L.note, L.createDate, T.name as AddedBy
FROM dbo.leads L join dbo.team T
on L.addedBy_teamId = T.id
)


GO
CREATE FUNCTION [getActiveLeads]
()
returns TABLE
WITH Encryption,
SchemaBinding
AS
RETURN
(
SELECT L.id, L.name, L.email, L.source, L.status, L.note, L.createDate, T.name as AddedBy
FROM dbo.leads L join dbo.team T
on L.addedBy_teamId = T.id
where L.status not LIKE 'Lost'
)


GO
CREATE FUNCTION [getClosedLeads]
()
returns TABLE
WITH Encryption,
SchemaBinding
AS
RETURN
(
SELECT L.id, L.name, L.email, L.source, L.status, L.note, L.createDate, T.name as AddedBy
FROM dbo.leads L join dbo.team T
on L.addedBy_teamId = T.id
where L.status  LIKE 'Lost'
)


---Events

GO
ALTER FUNCTION [getAllEvents]
()
returns TABLE
WITH Encryption,
SchemaBinding
AS
RETURN
(
SELECT E.id, E.topic, E.type, E.status,  T.name as AddedBy, E.note, E.startDate, E.end_date
FROM dbo.events E 
join dbo.team T on E.addedBy_teamId = T.id
)
GO
ALTER FUNCTION [getPastEvents]
()
returns TABLE
WITH Encryption,
SchemaBinding
AS
RETURN
(
SELECT E.id, E.topic, E.type, E.status,  T.name as AddedBy, E.note, E.startDate, E.end_date
FROM dbo.events E 
join dbo.team T on E.addedBy_teamId = T.id
where E.end_date > GETDATE()
)

GO
ALTER FUNCTION [getUpcomingEvents]
()
returns TABLE
WITH Encryption,
SchemaBinding
AS
RETURN
(
SELECT E.id, E.topic, E.type, E.status,  T.name as AddedBy, E.note, E.startDate, E.end_date
FROM dbo.events E 
join dbo.team T on E.addedBy_teamId = T.id
where E.startDate < GETDATE()
)



---Tasks

GO
CREATE FUNCTION [getAllTasks]
()
returns TABLE
WITH Encryption,
SchemaBinding
AS
RETURN
(
SELECT Ta.id, Ta.status, Ta.refer_name, Ta.refer_type, Ta.priority, Ta.note, Te.name as AddedBy
From dbo.tasks Ta join dbo.team Te
on Ta.addedBy_teamId = Te.id 
)




--ComboBoxes
GO
CREATE FUNCTION [getAllLeadId]
()
returns TABLE
WITH Encryption,
SchemaBinding
AS
RETURN
(
SELECT id From dbo.leads
)

--AddedBy
GO
CREATE FUNCTION [getAllTeamId]
()
returns TABLE
WITH Encryption,
SchemaBinding
AS
RETURN
(
SELECT id From dbo.team
)

GO

/*--------------------------------------------------------------------------

                            creating logins

----------------------------------------------------------------------------*/


CREATE LOGIN [TeamAdmin Login] WITH PASSWORD = '0'

	CREATE USER [TeamAdmin] FOR LOGIN [TeamAdmin Login]

CREATE LOGIN [Team Login] WITH PASSWORD = '0'
	CREATE USER [Team] FOR LOGIN [Team Login]



use [CRM_PROJECT]
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[customers] TO [TeamAdmin] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[customers] TO [TeamAdmin] WITH GRANT OPTION  AS [dbo]
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[customers] TO [TeamAdmin] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[customers] TO [TeamAdmin] WITH GRANT OPTION  AS [dbo]
GO
use [CRM_PROJECT]
GO
GRANT DELETE ON [dbo].[customers] TO [TeamAdmin] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT DELETE ON [dbo].[customers] TO [TeamAdmin] WITH GRANT OPTION  AS [dbo]
GO
use [CRM_PROJECT]
GO
GRANT INSERT ON [dbo].[customers] TO [TeamAdmin] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT INSERT ON [dbo].[customers] TO [TeamAdmin] WITH GRANT OPTION  AS [dbo]
GO
use [CRM_PROJECT]
GO
GRANT REFERENCES ON [dbo].[customers] TO [TeamAdmin] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT REFERENCES ON [dbo].[customers] TO [TeamAdmin] WITH GRANT OPTION  AS [dbo]
GO
use [CRM_PROJECT]
GO
GRANT SELECT ON [dbo].[customers] TO [TeamAdmin] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT SELECT ON [dbo].[customers] TO [TeamAdmin] WITH GRANT OPTION  AS [dbo]
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[customers] TO [TeamAdmin] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[customers] TO [TeamAdmin] WITH GRANT OPTION  AS [dbo]
GO
use [CRM_PROJECT]
GO
GRANT UPDATE ON [dbo].[customers] TO [TeamAdmin] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT UPDATE ON [dbo].[customers] TO [TeamAdmin] WITH GRANT OPTION  AS [dbo]
GO
use [CRM_PROJECT]
GO
GRANT VIEW CHANGE TRACKING ON [dbo].[customers] TO [TeamAdmin] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW CHANGE TRACKING ON [dbo].[customers] TO [TeamAdmin] WITH GRANT OPTION  AS [dbo]
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[customers] TO [TeamAdmin] WITH GRANT OPTION 
GO

-- Team Permition on Team

use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[customers] TO [TeamAdmin] WITH GRANT OPTION  AS [dbo]
GO
use [CRM_PROJECT]
GO
DENY ALTER ON [dbo].[team] TO [Team]
GO
use [CRM_PROJECT]
GO
DENY CONTROL ON [dbo].[team] TO [Team]
GO
use [CRM_PROJECT]
GO
DENY DELETE ON [dbo].[team] TO [Team]
GO
use [CRM_PROJECT]
GO
DENY INSERT ON [dbo].[team] TO [Team]
GO
use [CRM_PROJECT]
GO
DENY REFERENCES ON [dbo].[team] TO [Team]
GO
use [CRM_PROJECT]
GO
DENY SELECT ON [dbo].[team] TO [Team]
GO
use [CRM_PROJECT]
GO
DENY TAKE OWNERSHIP ON [dbo].[team] TO [Team]
GO
use [CRM_PROJECT]
GO
DENY UPDATE ON [dbo].[team] TO [Team]
GO
use [CRM_PROJECT]
GO
DENY VIEW CHANGE TRACKING ON [dbo].[team] TO [Team]
GO
use [CRM_PROJECT]
GO
DENY VIEW DEFINITION ON [dbo].[team] TO [Team]
GO

-- Team Permition on Organization

use [CRM_PROJECT]
GO
DENY DELETE ON [dbo].[organization] TO [Team]
GO
use [CRM_PROJECT]
GO
DENY INSERT ON [dbo].[organization] TO [Team]
GO
use [CRM_PROJECT]
GO
DENY REFERENCES ON [dbo].[organization] TO [Team]
GO
use [CRM_PROJECT]
GO
DENY SELECT ON [dbo].[organization] TO [Team]
GO
use [CRM_PROJECT]
GO
DENY TAKE OWNERSHIP ON [dbo].[organization] TO [Team]
GO
use [CRM_PROJECT]
GO
DENY UPDATE ON [dbo].[organization] TO [Team]
GO
use [CRM_PROJECT]
GO
DENY VIEW CHANGE TRACKING ON [dbo].[organization] TO [Team]
GO
use [CRM_PROJECT]
GO
DENY VIEW DEFINITION ON [dbo].[organization] TO [Team]
GO





use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[Add Customers] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[Add Customers] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[Add Customers] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[Add Customers] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[Add Customers] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[Add Events] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[Add Events] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[Add Events] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[Add Events] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[Add Events] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[Delete Organization_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[Delete Organization_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[Delete Organization_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[Delete Organization_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[Delete Organization_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[Delete Guest_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[Delete Guest_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[Delete Guest_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[Delete Guest_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[Delete Guest_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[Get Organization] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[Get Organization] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[Get Organization] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[Get Organization] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[Get Organization] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[Update Leads_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[Update Leads_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[Update Leads_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[Update Leads_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[Update Leads_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[Update Team_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[Update Team_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[Update Team_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[Update Team_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[Update Team_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[Add organization] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[Add organization] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[Add organization] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[Add organization] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[Add organization] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[Search Team_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[Search Team_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[Search Team_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[Search Team_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[Search Team_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[Delete Team_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[Delete Team_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[Delete Team_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[Delete Team_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[Delete Team_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[Add Leads] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[Add Leads] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[Add Leads] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[Add Leads] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[Add Leads] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[Search Event_byIdOrTopic] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[Search Event_byIdOrTopic] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[Search Event_byIdOrTopic] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[Search Event_byIdOrTopic] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[Search Event_byIdOrTopic] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[Add Guest] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[Add Guest] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[Add Guest] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[Add Guest] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[Add Guest] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[GetAll Leads] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[GetAll Leads] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[GetAll Leads] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[GetAll Leads] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[GetAll Leads] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[Delete Leads_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[Delete Leads_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[Delete Leads_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[Delete Leads_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[Delete Leads_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[Delete Event_byIdOrTopic] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[Delete Event_byIdOrTopic] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[Delete Event_byIdOrTopic] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[Delete Event_byIdOrTopic] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[Delete Event_byIdOrTopic] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[GetAll Team] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[GetAll Team] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[GetAll Team] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[GetAll Team] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[GetAll Team] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[Update Tasks_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[Update Tasks_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[Update Tasks_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[Update Tasks_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[Update Tasks_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[Update Organization_byName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[Update Organization_byName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[Update Organization_byName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[Update Organization_byName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[Update Organization_byName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[Add Customers] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[Add Customers] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[Add Customers] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[Add Customers] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[Add Customers] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[Delete Tasks_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[Delete Tasks_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[Delete Tasks_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[Delete Tasks_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[Delete Tasks_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[Search Leads_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[Search Leads_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[Search Leads_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[Search Leads_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[Search Leads_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[Search Guest_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[Search Guest_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[Search Guest_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[Search Guest_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[Search Guest_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[Add Events] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[Add Events] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[Add Events] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[Add Events] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[Add Events] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[Add Tasks] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[Add Tasks] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[Add Tasks] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[Add Tasks] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[Add Tasks] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[Update Events_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[Update Events_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[Update Events_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[Update Events_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[Update Events_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[Delete Customers_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[Delete Customers_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[Delete Customers_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[Delete Customers_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[Delete Customers_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[GetAll Tasks] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[GetAll Tasks] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[GetAll Tasks] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[GetAll Tasks] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[GetAll Tasks] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[Update Customers_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[Update Customers_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[Update Customers_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[Update Customers_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[Update Customers_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[Search Customers_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[Search Customers_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[Search Customers_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[Search Customers_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[Search Customers_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[GetAll Customers] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[GetAll Customers] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[GetAll Customers] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[GetAll Customers] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[GetAll Customers] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[Update Guest_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[Update Guest_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[Update Guest_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[Update Guest_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[Update Guest_byId] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[GetAll Guest] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[GetAll Guest] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[GetAll Guest] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[GetAll Guest] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[GetAll Guest] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[GetAll Events] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[GetAll Events] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[GetAll Events] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[GetAll Events] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[GetAll Events] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[Search Tasks_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[Search Tasks_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[Search Tasks_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[Search Tasks_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[Search Tasks_byIdOrName] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT ALTER ON [dbo].[Add Team] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT CONTROL ON [dbo].[Add Team] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT EXECUTE ON [dbo].[Add Team] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT TAKE OWNERSHIP ON [dbo].[Add Team] TO [Team] WITH GRANT OPTION 
GO
use [CRM_PROJECT]
GO
GRANT VIEW DEFINITION ON [dbo].[Add Team] TO [Team] WITH GRANT OPTION 
GO
