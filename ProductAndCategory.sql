use ProductAndCategory;
go

create table Product
(
	Id int primary key identity not null,
	ProductName nvarchar(150) not null
)

create table Category
(
	Id int primary key identity not null,
	CategoryName nvarchar(150) not null
)

create table ProductCategory
(
	Id int primary key identity not null,
	ProductId int null,
	CategoryId int null,

	foreign key (ProductId) references Product (Id) on delete set null,
	foreign key (CategoryId) references Category (Id) on delete set null
)

select ProductCategory.Id, Product.ProductName, Category.CategoryName
from ProductCategory
full join Category on Category.Id = ProductCategory.Id
full join Product on Product.Id = ProductCategory.Id