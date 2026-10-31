using Sports_Equipment.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports_Equipment.Entities
{
    public class InventoryItem
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public InventoryType Type { get; private set; }
        public string Size { get; private set; } = string.Empty;
        public InventoryCondition Condition { get; private set; }

        public static InventoryItem CreateEntity(int id, string name, InventoryType type, string size, InventoryCondition condition)
        {
            return new InventoryItem
            {
                Id = id,
                Name = name ?? string.Empty,
                Type = type,
                Size = size ?? string.Empty,
                Condition = condition
            };
        }
    }
}
