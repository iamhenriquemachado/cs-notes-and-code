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
        public void Add(StockMovement movement)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<StockMovement> GetByProductId(int productId)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<StockMovement> List()
        {
            throw new NotImplementedException();
        }
    }
}
