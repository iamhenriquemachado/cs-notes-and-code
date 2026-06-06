using cs_notes_and_code.challenges.CsvReader;
using cs_notes_and_code.challenges.CsvReader.Entities;
using cs_notes_and_code.challenges.CsvReader.Interfaces;
using cs_notes_and_code.challenges.Day_19_20;
using static System.Runtime.InteropServices.JavaScript.JSType;

Reports reports = new Reports();

List<Product> products = new List<Product>
{
    new Product { Id = 1, Name = "Notebook Dell Inspiron", Category = "Computers", SalesPerson = "Carlos Silva", Value = 4599.90m, Date = DateTime.UtcNow },
    new Product { Id = 2, Name = "Mouse Logitech G502", Category = "Accessories", SalesPerson = "Ana Souza", Value = 349.90m, Date = DateTime.UtcNow },
    new Product { Id = 3, Name = "Monitor LG UltraWide", Category = "Monitors", SalesPerson = "Bruno Costa", Value = 1899.99m, Date = DateTime.UtcNow },
    new Product { Id = 4, Name = "Teclado Mecânico Redragon", Category = "Accessories", SalesPerson = "Fernanda Lima", Value = 429.90m, Date = DateTime.UtcNow },
    new Product { Id = 5, Name = "iPhone 17", Category = "Smartphones", SalesPerson = "Ricardo Alves", Value = 7999.00m, Date = DateTime.UtcNow },
    new Product { Id = 6, Name = "Samsung Galaxy S26", Category = "Smartphones", SalesPerson = "Juliana Martins", Value = 6899.90m, Date = DateTime.UtcNow },
    new Product { Id = 7, Name = "Apple Watch Series 12", Category = "Wearables", SalesPerson = "Lucas Pereira", Value = 3599.90m, Date = DateTime.UtcNow },
    new Product { Id = 8, Name = "Kindle Paperwhite", Category = "E-Readers", SalesPerson = "Mariana Rocha", Value = 799.90m, Date = DateTime.UtcNow },
    new Product { Id = 9, Name = "PlayStation 5 Pro", Category = "Gaming", SalesPerson = "Gustavo Mendes", Value = 5499.90m, Date = DateTime.UtcNow },
    new Product { Id = 10, Name = "Xbox Series X", Category = "Gaming", SalesPerson = "Patrícia Oliveira", Value = 4699.00m, Date = DateTime.UtcNow },
    new Product { Id = 11, Name = "Cadeira Gamer ThunderX3", Category = "Furniture", SalesPerson = "Diego Santos", Value = 1499.90m, Date = DateTime.UtcNow },
    new Product { Id = 12, Name = "Headset HyperX Cloud III", Category = "Audio", SalesPerson = "Camila Ferreira", Value = 699.90m, Date = DateTime.UtcNow },
    new Product { Id = 13, Name = "Impressora HP LaserJet", Category = "Printers", SalesPerson = "Rafael Gomes", Value = 1299.90m, Date = DateTime.UtcNow },
    new Product { Id = 14, Name = "SSD Kingston 1TB", Category = "Storage", SalesPerson = "Beatriz Almeida", Value = 549.90m, Date = DateTime.UtcNow },
    new Product { Id = 15, Name = "Memória RAM Corsair 32GB", Category = "Components", SalesPerson = "Felipe Barbosa", Value = 899.90m, Date = DateTime.UtcNow },
    new Product { Id = 16, Name = "Smart TV Samsung 55\"", Category = "TVs", SalesPerson = "Larissa Castro", Value = 3299.90m, Date = DateTime.UtcNow },
    new Product { Id = 17, Name = "Caixa de Som JBL Charge 6", Category = "Audio", SalesPerson = "Eduardo Ribeiro", Value = 999.90m, Date = DateTime.UtcNow },
    new Product { Id = 18, Name = "Drone DJI Mini 5", Category = "Drones", SalesPerson = "Vanessa Cardoso", Value = 4999.90m, Date = DateTime.UtcNow },
    new Product { Id = 19, Name = "Câmera Sony Alpha A7 IV", Category = "Cameras", SalesPerson = "Thiago Moreira", Value = 12999.00m, Date = DateTime.UtcNow },
    new Product { Id = 20, Name = "MacBook Air M5", Category = "Computers", SalesPerson = "Renata Nogueira", Value = 10499.90m, Date = DateTime.UtcNow }
};

reports.AddProduct(products);

DateTime initialDate = new DateTime(2025, 01, 01);
DateTime finalDate = new DateTime(2028, 01, 01);

reports.Report_AverageValueByCategory();