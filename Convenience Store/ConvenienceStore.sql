use [master]
go
/*******************************************************************************
   Drop database if it exists
********************************************************************************/
IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'ConvenienceStore')
BEGIN
	ALTER DATABASE [ConvenienceStore] SET OFFLINE WITH ROLLBACK IMMEDIATE;
	ALTER DATABASE [ConvenienceStore] SET ONLINE;
	DROP DATABASE [ConvenienceStore];
END
GO

CREATE DATABASE [ConvenienceStore]
GO

USE [ConvenienceStore]
GO

/*******************************************************************************
	Drop tables if exists
*******************************************************************************/
DECLARE @sql nvarchar(MAX) 
SET @sql = N'' 

SELECT @sql = @sql + N'ALTER TABLE ' + QUOTENAME(KCU1.TABLE_SCHEMA) 
    + N'.' + QUOTENAME(KCU1.TABLE_NAME) 
    + N' DROP CONSTRAINT ' -- + QUOTENAME(rc.CONSTRAINT_SCHEMA)  + N'.'  -- not in MS-SQL
    + QUOTENAME(rc.CONSTRAINT_NAME) + N'; ' + CHAR(13) + CHAR(10) 
FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS AS RC 

INNER JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE AS KCU1 
    ON KCU1.CONSTRAINT_CATALOG = RC.CONSTRAINT_CATALOG  
    AND KCU1.CONSTRAINT_SCHEMA = RC.CONSTRAINT_SCHEMA 
    AND KCU1.CONSTRAINT_NAME = RC.CONSTRAINT_NAME 

EXECUTE(@sql) 

GO
DECLARE @sql2 NVARCHAR(max)=''

SELECT @sql2 += ' Drop table ' + QUOTENAME(TABLE_SCHEMA) + '.'+ QUOTENAME(TABLE_NAME) + '; '
FROM   INFORMATION_SCHEMA.TABLES
WHERE  TABLE_TYPE = 'BASE TABLE'

Exec Sp_executesql @sql2 
GO
create table [Account](
    accId int identity (1,1 ) PRIMARY KEY,
    accName varchar(1000) NOT NULL,
    accPass varchar(50) NOT NULL,
    accCreatedTime DATETIME NOT NULL,
    accDOB DATE NOT NULL,
    accPhone varchar(11) NOT NULL,
    accRole int  NOT NULL,
    accAddress varchar(1000),
);

GO

create table [Customer](
    cusId int identity (1,1) PRIMARY KEY,
    cusName varchar(1000) NOT NULL,
    cusGender int NOT NULL,
    cusDOB DATE NOT NULL,
    cusPhone varchar(11),
);

GO

Create table [Category](
	idCategory int identity(1,1) primary key,
	nameCateGory nvarchar(100) not null,

);
Go

create table [Merchandise](
    merId int identity (1,1) PRIMARY KEY,
    merName nvarchar (100) NOT NULL,
    merDescription nvarchar(2000) NOT NULL,
    merPrice float NOT NULL,
    merQuantity int NOT NULL,
    merUnit nvarchar(50),
	merIdCategory int not null,
	foreign key(merIdCategory) references Category(idCategory)


);

GO

create table [Provider](
    proId int identity (1,1 ) PRIMARY KEY,
    proName varchar(1000) NOT NULL,
    proGender int NOT NULL,
    proPhone varchar(11) NOT NULL,
    proDOB DATE NOT NULL,
);

GO

create table [ExportBill](
    exId int identity (1,1) PRIMARY KEY,
    exManager varchar(1000) NOT NULL,
    exDate DATETIME NOT NULL,
    accId int NOT NULL,
    cusId int NOT NULL,
    foreign key (accId) references [Account](accId),
    foreign key (cusId) references [Customer](cusId)
);

GO 

create table [ImportBill](
    imId int identity (1,1) PRIMARY KEY,
    imName varchar(1000) NOT NULL,
    imProvider varchar(1000) NOT NULL,
    imDate DATETIME NOT NULL,
    merId int NOT NULL,
    proId int NOT NULL,
    foreign key (merId) references [Merchandise](merId),
    foreign key (proId) references [Provider](proId),
);

GO



