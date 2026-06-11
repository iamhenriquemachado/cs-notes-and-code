using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_notes_and_code.challenges.Day_26_30_Architectural_Structure.Domain.Entities
{
    internal class StockMovement
    {
        public int ProductId { get; set; }
        public enum Type
        {
            Inbound,
            Outbound
        }

        public Type MovementType { get; set; }

        public decimal Quantity { get; set; }
        public DateTime Date { get; set; }
    }
}
