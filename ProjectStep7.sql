--Drop database if exists BBS;


--create database BBS;

use BBS;

/*create table Users(
userID int not null identity(0000000001, 1) primary key,
lastName varchar(20) not null,
firstNmae varchar(20) not null,
streetAddress char(255) not null,
city char(25) not null,
state char(2) not null constraint [chk_state] check([state] like replicate('[A-Z]',2)),
zip int not null constraint [chk_zip] check([zip] like replicate('[0-9,]',5)),
phone bigint constraint [chk_phone] check([phone] like replicate('[0-9,]',10)),
email varchar(50) not null constraint [chk_email] check([email] like ('%_@__%.__%')));

create table SysLog(
logID int not null identity(0000000001,1) primary key,
logType varchar(255) not null,
description varchar(255),
date datetime not null,
userID int not null foreign key(userID) references Users(userID));

create table Documents(
docID int not null identity(0000000001,1) primary key,
userID int not null foreign key(userID) references Users(userID),
fileLocation varchar(max) not null); 

create table Events(
eventID int not null identity(0000000001,1) primary key,
eventType varchar(255) not null,
eventDescription text,
eventDate smalldatetime not null,
docID int foreign key(docID) references Documents(docID),
userID int not null foreign key(userID) references Users(userID));

create table Login (
userID int not null foreign key(userID) references Users(userID), 
userName varchar(10) not null primary key,
password nvarchar(10) not null);*/

select * from Users;
select * from SysLog;
select * from Login;
select * from Documents;
select * from Events;