--PART 1

--create table [Countries](
--	[ID] int not null identity(1,1),
--	[Name] nvarchar(100) not null,

--	constraint PK_Countries_ID primary key([ID]),
--	constraint CK_Countries_Name check([Name] <> '')
--);


--create table [Cities] (
--	[ID] int not null identity(1,1),
--	[Name] nvarchar(100) not null,

--	[CountryID] int not null,

--	constraint PK_Cities_ID primary key([ID]),
--	constraint CK_Cities_Name check([Name] <> ''),
--	constraint FK_Cities_CountryID foreign key([CountryID]) references [Countries]([ID])
--);


--create table [Sections](
--	[ID] int not null identity(1,1),
--	[Name] nvarchar(100) not null,

--	constraint PK_Sections_ID primary key([ID]),
--	constraint CK_Sections_Name check([Name] <> '')
--);


--create table [Customers] (
--	[ID] int not null identity(1,1),
--	[Name] nvarchar(100) not null,
--	[Surname] nvarchar(100) not null,
--	[Patronymic] nvarchar(100) not null,
--	[Birth] date,
--	[Gender] varchar(6),
--	[Email] varchar(256),
--	[CityID] int,

--	constraint PK_Customers_ID primary key([ID]),
--	constraint CK_Customers_Name check([Name] <> ''),
--	constraint CK_Customers_Surname check([Surname] <> ''),
--	constraint CK_Customers_Patronymic check([Patronymic] <> ''),
--	constraint CK_Customers_Birth check([Birth] < getdate()),
--	constraint CK_Customers_Gender check([Gender] in ('Male', 'Female', 'Other')),
--	constraint CK_Customers_Email check([Email] <> ''),
--	constraint FK_Customers_CityID foreign key([CityID]) references [Cities]([ID])
--);


--create table [CustomersSections](
--	[CustomerID] int not null,
--	[SectionID] int not null,

--	constraint PK_CustomersSections primary key([CustomerID], [SectionID]),
--	constraint FK_CustomersSections_CustomerID foreign key([CustomerID]) references [Customers]([ID]),
--	constraint FK_CustomersSections_SectionID foreign key([SectionID]) references [Sections]([ID])
--);


--create table [Shares](
--	[ID] int not null identity(1,1),
--	[Name] nvarchar(150) not null,
--	[CountryID] int not null,
--	[DateStart] date not null,
--	[DateEnd] date not null,


--	constraint PK_Shares_ID primary key([ID]),
--	constraint CK_Shares_Name check([Name] <> ''),
--	constraint FK_Shares_CountryID foreign key([CountryID]) references [Countries]([ID])
--);


--create table [Products](
--	[ID] int not null identity(1,1),
--	[Name] nvarchar(150) not null,
--	[Price] money not null,
--	[SectionID] int not null,
--	[ShareID] int,

--	constraint PK_Products_ID primary key([ID]),
--	constraint CK_Products_Name check([Name] <> ''),
--	constraint FK_Products_SectionID foreign key([SectionID]) references [Sections]([ID]),
--	constraint FK_Products_ShareID foreign key([ShareID]) references [Shares]([ID])
--);


--create table [CustomersProducts](
--	[CustomerID] int not null,
--	[ProductID] int not null,
--	[PurchaseDate] date not null,

--	constraint PK_CustomersProducts primary key([CustomerID], [ProductID]),
--	constraint FK_CustomersProducts_CustomerID foreign key([CustomerID]) references [Customers]([ID]),
--	constraint FK_CustomersProducts_ProductID foreign key([ProductID]) references [Products]([ID])
--);




--Task 3
/* 1.)
alter function GetAllCustomers()
returns table
as
	return(
		select
			C.[Name],
			C.[Surname],
			C.[Patronymic],
			C.[Email],
			C.[Gender],
			C.[Birth],
			Ci.[Name] as [City],
			Co.[Name] as [Country]
		from [Customers] as C
		join [Cities] as Ci on C.[CityID] = Ci.[ID]
		join [Countries] as Co on Ci.[CountryID] = Co.[ID]
	);
*/

