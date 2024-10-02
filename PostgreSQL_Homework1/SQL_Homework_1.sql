--1. Product isimlerini (`ProductName`) ve birim başına miktar (`QuantityPerUnit`) değerlerini almak için sorgu yazın.
select product_name,quantity_per_unit from products;

--2. Ürün Numaralarını (`ProductID`) ve Product isimlerini (`ProductName`) değerlerini almak için sorgu yazın. Artık satılmayan ürünleri (`Discontinued`) filtreleyiniz.
select product_id,product_name from products;

--3. Durdurulan Ürün Listesini, Ürün kimliği ve ismi (`ProductID`, `ProductName`) değerleriyle almak için bir sorgu yazın.
select product_id,product_name from products
where discontinued=0;

--4. Ürünlerin maliyeti 20'dan az olan Ürün listesini (`ProductID`, `ProductName`, `UnitPrice`) almak için bir sorgu yazın.
select product_id,product_name,unit_price from products
where unit_price<20;

--5. Ürünlerin maliyetinin 15 ile 25 arasında olduğu Ürün listesini (`ProductID`, `ProductName`, `UnitPrice`) almak için bir sorgu yazın.
select product_id,product_name,unit_price from products
where unit_price BETWEEN 15 AND 25;

--6. Ürün listesinin (`ProductName`, `UnitsOnOrder`, `UnitsInStock`) stoğun siparişteki miktardan az olduğunu almak için bir sorgu yazın.
select product_name,units_on_order,units_in_stock from products
where units_in_stock < units_on_order;

--7. İsmi `a` ile başlayan ürünleri listeleyeniz.
select * from products
where LOWER(product_name) LIKE 'a%';

--8. İsmi `i` ile biten ürünleri listeleyeniz.
select * from products
where product_name LIKE '%i';

--9. Ürün birim fiyatlarına %18’lik KDV ekleyerek listesini almak (ProductName, UnitPrice, UnitPriceKDV) için bir sorgu yazın.
select product_name, unit_price, unit_price * 1.8 as "UnitPriceKDV" from Products;

--10. Fiyatı 30 dan büyük kaç ürün var?
select COUNT(product_name) ProductCount from products
where unit_price > 30;

--11. Ürünlerin adını tamamen küçültüp fiyat sırasına göre tersten listele
select LOWER(product_name),unit_price from products
ORDER BY unit_price DESC;

--12. Çalışanların ad ve soyadlarını yanyana gelecek şekilde yazdır
select first_name||' '||last_name AS "Ad Soyad" from employees;

--13. Region alanı NULL olan kaç tedarikçim var?
select COUNT(supplier_id) from suppliers
where region is NULL;

--14. a.Null olmayanlar?
select COUNT(supplier_id) from suppliers
where region is NOT NULL;

--15. Ürün adlarının hepsinin soluna TR koy ve büyültüp olarak ekrana yazdır.
select CONCAT('TR',UPPER(product_name)) from products;

--16. a.Fiyatı 20den küçük ürünlerin adının başına TR ekle
select CONCAT('TR',UPPER(product_name)),unit_price from products
where unit_price<20;

--17. En pahalı ürün listesini (`ProductName` , `UnitPrice`) almak için bir sorgu yazın.
select product_name,unit_price from products
ORDER BY unit_price DESC;

--18. En pahalı on ürünün Ürün listesini (`ProductName` , `UnitPrice`) almak için bir sorgu yazın.
select product_name,unit_price from products
ORDER BY unit_price DESC LIMIT 10;

--19. Ürünlerin ortalama fiyatının üzerindeki Ürün listesini (`ProductName` , `UnitPrice`) almak için bir sorgu yazın.
select product_name,unit_price from products
where unit_price > (SELECT AVG(unit_price) from products);

--20. Stokta olan ürünler satıldığında elde edilen miktar ne kadardır.
select product_name,(units_in_stock-units_on_order) AS "Elde edilen miktar" from products
where (units_in_stock-units_on_order)>=0;

--21. Mevcut ve Durdurulan ürünlerin sayılarını almak için bir sorgu yazın.
select count(product_id),discontinued from products
group by discontinued;

--22. Ürünleri kategori isimleriyle birlikte almak için bir sorgu yazın.
select products.product_name,categories.category_name from products
inner join categories on products.Category_id = Categories.Category_id;

