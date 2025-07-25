CREATE DATABASE eSkyAnalizeDB
USE eSkyAnalizeDB

CREATE TABLE Country(
ID int primary key identity(1,1),
Name varchar(60) not null
)

CREATE TABLE Airport(
ID int primary key identity(1,1),
Name varchar(60) not null,
CountryID int foreign key references Country(ID) not null 
)

CREATE TABLE Airline(
ID int primary key identity(1,1),
Name varchar(30) not null
)

//*CREATE TABLE TicketType(
ID int primary key identity(1,1),
Type varchar(15) not null
)*//

CREATE TABLE 