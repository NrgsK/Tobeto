--86. a.Bu ülkeler hangileri..? (85.Kaç farklı ülkeye ihraacat yapıyorum?)
select distinct ship_country,count(ship_country) from orders
group by ship_country
order by ship_country;

--87. En Pahalı 5 ürün
select product_name,unit_price from products
order by unit_price desc limit 5;

--88. ALFKI CustomerID’sine sahip müşterimin sipariş sayısı..?
select c.customer_id,count(o.order_id) from customers c
inner join orders o on o.customer_id=c.customer_id
where c.customer_id='ALFKI'
group by c.customer_id;

--89. Ürünlerimin toplam maliyeti
select sum(unit_price * units_in_stock) as "Toplam Maliyet" from products;

--90. Şirketim, şimdiye kadar ne kadar ciro yapmış..?
select sum(unit_price*quantity) as "Ciro" from order_details;

--91. Ortalama Ürün Fiyatım
select avg(unit_price) as "Ortalama Fiyat" from products;

--92. En Pahalı Ürünün Adı
select product_name,unit_price from products
order by unit_price desc limit 1;

--93. En az kazandıran sipariş
select order_id,min(unit_price*quantity) as "Minimum Kazanç" from order_details
group by order_id
order by "Minimum Kazanç" limit 1;

--94. Müşterilerimin içinde en uzun isimli müşteri
select customer_id,company_name from customers
order by length(company_name) desc limit 1;

--95. Çalışanlarımın Ad, Soyad ve Yaşları
select first_name||' '||last_name as "Employee", date_part('year',age(birth_date)) as "Age" from employees;

--96. Hangi üründen toplam kaç adet alınmış..?
select p.product_id,p.product_name,sum(od.quantity) from products p
inner join order_details od on p.product_id=od.product_id
group by p.product_id,p.product_name
order by sum(od.quantity) desc;

--97. Hangi siparişte toplam ne kadar kazanmışım..?
select order_id,sum(unit_price*quantity) from order_details od
group by order_id;

--98. Hangi kategoride toplam kaç adet ürün bulunuyor..?
select c.category_name,count(p.product_id) from products p
inner join categories c on c.category_id=p.category_id
group by c.category_id;

--99. 1000 Adetten fazla satılan ürünler?
select p.product_name,sum(od.quantity) from order_details od
inner join products p on p.product_id=od.product_id
group by p.product_name
having sum(od.quantity)>1000;

--100. Hangi Müşterilerim hiç sipariş vermemiş..?
select customer_id,company_name from customers
where customer_id not in(select distinct customer_id from orders);

--101. Hangi tedarikçi hangi ürünü sağlıyor ?
select s.company_name,p.product_name from products p
inner join suppliers s on p.supplier_id=s.supplier_id;

--102. Hangi sipariş hangi kargo şirketi ile ne zaman gönderilmiş..?
select o.order_id,s.company_name,o.order_date,o.shipped_date from orders o
inner join shippers s on s.shipper_id=o.ship_via;

--103. Hangi siparişi hangi müşteri verir..?
select o.order_id,c.company_name from orders o
inner join customers c on c.customer_id=o.customer_id;

--104. Hangi çalışan, toplam kaç sipariş almış..?
select e.employee_id,e.first_name||' '||e.last_name as "Employee",count(order_id) as "Sipariş Sayısı" from orders o
inner join employees e on e.employee_id=o.employee_id
group by e.employee_id
order by e.employee_id;

--105. En fazla siparişi kim almış..?
select e.employee_id,e.first_name||' '||e.last_name,count(order_id) from orders o
inner join employees e on e.employee_id=o.employee_id
group by e.employee_id
order by count(order_id) desc limit 1;

--106. Hangi siparişi, hangi çalışan, hangi müşteri vermiştir..?
select o.order_id, e.first_name||' '||e.last_name as "Employee", c.company_name as "Customer" from orders o
inner join employees e on e.employee_id=o.employee_id
inner join customers c on c.customer_id=o.customer_id
where c.customer_id=o.customer_id;

--107. Hangi ürün, hangi kategoride bulunmaktadır..? Bu ürünü kim tedarik etmektedir..?
select p.product_name,c.category_name,s.company_name from products p
inner join categories c on c.category_id=p.category_id
inner join suppliers s on s.supplier_id=p.supplier_id
where p.supplier_id=s.supplier_id;

