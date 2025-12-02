create  database Hotel_Management_System;


Create table User_table(

User_ID int identity (1,1) not null,
User_Name varchar (150) UNIQUE not null,
User_Password varchar (150) not null,
constraint User_Table_User_ID_PK primary key(User_ID)


);

insert into User_table values
('admin' , 'admin');

select *from user_table;

CREATE TABLE CLient_Table
(
Client_ID int identity (1,1) not null,
Client_FirstName varchar (150) not null,
Client_LastName varchar (150) not null,
Client_Phone varchar (15) unique not null,
Client_Address varchar (150) not null,
CONSTRAINT Client_Table_Client_ID_PK primary key (Client_ID)

);

insert into CLient_Table values
('Ali','Salh','123456789','taiz'),
('top','twfeeq','123456780','taiz');




create table Room_Table
(
Room_Number int identity (1,1) not null,
Room_Type varchar(10) not null,
Room_Phone varchar(15) unique not null,
Room_Free varchar(3) not null,
constraint Room_Table_Room_Number_PK primary key (Room_Number)
);


insert into Room_Table VALUES
('single','12345678','Yes'),
('Family' , '12345689','No');





