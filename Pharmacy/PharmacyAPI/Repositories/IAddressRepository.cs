using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public interface IAddressRepository
    {
        List<Address> GetAll();
    }
}
