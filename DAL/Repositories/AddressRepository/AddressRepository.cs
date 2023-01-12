

using DAL.Data;
using DAL.Models;

namespace DAL.Repositories.AddressRepository
{
    public class AddressRepository : GenericRepository.GenericRepository<Address>, IAddressRepository
    {
        public AddressRepository(ProiectContext context) : base(context)
        {
        }
    }
}
