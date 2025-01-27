using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public interface IBrandRepository
    {
        List<Brand> GetAll();
    }
}
