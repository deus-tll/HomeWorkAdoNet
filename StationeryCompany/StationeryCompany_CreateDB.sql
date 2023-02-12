use [master];
go

if db_id('StationeryCompanyDB') is not null
begin
	drop database[StationeryCompanyDB];
end
go


create database[StationeryCompanyDB];
go

use [StationeryCompanyDB];
go


create table [BuyerCompanies](
	[ID] int not null identity(1,1),
	[Name] nvarchar(300) not null,
	[Address] nvarchar(300),

	constraint PK_BuyerCompanies_ID primary key([ID]),
	constraint CK_BuyerCompanies_Name check([Name] <> ''),
	constraint CK_BuyerCompanies_Address check([Address] <> '')
);
go


--create trigger DeleteBuyerCompanyTrigger
--on [BuyerCompanies]
--for delete
--as
--begin
--	if(@@ROWCOUNT = 1)
--	begin
--		declare @name nvarchar(300), @address nvarchar(300);

--		select @name = [Name], @address = [Address] from deleted;

--		insert into [BuyerCompaniesArchive] values(@name, @address);

--	end
--	else
--	begin
--		raiserror('You are trying to insert more than one row',0,1);
--		rollback tran;
--	end
--end


create table [Managers](
	[ID] int not null identity(1,1),
	[Name] nvarchar(150) not null,
	[Surname] nvarchar(150) not null,

	constraint PK_Managers_ID primary key([ID]),
	constraint CK_Managers_Name check([Name] <> ''),
	constraint CK_Managers_Surname check([Surname] <> '')

);
go


--create trigger DeleteManagerTrigger
--on [Managers]
--for delete
--as
--begin
--	if(@@ROWCOUNT = 1)
--	begin
--		declare @name nvarchar(150), @surname nvarchar(150);

--		select @name = [Name], @surname = [Surname] from deleted;

--		insert into [ManagersArchive] values(@name, @surname);

--	end
--	else
--	begin
--		raiserror('You are trying to insert more than one row',0,1);
--		rollback tran;
--	end
--end


create table [Types](
	[ID] int not null identity(1,1),
	[Name] nvarchar(150) not null,
	[NumberOfStationery] int not null default(0),

	constraint PK_Types_ID primary key([ID]),
	constraint CK_Types_Name check([Name] <> ''),
	constraint CK_Types_NumberOfStationery check([NumberOfStationery] >= 0)
);
go


--create trigger DeleteTypeTrigger
--on [Types]
--for delete
--as
--begin
--	if(@@ROWCOUNT = 1)
--	begin
--		declare @name nvarchar(150);

--		select @name = [Name] from deleted;

--		insert into [TypesArchive] values(@name);

--	end
--	else
--	begin
--		raiserror('You are trying to insert more than one row',0,1);
--		rollback tran;
--	end
--end


create table [Stationeries](
	[ID] int not null identity(1,1),
	[Name] nvarchar(300) not null unique,
	[Cost] money not null default(0.0),
	[Units] int not null default(1),
	[SellingPrice] money not null default(0.0),
	[TypeID] int,
	

	constraint PK_Stationeries_ID primary key([ID]),
	constraint CK_Stationeries_Name check([Name] <> ''),
	constraint CK_Stationeries_Cost check([Cost] >= 0.0 ),
	constraint CK_Stationeries_Units check([Units] > 0 ),
	constraint CK_Stationeries_SellingPrice check([SellingPrice] >= 0.0),
	constraint FK_Stationeries_TypeID foreign key([TypeID]) references [Types]([ID])
);
go


--create trigger AddStationeryTrigger
--on [Stationeries]
--for insert
--as
--begin
--	if(@@ROWCOUNT = 1)
--	begin
--		declare @id int, @count int;
--		select @id = TypeID from inserted;
--		select @count = NumberOfStationery from [Types] where [ID] = @id;
--		update [Types] set [Types].[NumberOfStationery] = @count + 1 where [ID] = @id;
--	end
--	else
--	begin
--		raiserror('You are trying to insert more than one row',0,1)
--		rollback tran;
--	end
--end