create table [Bill](
    billId int identity(1,1) PRIMARY KEY,
    billCreatedTime DATETIME NOT NULL,
    accId int NOT NULL,
    merId int NOT NULL,
    foreign key (accId) references [Account](accId),
    foreign key (merId) references [Merchandise](merId)
);

GO

create table [BillDetail](
    billDetailId int identity(1,1),
    billId int NOT NULL,
    merId int NOT NULL,
    billMerQuanity int NOT NULL,
    billMerPrice float NOT NULL,
    foreign key (billId) references [Bill](billId),
    foreign key (merId) references [Merchandise](merId)
);

GO

INSERT INTO Account (accName, accPass, accCreatedTime, accDOB, accPhone, accRole, accAddress)
VALUES
('Admin', '123', CURRENT_TIMESTAMP, '1990-01-01', '1234567890', 0, '123 Main St'),
('Bob Johnson', '123', '2020-01-02 13:00:00', '1995-05-05', '2345678901', 1, '456 Maple Ave'),
('Charlie Brown', '123', '2020-01-03 14:00:00', '1980-12-25', '3456789012', 1, '789 Oak St'),
('David Lee', '123', '2020-01-04 15:00:00', '1975-07-01', '4567890123', 1, '12 Elm St'),
('Emily Chen', '123', '2020-01-05 16:00:00', '2000-10-10', '5678901234', 1, '34 Pine Rd'),
('Frank Wang', '123', '2020-01-06 17:00:00', '1998-03-15', '6789012345', 1, '56 Cedar Ln'),
('Grace Kim', '123', '2020-01-07 18:00:00', '1985-06-30', '7890123456', 1, '78 Beech St'),
('Hannah Park', '123', '2020-01-08 19:00:00', '1992-09-20', '8901234567', 1, '90 Oakwood Ave'),
('Isaac Lee', '123', '2020-01-09 20:00:00', '1983-04-05', '9012345678', 1, '23 Maple Ct'),
('Jasmine Kim', '123', '2020-01-10 21:00:00', '1996-11-11', '0123456789', 1, '45 Pine St');

GO
INSERT INTO [Customer] (cusName, cusGender, cusDOB, cusPhone)
VALUES
('Alice Smith', 2, '1990-01-01', '1234567890'),
('Bob Johnson', 1, '1995-05-05', '2345678901'),
('Charlie Brown', 1, '1980-12-25', '3456789012'),
('David Lee', 2, '1975-07-01', '4567890123'),
('Emily Chen', 2, '2000-10-10', '5678901234'),
('Frank Wang', 1, '1998-03-15', '6789012345'),
('Grace Kim', 2, '1985-06-30', '7890123456'),
('Hannah Park', 2, '1992-09-20', '8901234567'),
('Isaac Lee', 1, '1983-04-05', '9012345678'),
('Jasmine Kim', 2, '1996-11-11', '0123456789');

GO

insert into [Category] (nameCategory)
values
('Snack,Candy'),		/*1*/
('Acoholic Drink'),		/*2*/
('Beverage'),			/*3*/
('Instant Food'),		/*4*/
('Personal Belongings'),/*5*/
('Medicine'),			/*6*/
('Milk'),				/*7*/
('Spices'),				/*8*/
('Cigarette'),			/*9*/
('Office Supplies'),	/*10*/
('Tissue'),				/*11*/
('Frozen Products'),	/*12*/
('Canned Food'),		/*13*/
('Chemicals - Cosmetics');/*14*/

go

