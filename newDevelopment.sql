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
	seeds_planted int
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



