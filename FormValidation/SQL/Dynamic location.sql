Create table Location
(
id int primary key identity(1,1),
Name varchar(100) not null,
Description nvarchar(100) not null,
PostalCode  int not null,
Isactive BIT NOT NULL
)

insert into Location values ('palani','temple city',1234567,'true')
insert into Location values ('dharapuram',' city',7654567,'true')
insert into Location values ('CBE','it city',342567,'true')
insert into Location values ('Nkp','Village city',6664567,'true')

