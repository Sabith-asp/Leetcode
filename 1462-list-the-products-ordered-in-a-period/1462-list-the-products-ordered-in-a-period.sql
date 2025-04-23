# Write your MySQL query statement below

-- select p.product_name,o.unit  from orders o join products p on p.product_id  = o.product_id where (select SUM(o.unit) from o where MONTH(o.order_date)=2)>=100

SELECT p.product_name, SUM(o.unit) AS unit FROM Orders o JOIN Products p ON p.product_id =o.product_id WHERE o.order_date >= '2020-02-01' AND o.order_date < '2020-03-01'GROUP BY o.product_id, p.product_name HAVING SUM(o.unit) >= 100;
