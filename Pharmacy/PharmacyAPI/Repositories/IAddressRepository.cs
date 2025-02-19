using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public interface IAddressRepository
    {
        List<Address> GetAll();
        Address? GetById(int id);
        Address Create(Address address);
        Address? Delete(int id);
        Address? Update(int id,Address address);
    }
}
