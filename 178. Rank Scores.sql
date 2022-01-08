SELECT score, DENSE_RANK() OVER (ORDER BY score DESC) AS rank
FROM Scores
ORDER BY score DESC

/* RANK() OVER (ORDER BY score) */
/* ROW_NUMBER() OVER (ORDER BY score) */