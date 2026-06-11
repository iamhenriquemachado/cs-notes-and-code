using cs_notes_and_code.challenges.Day_26_30_Architectural_Structure.Domain.Entities;
using cs_notes_and_code.challenges.Day_26_30_Architectural_Structure.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.Day_26_30_Architectural_Structure.Infrastructure
{
    internal class ProductRepository : IProductRepository
    {
        List<Product> _productsList = new List<Product>();
        public void Add(Product product)
        {
            if (product != null)
            {
                _productsList.Add(product);
            }
        }

        public Product? GetById(int id)
        {
            var productFound = _productsList.FirstOrDefault(p => p.Id == id);
            return productFound;
        }

        public IReadOnlyList<Product> List()
        {

            var result = _productsList.ToList();

            foreach (var p in result)
            {
                Console.WriteLine($"{p.Id,-3} | {p.Name,-21} | {p.Price,-15} | {p.Stock}");
            }

            return result;
        }

        public void Remove(int id)
        {
            var productFound = _productsList.FirstOrDefault(p => p.Id == id);
            if (productFound != null)
            {
                _productsList.Remove(productFound);
            }
        }
    }
}
