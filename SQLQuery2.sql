/*create table HYDROPONICS
( plantid int primary key not null identity,
  nosolutiondate date,
  halfstrengthsolutiondate date,
  fullstrengthsolutiondate date,
  harvestdate date not null,
  nextplant date not null,
  growboxid int,
  seedlingtrayid int 
)*/
/*
SELECT * FROM HYDROPONICS
create table GROWBOX
( 
  growboxid int primary key not null,
  transferdate date,
  harvestdate date not null,
  nextplant date not null,
)
CREATE TABLE SEEDLINGTRAY
( 
  seedlingtrayid int primary key not null,
  plantdate date not null,
  nosolutiondate date not null,
  halfstrengthsolutiondate date not null,
  fullstrengthsolutiondate date not null,
  harvestdate date not null,
  nextplantdate date not null
)
*/
select * from SEEDLINGTRAY

CREATE TABLE SEEDLINGS
(
	SEEDID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	SEEDNAME VARCHAR(100) UNIQUE NOT NULL
)

CREATE TABLE SEEDLINGSTATS
(
	SEEDLINGSTATSID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	SEEDID INT FOREIGN KEY REFERENCES SEEDLINGS(SEELINGDID) NOT NULL,
	SEEDNAME VARCHAR(100) FOREIGN KEY REFERENCES SEEDLINGS(SEELINGDNAME) NOT NULL,
	NUMBEROFPLANTEDSEEDS INT,
	NUMBEROFSPROUTS INT,
	GERMINATIONRATE DECIMAL(2,2),
	NUMBEROFHARVEST INT,
	AVERAGEWEIGHT DECIMAL(2,2)
)

SELECT * FROM SEEDLINGS




