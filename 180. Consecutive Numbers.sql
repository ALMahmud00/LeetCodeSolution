SELECT DISTINCT(lg.num) AS ConsecutiveNums
FROM Logs AS lg
WHERE num = (SELECT num FROM Logs WHERE id = lg.id - 1)
  AND num = (SELECT num FROM Logs WHERE id = lg.id + 1)