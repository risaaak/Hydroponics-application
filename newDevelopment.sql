/*CREATE DATABASE HYDROPONICS_TEST
USE HYDROPONICS_TEST

CREATE TABLE SEEDS (
	seed_id INT PRIMARY KEY IDENTITY(001,1),
	seed_name VARCHAR(255) NOT NULL,
	seed_times_planted INT,
	seed_times_sprouted INT, 
	seed_germination_rate FLOAT
	)

CREATE TABLE PLANT (
	plant_id INT PRIMARY KEY IDENTITY(00001,1),
	seed_id INT FOREIGN KEY REFERENCES SEEDS(seed_id),
	sow_date VARCHAR(255),
	transfer_date VARCHAR(255),
	harvest_date VARCHAR(255),
	next_plant_date VARCHAR(255),
	seeds_planted int,
	seeds_sprouted float
	)
	*/

CREATE TABLE EXPENDITURES (
	item_id INT PRIMARY KEY IDENTITY(000001,1),
	item_name VARCHAR(255),
	item_description VARCHAR(255),
	item_quantity INT,
	item_price FLOAT,
	item_total_amount FLOAT,
	item_date DATETIME
)

CREATE TABLE INCOME (
	income_id INT PRIMARY KEY IDENTITY(000001,1),
	income_description VARCHAR(255),
	name VARCHAR(255),
	quantity int,
	price_per_piece FLOAT,
	total_amount FLOAT,
	income_date DATETIME
	)

CREATE TABLE FINANCE (
	id INT PRIMARY KEY IDENTITY(000001,1),
	income FLOAT,
	expense FLOAT,
	earnings FLOAT,
	date DATETIME
	)

CREATE TABLE WEEKLYFINANCE (
   id INT PRIMARY KEY IDENTITY(000001,1),
   DATE INT,
   cash_outflow FLOAT,
   cash_inflow FLOAT,
   earnings FLOAT
   )

CREATE TABLE WEEKLYFINANCETEMP (
id INT PRIMARY KEY IDENTITY(000001,1),
DATE INT,
cash_outflow FLOAT,
cash_inflow FLOAT,
earnings FLOAT
)

CREATE TABLE MONTHLYFINANCE (
	id INT PRIMARY KEY,
	month DATE,
	year DATE,
	cash_outflow FLOAT,
	cash_inflow FLOAT,
	earnings FLOAT
	)
CREATE TABLE YEARLYFINANCE (
	id INT PRIMARY KEY,
	year DATE,
	cash_outflow FLOAT,
	cash_inflow FLOAT,
	earnings FLOAT
	)

CREATE TABLE WEEKLYEXPENSE(
	ID INT PRIMARY KEY IDENTITY(000001,1),
	AMOUNT FLOAT,
	DATE INT)

CREATE TABLE WEEKLYINCOME(
	ID INT PRIMARY KEY IDENTITY(000001,1),
	AMOUNT FLOAT,
	DATE INT)


select item_total_amount from EXPENDITURES where MONTH(item_date) = 8


UPDATE SEEDS SET seed_times_planted = 2, seed_times_sprouted=1, seed_germination_rate = seed_times_sprouted / seed_times_planted * 100 WHERE seed_name = 'jonction'
select * from plant
select * from SEEDS
drop table EXPENDITURES

delete from seeds where seed_id = 2

select sum(item_total_amount) as sum, '33' as week from expenditures where datepart(ISOWK,item_date) = 33;

select sum(item_total_amount) as sum from expenditures where DATEPART(ISO_WEEK,GETDATE()) =33;

select * from expenditures

select DATEPART(ISOWK,'2023-08-18 16:28:59.093')

SELECT SUM(item_total_amount) FROM EXPENDITURES where datepart(ISOWK,item_date) = 33

select sum(item_total_amount),CONCAT(CAST(DATEPART(ISO_WEEK,item_date) AS INT), CAST(DATEPART(yyyy,item_date) AS INT)) from expenditures group by DATEPART(ISO_WEEK,item_date), year(item_date)


