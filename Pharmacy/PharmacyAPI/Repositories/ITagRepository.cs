using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public interface ITagRepository
    {
        List<Tag> GetAll();
    }
}