/* 2.)
create function GetAllCustomersEmails()
returns table
as
	return(
		select [Name], [Surname], [Email]
		from [Customers]
	);
*/


/* 3.)
create function GetAllSections()
returns table
as
	return(
		select *
		from [Sections]
	);
*/


/* 4.)
alter function GetAllSharesProducts()
returns table
as
	return(
		select
			P.[Name] as [Product Name],
			P.[Price],
			S.[Name] as [Section]
		from 
			[Products] as P join [Sections] as S on
			P.[SectionID] = S.[ID]
		where 
			[ShareID] is not null
	);
*/


/* 5.)
alter function GetAllCities()
returns table
as
	return(
		select [Name]
		from [Cities]
	);
*/


/* 6.)
create function GetAllCountries()
returns table
as
	return(
		select [Name]
		from [Countries]
	);
*/


--Task 4
/* 1.)
create function GetAllCustomersByCity(@city nvarchar(100))
returns table
as
	return (
		select
			Cust.[Name],
			Cust.[Surname],
			Cust.[Patronymic],
			Cust.[Birth],
			Cust.[Gender],
			Cust.[Email]
		from
			[Customers] as Cust join [Cities] as Cit on
			Cust.[CityID] = Cit.[ID]
		where
			Cit.[Name] = @city
	);
*/


/* 2.)
create function GetAllCustomersByCountry(@country nvarchar(100))
returns table
as
	return (
		select
			Cust.[Name],
			Cust.[Surname],
			Cust.[Patronymic],
			Cust.[Birth],
			Cust.[Gender],
			Cust.[Email]
		from
			[Customers] as Cust join [Cities] as Cit on
			Cust.[CityID] = Cit.[ID]

			join [Countries] as Coun on
			Cit.[CountryID] = Coun.[ID]
		where
			Coun.[Name] = @country
	);
*/


/* 3.)
create function GetAllSharesByCountry(@country nvarchar(100))
returns table
as
	return (
		select
			S.[Name] as [Share Name],
			S.[DateStart] as [Date Start],
			S.[DateEnd] as [Date End]
		from
			[Shares] as S join [Countries] as C on
			S.[CountryID] = C.[ID]
		where
			C.[Name] = @country
	);
*/


--PART 2

--Task 1
-- 1.)
--create function GetCountCustomersInEachCity()
--returns table
--as
--	return (
--		select
--			Cit.[Name] as [City],
--			Count(Cust.[ID]) as [Count Customers]
--		from
--			[Customers] as Cust join [Cities] as Cit on
--			Cust.[CityID] = Cit.[ID]
--		group by
--			Cit.[Name]
--	);


-- 2.)
--create function GetCountCustomersInEachCountry()
--returns table
--as
--	return (
--		select
--			Coun.[Name] as [Country],
--			Count(Cust.[ID]) as [Count Customers]
--		from
--			[Customers] as Cust join [Cities] as Cit on
--			Cust.[CityID] = Cit.[ID]

--			join [Countries] as Coun on 
--			Cit.[CountryID] = Coun.[ID]
--		group by
--			Coun.[Name]
--	);


-- 3.)
--create function GetCountCitiesInEachCountry()
--returns table
--as
--	return (
--		select
--			Coun.[Name] as [Country],
--			Count(Cit.[ID]) as [Count Cities]
--		from
--			[Cities] as Cit join [Countries] as Coun on
--			Cit.[CountryID] = Coun.[ID]
--		group by
--			Coun.[Name]
--	);


-- 4.)
--create function GetAverageCountOfCitiesByAllCountry()
--returns @resTable table([Avg] int)
--as
--begin
--	declare @table table ([Country] nvarchar(100), [Count] int);
	
--	insert into @table
--	select distinct
--		Coun.[Name] as [Country],
--		Count(Cit.[ID]) as [Count Cities]
--	from
--		[Cities] as Cit join [Countries] as Coun on
--		Cit.[CountryID] = Coun.[ID]
--	group by
--		Coun.[Name];

