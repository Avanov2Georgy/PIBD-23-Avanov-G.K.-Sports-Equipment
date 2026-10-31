using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports_Equipment.Entities
{
    public class Rental
    {
        public int Id { get; private set; }
        public int ClientId { get; private set; }
        public int TariffId { get; private set; }
        public DateTime IssueDate { get; private set; }
        public DateTime? ReturnDate { get; private set; }
        public decimal TotalCost { get; private set; }

        // Поля для отображения (чтобы не выводить ID в таблицу)
        public string ClientName { get; private set; } = string.Empty;
        public string TariffName { get; private set; } = string.Empty;

        // Список для связи
        public List<RentalItem> RentalItems { get; private set; } = new();

        public static Rental CreateEntity(int id, int clientId, int tariffId, DateTime issueDate,
            DateTime? returnDate, decimal totalCost, string clientName = "", string tariffName = "")
        {
            return new Rental
            {
                Id = id,
                ClientId = clientId,
                TariffId = tariffId,
                IssueDate = issueDate,
                ReturnDate = returnDate,
                TotalCost = totalCost,
                ClientName = clientName ?? string.Empty,
                TariffName = tariffName ?? string.Empty
            };
        }

        public void SetRentalItems(List<RentalItem> items)
        {
            RentalItems = items ?? new List<RentalItem>();
        }
    }
}
