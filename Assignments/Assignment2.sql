USE AdventureWorks2019
GO

--1. 
SELECT DISTINCT Count(Name)
FROM Production.Product
 -- 504 Products

 --2. 
SELECT Count(Name)
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL
 -- 295

 --3.
SELECT ProductSubcategoryID, COUNT(Name) as CountedProducts
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL
GROUP BY ProductSubcategoryID

 --4. 
SELECT COUNT(Name)
FROM Production.Product
WHERE ProductSubcategoryID IS NULL
  -- 209

--5.
SELECT SUM(Quantity) 
FROM Production.ProductInventory

--6.
SELECT ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
GROUP BY ProductID

--7.
/*
7.    Write a query to list the sum of products with the shelf information 
	in the Production.ProductInventory table and LocationID set to 40 and limit 
	the result to include just summarized quantities less than 100
	*/
SELECT Shelf, ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY Shelf, ProductID
HAVING SUM(Quantity) < 100;


--8.
SELECT * 
FROM Production.ProductInventory


--9.
SELECT ProductID, Shelf, AVG(Quantity) as TheAvg
FROM Production.ProductInventory
GROUP BY ProductID,Shelf

--10.
SELECT ProductID, Shelf, AVG(Quantity) as TheAvg
FROM Production.ProductInventory
WHERE Shelf != 'N/A'
GROUP BY ProductID,Shelf

--11.
SELECT Color, Class, COUNT(Class) TheCount, AVG(ListPrice) AS AvgPrice
FROM Production.Product
WHERE Color IS NOT NULL AND Class IS NOT NULL
GROUP BY Color, Class

--12.

SELECT cr.Name as Country, st.Name as Province
FROM Person.CountryRegion cr 
JOIN
Person.StateProvince st ON cr.CountryRegionCode = st.CountryRegionCode


--13.
SELECT cr.Name as Country, st.Name as Province
FROM Person.CountryRegion cr 
JOIN
Person.StateProvince st ON cr.CountryRegionCode = st.CountryRegionCode
WHERE cr.Name NOT IN('Germany','Canada')

--14 to 28 
USE Northwind
GO

--14.
SELECT p.ProductName, MAX(o.OrderDate) as OrderDate
FROM Products p JOIN [Order Details] od on p.ProductID = od.ProductID JOIN Orders o on od.OrderID = o.OrderID
WHERE o.OrderDate > DATEADD(YEAR, -25, GETDATE())
GROUP BY p.ProductName

--15.
SELECT TOP 5 o.ShipPostalCode , COUNT(p.ProductName) as CountProducts
FROM Products p JOIN [Order Details] od on p.ProductID = od.ProductID JOIN Orders o on od.OrderID = o.OrderID
WHERE ShipPostalCode IS NOT NULL
GROUP BY o.ShipPostalCode

--16.
SELECT TOP 5 o.ShipPostalCode , COUNT(p.ProductName) as CountProducts
FROM Products p JOIN [Order Details] od on p.ProductID = od.ProductID JOIN Orders o on od.OrderID = o.OrderID
WHERE ShipPostalCode IS NOT NULL AND o.OrderDate > '19980101'
GROUP BY o.ShipPostalCode

--17.
SELECT City, COUNT(CustomerID) as CountCustomers
FROM Customers
GROUP BY City

--18.
SELECT City, CountCustomers
FROM 
(SELECT City, COUNT(CustomerID) as CountCustomers
FROM Customers
GROUP BY City) cc
WHERE CountCustomers > 2

--19.
SELECT c.CustomerID, c.ContactName, MAX(o.OrderDate) as LatestOrder
FROM Customers c JOIN Orders o on c.CustomerID = o.CustomerID
WHERE o.OrderDate > '19980101'
GROUP BY c.CustomerID, c.ContactName

--20.
SELECT c.CustomerID, c.ContactName, MAX(o.OrderDate) as LatestOrder
FROM Customers c JOIN Orders o on c.CustomerID = o.CustomerID
GROUP BY c.CustomerID, c.ContactName
ORDER BY LatestOrder DESC

--21.
SELECT c.CustomerID, c.ContactName, SUM(od.Quantity) as CountProduct
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.CustomerID, ContactName
 --added CustomerID in case there are different people with the same name

--22.
SELECT ContactName, CountProduct
FROM 
(SELECT c.CustomerID, c.ContactName, SUM(od.Quantity) as CountProduct
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.CustomerID, ContactName) tb
WHERE CountProduct > 100

--23.
SELECT DISTINCT s.CompanyName as [Supplier Company Name], sh.CompanyName as [Shipping Company Name]
FROM
Suppliers s JOIN Products p ON s.SupplierID = p.SupplierID
JOIN [Order Details] od ON p.ProductID = od.ProductID
JOIN Orders o ON od.OrderID = o.OrderID
JOIN Shippers sh ON o.ShipVia = sh.ShipperID


--24.
SELECT p.ProductName, o.OrderDate, RANK() OVER (PARTITION BY o.orderDate ORDER BY p.ProductName DESC) RNK
FROM Products p JOIN [Order Details] od on p.ProductID = od.ProductID JOIN Orders o on od.OrderID = o.OrderID


--25.
SELECT Title, EmployeeID, FirstName + ' ' + LastName as FullName, RANK() OVER (PARTITION BY Title ORDER BY EmployeeID) RNK
FROM Employees e

--26.
SELECT FullName, COUNT(*)
FROM
(SELECT e1.EmployeeID, e1.FirstName + ' ' + e1.LastName as FullName, e1.ReportsTo
FROM Employees e1 JOIN Employees e2 ON e1.ReportsTo = e2.EmployeeID) tb
GROUP BY FullName
 -- not correct fix
/*
WITH EmpHierarchyCTE
AS
(
	SELECT EmployeeID, FirstName, ReportsTo, 0 Underlings
	FROM Employees
	WHERE ReportsTo is not null

	UNION ALL

	SELECT e.EmployeeID, e.FirstName, e.ReportsTo, cte.Underlings + 1
	FROM Employees e JOIN EmpHierarchyCTE cte ON e.ReportsTo = cte.EmployeeID
)
SELECT * FROM EmpHierarchyCTE
*/

--27.
  --City Name Contact Name Type
SELECT s.City as City , s.CompanyName as Name, s.ContactName as [Contact Name], 'Supplier' as Type
From Suppliers s
UNION 
SELECT c.City as City , c.CompanyName as Name, c.ContactName as [Contact Name], 'Customer' as Type
From Customers c