--23. Ürünlerin kategorilerine göre fiyat ortalamasını almak için bir sorgu yazın.
select category_name,AVG(products.unit_price) AS "Ortalama Fiyat" from categories
inner join products on categories.category_id = products.category_id
GROUP BY category_name;

--24. En pahalı ürünümün adı, fiyatı ve kategorisin adı nedir?
select product_name,unit_price,categories.category_name from products
inner join categories on products.Category_id = Categories.Category_id
where unit_price=(select MAX(unit_price) from products);

--25. En çok satılan ürününün adı, kategorisinin adı ve tedarikçisinin adı
select product_name,contact_name,Category_Name from products
INNER JOIN Categories ON Products.Category_ID = Categories.Category_ID
INNER JOIN suppliers ON Products.Supplier_ID = Suppliers.Supplier_ID 
where units_on_order=(select MAX(units_on_order) from products);

--26. Stokta bulunmayan ürünlerin ürün listesiyle birlikte tedarikçilerin ismi ve iletişim numarasını (`ProductID`, `ProductName`, `CompanyName`, `Phone`) almak için bir sorgu yazın.
select product_id,product_name,suppliers.company_name,suppliers.phone from products
inner join suppliers on products.supplier_id=suppliers.supplier_id
where products.discontinued=0;

--27. 1998 yılı mart ayındaki siparişlerimin adresi, siparişi alan çalışanın adı, çalışanın soyadı
select orders.ship_address,employees.first_name,employees.last_name from orders
inner join employees on employees.employee_id=orders.employee_id
where orders.order_date>='1998-03-01' AND orders.order_date<'1998-04-01';

--28. 1997 yılı şubat ayında kaç siparişim var?
select COUNT(order_id) AS "Sipariş Sayısı" from orders
where order_date >='1997-02-01' AND order_date<'1997-03-01';

--29. London şehrinden 1998 yılında kaç siparişim var?
select COUNT(order_id) from orders
where order_date >= '01-01-1998' AND order_date <= '31-12-1998' AND ship_city='London';

--30. 1997 yılında sipariş veren müşterilerimin contactname ve telefon numarası
Select contact_name,phone from orders o 
inner join customers c on o.customer_id=c.customer_id 
where date_part('YEAR', order_date) = 1997;

--31. Taşıma ücreti 40 üzeri olan siparişlerim
SELECT * FROM orders
WHERE freight > 40;

--32. Taşıma ücreti 40 ve üzeri olan siparişlerimin şehri, müşterisinin adı
SELECT ship_city,c.company_name FROM orders o
inner join customers c on c.customer_id=o.customer_id
WHERE freight >= 40;

--33. 1997 yılında verilen siparişlerin tarihi, şehri, çalışan adı -soyadı ( ad soyad birleşik olacak ve büyük harf),
SELECT UPPER(e.last_name||' '|| e.first_name), o.order_date, o.ship_city 
FROM orders o
INNER JOIN employees e
ON o.employee_id = e.employee_id
WHERE order_date >= '01-01-1997' AND order_date <= '31-12-1997';

--34. 1997 yılında sipariş veren müşterilerin contactname i, ve telefon numaraları ( telefon formatı 2223322 gibi olmalı )
select customers.contact_name,customers.phone from orders
inner join customers on orders.customer_id=customers.customer_id
WHERE order_date >= '01-01-1997' AND order_date <= '31-12-1997';

--35. Sipariş tarihi, müşteri contact name, çalışan ad, çalışan soyad
select order_date,c.contact_name,e.first_name,e.last_name from orders o
inner join customers c on o.customer_id=c.customer_id
inner join employees e on e.employee_id=o.employee_id;

--36. Geciken siparişlerim?
select product_name,orders.shipped_date,required_date from order_details
INNER JOIN products ON products.product_ID = order_details.product_ID
INNER JOIN orders ON orders.order_ID = order_details.order_ID
where shipped_date>required_date;

--37. Geciken siparişlerimin tarihi, müşterisinin adı
select orders.shipped_date,orders.required_date,customers.contact_name from order_details
INNER JOIN products ON products.product_ID = order_details.product_ID
INNER JOIN orders ON orders.order_ID = order_details.order_ID
inner join customers on customers.customer_id=orders.customer_id
where shipped_date>required_date;

