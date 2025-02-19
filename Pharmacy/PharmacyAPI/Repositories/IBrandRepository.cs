using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public interface IBrandRepository
    {
        List<Brand> GetAll();
        Brand? FindById(int id);
        Brand Create(Brand brand);
        Brand? Delete(int id);
        Brand? Update(int id,Brand brand);

    }
}
