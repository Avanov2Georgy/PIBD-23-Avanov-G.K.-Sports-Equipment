using System.Collections.Generic;
using Sports_Equipment.Entities;
using Sports_Equipment.Repositories;

namespace Sports_Equipment.Repositories.Implementations
{
    internal class RentalRepository : IRentalRepository
    {
        public void CreateRental(Rental rental) { }
        public IEnumerable<Rental> ReadRentals() => [];
    }
}