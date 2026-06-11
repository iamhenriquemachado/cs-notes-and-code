using cs_notes_and_code.challenges.Day_26_30_Architectural_Structure.Domain.Interfaces;
using cs_notes_and_code.challenges.Day_26_30_Architectural_Structure.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.Day_26_30_Architectural_Structure.Services
{
    internal class StockService
    {
        private readonly IProductRepository _productRepository;
        private readonly IStockMovementRepository _stockRepository;

        public StockService(IProductRepository productRepository, IStockMovementRepository stockRepository)
        {
            _productRepository = productRepository;
            _stockRepository = stockRepository;
        }
    }
}