INSERT INTO [Merchandise] (merName, merDescription, merPrice, merQuantity, merUnit, merIdCategory)
VALUES
(N'Snack Doritos', N'This is a description for Product A', 10.99, 100, 'pcs', 1),
(N'Cá hộp Thái', N'This is a description for Product B', 5.99, 50, 'pcs',13),
(N'Beer Tiger', N'This is a description for Product C', 19.99, 200, 'pcs',2),
(N'Nước gạo rang', N'This is a description for Product D', 7.49, 75, 'pcs',7),
(N'Sữa bột Ensure Gold', N'This is a description for Product E', 12.99, 150, 'pcs',7),
(N'Beer 333', N'This is a description for Product F', 3.99, 25, 'pcs',2),
(N'Bút bi',N'This is a description for Product G', 9.99, 80, 'pcs',10),
(N'Soju bưởi', N'This is a description for Product H', 15.49, 120, 'pcs',2),
(N'Muối Tiêu chanh Guyumi', N'This is a description for Product I', 22.99, 250, 'pcs',8),
(N'Bấm kim số 3', N'This is a description for Product J', 6.99, 40, 'pcs',10),
(N'Dầu tắm Ôliu', N'This is a description for Product I', 22.99, 250, 'pcs',14),
(N'ENCHANTEUR ST-C', N'This is a description for Product I', 22.99, 250, 'pcs',14),
(N'Bánh Bon sợi thịt gà', N'This is a description for Product I', 22.99, 250, 'pcs',1),
(N'Chả giò chay', N'This is a description for Product I', 22.99, 250, 'pcs',12),
(N'Cá hộp 3 cô gái', N'This is a description for Product I', 22.99, 250, 'pcs',13),
(N'Snack Poca', N'This is a description for Product I', 22.99, 250, 'pcs',1),
(N'Kem Celano ốc quế dâu', N'This is a description for Product I', 22.99, 250, 'pcs',12),
(N'Yakult', N'This is a description for Product I', 22.99, 250, 'pcs',7),
(N'Chocopile', N'This is a description for Product I', 22.99, 250, 'pcs',1),
(N'Kem tắm trắng da Scentio Doublo', N'This is a description for Product I', 22.99, 250, 'pcs',14),
(N'Snack Pringles', N'This is a description for Product I', 22.99, 250, 'pcs',1),
(N'Soju đào', N'This is a description for Product I', 22.99, 250, 'pcs',2),
(N'Kem Dưỡng Ẩm Toàn Thân Byphasse Moisturizing', N'This is a description for Product I', 22.99, 250, 'pcs',14),
(N'Bánh socola pie Oreo', N'This is a description for Product I', 22.99, 250, 'pcs',1),
(N'Snack Cheetos', N'This is a description for Product I', 22.99, 250, 'pcs',1),
(N'ALPERLIEBE SỮA', N'This is a description for Product I', 22.99, 250, 'pcs',1),
(N'Bánh DAISY', N'This is a description for Product I', 22.99, 250, 'pcs',1),
(N'Rượu gạo nho', N'This is a description for Product I', 22.99, 250, 'pcs',2),
(N'Cá ngừ sốt cay', N'This is a description for Product I', 22.99, 250, 'pcs',13),
(N'Bánh Danisa 200g', N'This is a description for Product I', 22.99, 250, 'pcs',1),
(N'Rượu vang Santiago', N'This is a description for Product I', 22.99, 250, 'pcs',2),
(N'Sữa TH True Milk', N'This is a description for Product I', 22.99, 250, 'pcs',7),
(N'Snack Lay’s Stax', N'This is a description for Product I', 22.99, 250, 'pcs',1),
(N'Vinamilk ít đường', N'This is a description for Product I', 22.99, 250, 'pcs',7),
(N'Cá xốt cà', N'This is a description for Product I', 22.99, 250, 'pcs',13),
(N'Grow Plus', N'This is a description for Product I', 22.99, 250, 'pcs',7),
(N'Bánh Custas kem trứng', N'This is a description for Product I', 22.99, 250, 'pcs',1),
(N'Bóp vải ', N'This is a description for Product I', 22.99, 250, 'pcs',10),
(N'Bánh đậu phộng Peanut', N'This is a description for Product I', 22.99, 250, 'pcs',1),
(N'Sữa milo', N'This is a description for Product I', 22.99, 250, 'pcs',7),
(N'Bánh gạo One One ', N'This is a description for Product I', 22.99, 250, 'pcs',1),	
(N'Sữa Ovaltine', N'This is a description for Product I', 22.99, 250, 'pcs',7),
(N'Bánh trứng tươi KARO', N'This is a description for Product I', 22.99, 250, 'pcs',1),
(N'Bút bi FO-036 mực đỏ', N'This is a description for Product I', 22.99, 250, 'pcs',10),
(N'Băng keo xóa ', N'This is a description for Product I', 22.99, 250, 'pcs',10),
(N'Bánh que Cosy', N'This is a description for Product I', 22.99, 250, 'pcs',1),
(N'Coca Cola', N'This is a description for Product I', 22.99, 250, 'pcs',3),
(N'Kem đánh răng', N'This is a description for Product I', 22.99, 250, 'pcs',5),
(N'Bàn chải', N'This is a description for Product I', 22.99, 250, 'pcs',5),
(N'Da cá chiên giòn', N'This is a description for Product I', 22.99, 250, 'pcs',4),
(N'Chỉ nha khoa', N'This is a description for Product I', 22.99, 250, 'pcs',5),
(N'Condom', N'This is a description for Product I', 22.99, 250, 'pcs',5),
(N'Panadol', N'This is a description for Product I', 22.99, 250, 'pcs',6),
(N'Thuốc đau dạ dày', N'This is a description for Product I', 22.99, 250, 'pcs',6),
(N'Đường tinh luyện', N'This is a description for Product I', 22.99, 250, 'pcs',8),
(N'Sa tế hũ', N'This is a description for Product I', 22.99, 250, 'pcs',8),
(N'Hạt nêm', N'This is a description for Product I', 22.99, 250, 'pcs',8),
(N'Bột ngọt', N'This is a description for Product I', 22.99, 250, 'pcs',8),
(N'Muối Iot', N'This is a description for Product I', 22.99, 250, 'pcs',8),
(N'Bình giữ nhiệt', N'This is a description for Product I', 22.99, 250, 'pcs',5),
(N'Dao cạo râu', N'This is a description for Product I', 22.99, 250, 'pcs',5),
(N'Bánh que Cosy', N'This is a description for Product I', 22.99, 250, 'pcs',1),
(N'Rong biển', N'This is a description for Product I', 22.99, 250, 'pcs',4),
(N'Redbull', N'This is a description for Product I', 22.99, 250, 'pcs',3),
(N'Xúc xích xiên', N'This is a description for Product I', 22.99, 250, 'pcs',4),
(N'Bánh que Cosy', N'This is a description for Product I', 22.99, 250, 'pcs',1),
(N'Cơm hộp Dosirak', N'This is a description for Product I', 22.99, 250, 'pcs',4),
(N'Monster Energy ', N'This is a description for Product I', 22.99, 250, 'pcs',3),
(N'Sprite', N'This is a description for Product I', 22.99, 250, 'pcs',3),
(N'Cơm nắm', N'This is a description for Product I', 22.99, 250, 'pcs',4),
(N'Bánh que Cosy', N'This is a description for Product I', 22.99, 250, 'pcs',1),
(N'Mì ly Hảo Hảo', N'This is a description for Product I', 22.99, 250, 'pcs',4),
(N'Pepsi', N'This is a description for Product I', 22.99, 250, 'pcs',3),
(N'Demi', N'This is a description for Product I', 22.99, 250, 'pcs',9),
(N'Sài gòn bạc', N'This is a description for Product I', 22.99, 250, 'pcs',9),
(N'555',N'This is a description for Product I', 22.99, 250, 'pcs',9),
(N'Jet', N'This is a description for Product I', 22.99, 250, 'pcs',9),
(N'Giấy Puri', N'This is a description for Product I', 22.99, 250, 'pcs',11),
(N'Giấy Pulppy', N'This is a description for Product I', 22.99, 250, 'pcs',11),
(N'Giấy Elene', N'This is a description for Product I', 22.99, 250, 'pcs',11),
(N'Giấy tempo', N'This is a description for Product I', 22.99, 250, 'pcs',11),
(N'Bánh xếp CJ nhân thịt và bắp', N'This is a description for Product I', 22.99, 250, 'pcs',12),
(N'Cá viên La cusina', N'This is a description for Product I', 22.99, 250, 'pcs',12),
(N'Chả lụa quết Cầu Tre', N'This is a description for Product I', 22.99, 250, 'pcs',12),
(N'Gà viên lá chanh SG', N'This is a description for Product I', 22.99, 250, 'pcs',12),
(N'Cá Saba Tiêu xanh', N'This is a description for Product I', 22.99, 250, 'pcs',12),
(N'Kim chi cải thảo cắt lát', N'This is a description for Product I', 22.99, 250, 'pcs',12),
(N'Bột giặt Omo', N'This is a description for Product I', 22.99, 250, 'pcs',14),
(N'Vim', N'This is a description for Product I', 22.99, 250, 'pcs',14),
(N'Nước rửa chén sunlight', N'This is a description for Product I', 22.99, 250, 'pcs',14),
(N'Chà xoong nồi SUN BRITE', N'This is a description for Product I', 22.99, 250, 'pcs',14),
(N'Nước lau kính CIF', N'This is a description for Product I', 22.99, 250, 'pcs',14),
(N'Sữa đặc Ngôi sao', N'This is a description for Product J', 6.99, 40, 'pcs',7);

