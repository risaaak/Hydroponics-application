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
	item_quantity INT,
	item_description VARCHAR(255),
	item_price FLOAT
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

UPDATE SEEDS SET seed_times_planted = 2, seed_times_sprouted=1, seed_germination_rate = seed_times_sprouted / seed_times_planted * 100 WHERE seed_name = 'jonction'
select * from plant
select * from SEEDS
drop table plant

delete from seeds where seed_id = 2

