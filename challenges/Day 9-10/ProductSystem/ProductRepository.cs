using System;
using System.Collections.Generic;
using System.Linq;

namespace cs_notes_and_code.challenges.ProductSystemCrud
{
    internal class ProductRepository
    {
        private readonly List<Product> _products = new List<Product>();

        public void AddProduct(int id, string name, decimal price, int stock)
        {
            Product product = new(id, name, price, stock);
            _products.Add(product);

            Console.WriteLine("Adding product to the list...");
            Console.WriteLine($"New product added: {product.Id} - {product.Name} - {product.Price:C} - {product.Stock} units - Total Value: {product.TotalStockValue:C}");
        }

        public void SearchById(int id)
        {
            
            var searchItemById = _products.FirstOrDefault(product => product.Id == id);

            
            if (searchItemById != null)
            {
                Console.WriteLine("Item found...");
                Console.WriteLine($"{searchItemById.Name}"); 
            }
            else
            {
                Console.WriteLine("Item not found...");
            }
        }

        public void RemoveById(int id)
        {
            var searchItemById = _products.FirstOrDefault(product => product.Id == id);

            if (searchItemById != null)
            {
                _products.Remove(searchItemById);
                Console.WriteLine("Item deleted...");
            }
            else
            {
                Console.WriteLine("Item not found...");
            }
        }

        public void UpdateById(int id, string name, decimal price, int stock)
        {
            var searchItemById = _products.FirstOrDefault(product => product.Id == id);

            if (searchItemById != null)
            {
                searchItemById.Name = name;
                searchItemById.Price = price;
                searchItemById.Stock = stock;

                Console.WriteLine("Product updated...");
                Console.WriteLine($"Updated Name: {searchItemById.Name}");
            }
            else
            {
                Console.WriteLine("Item not found");
            }
        }

        public void ListAll()
        {

            if (!_products.Any())
            {
                Console.WriteLine("The product catalog is currently empty.");
                return;
            }

            foreach (var product in _products)
            {
                Console.WriteLine($"Product name: {product.Name} / Product ID: {product.Id}");
            }
        }
    }
}