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

            if (getProductById == null) throw new ArgumentNullException(nameof(id), "ID invalid or null.");

            int increaseProductMovement = getProductById.Stock += quantity;
            StockMovement stockMovement = new StockMovement
            {
                ProductId = id,
                Quantity = increaseProductMovement,
                MovementType = StockMovement.Type.Inbound,
                Date = DateTime.Now
            };

            _stockRepository.Add(stockMovement);

        }

        public void StockOut(int id, int quantity)
        {

            var getProductById = _productRepository.GetById(id);

            if (getProductById == null) throw new Exception("ID cannot be null.");
            if (getProductById.Stock < quantity) throw new Exception("InsufficientStockException");

            int decreaseProductMovement = getProductById.Stock -= quantity;
            StockMovement stockMovement = new StockMovement
            {
                ProductId = id,
                Quantity = quantity,
                MovementType = StockMovement.Type.Outbound,
                Date = DateTime.Now
            };

            _stockRepository.Add(stockMovement);
        }
    }
}
