USE Northwind
GO

--1.
/*
SELECT c.City 
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN Employees e ON o.EmployeeID = e.EmployeeID
*/
SELECT DISTINCT c.City
FROM Customers c
INTERSECT
SELECT DISTINCT e.City
FROM Employees e

--2.
 --a)
SELECT DISTINCT c.City
FROM Customers c 
WHERE c.City not in(
SELECT e.City
FROM Employees e
)

 --b)
SELECT DISTINCT c.City
FROM Customers c LEFT JOIN Employees e ON c.City = e.City
WHERE e.City IS NULL

--3.
SELECT p.ProductName, SUM(od.Quantity) as SumQuantities
FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID
--JOIN Orders o ON od.OrderID = o.OrderID
GROUP BY p.ProductName;

--4.
SELECT o.ShipCity as City, o.OrderID, od.Quantity
FROM Orders o JOIN [Order Details] od ON o.OrderID = od.OrderID
WHERE o.ShipCity in
(SELECT DISTINCT City c
FROM Customers c)

/*
WITH cte
AS
(
SELECT DISTINCT City c
FROM Customers c
)
*/

--5.
--a) not sure
SELECT City, COUNT(*) as CountCustomer
FROM Customers c
GROUP BY City
HAVING COUNT(*) = 1
UNION
SELECT City, COUNT(*) as CountCustomer
FROM Customers c
GROUP BY City
HAVING COUNT(*) = 2

--b)
SELECT tb.City, tb.CountCustomer
FROM
(SELECT City, COUNT(*) as CountCustomer
FROM Customers c
GROUP BY City) tb
WHERE tb.CountCustomer >= 2

--6.
SELECT tb.City, COUNT(*) AS CountDistProducts
FROM
(SELECT DISTINCT c.City, od.ProductID
FROM Customers c JOIN Orders o ON c.CustomerID=o.CustomerID 
JOIN [Order Details] od ON o.OrderID = od.OrderID) tb
GROUP BY tb.City
HAVING COUNT(*) >= 2


--7.
SELECT DISTINCT c.ContactName, c.City, o.ShipCity
FROM Customers c JOIN Orders o ON c.CustomerID=o.CustomerID 
WHERE c.City != o.ShipCity

--8. 

WITH cte 
AS(
	SELECT TOP 5 p.ProductID, p.ProductName, SUM(od.Quantity) as SumQuantity, AVG(od.UnitPrice * od.Quantity) as AvgPrice
	FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID
	JOIN Orders o ON od.OrderID = o.OrderID
	JOIN Customers c ON o.CustomerID = c.CustomerID
	GROUP BY p.ProductID, p.ProductName
	ORDER BY SUM(od.Quantity) DESC
)
SELECT cte.ProductID, cte.ProductName, cte.SumQuantity, cte.AvgPrice, tb.City
FROM cte cte JOIN
(
SELECT p.ProductID, c.City, SUM(Quantity) as SumQuantity2
FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID
JOIN Orders o ON od.OrderID = o.OrderID
JOIN Customers c ON o.CustomerID = c.CustomerID
GROUP BY p.ProductID, c.City
) tb 
ON cte.ProductID = tb.ProductID
--TODO




--9.
--a)
SELECT e.City
FROM Employees e
WHERE e.City NOT IN 
(
SELECT c.City
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
)

--b)
SELECT e.City
FROM Employees e LEFT JOIN Customers c ON e.City = c.City
WHERE c.City IS NULL

--10.




--11.
/*
There are many ways to delete duplicates, such as using the DISTINCT identifier to remove duplicates from the query and setting it as the new table

You can also use the Row_Number ranking to see and remove any duplicates.

ex:)

WITH cte AS(
SELECT name, email, address, ROW_NUMBER() OVER (PARTITION BY name, email, address ORDER BY name, email, address) RowNum
FROM table
)
DELETE FROM cte WHERE row_num > 1

*/