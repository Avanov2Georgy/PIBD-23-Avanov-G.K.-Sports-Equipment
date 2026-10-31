using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports_Equipment.Entities
{
    public class Tariff
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
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
