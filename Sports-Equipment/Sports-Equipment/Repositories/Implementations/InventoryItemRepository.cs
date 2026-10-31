using System.Collections.Generic;
using Sports_Equipment.Entities;
using Sports_Equipment.Entities.Enums;
using Sports_Equipment.Repositories;

namespace Sports_Equipment.Repositories.Implementations
{
    internal class InventoryItemRepository : IInventoryItemRepository
    {
        public void CreateInventoryItem(InventoryItem item) { }
        public void DeleteInventoryItem(int id) { }
        public InventoryItem ReadInventoryItemById(int id) =>
            InventoryItem.CreateEntity(0, string.Empty, InventoryType.None, string.Empty, InventoryCondition.None);
        public IEnumerable<InventoryItem> ReadInventoryItems() => [];
        public void UpdateInventoryItem(InventoryItem item) { }
    }
}