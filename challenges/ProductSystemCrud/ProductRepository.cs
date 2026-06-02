using System;
using System.Diagnostics;
using System.Xml.Linq;


namespace cs_notes_and_code.challenges.ProductSystemCrud
{

    internal class ProductRepository
    {
        private List<Product> _product = new List<Product>();

        public void AddProduct(string name, decimal price, int stock)
        {


            Product product = new(name, price, stock);

            _product.Add(product);

            Console.WriteLine($"Adding product to the list...");
            Console.WriteLine($"New product added {product.Id} - {product.Name} -  {product.Price} - {product.Stock} - {product.TotalStockValue}");
        }
    }
}
