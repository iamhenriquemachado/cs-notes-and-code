using System;

namespace cs_notes_and_code.challenges.ProductSystemCrud
{
    internal class Product
    {
        public int Id { get; init; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public decimal TotalStockValue { get; }

        public Product(string name, decimal price, int stock)
        {
            this.Name = name;
            this.Price = price;
            this.Stock = stock;

            if (name == null || name == "")
            {
                throw new ArgumentException("Name cannot be null or empty.");
            }

            if (price <= 0)
            {
                throw new ArgumentException("Price cannot be equal or less than 0.");
            }

            this.TotalStockValue = Price * Stock;
        }
    }
}