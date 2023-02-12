use [StationeryCompanyDB];
go

--1.)
--create function ManagersWithMostSalesByNumberOfUnits()
--returns @resTable table([Manager`s Name] nvarchar(150), [Manager`s Surname] nvarchar(150))
--as
--begin
--	declare @maxCountOfSoldUnits int;
--	declare @table table([ManagerName] nvarchar(150), [ManagerSurname] nvarchar(150), [CountOfSoldUnits] int)

--	insert into @table
--	select M.[Name], M.[Surname], Sum(S.[Offtake]) as [CountOfSoldUnits]
--	from [Sales] as S join [Managers] as M on S.[ManagerID] = M.[ID]
--	group by M.[Name], M.[Surname];

--	select @maxCountOfSoldUnits = Max([CountOfSoldUnits])
--	from @table

--	insert into @resTable
--	select [ManagerName], [ManagerSurname]
--	from @table
--	where @maxCountOfSoldUnits = [CountOfSoldUnits]

--	return
--end


--2.)
--create function ManagersWithMostSalesByHighestTotalProfit()
--returns @resTable table([Manager`s Name] nvarchar(150), [Manager`s Surname] nvarchar(150))
--as
--begin
--	declare @highestTotalProfit money;
--	declare @table table([ManagerName] nvarchar(150), [ManagerSurname] nvarchar(150), [HighestTotalProfit] money)

--	insert into @table
--	select M.[Name], M.[Surname], Sum(S.[PricePerUnit] * S.[Offtake]) as [HighestTotalProfit]
--	from [Sales] as S join [Managers] as M on S.[ManagerID] = M.[ID]
--	group by M.[Name], M.[Surname]

--	select @highestTotalProfit = Max([HighestTotalProfit])
--	from @table

--	insert into @resTable
--	select [ManagerName], [ManagerSurname]
--	from @table
--	where @highestTotalProfit = [HighestTotalProfit]

--	return
--end


--3.)
--create function ManagersWithMostSalesByHighestTotalProfitInRangeDate(@startDate date, @endDate date)
--returns @resTable table([Manager`s Name] nvarchar(150), [Manager`s Surname] nvarchar(150))
--as
--begin
--	declare @highestTotalProfit int;
--	declare @table table([ManagerName] nvarchar(150), [ManagerSurname] nvarchar(150), [HighestTotalProfit] int)

--	insert into @table
--	select M.[Name], M.[Surname], Sum(S.[PricePerUnit] * S.[Offtake]) as [HighestTotalProfit]
--	from [Sales] as S join [Managers] as M on S.[ManagerID] = M.[ID]
--	where S.[DateOfSale] between @startDate and @endDate or
--		  S.[DateOfSale] between @endDate and @startDate
--	group by M.[Name], M.[Surname]

--	select @highestTotalProfit = Max([HighestTotalProfit])
--	from @table

--	insert into @resTable
--	select [ManagerName], [ManagerSurname]
--	from @table
--	where @highestTotalProfit = [HighestTotalProfit]

--	return
--end




--4.)
--alter function BuyerCompaniesPurchaseWithLargestAmount()
--returns @resTable table([BuyerCompany`s Name] nvarchar(300), [BuyerCompany`s Address] nvarchar(300))
--as
--begin
--	declare @largestAmount money;
--	declare @table table([BuyerCompanyName] nvarchar(150), [BuyerCompanyAddress] nvarchar(150), [LargestAmount] money)

--	insert into @table
--	select BC.[Name], BC.[Address], Sum(S.[PricePerUnit] * S.[Offtake]) as [LargestAmount]
--	from [Sales] as S join [BuyerCompanies] as BC on S.[BuyerCompanyID] = BC.[ID]
--	group by BC.[Name], BC.[Address]

--	select @largestAmount = Max([LargestAmount])
--	from @table

--	insert into @resTable
--	select [BuyerCompanyName], [BuyerCompanyAddress]
--	from @table
--	where @largestAmount = [LargestAmount]

--	return
--end


--5.)
--create function TypeStationeryWithMostSalesByNumberOfSales()
--returns @resTable table([Type`s Name] nvarchar(150), [Number Of Stationery] int)
--as
--begin
--	declare @maxCountOfSales int;
--	declare @table table([TypeName] nvarchar(150), [NumberOfStationery] int, [CountOfSales] int)

--	insert into @table
--	select T.[Name], T.[NumberOfStationery], Count(S.[ID]) as [CountOfSales]
--	from [Sales] as S join [Stationeries] as St on S.[Name] = St.[Name]
--					  join [Types] as T on St.[TypeID] = T.[ID]
--	group by T.[Name], T.[NumberOfStationery];

--	select @maxCountOfSales = Max([CountOfSales])
--	from @table

--	insert into @resTable
--	select [TypeName] , [NumberOfStationery]
--	from @table
--	where @maxCountOfSales = [CountOfSales]

--	return
--end


--6.)
--create function TypeStationeryWithMostProfitableStationeries()
--returns @resTable table([Type`s Name] nvarchar(150), [Number Of Stationery] int)
--as
--begin
--	declare @mostProfitableStationery money;
--	declare @table table([TypeName] nvarchar(150), [NumberOfStationery] int, [ProfitableStationery] money)

