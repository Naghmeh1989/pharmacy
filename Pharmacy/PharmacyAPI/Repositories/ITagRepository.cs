using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public interface ITagRepository
    {
        List<Tag> GetAll();
        Tag? GetById(int id);
        Tag Create(Tag tag);
        Tag? Delete(int id);
        Tag? Update(int id,Tag tag);

    }
}