INSERT INTO WEEKLYEXPENSE(AMOUNT, DATE)
select sum(item_total_amount),CONCAT(CAST(DATEPART(ISO_WEEK,item_date) AS INT), CAST(DATEPART(yyyy,item_date) AS INT)) from expenditures group by DATEPART(ISO_WEEK,item_date), year(item_date)

INSERT INTO WEEKLYINCOME(AMOUNT, DATE)
select sum(total_amount),CONCAT(CAST(DATEPART(ISO_WEEK,income_date) AS INT), CAST(DATEPART(yyyy,income_date) AS INT)) from INCOME group by DATEPART(ISO_WEEK,income_date), year(income_date)

IF  EXISTS (SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID(N'WEEKLYEXPENSE') 
AND type in (N'U'))
BEGIN
      DROP TABLE WEEKLYEXPENSE
END
SELECT * FROM WEEKLYFINANCE
select * from WEEKLYINCOME
select * from WEEKLYEXPENSE

select sum(amount) from (
	select amount,date from WEEKLYINCOME union select amount, date from weeklyexpense
) as amount



--INSERT TO WEEKLYFINANCE.CASH_INFLOW FROM WEEKLYINCOME
if exists(select * from WEEKLYFINANCE where DATE = 332023)
	BEGIN
		UPDATE WEEKLYFINANCE
		SET cash_inflow = cash_inflow + (SELECT AMOUNT FROM WEEKLYINCOME WHERE DATE = 332023) 
		WHERE DATE = 332023
	END
else 
	BEGIN
		INSERT INTO WEEKLYFINANCE (cash_inflow,DATE)
		SELECT AMOUNT,DATE FROM WEEKLYINCOME
	END

--INSERT INTO WEEKLYFINANCE.CASH_OUTFLOW FROM WEEKLYEXPENSE
if exists(select * from WEEKLYINCOME where DATE = 362023)
	BEGIN
		UPDATE WEEKLYFINANCE
		SET cash_outflow = ISNULL (cash_outflow,0) + (SELECT AMOUNT FROM WEEKLYEXPENSE WHERE DATE = 362023)
		WHERE DATE = 362023
	END
else 
	BEGIN
		UPDATE WEEKLYFINANCE
		SET cash_outflow = (SELECT AMOUNT FROM WEEKLYEXPENSE WHERE DATE = 362023) WHERE DATE = 362023
	END
	DROP TABLE WEEKLYFINANCE
	SELECT * FROM WEEKLYFINANCE
GO
--WEEKLYEXPENSE PROCEDURE
CREATE PROCEDURE WEEKLYEXPENSETABLE
AS
	DROP TABLE IF EXISTS WEEKLYEXPENSE
	CREATE TABLE WEEKLYEXPENSE(
	ID INT PRIMARY KEY IDENTITY(000001,1),
	AMOUNT FLOAT,
	DATE INT)
	INSERT INTO WEEKLYEXPENSE(AMOUNT, DATE)
	select sum(item_total_amount),CONCAT(CAST(DATEPART(ISO_WEEK,item_date) AS INT), CAST(DATEPART(yyyy,item_date) AS INT)) from expenditures group by DATEPART(ISO_WEEK,item_date), year(item_date)
GO

--WEEKLYINCOME PROCEDURE
CREATE PROCEDURE WEEKLYINCOMETABLE
AS
	DROP TABLE IF EXISTS WEEKLYINCOME
	CREATE TABLE WEEKLYINCOME(
	ID INT PRIMARY KEY IDENTITY(000001,1),
	AMOUNT FLOAT,
	DATE INT)
	INSERT INTO WEEKLYINCOME(AMOUNT, DATE)
	select sum(total_amount),CONCAT(CAST(DATEPART(ISO_WEEK,income_date) AS INT), CAST(DATEPART(yyyy,income_date) AS INT)) from INCOME group by DATEPART(ISO_WEEK,income_date), year(income_date)
GO


