using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cs_notes_and_code.challenges.Day_19_20;
using cs_notes_and_code.challenges.EmployeeSystem;

namespace cs_notes_and_code.challenges.Day_19_20
{
    internal class Reports
    {
        List<Product> _product = new List<Product>();

        public void AddProduct(List<Product> product)
        {

            if (product == null) throw new ArgumentNullException("Cannot insert a null product list.");
            _product.AddRange(product);

            Console.WriteLine($"{"ID",-4} | {"Name",-30} | {"SalesPerson",-20} | {"Value",12} | {"Date",-10}");

            Console.WriteLine($"{new string('-', 4)}-+-{new string('-', 30)}-+-{new string('-', 20)}-+-{new string('-', 12)}-+-{new string('-', 10)}");

            foreach (var p in product)
            {
                Console.WriteLine(
                    $"{p.Id,-4} | " +
                    $"{p.Name,-30} | " +
                    $"{p.SalesPerson,-20} | " +
                    $"{p.Value,12:C2} | " +
                    $"{p.Date:dd/MM/yyyy}");
            }
        }

        public void Report_TotalSalesPerPerson()
        {
            var query = _product
                .GroupBy(a => a.SalesPerson)
                .Select(b => new
                {
                    SalesPerson = b.Key,
                    Value = b.Sum(c => c.Value)
                })
                .OrderByDescending(x => x.Value)
                .ToList();


            Console.WriteLine($" {"SalesPerson",-20} | {"Value",5} ");
            query.ForEach(query => Console.WriteLine($"{query.SalesPerson,-20} | {query.Value,12:C2}"));

        }
    }
}