--38. 10248 nolu siparişte satılan ürünlerin adı, kategorisinin adı, adedi
select p.product_name,c.category_name,od.quantity from order_details od
inner join products p on od.product_id=p.product_id
inner join categories c on c.category_id=p.category_id
where order_id=10248;

--39. 10248 nolu siparişin ürünlerinin adı , tedarikçi adı
select product_name , contact_name from order_details
INNER JOIN products ON products.product_ID = order_details.product_ID
INNER JOIN suppliers ON products.supplier_ID = suppliers.supplier_ID
where order_id = 10248;

--40. 3 numaralı ID ye sahip çalışanın 1997 yılında sattığı ürünlerin adı ve adeti
select p.product_name,od.quantity,o.order_date from order_details od
inner join orders o on o.order_id=od.order_id
inner join employees e on e.employee_id=o.employee_id
inner join products p on p.product_id=od.product_id
where e.employee_id=3 AND date_part('YEAR', order_date) = 1997;

--41. 1997 yılında bir defasinda en çok satış yapan çalışanımın ID,Ad soyad
select e.employee_id,e.first_name,e.last_name from order_details od
inner join orders o on o.order_id=od.order_id
inner join employees e on e.employee_id=o.employee_id
where date_part('YEAR',order_date)=1997 AND od.quantity=(select MAX(quantity) from order_details);

--42. 1997 yılında en çok satış yapan çalışanımın ID,Ad soyad ****
select employee_id,first_name||' '||last_name from employees e
inner join orders o on e.employee_id=o.employee_id
inner join order_details od on od.order_id=o.order_id
where date_part('YEAR',order_date)=1997 and (select max(count(employee_id)) from )

--43. En pahalı ürünümün adı,fiyatı ve kategorisin adı nedir?
select distinct p.product_name,od.unit_price,c.category_name from order_details od
inner join products p on od.product_id=p.product_id
inner join categories c on c.category_id=p.category_id
where od.unit_price=(select max(unit_price) from order_details);

--44. Siparişi alan personelin adı,soyadı, sipariş tarihi, sipariş ID. Sıralama sipariş tarihine göre
select e.first_name||' '||e.last_name,o.order_date,o.order_id from orders o
inner join employees e on e.employee_id=o.employee_id
order by o.order_date;

--45. SON 5 siparişimin ortalama fiyatı ve orderid nedir?
select o.order_id, avg(od.unit_price * od.quantity) from orders o
inner join order_details od on o.order_id = od.order_id
group by o.order_id
order by o.order_id desc
limit 5;

--46. Ocak ayında satılan ürünlerimin adı ve kategorisinin adı ve toplam satış miktarı nedir?
select p.product_name,c.category_name,count(od.product_id),o.order_date from order_details od
inner join orders o on o.order_id=od.order_id
inner join products p on p.product_id=od.product_id
inner join categories c on c.category_id=p.category_id
where date_part('MONTH',order_date)=1
group by p.product_name,c.category_name,o.order_date;

--47. Ortalama satış miktarımın üzerindeki satışlarım nelerdir?
select od.order_id from orders o
inner join order_details od on o.order_id=od.order_id
inner join products p on p.product_id=od.product_id
where od.quantity>(select avg(quantity) from order_details);

--48. En çok satılan ürünümün(adet bazında) adı, kategorisinin adı ve tedarikçisinin adı
select p.product_name, c.category_name, s.company_name from products p
inner join categories c on p.category_id = c.category_id
inner join suppliers s on p.supplier_id = s.supplier_id
where p.product_id = (select product_id from order_details
   					  group by product_id
   					  order by sum(quantity) desc
   					  limit 1);

--49. Kaç ülkeden müşterim var
select count(distinct(country)) from customers;

--50. 3 numaralı ID ye sahip çalışan (employee) son Ocak ayından BUGÜNE toplamda ne kadarlık ürün sattı?
select e.employee_id, e.first_name, e.last_name, sum(od.quantity) as total from employees e
inner join orders o on e.employee_id = o.employee_id
inner join order_details od on o.order_id = od.order_id
where e.employee_id = 3
  and o.order_date >= date '2023-01-01' 
  and o.order_date <= current_date
group by e.employee_id, e.first_name, e.last_name;
