/*Many-To-Many multi mapping*/

CREATE TABLE Products (
	Id INT PRIMARY KEY,
	"ProductName" TEXT
);

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	"CategoryName" TEXT
);
/*Junction table*/
CREATE TABLE ProductCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO Categories
VALUES
		(1, 'Books'),
		(2, 'Videos'),
		(3, 'Courses');

INSERT INTO Products
VALUES
		(1, 'C#'),
		(2, 'C++'),
		(3, 'C');

INSERT INTO ProductCategories
VALUES
		(1, 1),
		(1, 2),
		(1, 3),
		(2, 1),
		(2, 2),
		(2, 3);

SELECT P."ProductName", C."CategoryName"
FROM Products P
LEFT JOIN ProductCategories PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories C
	ON PC.CategoryId = C.Id;