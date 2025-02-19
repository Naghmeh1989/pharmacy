using PharmacyAPI.Models;

namespace PharmacyAPI.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly PharmacyDbContext dbContext;

        public CategoryRepository(PharmacyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Category Create(Category category)
        {
            dbContext.Categories.Add(category);
            dbContext.SaveChanges();
            return category;
        }

        public Category? Delete(int id)
        {
            var category = dbContext.Categories.Find(id);
            if (category == null) 
            { 
                return null;
            }
            dbContext.Categories.Remove(category);
            dbContext.SaveChanges();
            return category;
        }

        public List<Category> GetAll()
        {
            return dbContext.Categories.ToList();
        }

        public Category? GetById(int id)
        {
            return dbContext.Categories.Find(id);
        }

        public Category? Update(int id, Category category)
        {
            var existingCategory = dbContext.Categories.Find(id);
            if (existingCategory == null)
            {
                return null;
            }
            existingCategory.Name = category.Name;
            existingCategory.CreatedDate = category.CreatedDate;
            existingCategory.ModifiedDate = category.ModifiedDate;
            existingCategory.ModifiedBy = category.ModifiedBy;
            existingCategory.CreatedBy = category.CreatedBy;
            dbContext.SaveChanges();
            return existingCategory;
        }
    }
}