--create trigger DeleteStationeryTrigger
--on [Stationeries]
--for delete
--as
--begin
--	if(@@ROWCOUNT = 1)
--	begin
--		declare @id int, 
--				@nameStationery nvarchar(300),
--				@cost money, 
--				@nameType nvarchar(150),
--				@count int;

--		select
--			@id = TypeID,
--			@nameStationery = [Name],
--			@cost = [Cost]
--		from
--			deleted

--		select @count = NumberOfStationery, @nameType = [Name]
--		from [Types]
--		where [ID] = @id;
--		update [Types] set [Types].[NumberOfStationery] = @count - 1 where [ID] = @id;

--		insert into [StationeriesArchive] values(@nameStationery, @cost, @nameType)

--	end
--	else
--	begin
--		raiserror('You are trying to insert more than one row',0,1)
--		rollback tran;
--	end
--end


create table [Sales](
	[ID] int not null identity(1,1),
	[Name] nvarchar(300) not null,
	[DateOfSale] date not null default(GetDate()),
	[Offtake] smallint not null default(1),
	[PricePerUnit] money not null default(0.1),
	[ManagerID] int,
	[BuyerCompanyID] int,

	constraint PK_Sales_ID primary key([ID]),
	constraint CK_Sales_Name check([Name] <> ''),
	constraint CK_Sales_DateOfSale check([DateOfSale] <= GetDate()),
	constraint CK_Sales_Offtake check([Offtake] > 0),
	constraint FK_Sales_ManagerID foreign key ([ManagerID]) references [Managers]([ID]),
	constraint FK_Sales_BuyerCompanyID foreign key ([BuyerCompanyID]) references [BuyerCompanies]([ID]),
);


--create trigger MakeSaleTrigger
--on [Sales]
--for insert
--as
--begin
--	declare @nameStationery nvarchar(300), @offtake smallint, @units int;

--	select
--		@offtake = i.[Offtake],
--		@nameStationery = i.[Name]
--	from
--		inserted as i

--	select
--		@units = S.[Units]
--	from
--		[Stationeries] as S

--	if(@units - @offtake >= 0)
--	begin
--		update [Stationeries] set [Stationeries].Units = @units - @offtake where [Name] = @nameStationery;
--	end
--	else
--	begin
--		raiserror('There are not enough units of the product in stock',0,1)
--		rollback tran;
--	end
--end


create table [BuyerCompaniesArchive](
	[ID] int not null identity(1,1),
	[Name] nvarchar(150) not null,
	[Address] nvarchar(150),

	constraint PK_BuyerCompaniesArchive_ID primary key([ID]),
	constraint CK_BuyerCompaniesArchive_Name check([Name] <> ''),
	constraint CK_BuyerCompaniesArchive_Address check([Address] <> '')
);
go

create table [ManagersArchive](
	[ID] int not null identity(1,1),
	[Name] nvarchar(150) not null,
	[Surname] nvarchar(150) not null,

	constraint PK_ManagersArchive_ID primary key([ID]),
	constraint CK_ManagersArchive_Name check([Name] <> ''),
	constraint CK_ManagersArchive_Surname check([Surname] <> '')

);
go

create table [TypesArchive](
	[ID] int not null identity(1,1),
	[Name] nvarchar(150) not null,

	constraint PK_TypesArchive_ID primary key([ID]),
	constraint CK_TypesArchive_Name check([Name] <> '')
);
go

create table [StationeriesArchive](
	[ID] int not null identity(1,1),
	[Name] nvarchar(300) not null,
	[Cost] money not null default(0.0),
	[TypeName] nvarchar(150),
	

	constraint PK_StationeriesArchive_ID primary key([ID]),
	constraint CK_StationeriesArchive_Name check([Name] <> ''),
	constraint CK_StationeriesArchive_Cost check([Cost] >= 0.0 )
);
go


