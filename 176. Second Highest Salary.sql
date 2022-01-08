SELECT TOP (1) (CASE WHEN sl = 2 THEN salary ELSE NULL END) AS SecondHighestSalary
FROM    
    (SELECT salary, DENSE_RANK() OVER (ORDER BY salary DESC) AS sl
     FROM Employee) AS temp
WHERE sl in (1,2)
ORDER BY sl DESC