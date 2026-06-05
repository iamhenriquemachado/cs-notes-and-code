using cs_notes_and_code.challenges.CsvReader;
using cs_notes_and_code.challenges.CsvReader.Entities;
using cs_notes_and_code.challenges.CsvReader.Interfaces;
using cs_notes_and_code.challenges.Day_19_20;
using static System.Runtime.InteropServices.JavaScript.JSType;

Reports reports = new Reports();

List<Product> products = new List<Product>
{
    new Product { Id = 1, Name = "Notebook Dell Inspiron", SalesPerson = "Carlos Silva", Value = 4599.90m, Date = DateTime.UtcNow },
    new Product { Id = 2, Name = "Mouse Logitech G502", SalesPerson = "Ana Souza", Value = 349.90m, Date = DateTime.UtcNow },
    new Product { Id = 3, Name = "Monitor LG UltraWide", SalesPerson = "Bruno Costa", Value = 1899.99m, Date = DateTime.UtcNow },
    new Product { Id = 4, Name = "Teclado Mecânico Redragon", SalesPerson = "Fernanda Lima", Value = 429.90m, Date = DateTime.UtcNow },
    new Product { Id = 5, Name = "iPhone 17", SalesPerson = "Ricardo Alves", Value = 7999.00m, Date = DateTime.UtcNow },
    new Product { Id = 6, Name = "Samsung Galaxy S26", SalesPerson = "Juliana Martins", Value = 6899.90m, Date = DateTime.UtcNow },
    new Product { Id = 7, Name = "Apple Watch Series 12", SalesPerson = "Lucas Pereira", Value = 3599.90m, Date = DateTime.UtcNow },
    new Product { Id = 8, Name = "Kindle Paperwhite", SalesPerson = "Mariana Rocha", Value = 799.90m, Date = DateTime.UtcNow },
    new Product { Id = 9, Name = "PlayStation 5 Pro", SalesPerson = "Gustavo Mendes", Value = 5499.90m, Date = DateTime.UtcNow },
    new Product { Id = 10, Name = "Xbox Series X", SalesPerson = "Patrícia Oliveira", Value = 4699.00m, Date = DateTime.UtcNow },
    new Product { Id = 11, Name = "Cadeira Gamer ThunderX3", SalesPerson = "Diego Santos", Value = 1499.90m, Date = DateTime.UtcNow },
    new Product { Id = 12, Name = "Headset HyperX Cloud III", SalesPerson = "Camila Ferreira", Value = 699.90m, Date = DateTime.UtcNow },
    new Product { Id = 13, Name = "Impressora HP LaserJet", SalesPerson = "Rafael Gomes", Value = 1299.90m, Date = DateTime.UtcNow },
    new Product { Id = 14, Name = "SSD Kingston 1TB", SalesPerson = "Beatriz Almeida", Value = 549.90m, Date = DateTime.UtcNow },
    new Product { Id = 15, Name = "Memória RAM Corsair 32GB", SalesPerson = "Felipe Barbosa", Value = 899.90m, Date = DateTime.UtcNow },
    new Product { Id = 16, Name = "Smart TV Samsung 55\"", SalesPerson = "Larissa Castro", Value = 3299.90m, Date = DateTime.UtcNow },
    new Product { Id = 17, Name = "Caixa de Som JBL Charge 6", SalesPerson = "Eduardo Ribeiro", Value = 999.90m, Date = DateTime.UtcNow },
    new Product { Id = 18, Name = "Drone DJI Mini 5", SalesPerson = "Vanessa Cardoso", Value = 4999.90m, Date = DateTime.UtcNow },
    new Product { Id = 19, Name = "Câmera Sony Alpha A7 IV", SalesPerson = "Thiago Moreira", Value = 12999.00m, Date = DateTime.UtcNow },
    new Product { Id = 20, Name = "MacBook Air M5", SalesPerson = "Renata Nogueira", Value = 10499.90m, Date = DateTime.UtcNow }
};

reports.AddProduct(products);
reports.Report_TotalSalesPerPerson();