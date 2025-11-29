create  database Hotel_Management_System;


Create table User_table(

User_ID int identity (1,1) not null,
User_Name varchar (150) not null,
User_Password varchar (150) not null,
constraint User_Table_User_ID_PK primary key(User_ID)


);

insert into User_table values
('Hacktor' , '1234');

select *from user_table;