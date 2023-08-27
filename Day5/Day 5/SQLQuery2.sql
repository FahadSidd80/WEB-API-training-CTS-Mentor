create table products
(
	pId int primary key,
	pName varchar(20),
	pCategory varchar(20),
	pPrice int,
	pIsInStock bit
)

insert into products values(101,'Pepsi','Cold-Drink',50,1)
insert into products values(102,'IPhone','Smart Phone',150000,1)
insert into products values(103,'Dell Lattitude','85000',50,0)
insert into products values(104,'Latte','Coffee',250,1)
insert into products values(105,'Boat','Head-Phones',3500,1)
insert into products values(106,'Appy','Cold-Drink',80,0)


create table customers
(
	cId int primary key,
	cName varchar(20),
	cType varchar(20),
	cWalletBalance int,
	cAddress varchar(100),
	cIsActive bit
)
insert into customers values(501,'Smriti','Regular',500,'Pune',1)
insert into customers values(502,'Nikhil','Regular',100,'Pune',1)
insert into customers values(503,'Sumit','Regular',300,'Chennai',0)
insert into customers values(504,'Karan','Prime',5000,'Pune',1)
insert into customers values(505,'Isha','Regular',0,'Mumbai',0)

select * from products



alter table products add pManufacturer varchar(30)

create table orders 
(
	oId int primary key,
	oType varchar(20),
	oStatus varchar(20)
	)
	

	insert into orders values(1,'Confirmed','Dilivered')
	insert into orders values(2,'Delayed','Waiting')
	insert into orders values(3,'Calcelled','Cancelled')
	insert into orders values(4,'Confirmed','Dilivered')





















