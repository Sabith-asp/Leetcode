/* Write your T-SQL query statement below */
SELECT COALESCE(
    (SELECT DISTINCT salary 
     FROM employee 
     ORDER BY salary DESC 
     OFFSET 1 ROW FETCH NEXT 1 ROW ONLY), 
    NULL
) AS SecondHighestSalary;
