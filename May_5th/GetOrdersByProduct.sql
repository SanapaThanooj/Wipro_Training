CREATE PROCEDURE GetOrdersByProduct
	@productID INT
AS
BEGIN
	SELECT
		o.Orderid,
		o.Quantity,
		o.OrderDate,
		p.ProductName,
		p.Price
	FROM Orders o
	INNER JOIN Products p ON o.productID = p.productID
	WHERE o.productID = @productID;
END;  

EXEC GetOrdersByProduct @productID = 1; //
