SELECT ProductId, Count(ProductId) as Count 
FROM (
		SELECT sales.* FROM Sales as sales inner join 
			(SELECT CustomerId, MIN(DateCreated) as MinDate
			 FROM Sales 
			 group by CustomerId) as minsales
	    on (sales.CustomerId = minsales.CustomerId and sales.DateCreated = minsales.MinDate)
	  ) as joinedsales
group by joinedsales.ProductId
order by Count desc