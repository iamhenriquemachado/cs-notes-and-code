using cs_notes_and_code.challenges.Day_26_30_Architectural_Structure.Domain.Entities;
using cs_notes_and_code.challenges.Day_26_30_Architectural_Structure.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.Day_26_30_Architectural_Structure.Infrastructure
{
    internal class StockMovementRepository : IStockMovementRepository
    {

        private readonly List<StockMovement> _movements = new();
        public void Add(StockMovement movement)
        {
            _movements.Add(movement);
        }

        public IReadOnlyList<StockMovement> GetByProductId(int productId)
        {
            var stockMovements = _movements.Where(m => m.ProductId == productId).ToList();
            return stockMovements;
        }

        public IReadOnlyList<StockMovement> List()
        {
            return _movements;
        }
    }
}
