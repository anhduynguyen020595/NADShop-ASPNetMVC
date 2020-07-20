create database DuyShop

use DuyShop

create table ProductCategories
(
	ID int identity(1,1) not null primary key,
	[Name] nvarchar(250) not null,
	Alias varchar(250) not null,
	[Description] nvarchar(500),
	ParentID int,
	DisplayOrder int,
	[Image] nvarchar(500),
	MetaKeyword nvarchar(250),
	MetaDescription nvarchar(250),
	CreatedDate datetime,
	CreatedBy varchar(50),
	UpdatedDate datetime,
	UpdatedBy varchar(50),
	[Status] bit not null,
	HomeFlag bit
)

create table Products
(
	ID int identity(1,1) not null primary key,
	[Name] nvarchar(250) not null,
	Alias varchar(250) not null,
	CategoryID int foreign key references ProductCategories(ID),
	DisplayOrder int,
	Price decimal(18,2) not null,
	Promotion decimal(18,2),
	Warranty int, 
	[Description] nvarchar(500),
	Content nvarchar(max),
	MoreImages xml,
	[Image] nvarchar(500),
	MetaKeyword nvarchar(250),
	MetaDescription nvarchar(250),
	CreatedDate datetime,
	CreatedBy varchar(50),
	UpdatedDate datetime,
	UpdatedBy varchar(50),
	[Status] bit not null,
	HomeFlag bit,
	HotFlag bit,
	ViewCount int
)

create table PostCategories
(
	ID int identity(1,1) not null primary key,
	[Name] nvarchar(250) not null,
	Alias varchar(250) not null,
	[Description] nvarchar(500),
	ParentID int,
	DisplayOrder int,
	[Image] nvarchar(500),
	MetaKeyword nvarchar(250),
	MetaDescription nvarchar(250),
	CreatedDate datetime,
	CreatedBy varchar(50),
	UpdatedDate datetime,
	UpdatedBy varchar(50),
	[Status] bit not null,
	HomeFlag bit
)

create table Posts
(
	ID int identity(1,1) not null primary key,
	[Name] nvarchar(250) not null,
	Alias varchar(250) not null,
	CategoryID int foreign key references PostCategories(ID),
	DisplayOrder int, 
	[Description] nvarchar(500),
	Content nvarchar(max),
	[Image] nvarchar(500),
	MetaKeyword nvarchar(250),
	MetaDescription nvarchar(250),
	CreatedDate datetime,
	CreatedBy varchar(50),
	UpdatedDate datetime,
	UpdatedBy varchar(50),
	[Status] bit not null,
	HomeFlag bit,
	HotFlag bit,
	ViewCount int
)

create table Tags
(
	ID varchar(50) not null primary key,
	[Name] nvarchar(50),
	[Type] varchar(50),
)

create table ProductTags
(
	ProductID int not null foreign key references Products(ID),
	TagID varchar(50) not null foreign key references Tags(ID)

	primary key (ProductID, TagID)
)

create table PostTags
(
	PostID int not null foreign key references Posts(ID),
	TagID varchar(50) not null foreign key references Tags(ID)

	primary key (PostID, TagID)
)


create table Orders
(
	ID int identity(1,1) not null primary key,
	CustomerName nvarchar(250) not null,
	CustomerAddress nvarchar(250) not null,
	CustomerEmail nvarchar(250) not null,
	CustomerMobile varchar(50) not null,
	CustomerMessage nvarchar(250),
	CreatedDate datetime,
	CreatedBy varchar(50),
	PaymentMethod nvarchar(250),
	PaymentStatus nvarchar(50) not null,
	UpdatedDate datetime,
	UpdatedBy varchar(50),
	[Status] bit not null,
)


create table OrderDetails
(
	OrderID int not null foreign key references Orders(ID),
	ProductID int not null foreign key references Products(ID),
	Quantity int not null,
	
	primary key(OrderID, ProductID)
)

create table Menus
(
	ID int identity(1,1) not null primary key,
	[Name] nvarchar(250),
	[URL] nvarchar(500),
	DisplayOrder int,
	GroupID int,
	[Target] varchar(10),
	[Status] bit
)

create table MenuGroups
(
	ID int identity(1,1) not null primary key,
	[Name] nvarchar(250)
)

create table Slides
(
	ID int identity(1,1) not null primary key,
	[Name] nvarchar(50) not null,
	[Description] nvarchar(250),
	[Image] nvarchar(500) not null,
	[URL] nvarchar(500) not null,
	DisplayOrder int,
	[Status] bit not null
)

create table Footers
(
	ID varchar(250) not null primary key,
	[Content] nvarchar(max)
)

create table Pages
(
	ID int identity(1,1) not null primary key,
	[Name] nvarchar(250),
	[Content] nvarchar(max),
	MetaKeyword nvarchar(250),
	MetaDescription nvarchar(250),
	[Status] bit
)

create table SupportOnlines
(
	ID int identity(1,1) not null primary key,
	[Name] nvarchar(250),
	Department nvarchar(250),
	Skype nvarchar(250),
	Mobile nvarchar(250),
	Email nvarchar(250),
	Yahoo nvarchar(250),
	Facebook nvarchar(250),
	[Status] bit
)

create table SystemConfigs
(
	ID int identity(1,1) not null primary key,
	Code varchar(50),
	ValueString nvarchar(250),
	ValueInt int
)

create table VisitorStatistics
(
	ID uniqueidentifier not null primary key,
	VistedDate datetime not null,
	IPAddress varchar(50) not null
)