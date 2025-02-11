
CREATE DATABASE education;


use education;


CREATE SCHEMA wipro;

CREATE TABLE wipro.course(courseId int , courseName varchar(244));

TRUNCATE TABLE wipro.course

DROP TABLE wipro.course;


--ALTER EXAMPLE
--adding new column to a table
CREATE TABLE product (id int primary key, name varchar(233));

ALTER TABLE product ADD  price int 

SELECT * FROM product;

--deleting a column from  product table
ALTER TABLE product DROP COLUMN price;



INSERT INTO product (id,name,price) VALUES (1,'TV',12000),(2,'AC',50000);


DELETE FROM product where id =1;

UPDATE product SET price =1000 WHERE id =2;


SELECT id,name,price from product;

ALTER TABLE product ADD quantity int;

insert into product (id,name,price ,quantity) values(1,'TV',12000,2);

SELECT name , quantity * price  as totalPrice  from product;


CREATE TABLE student(id int primary key, name varchar(255));


	CREATE TABLE course (id int, name varchar(255));

	ALTER TABLE course ADD CONSTRAINT id int primary key;


drop TABLE product;

----------------------------------------Foreign key ---------------------------------
CREATE TABLE customer (id int primary key, name varchar(255));

CREATE TABLE orders ( id int primary key  ,
                        order_name varchar (255), 
						c_id int,
						foreign key(c_id) REFERENCES customer(id)

						);
--------------------------------check constraint------------------------------------
CREATE TABLE products (
                       id  int primary key,
					   name varchar(244),
					   price int,
					   CHECK(price > 500));

					   INSERT INTO products (id,name,price)VALUES(1,'TV',1200);







					   ---------------------------shorting ----------------
				
	SELECT * FROM products order by price desc;
	insert into products(id,name,price) values(3,'fridge',900);

	------------------------------AND----------------------
	select * from products where id =2 AND price =1500;
	SELECT * from products where NOT id =2 NOT;

	EXEC SP_RENAME  'products.id','productId','COLUMN';