GO

INSERT INTO [Provider] (proName, proGender, proPhone, proDOB)
VALUES
('John Smith', 1, '1234567890', '1980-01-01'),
('Mary Johnson', 2, '2345678901', '1985-05-05'),
('Peter Brown', 1, '3456789012', '1990-12-25'),
('Sarah Lee', 2, '4567890123', '1975-07-01'),
('Kevin Chen', 1, '5678901234', '1995-10-10'),
('Jane Wang', 2, '6789012345', '1998-03-15'),
('Tom Kim', 1, '7890123456', '1980-06-30'),
('Lucy Park', 2, '8901234567', '1992-09-20'),
('Steven Lee', 1, '9012345678', '1983-04-05'),
('Linda Kim', 2, '0123456789', '1996-11-11');

GO

INSERT INTO [ExportBill] (exManager, exDate, accId, cusId)
VALUES
('John Doe', '2022-05-01 12:00:00', 1, 1),
('Bob Johnson', '2022-05-02 13:00:00', 2, 2),
('Charlie Brown', '2022-05-03 14:00:00', 3, 3),
('David Lee', '2022-05-04 15:00:00', 1, 4),
('Emily Chen', '2022-05-05 16:00:00', 2, 5),
('Frank Wang', '2022-05-06 17:00:00', 3, 6),
('Grace Kim', '2022-05-07 18:00:00', 1, 7),
('Hannah Park', '2022-05-08 19:00:00', 2, 8),
('Isaac Lee', '2022-05-09 20:00:00', 3, 9),
('Jasmine Kim', '2022-05-10 21:00:00', 1, 10);

