CREATE PROCEDURE HigherEndPriceS
AS
BEGIN 
	SELECT * FROM Products
	WHERE Price>60000;
END;

EXEC HigherEndPriceS
/*CREATE PROCEDURE GetOrdersByProduct
	@productID INT
AS
BEGIN
	SELECT
		o.Orderid,
		o.Quantity,
		o.OrderDate
		p.ProductName,
		p.Price
	FROM Orders o
	INNER JOIN Products p ON o.productID = p.productID
	WHERE o.productID = @productID;
END;  */
--Msg 102, Level 15, State 1, Procedure GetOrdersByProduct, Line 9 [Batch Start Line 0] Incorrect syntax near '.'.

