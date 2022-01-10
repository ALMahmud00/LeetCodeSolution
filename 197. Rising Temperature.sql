/* Solution 01
SELECT id
FROM Weather H
WHERE H.temperature > 
    (SELECT TOP (1) R.temperature FROM Weather AS R WHERE H.recordDate = DATEADD(DAY, 1 , R.recordDate))

*/
 
/* Solution 02*/
SELECT H.id
FROM Weather H
JOIN Weather R ON H.recordDate = DATEADD(DAY, 1 , R.recordDate)
WHERE H.temperature > R.temperature
