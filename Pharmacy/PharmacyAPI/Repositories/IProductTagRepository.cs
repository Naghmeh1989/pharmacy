using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public interface IProductTagRepository
    {
        List<ProductsTag> GetAll();
    }
}