--108. Hangi siparişi hangi müşteri vermiş, hangi çalışan almış, hangi tarihte, hangi kargo şirketi tarafından gönderilmiş hangi üründen kaç adet alınmış, hangi fiyattan alınmış, ürün hangi kategorideymiş bu ürünü hangi tedarikçi sağlamış
select o.order_id,c.customer_id,c.company_name,e.first_name||' '||e.last_name,
	   o.order_date,s.company_name,p.product_name,od.quantity,od.unit_price,
	   cat.category_name,sup.company_name from orders o
inner join customers c on o.customer_id = c.customer_id
inner join employees e on o.employee_id = e.employee_id
inner join shippers s on o.ship_via = s.shipper_id
inner join order_details od on o.order_id = od.order_id
inner join products p on od.product_id = p.product_id
inner join categories cat on p.category_id = cat.category_id
inner join suppliers sup on p.supplier_id = sup.supplier_id;

--109. Altında ürün bulunmayan kategoriler
select c.category_name from categories c
inner join products p on p.category_id=c.category_id
where p.product_id is null;

--110. Manager ünvanına sahip tüm müşterileri listeleyiniz.
select contact_name,company_name, contact_title from customers
where contact_title like '%Manager';

--111. FR ile başlayan 5 karekter olan tüm müşterileri listeleyiniz.
select company_name from customers
where company_name like 'Fr___';

--112. (171) alan kodlu telefon numarasına sahip müşterileri listeleyiniz.
select company_name, phone from customers
where phone like '(171)%';

--113. BirimdekiMiktar alanında boxes geçen tüm ürünleri listeleyiniz.
select product_name,quantity_per_unit from products
where quantity_per_unit like '%boxes%';

--114. Fransa ve Almanyadaki (France,Germany) Müdürlerin (Manager) Adını ve Telefonunu listeleyiniz.(MusteriAdi,Telefon)
select company_name,contact_name,phone from customers
where country='France' or country='Germany' and contact_title like '%Manager';

--115. En yüksek birim fiyata sahip 10 ürünü listeleyiniz.
select product_name,unit_price from products
order by unit_price desc limit 10;

--116. Müşterileri ülke ve şehir bilgisine göre sıralayıp listeleyiniz.
select company_name,country,city from customers
order by country,city;

--117. Personellerin ad,soyad ve yaş bilgilerini listeleyiniz.
select first_name||' '||last_name as "Employee", date_part('year',age(birth_date)) as "Age" from employees
order by first_name;

--118. 35 gün içinde sevk edilmeyen satışları listeleyiniz.
select * from orders
where date(shipped_date)- date(order_date)>35;

--119. Birim fiyatı en yüksek olan ürünün kategori adını listeleyiniz. (Alt Sorgu)
select category_name from categories c
inner join products p on p.category_id=c.category_id
where p.unit_price = (select max(unit_price) from products);

--120. Kategori adında 'on' geçen kategorilerin ürünlerini listeleyiniz. (Alt Sorgu)
select product_name,c.category_name from products p
inner join categories c on c.category_id=p.category_id
where c.category_name like '%on%';

--121. Konbu adlı üründen kaç adet satılmıştır.
select p.product_name,count(order_id) from order_details od
inner join products p on p.product_id=od.product_id
where p.product_id=od.product_id and p.product_name='Konbu'
group by p.product_id;

--122. Japonyadan kaç farklı ürün tedarik edilmektedir.
select count(p.product_id) from suppliers s
inner join products p on p.supplier_id=s.supplier_id
where s.country='Japan';

--123. 1997 yılında yapılmış satışların en yüksek, en düşük ve ortalama nakliye ücretlisi ne kadardır?
select max(freight) as "Maximum Freight",min(freight) as "Minimum Freight",avg(freight) as "Average Freight" from orders
where date_part('year',order_date)=1997;

--124. Faks numarası olan tüm müşterileri listeleyiniz.
select company_name, fax from customers 
where fax is not null;

--125. 1996-07-16 ile 1996-07-30 arasında sevk edilen satışları listeleyiniz. 
select * from orders
where shipped_date between '1996-07-16' and '1996-07-30';
