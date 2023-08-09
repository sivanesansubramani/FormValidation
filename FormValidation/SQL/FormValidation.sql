Create table Validation
(
id int primary key identity(1,1),
Name varchar(100) not null,
Lastname nvarchar(100) not null,
Email nvarchar(100)  not null,
Pnone int not null,
Location nvarchar (100)
)

select * from Validation

insert into Validation(Name,Lastname,Email,Pnone,Location) values ('kvm','kuppusamy','temple@gmail.com',12345678,'Palani')

-- insert records into stubio 
create or alter procedure InsertValidation(@Name nvarchar(100),@Lastname nvarchar(100),@Email nvarchar(100),@Phone int,@Location nvarchar(100))
as
begin

insert into Validation(Name,Lastname,Email,Pnone,Location) values (@Name,@Lastname,@Email,@Phone,@Location)

end

exec InsertValidation 'kvm','kuppusamy','temple@gmail.com',12345678,'thopampatti'

-------select sp
create or alter procedure SelectValidation
as
begin

  Select * from Validation

end

exec SelectValidation


-------select sp with id
create or alter procedure selectsvalidationID(@ID int)
as
begin

  Select * from Validation where id =@ID

end

exec selectsvalidationID 1

--ubdate store procedure
create or alter procedure UbdateValidation (@ID int,@Name nvarchar(100),@Lastname nvarchar(100),@Email nvarchar(100),@Phone int)
as
begin

  update Validation set Name =@Name, Lastname=@Lastname,Email= @Email, Pnone =@Phone where id =@ID

end

exec UbdateValidation 2,'kvm2','kuppusamy2','temple2@gmail.com',123000


--delete
create or alter procedure DeleteValidation(@id int)
as
begin

  delete from Validation where id =@id

end

exec DeleteValidation 2