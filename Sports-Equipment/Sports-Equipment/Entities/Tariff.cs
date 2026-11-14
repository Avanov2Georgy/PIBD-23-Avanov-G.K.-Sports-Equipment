using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Sports_Equipment.Entities
{
    public class Tariff
    {
        // Приватные сеттеры
        public int Id { get; private set; }

        [DisplayName("Название")]
        public string Name { get; private set; } = string.Empty;

        // decimal используется для точных цен
        [DisplayName("Цена")]
        public decimal Price { get; private set; } 

        public static Tariff CreateEntity(int id, string name, decimal price)
        {
            return new Tariff
            {
                Id = id,
                Name = name ?? string.Empty,
                Price = price
            };
        }
    }
}
