CREATE FUNCTION getNthHighestSalary(@N INT) RETURNS INT AS
BEGIN
    RETURN (
        /* Write your T-SQL query statement below. */
        SELECT TOP (1) (CASE WHEN sl = @N THEN salary ELSE NULL END) AS SecondHighestSalary
        FROM    
            (SELECT salary, DENSE_RANK() OVER (ORDER BY salary DESC) AS sl
             FROM Employee) AS temp
        WHERE sl in (1,@N)
        ORDER BY sl DESC
    );
END