using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    
    public class TagRepository : ITagRepository
    {
        private readonly PharmacyDbContext dbContext;

        public TagRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Tag Create(Tag tag)
        {
            dbContext.Tags.Add(tag);
            dbContext.SaveChanges();
            return tag;
        }

        public Tag? Delete(int id)
        {
            var tag = dbContext.Tags.Find(id);
            if (tag == null) 
            { 
                return null;
            }
            dbContext.Tags.Remove(tag);
            dbContext.SaveChanges();
            return tag;
        }

        public List<Tag> GetAll()
        {
            return dbContext.Tags.ToList();
        }

        public Tag? GetById(int id)
        {
            return dbContext.Tags.Find(id);
        }

        public Tag? Update(int id, Tag tag)
        {
            var existingTag = dbContext.Tags.Find(id);
            if (existingTag == null)
            {
                return null;
            }
            existingTag.CreatedDate = tag.CreatedDate;
            existingTag.ModifiedDate = tag.ModifiedDate;
            existingTag.CreatedBy = tag.CreatedBy;
            existingTag.ModifiedBy = tag.ModifiedBy;
            existingTag.Name = tag.Name;
            dbContext.SaveChanges();
            return existingTag;
        }
    }
}
