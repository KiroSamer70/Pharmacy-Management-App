create database PharmacyDB
on primary(Name='PharmacyDB',filename='D:\Pharmacy Management System (1)\DataBase\Pharmacy_Data.mdf')
Log on(Name='PharmacyDB_Log',filename='D:\Pharmacy Management System (1)\DataBase\Pharmacy_Log.mdf')

use PharmacyDB

-- Create Pharmacy Table
CREATE TABLE pharmacy (
    id INT PRIMARY KEY identity(1,1),
    name VARCHAR(255) NOT NULL,
    location VARCHAR(255) NOT NULL
);
select * from pharmacy
insert into pharmacy
values ('anglena pharmacy','leoo')
TRUNCATE table pharmacy
Drop table pharmacy


-- Create Medicine Table
CREATE TABLE medicine (
    id INT PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    solded_amount INT NOT NULL,
    expiration_date DATE NOT NULL,
    sales_price DECIMAL(10, 2) NOT NULL
);

--Solded ones
CREATE TABLE SoldedMedicines (
    id INT PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    sales_price DECIMAL(10, 2) NOT NULL
);

-- Create Stocks Table
CREATE TABLE stocks (
    id INT PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    stock_level INT NOT NULL
);