--	insert into @table
--	select T.[Name], T.[NumberOfStationery], Sum(S.[PricePerUnit] * S.[Offtake]) as [MostProfitableStationery]
--	from [Sales] as S join [Stationeries] as St on S.[Name] = St.[Name]
--					  join [Types] as T on St.[TypeID] = T.[ID]
--	group by T.[Name], T.[NumberOfStationery];

--	select @mostProfitableStationery = Max([MostProfitableStationery])
--	from @table

--	insert into @resTable
--	select [TypeName] , [NumberOfStationery]
--	from @table
--	where @mostProfitableStationery = [MostProfitableStationery]

--	return
--end


--7.)
--create function MostPopularStationeries()
--returns @resTable table([Stationery Name] nvarchar(300))
--as
--begin
--	declare @mostSoldUnits int;
--	declare @table table([StationeryName] nvarchar(300), [SoldUnits] int)

--	insert into @table
--	select S.[Name], Sum(S.[Offtake]) as [SoldUnits]
--	from [Sales] as S
--	group by S.[Name]

--	select @mostSoldUnits = Max([SoldUnits])
--	from @table

--	insert into @resTable
--	select [StationeryName]
--	from @table
--	where @mostSoldUnits = [SoldUnits]

--	return
--end


--8.)
--create function StationeriesThatNotSoldInSpecCountOfDays(@countOfDays int)
--returns @resTable table([Stationery Name] nvarchar(300))
--as
--begin
--	declare @table table([StationeryName] nvarchar(300));

--	insert into @table
--	select [Name]
--	from [Sales]
--	where DateDiff(day, [DateOfSale], GetDate()) <= @countOfDays

--	insert into @resTable
--	select [Name]
--	from [Stationeries]
--	where [Name] <> all (select [StationeryName] from @table);

--	return
--end



--insert into [Managers] values('ManagerName1', 'ManagerSurname1');
--insert into [Managers] values('ManagerName2', 'ManagerSurname2');
--insert into [Managers] values('ManagerName3', 'ManagerSurname3');
--insert into [Managers] values('ManagerName4', 'ManagerSurname4');

--insert into [BuyerCompanies] values('BuyerCompany1', 'Address1');
--insert into [BuyerCompanies] values('BuyerCompany2', 'Address2');
--insert into [BuyerCompanies] values('BuyerCompany3', 'Address3');

--insert into [Types]([Name]) values('Type1');
--insert into [Types]([Name]) values('Type2');
--insert into [Types]([Name]) values('Type3');
--insert into [Types]([Name]) values('Type4');

--insert into [Stationeries] values('Stationery1', 345, 30, 400, 1);
--insert into [Stationeries] values('Stationery2', 500, 25, 600, 2);
--insert into [Stationeries] values('Stationery3', 111, 27, 200, 4);
--insert into [Stationeries] values('Stationery4', 236.97, 26, 300, 3);
--insert into [Stationeries] values('Stationery5', 229, 32, 300, 2);
--insert into [Stationeries] values('Stationery6', 443.10, 15, 500, 3);
--insert into [Stationeries] values('Stationery7', 299, 29, 300, 2);
--insert into [Stationeries] values('Stationery8', 793, 31, 850, 1);
--insert into [Stationeries] values('Stationery9', 45, 19, 120, 1);
--insert into [Stationeries] values('Stationery10', 1200, 20, 2000, 3);
--insert into [Stationeries] values('Stationery11', 3048, 18, 4000, 4);

--insert into [Sales] values('Stationery1', '2022-12-13', 3, 345, 1, 1);
--insert into [Sales] values('Stationery3', '2022-12-15', 5, 111, 3, 3);
--insert into [Sales] values('Stationery2', '2022-12-16', 2, 500,	2, 2);
--insert into [Sales] values('Stationery7', '2022-12-17', 4, 299,	4, 2);
--insert into [Sales] values('Stationery1', '2022-12-20', 6, 345, 4, 3);
--insert into [Sales] values('Stationery10', '2022-12-23', 7, 1200, 3, 1);
--insert into [Sales] values('Stationery3', '2022-12-28', 5, 111, 2, 1);
--insert into [Sales] values('Stationery4', '2022-12-31', 9, 236.97, 2, 2);
--insert into [Sales] values('Stationery6', '2023-01-03', 6, 443.10, 3, 1);
--insert into [Sales] values('Stationery8', '2023-01-05', 3, 793, 1, 3);
--insert into [Sales] values('Stationery9', '2023-01-09', 2, 45, 1, 2);
--insert into [Sales] values('Stationery11', '2023-01-11', 1, 3048, 4, 1);
--insert into [Sales] values('Stationery5', '2023-01-17', 5, 229, 3, 2);
--insert into [Sales] values('Stationery9', '2023-01-20', 2, 45, 4, 1);
--insert into [Sales] values('Stationery1', '2023-02-01', 1, 345, 2, 3);
--insert into [Sales] values('Stationery11', '2023-02-05', 3, 3048, 1, 1);
--insert into [Sales] values('Stationery7', '2023-02-10', 1, 299, 2, 3);