--	insert into @resTable
--	select
--		Avg([Count])
--	from
--		@table

--	return
--end


--Task 2

-- 1.)
--create function GetSectionsCertCustomersFromCertCountryInterested(@country nvarchar(100), @buyer_email nvarchar(256))
--returns table
--as
--	return (
--		select
--			S.[Name] as [Section Name]
--		from
--			[Sections] as S
--			join [CustomersSections] as CS on S.[ID] = CS.[SectionID]
--			join [Customers] as C on CS.[CustomerID] = C.[ID]
--			join [Cities] as CT on C.[CityID] = CT.[ID]
--			join [Countries] as CO on CT.[CountryID] = CO.[ID]
--		where
--			CO.[Name] = @country and C.[Email] = @buyer_email
--	);


-- 2.)
--create function GetSharesProductsCertSectionInRangeDate(@section nvarchar(100), @startDate date, @endDate date)
--returns table
--as
--	return (
--		select
--			P.[Name] as [Shares Products],
--			P.[Price],
--			Sc.[Name] as [Section],
--			Sh.[Name] as [Share name],
--			Sh.[DateStart],
--			Sh.[DateEnd]
--		from
--			[Products] as P
--			join [Sections] as Sc on P.[SectionID] = Sc.[ID]
--			join [Shares] as Sh on P.[ShareID] = Sh.[ID]
--		where
--			Sc.[Name] = @section
--			and Sh.[DateStart] >= @startDate
--			and Sh.[DateEnd] <= @endDate
--	);


-- 3.)
--create function GetSharesProductsCertCustomer(@buyer_email nvarchar(256))
--returns table
--as
--	return (
--		select
--			P.[Name] as [Shares Products],
--			P.[Price],
--			S.[Name] as [Section],
--			S.[Name] as [Share name],
--			S.[DateStart],
--			S.[DateEnd]
--		from
--			[Products] as P
--			join [Shares] as S on P.[ShareID] = S.[ID]
--			join [CustomersProducts] as CP on CP.[ProductID] = P.[ID]
--			join [Customers] as C on CP.[CustomerID] = C.[ID]
--		where
--			C.[Email] = @buyer_email
--	);


--Task 3

-- 1.)
--create function GetTop3CountryByCountOfCustomers()
--returns table
--as
--	return(
--		select top 3
--			C.[Name] as [Country],
--			Count(*) as [CustomerCount]
--		from
--			[Customers] as Cust
--			join [Cities] as Ct on Cust.[CityID] = Ct.[ID]
--			join [Countries] as C on Ct.[CountryID] = C.[ID]
--		group by
--			C.[Name]
--		order by
--			CustomerCount desc
--	);


-- 2.)
--create function GetTop1CountryByCountOfCustomers()
--returns table
--as
--	return (
--		select top 1
--			Coun.[Name] as [Country],
--			Count(Cust.[ID]) as [CountOfCustomers]
--		from
--			[Customers] as Cust 
--			join [Cities] as Cit on Cust.[CityID] = Cit.[ID]
--			join [Countries] as Coun on Cit.[CountryID] = Coun.[ID]
--		group by
--			Coun.[Name]
--		order by [CountOfCustomers] desc
--	);


-- 3.)
--create function GetTop3CityByCountOfCustomers()
--returns table
--as
--	return (
--		select top 3
--			Cit.[Name] as [City],
--			Count(Cust.[ID]) as [CountOfCustomers]
--		from
--			[Customers] as Cust join [Cities] as Cit on
--			Cust.[CityID] = Cit.[ID]
--		group by
--			Cit.[Name]
--		order by [CountOfCustomers] desc
--	);


-- 4.)
--create function GetTop1CityByCountOfCustomers()
--returns table
--as
--	return(
--		select top 1
--			C.[Name] as [City],
--			Count(Cu.[ID]) as [Count Of Customers]
--		from
--			[Customers] as Cu 
--			join [Cities] as C on Cu.[CityID] = C.[ID]
--		group by
--			C.[Name]
--		order by
--			[Count Of Customers] desc
--	);