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

Insert into HardwareProducts (Price, Manufacturer, Title, Description)
Values (200, 'AMD', 'Ryzen 5 2600', 'Processor')

Insert into HardwareProducts (Price, Manufacturer, Title, Description)
Values (189.99, 'Nvidia', 'Geforce RTX 2800', 'GPU')

Insert into HardwareProducts (Price, Manufacturer, Title, Description)
Values (21.95, 'Microsoft', 'P22 Keyboard', 'A mechanical style keyboard ...')

go