--INSERT DATE INTO WEEKLYFINANCE
CREATE PROCEDURE INSERTINTOWEEKLYFINANCE
AS
	 --IF EXISTS (SELECT * FROM WEEKLYFINANCE WHERE DATE = (SELECT DATE FROM WEEKLYINCOME))

BEGIN
	IF NOT EXISTS(SELECT DATE FROM WEEKLYFINANCE WHERE DATE = 332023)
	BEGIN
		INSERT INTO WEEKLYFINANCE (DATE)
		SELECT DATE FROM WEEKLYINCOME WHERE DATE = 332023
	END
END
GO

CREATE PROCEDURE INSERTINTOWEEKLYFINANCE
AS
DROP TABLE IF EXISTS WEEKLYEXPENSETEMP
SELECT MAX(CONCAT(CAST(DATEPART(ISO_WEEK,item_date) AS INT), CAST(DATEPART(yyyy,item_date) AS INT))) as WEEK, sum(item_total_amount) as cash_outflow
INTO WEEKLYEXPENSETEMP FROM EXPENDITURES GROUP BY DATEPART(ISO_WEEK,item_date)DROP TABLE IF EXISTS WEEKLYINCOME
DROP TABLE IF EXISTS WEEKLYINCOMETEMP
SELECT MAX(CONCAT(CAST(DATEPART(ISO_WEEK,income_date) AS INT), CAST(DATEPART(yyyy,income_date) AS INT))) as WEEK, sum(total_amount) as cash_INFLOW
INTO WEEKLYINCOMETEMP FROM INCOME GROUP BY DATEPART(ISO_WEEK,income_date)

DROP TABLE IF EXISTS WEEKLYFINANCETEMP

CREATE TABLE WEEKLYFINANCETEMP (
	id INT PRIMARY KEY IDENTITY(000001,1),
	DATE INT,
	cash_outflow FLOAT,
	cash_inflow FLOAT,
	earnings FLOAT
)
INSERT INTO WEEKLYFINANCETEMP(DATE,CASH_INFLOW)
SELECT WEEK,cash_INFLOW FROM WEEKLYINCOMETEMP

INSERT INTO WEEKLYFINANCETEMP(DATE,cash_outflow)
SELECT WEEK,cash_outflow FROM WEEKLYEXPENSETEMP

DROP TABLE IF EXISTS WEEKLYFINANCE

SELECT MAX(DATE) AS WEEK, SUM(CASH_OUTFLOW) AS CASH_OUTFLOW,SUM(CASH_INFLOW) AS CASH_INFLOW, SUM(ISNULL (CASH_OUTFLOW,0) + ISNULL(CASH_INFLOW,0)) AS EARNINGS--FROM WEEKLYFINANCETEMP --GROUP BY DATEPART(ISO_WEEK,DATE)
INTO WEEKLYFINANCE FROM WEEKLYFINANCETEMP GROUP BY DATEPART(ISO_WEEK,DATE)

SELECT * FROM WEEKLYFINANCE
GO

CREATE PROCEDURE MONTHLYFINANCEPROCEDURE
AS
DROP TABLE IF EXISTS MONTHLYEXPENSETEMP
--MONTHLYEXPENSETEMP
SELECT MAX(CONCAT(CAST(DATEPART(m,item_date) AS INT), CAST(DATEPART(yyyy,item_date) AS INT))) as MONTH, sum(item_total_amount) as cash_outflow
INTO MONTHLYEXPENSETEMP FROM EXPENDITURES GROUP BY DATEPART(m,item_date)
DROP TABLE IF EXISTS MONTHLYINCOMETEMP
--MONTHLYINCOMETEMP
SELECT MAX(CONCAT(CAST(DATEPART(m,income_date) AS INT), CAST(DATEPART(yyyy,income_date) AS INT))) as MONTH, sum(total_amount) as cash_INFLOW
INTO MONTHLYINCOMETEMP FROM INCOME GROUP BY DATEPART(m,income_date)

