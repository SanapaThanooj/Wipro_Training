CREATE PROCEDURE CheckProductExists
	@productID INT
AS
BEGIN
	
	IF EXISTS (SELECT 1 FROM Products WHERE productID =  @productID)
		PRINT 'Product Found '
	ELSE
		PRINT 'Product Not Found '
	
END; 

EXEC CheckProductExists @productID =1;