GO

INSERT INTO [ImportBill] (imName, imProvider, imDate, merId, proId)
VALUES
('Product A', 'Provider 1', '2022-06-01 12:00:00', 1, 1),
('Product B', 'Provider 2', '2022-06-02 13:00:00', 2, 2),
('Product C', 'Provider 3', '2022-06-03 14:00:00', 3, 3),
('Product D', 'Provider 4', '2022-06-04 15:00:00', 4, 4),
('Product E', 'Provider 5', '2022-06-05 16:00:00', 5, 5),
('Product F', 'Provider 6', '2022-06-06 17:00:00', 6, 6),
('Product G', 'Provider 7', '2022-06-07 18:00:00', 7, 7),
('Product H', 'Provider 8', '2022-06-08 19:00:00', 8, 8),
('Product I', 'Provider 9', '2022-06-09 20:00:00', 9, 9),
('Product J', 'Provider 10', '2022-06-10 21:00:00', 10, 10);

GO

INSERT INTO [Bill] (billCreatedTime, accId, merId)
VALUES
('2022-06-01 12:00:00', 1, 1),
('2022-06-02 13:00:00', 1, 2),
('2022-06-03 14:00:00', 1, 3),
('2022-06-04 15:00:00', 2, 4),
('2022-06-05 16:00:00', 2, 5),
('2022-06-06 17:00:00', 2, 6),
('2022-06-07 18:00:00', 3, 7),
('2022-06-08 19:00:00', 3, 8),
('2022-06-09 20:00:00', 3, 9),
('2022-06-10 21:00:00', 1, 10);

GO

INSERT INTO [BillDetail] (billId, merId, billMerQuanity, billMerPrice)
VALUES
(1, 1, 10, 100.0),
(1, 2, 5, 50.0),
(2, 3, 20, 200.0),
(2, 4, 15, 150.0),
(3, 5, 30, 300.0),
(3, 6, 25, 250.0),
(4, 7, 40, 400.0),
(4, 8, 35, 350.0);
