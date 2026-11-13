using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports_Equipment.Entities
{
    public class Client
    {
        // Приватные сеттеры
        public int Id { get; private set; }
        public string FullName { get; private set; } = string.Empty;
        public string Phone { get; private set; } = string.Empty;
        public string Document { get; private set; } = string.Empty;

        // Статический метод создания объекта
        public static Client CreateEntity(int id, string fullName, string phone, string document)
        {
            return new Client
            {
                Id = id,
                FullName = fullName ?? string.Empty,
                Phone = phone ?? string.Empty,
                Document = document ?? string.Empty
            };
        }
    }
}
