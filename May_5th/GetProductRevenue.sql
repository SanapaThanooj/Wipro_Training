CREATE PROCEDURE GetProductRevenue
	@productID INT
AS
BEGIN
	SELECT
		o.Orderid,
		o.Quantity,
		o.OrderDate,
		p.ProductName,
		(o.Quantity * p.Price) AS TotalRevenue,
		p.Price
	FROM Orders o
	INNER JOIN Products p ON o.productID = p.productID
	WHERE o.productID = @productID;
END;  

EXEC GetProductRevenue @productID = 1;
