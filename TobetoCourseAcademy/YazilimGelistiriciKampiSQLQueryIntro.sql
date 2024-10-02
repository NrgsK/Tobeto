--Select
--ANSII
select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

select * from Customers
where City='London'

--Case insensitive

select * from Products
where CategoryID = 1 or CategoryID = 3

select * from Products
where CategoryID = 1 or UnitPrice >= 10

--Order By
select * from Products
order by ProductName

select * from Products
order by CategoryID,ProductName

--ascending asc (default)  - artan
--descending desc   - düşen

select * from Products
where CategoryID=1
order by UnitPrice desc

select count(*) from Products -- Veri sayısını verir

select count(*),ProductName from Products -- hata verir çünkü count fonksiyonu tek bir satır üretir. 


-- Group By

-- Hangi kategoride kaç farklı ürün var
select * from Products 
group by CategoryID -- Çalışmaz. group by da kümülatif veri kullanulabilir.

select categotyID,count(*) from Products
group by CategoryID --Her bir kategorin için bir grubun oluşuyor.

-- Karar Destek Sistemleri - KDS

-- Having
-- Kümülatif data sorgulanacağı için having kullanılır

select categotyID,count(*) from Products
group by CategoryID
having count(*) < 10 -- Kümülatif dataya göre sorgu yapıldığı için 


select categotyID,count(*) from Products
where UnitPrice > 20
group by CategoryID 
having count(*) < 10


--Join
-- Tekrar olmaması için tablolar ilişkilendirlirir.

select Products.ProductID, Products.ProductName,Products.UnitPrice,Categories.CategoryName 
from Products
inner join Categories on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

-- DTO Data Transformation Object

-- inner join sadece iki tablodada eşleşen verileri getirir. 

select * from Products p
inner join [Order Details] od on p.ProductID=od.ProductID

select * from Products p
left join [Order Details] od on p.ProductID=od.ProductID --Solda olup sağda olmayanları da getirir. Sol - Products , Sağ - Order Details

select * from Customers c
left join Orders o on c.CustomerID=o.CustomerID
where o.CustomerID is null    --Hiç ürün almayan müşteriler

-- Right join : Sağda olup solda omayan verileri getirir.
select * from Customers c
right join Orders o on c.CustomerID=o.CustomerID
where o.CustomerID is null 

-- Birden fazla tabloyu ekleme
select * from Products p
inner join [Order Details] od on p.ProductID=od.ProductID 
inner join Orders o on o.OrderID=od.OrderID








