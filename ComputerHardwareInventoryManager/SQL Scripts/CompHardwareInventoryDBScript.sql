use master
go


Drop Database if exists CompHardwareInventory 
go


Create Database CompHardwareInventory
go

use CompHardwareInventory
go

Create table HardwareProducts
(
	ProductId		int				Primary Key Identity,
	Price			smallmoney		not null,
	Manufacturer	varchar(60)		not null,
	Title			varchar(60)		not null,
	Description		varchar(150)	not null,
)
go

