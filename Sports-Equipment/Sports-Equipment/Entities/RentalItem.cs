using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports_Equipment.Entities
{
    public class RentalItem
    {
        public int Id { get; private set; }
        public int RentalId { get; private set; }
        public int InventoryItemId { get; private set; }

        public static RentalItem CreateEntity(int id, int rentalId, int inventoryItemId)
        {
            return new RentalItem
            {
                Id = id,
                RentalId = rentalId,
                InventoryItemId = inventoryItemId
            };
        }
    }
}
