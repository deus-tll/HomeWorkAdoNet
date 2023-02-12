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