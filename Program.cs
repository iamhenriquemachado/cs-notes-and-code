using cs_notes_and_code.challenges.Day_26_30_Architectural_Structure.Domain.Entities;
using cs_notes_and_code.challenges.Day_26_30_Architectural_Structure.Domain.Interfaces;
using cs_notes_and_code.challenges.Day_26_30_Architectural_Structure.Infrastructure;
using cs_notes_and_code.challenges.Day_26_30_Architectural_Structure.Services;


IProductRepository productRepository = new ProductRepository();
IStockMovementRepository stockRepository = new StockMovementRepository();

StockService service = new StockService(productRepository, stockRepository);


var products = new List<Product>
{
    new Product { Id = 1001, Name = "MacBook Pro", Price = 101.00m, Stock = 50 },
    new Product { Id = 1002, Name = "Dell XPS 13", Price = 120.00m, Stock = 35 },
    new Product { Id = 1003, Name = "Lenovo ThinkPad X1", Price = 95.50m, Stock = 40 },
    new Product { Id = 1004, Name = "HP EliteBook", Price = 89.99m, Stock = 25 },
    new Product { Id = 1005, Name = "Asus ZenBook", Price = 110.75m, Stock = 30 },
    new Product { Id = 1006, Name = "Acer Swift 3", Price = 79.90m, Stock = 45 },
    new Product { Id = 1007, Name = "Samsung Galaxy Book", Price = 99.99m, Stock = 20 },
    new Product { Id = 1008, Name = "Microsoft Surface Laptop", Price = 130.00m, Stock = 15 },
    new Product { Id = 1009, Name = "LG Gram", Price = 115.25m, Stock = 18 },
    new Product { Id = 1010, Name = "Razer Blade 15", Price = 145.00m, Stock = 12 }
};

foreach (var product in products)
{
    productRepository.Add(product);
}

Console.WriteLine("1 - Register Product");
Console.WriteLine("2 - Stock In ");
Console.WriteLine("3 - Stock Out");
Console.WriteLine("4 - List all products");
Console.WriteLine("5 - Low stock report");
Console.WriteLine("6 - Recent movements report");
Console.WriteLine("7 - Search supplier CEP");
Console.WriteLine("8 - Exit");