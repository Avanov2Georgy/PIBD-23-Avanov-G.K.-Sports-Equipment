using System.Collections.Generic;
using Sports_Equipment.Entities;

namespace Sports_Equipment.Repositories
{
    public interface IInventoryItemRepository
    {
        IEnumerable<InventoryItem> ReadInventoryItems();
        InventoryItem ReadInventoryItemById(int id);
        void CreateInventoryItem(InventoryItem item);
        void UpdateInventoryItem(InventoryItem item);
        void DeleteInventoryItem(int id);
    }
}