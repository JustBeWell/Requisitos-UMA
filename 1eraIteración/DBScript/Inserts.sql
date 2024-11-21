SET IDENTITY_INSERT Producto ON;

INSERT INTO Producto (id, nombre) VALUES
(1, 'Floor Lamp'),
(2, 'Monitor'),
(3, 'Dining Table'),
(4, 'Chair'),
(5, 'Wardrobe'),
(6, 'Printer'),
(7, 'Speaker'),
(8, 'Television'),
(9, 'Microwave Oven'),
(10, 'Sofa'),
(11, 'Refrigerator'),
(12, 'Ceiling Fan'),
(13, 'Curtains'),
(14, 'Blender'),
(15, 'Mattress'),
(16, 'Desk Lamp'),
(17, 'Vacuum Cleaner'),
(18, 'Washing Machine'),
(19, 'Bowls'),
(20, 'Pillow'),
(21, 'Tupperware'),
(22, 'Laptop'),
(23, 'Headphones'),
(24, 'Tablet'),
(25, 'Keyboard'),
(26, 'Air Conditioner'),
(27, 'Glasses'),
(28, 'Blanket'),
(29, 'Cutlery Set'),
(30, 'Towel'),
(31, 'Water Bottle'),
(32, 'Smartwatch'),
(33, 'Plates'),
(34, 'Coffee Maker'),
(35, 'Bed'),
(36, 'Electric Kettle'),
(37, 'External Hard Drive'),
(38, 'Smartphone'),
(39, 'Wall Clock'),
(40, 'Iron'),
(41, 'Backpack'),
(42, 'Toaster'),
(43, 'Chandelier'),
(44, 'Mouse'),
(45, 'Camera'),
(46, 'Router'),
(47, 'Bookshelf'),
(48, 'Gaming Console'),
(49, 'Carpet'),
(50, 'Cookware Set');

SET IDENTITY_INSERT Producto OFF;

SET IDENTITY_INSERT Categoria ON;

INSERT INTO Categoria (id, nombre) VALUES
(1, 'Networking'),
(2, 'Gaming'),
(3, 'Home Appliances'),
(4, 'Office Supplies'),
(5, 'Furniture'),
(6, 'Lighting'),
(7, 'Travel Accessories'),
(8, 'Electronics'),
(9, 'Kitchenware'),
(10, 'Bedding');

SET IDENTITY_INSERT Categoria OFF;


INSERT INTO ProductoCategoria (producto_id, categoria_id) VALUES
(3, 5),
(12, 6),
(36, 9),
(33, 10),
(22, 8),
(27, 7),
(20, 10),
(32, 8),
(24, 9),
(29, 5),
(23, 8),
(9, 3),
(26, 3),
(14, 9),
(28, 10),
(1, 6),
(11, 3),
(35, 5);

SET IDENTITY_INSERT TipoAtributo ON;

INSERT INTO TipoAtributo (id, nombre) VALUES
(1, 'Capacity'),
(2, 'Resolution'),
(3, 'Weight'),
(4, 'Dimensions'),
(5, 'Processor Type'),
(6, 'Energy Efficiency'),
(7, 'Material'),
(8, 'Color'),
(9, 'Connectivity'),
(10, 'Voltage'),
(11, 'Screen Type'),
(12, 'Power'),
(13, 'Storage'),
(14, 'Features'),
(15, 'Warranty'),
(16, 'Battery Life'),
(17, 'Brand'),
(18, 'Size');

SET IDENTITY_INSERT TipoAtributo OFF;

SET IDENTITY_INSERT Atributo ON;

INSERT INTO Atributo (id, nombre, tipo) VALUES
(1, 'Capacity', 1),
(2, 'Resolution', 2),
(3, 'Screen Size', 11),
(4, 'Weight', 3),
(5, 'Dimensions', 4),
(6, 'Power Consumption', 12),
(7, 'Processor', 5),
(8, 'Material', 7),
(9, 'Color', 8),
(10, 'Voltage', 10),
(11, 'Energy Rating', 6),
(12, 'Storage', 13),
(13, 'RAM', 5),
(14, 'Features', 14),
(15, 'Warranty', 15),
(16, 'Battery Life', 16),
(17, 'Brand', 17),
(18, 'Connectivity', 9);

SET IDENTITY_INSERT Atributo OFF;

SET IDENTITY_INSERT ValorAtributo ON;

INSERT INTO ValorAtributo (id, valor, atributo_id, producto_id) VALUES
(1, '1TB', 12, 22),
(2, '10x10x10 cm', 5, 9),
(3, '2 Years', 15, 18),
(4, 'A+', 11, 11),
(5, 'Blue', 9, 42),
(6, 'Intel i7', 7, 22),
(7, 'Plastic', 8, 7),
(8, '500L', 1, 11),
(9, 'Sony', 17, 8),
(10, '2kg', 4, 10),
(11, '10 Hours', 16, 32),
(12, '1080p', 2, 2),
(13, 'WiFi', 18, 46),
(14, '110V', 10, 9),
(15, 'Red', 9, 8),
(16, 'LED', 11, 6),
(17, '220W', 6, 18),
(18, 'Eco-Friendly', 14, 28);

SET IDENTITY_INSERT ValorAtributo OFF;
