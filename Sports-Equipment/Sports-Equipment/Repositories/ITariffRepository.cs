using System.Collections.Generic;
using Sports_Equipment.Entities;

namespace Sports_Equipment.Repositories
{
    public interface ITariffRepository
    {
        IEnumerable<Tariff> ReadTariffs();
        Tariff ReadTariffById(int id);
        void CreateTariff(Tariff tariff);
        void UpdateTariff(Tariff tariff);
        void DeleteTariff(int id);
    }
}
