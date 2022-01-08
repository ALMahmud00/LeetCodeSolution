SELECT emp.name AS Employee
FROM Employee AS emp
JOIN Employee AS man ON man.id = emp.managerId
WHERE emp.salary > man.salary