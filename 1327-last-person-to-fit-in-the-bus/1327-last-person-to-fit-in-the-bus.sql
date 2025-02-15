/* Write your T-SQL query statement below */
WITH Boarding AS (
    SELECT person_name, 
           weight, 
           SUM(weight) OVER (ORDER BY turn) AS cumulative_weight
    FROM Queue
)
SELECT TOP 1 person_name 
FROM Boarding
WHERE cumulative_weight <= 1000
ORDER BY cumulative_weight DESC;
