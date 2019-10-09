SELECT [ProductName]
	  , [Category].CategoryName
  FROM [FullStack].[dbo].[Product] left join Category on Product.CategoryID = Category.CategoryID;