# Write your MySQL query statement below

select customer_number from (select customer_number,COUNT(order_number) ordercount from Orders group by customer_number order by COUNT(order_number) desc) as Result limit 1