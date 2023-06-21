CREATE TABLE Products (
                          id INT NOT NULL PRIMARY KEY,
                          ProductName VARCHAR(100) NOT NULL
);
CREATE TABLE Categories (
                          id INT NOT NULL PRIMARY KEY,
                          CategoryName VARCHAR(100) NOT NULL
);

CREATE TABLE ProductCategories (
                                   ProductID INT NOT NULL,
                                   CategoryID INT NOT NULL,
                                   PRIMARY KEY (ProductID, CategoryID),
                                   FOREIGN KEY (ProductID)
                                       REFERENCES Products (id) ON DELETE CASCADE,
                                   FOREIGN KEY (CategoryID)
                                       REFERENCES Categories (id) ON DELETE CASCADE
);

INSERT INTO Products values (1, 'product1'), (2, 'product2'), (3, 'product3'), (4, 'product4');
INSERT INTO Categories values (1, 'category1'), (2, 'category2');
INSERT INTO ProductCategories values (1, 1), (1, 2), (2, 1), (2, 2);

SELECT P.ProductName, C.CategoryName
FROM Products AS P
LEFT JOIN ProductCategories AS PC ON P.id = PC.ProductID
LEFT JOIN Categories AS C ON PC.CategoryID = C.id;