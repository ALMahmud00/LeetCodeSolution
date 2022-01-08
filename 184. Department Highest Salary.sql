SELECT res.Department, emp.name AS Employee, res.Salary FROM(
SELECT dp.name AS Department, MAX(em.salary) AS Salary
FROM Employee AS em
JOIN Department AS dp ON em.departmentId = dp.id
GROUP BY dp.name
) AS res
JOIN Employee emp ON res.Salary = emp.salary
JOIN Department dpt ON res.Department = dpt.name
WHERE emp.departmentId = dpt.id