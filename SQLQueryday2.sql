

drop database Ecom;

CREATE DATABASE ecom;

CREATE TABLE  users (userId int ,name varchar(255));

CREATE TABLE orders (orderId int, userid int ,ammount int);

INSERT INTO users(userId,name) VALUES(1,'ALICE'),(2,'BOB'),(3,'JOHN');

INSERT INTO orders(orderId,userid,ammount) VALUES(101,1,500),(102,2,600),(103,4,800);


SELECT * FROM users;
SELECT * FROM orders;

---------------performing inner join----------------
---------------INNER JOIN---------------------------
SELECT u.userId, u.name ,o.ammount FROM users  u INNER JOIN orders o ON u.userId = o.userid;

---------------LEFT JOIN---------------------------

SELECT users.userId,users.name,orders.orderId,orders.ammount FROM users LEFT JOIN orders ON users.userId = orders.userid;

--------------FULL OUTER JOIN---------------------------
SELECT * FROM users FULL OUTER JOIN  orders ON users.userId = orders.userid 

--------------------------------------self join -------------------------------
CREATE TABLE employee(id int, name varchar(242), mangerId int);
INSERT INTO employee(id,name,mangerId) VALUES (1,'AKASH',NULL),(2,'VIKASH',1),(3,'Rakesh',1);

SELECT * FROM employee

SELECT e1.name AS EMPLOYEE, e2.name AS MANAGER 
FROM employee e1 
INNER JOIN employee e2 
ON e1.mangerId = e2.id;

---------------------------------------------cross join ------------------------
CREATE TABLE laptop(id int , name varchar(255));
CREATE TABLE colors(id int, name varchar(255));

INSERT INTO laptop(id,name) VALUES (1,'HP'),(2,'DELL');
INSERT INTO colors(id,name) VALUES (1,'RED'),(2,'BLACK');

SELECT laptop.id, laptop.name ,colors.name FROM laptop CROSS JOIN colors;



------------------------------------------------------------------------------------------------------------------------------------------------------------
SELECT id ,name FROM laptop
UNION
SELECT id, name FROM colors;

------------------------------------------group by----------------------------------
CREATE TABLE Employees (
    id INT PRIMARY KEY,
    name VARCHAR(50),
    department VARCHAR(50),
    salary INT
);

INSERT INTO Employees (id, name, department, salary) VALUES
(1, 'John', 'HR', 50000),
(2, 'Alice', 'IT', 60000),
(3, 'Bob', 'IT', 65000),
(4, 'Eve', 'HR', 52000),
(5, 'Mike', 'Sales', 48000);

SELECT department, count(salary) AS TotaL_Number FROM Employees GROUP BY department HAVING min(salary) >40000;


------Aggergate function--------------------
select count(salary) from employees;

select LEN ('HEllo');
select getdate();
select round(10.5);