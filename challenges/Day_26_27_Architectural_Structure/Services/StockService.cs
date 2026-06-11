using cs_notes_and_code.challenges.Day_26_30_Architectural_Structure.Domain.Entities;
using cs_notes_and_code.challenges.Day_26_30_Architectural_Structure.Domain.Interfaces;

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

        public void StockIn(int id, int quantity)
        {
            var getProductById = _productRepository.GetById(id);

            if (getProductById == null) throw new ArgumentNullException("ID invalid or null.");

            int increaseProduct = getProductById.Stock += quantity;
            StockMovement stockMovement = new StockMovement
            {
                ProductId = id,
                Quantity = increaseProduct,
                MovementType = StockMovement.Type.Inbound,
                Date = DateTime.Now
            };

            _stockRepository.Add(stockMovement);

        }

        public void StockOut(int id, int quantity)
        {

            var getProductById = _productRepository.GetById(id);

            if (getProductById == null) throw new ArgumentNullException("ID cannot be null.");

            if (getProductById.Stock < quantity) throw new ArgumentNullException("InsufficientStockException");

            getProductById.Stock += quantity;
        }
    }
}
