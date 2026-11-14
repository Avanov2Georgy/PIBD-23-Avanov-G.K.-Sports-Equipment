using System.Collections.Generic;
using Sports_Equipment.Entities;
using Sports_Equipment.Repositories;

namespace Sports_Equipment.Repositories.Implementations
{
    internal class TariffRepository : ITariffRepository
    {
        public void CreateTariff(Tariff tariff) { }
        public void DeleteTariff(int id) { }
        public Tariff ReadTariffById(int id) => Tariff.CreateEntity(0, string.Empty, 0);
        public IEnumerable<Tariff> ReadTariffs() => [];
        public void UpdateTariff(Tariff tariff) { }
    }
}