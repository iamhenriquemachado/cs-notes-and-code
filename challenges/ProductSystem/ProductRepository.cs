using System;
using System.Diagnostics;
using System.Xml.Linq;


namespace cs_notes_and_code.challenges.ProductSystemCrud
{

    internal class ProductRepository
    {
        private List<Product> _product = new List<Product>();

        public void AddProduct(int id, string name, decimal price, int stock)
        {
            Product product = new(id, name, price, stock);

            _product.Add(product);

            Console.WriteLine($"Adding product to the list...");
            Console.WriteLine($"New product added {product.Id} - {product.Name} -  {product.Price} - {product.Stock} - {product.TotalStockValue}");
        }

        public void SearchById(int id)
        {
            bool found = false;

            var searchItemById = _product.Where(product => product.Id == id)
                .FirstOrDefault();

            if (searchItemById.Id != null)
            {
                found = true;
                Console.WriteLine("Item found...");
                Console.WriteLine($"{searchItemById.Name.ToString()}");
            }

            if (!found)
            {
                Console.WriteLine("Item not found...");
            }
            
        }

        public void RemoveById(int id)
        {
            bool found = false;

            var searchItemById = _product.Where(product => product.Id == id).FirstOrDefault();

            if (searchItemById !=  null)
            {
                found = true;
                Console.WriteLine("Item deleted...");
            }

            if(!found)
            {
                Console.WriteLine("Item not found...");
            }
        }
    }
}
