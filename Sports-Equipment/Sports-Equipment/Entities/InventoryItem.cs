using Sports_Equipment.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Sports_Equipment.Entities
{
    public class InventoryItem
    {
        // Приватные сеттеры
        public int Id { get; private set; }

        [DisplayName("Название")]
        public string Name { get; private set; } = string.Empty;

        // Обычное перечисление для типа инвентаря
        [DisplayName("Тип")]
        public InventoryType Type { get; private set; }

        [DisplayName("Размер")]
        public string Size { get; private set; } = string.Empty;

        // Флаговое перечисление для состояния
        [DisplayName("Состояние")]
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
