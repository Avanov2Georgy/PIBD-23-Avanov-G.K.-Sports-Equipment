using System.Collections.Generic;
using Sports_Equipment.Entities;

namespace Sports_Equipment.Repositories
{
    public interface IRentalRepository
    {
        IEnumerable<Rental> ReadRentals();
        void CreateRental(Rental rental);
    }
}