DROP TABLE IF EXISTS MONTHLYFINANCETEMP
CREATE TABLE MONTHLYFINANCETEMP (
	id INT PRIMARY KEY IDENTITY(000001,1),
	DATE INT,
	cash_outflow FLOAT,
	cash_inflow FLOAT,
	earnings FLOAT
)
INSERT INTO MONTHLYFINANCETEMP (DATE,cash_outflow)
SELECT MONTH,CASH_OUTFLOW FROM MONTHLYEXPENSETEMP
INSERT INTO MONTHLYFINANCETEMP (DATE,cash_inflow)
SELECT MONTH,CASH_INFLOW FROM MONTHLYINCOMETEMP

DROP TABLE IF EXISTS MONTHLYFINANCE
SELECT MAX(date) AS MONTH, SUM(cash_outflow) AS CASH_OUTFLOW,SUM(CASH_INFLOW) AS CASH_INFLOW, SUM(ISNULL (cash_outflow,0) + ISNULL(CASH_INFLOW,0)) AS EARNINGS
INTO MONTHLYFINANCE FROM MONTHLYFINANCETEMP GROUP BY DATEPART(m,date)
SELECT * FROM MONTHLYFINANCE
GO

CREATE PROCEDURE YEARLYFINANCEPROCEDURE
AS
DROP TABLE IF EXISTS YEARLYEXPENSETEMP
SELECT MAX(DATEPART(yyyy,item_date)) as YEAR, sum(item_total_amount) as cash_outflow
INTO YEARLYEXPENSETEMP FROM EXPENDITURES GROUP BY DATEPART(yyyy,item_date)
DROP TABLE IF EXISTS YEARLYINCOMETEMP
SELECT MAX(DATEPART(yyyy,income_date)) as YEAR, sum(total_amount) as cash_INFLOW
INTO YEARLYINCOMETEMP FROM INCOME GROUP BY DATEPART(yyyy,income_date)

DROP TABLE IF EXISTS YEARLYFINANCETEMP
CREATE TABLE YEARLYFINANCETEMP (
	id INT PRIMARY KEY IDENTITY(000001,1),
	DATE INT,
	cash_outflow FLOAT,
	cash_inflow FLOAT,
	earnings FLOAT
)
INSERT INTO YEARLYFINANCETEMP (DATE,cash_outflow)
SELECT YEAR,CASH_OUTFLOW FROM YEARLYEXPENSETEMP
INSERT INTO YEARLYFINANCETEMP (DATE,cash_inflow)
SELECT YEAR,CASH_INFLOW FROM YEARLYINCOMETEMP

DROP TABLE IF EXISTS YEARLYFINANCE
SELECT MAX(date) AS YEAR, SUM(cash_outflow) AS CASH_OUTFLOW,SUM(CASH_INFLOW) AS CASH_INFLOW, SUM(ISNULL (cash_outflow,0) + ISNULL(CASH_INFLOW,0)) AS EARNINGS
INTO YEARLYFINANCE FROM YEARLYFINANCETEMP GROUP BY DATEPART(yyyy,date)
SELECT * FROM YEARLYFINANCE
GO

DROP PROCEDURE YEARLYFINANCEPROCEDURE
EXEC YEARLYFINANCEPROCEDURE

CREATE TABLE LETTUCESALES (
	DATE DATE,
	COUNT INT,
	TOTAL_WEIGHT FLOAT,
	AVERAGE_WEIGHT FLOAT,
	)


ALTER TABLE PLANT drop constraint FK_PLANT_seed_id

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'seed_id')
BEGIN
  ALTER TABLE plant
  ADD CONSTRAINT fk_seed_id
  FOREIGN KEY (seed_id)
  REFERENCES seeds(seed_id) /* make sure Resources.id is a PRIMARY KEY */
END;

alter table plant
drop constraint FK__PLANT__seed_id__5441852A


alter table plant
alter column seed_id nvarchar(100)

EXEC sp_rename 'PLANT.seed_id', 'seed_name', 'COLUMN'

ALTER TABLE PLANT ADD germination_rate FLOAT

CREATE TABLE LAST_GERMINATION_UPDATE (
	LAST INT NOT NULL UNIQUE
	)