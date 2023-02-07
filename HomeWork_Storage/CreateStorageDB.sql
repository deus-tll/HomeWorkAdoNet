use [master];
go

if db_id('StorageDB') is not null
begin
	drop database [StorageDB];
end
go

create database [StorageDB];
go

use [StorageDB];
go


create table [Types](
	[ID] int not null identity(1,1),
	[Name] nvarchar(max) not null,

	constraint PK_Types_ID primary key([ID]),
	constraint CK_Types_Name check([Name] <> '')
);
go

create table [Providers](
	[ID] int not null identity(1,1),
	[Name] nvarchar(max) not null,
	[Address] nvarchar(max),

	constraint PK_Providers_ID primary key([ID]),
	constraint CK_Providers_Name check([Name] <> ''),
	constraint CK_Providers_Address check([Address] <> '')
);
go

create table [Products](
	[ID] int not null identity(1,1),
	[Name] nvarchar(max) not null,
	[TypeID] int,
	[ProviderID] int,
	[InStock] smallint not null default(1),
	[CostPrice] money not null default(0.0),
	[DeliveryDate] date default(GetDate()),

	constraint PK_Products_ID primary key([ID]),
	constraint CK_Products_Name check([Name] <> ''),
	constraint FK_Prodcts_TypeID foreign key([TypeID]) references [Types]([ID]),
	constraint FK_Prodcts_ProviderID foreign key([ProviderID]) references [Providers]([ID]),
	constraint CK_Products_InStock check([InStock] > 0),
	constraint CK_Products_CostPrice check([CostPrice] > 0.0),
	constraint CK_Products_DeliveryDate check([DeliveryDate] < GetDate())
);
go