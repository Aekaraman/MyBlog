using System.Collections.Generic;
using System.Linq;
using BlogInstance.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogInstance.DataAccess.Repositories
{
    public class CategoryRepository
    {
        BlogDbContext dbContext;
        public CategoryRepository(BlogDbContext blogDb)
        {
            dbContext = blogDb;
        }

        public void AddCategory(Category category)
        {
            var create = dbContext.Categories.SingleOrDefault(a => a.CategoryID == category.CategoryID);
            dbContext.Categories.Add(category);
            dbContext.SaveChanges();
        }
        public void DeleteCategory(int id)
        {
            Category selected = dbContext.Categories.SingleOrDefault(a => a.CategoryID == id);
            selected.IsActive = false;
            //or remove
            dbContext.SaveChanges();
        }
        public void UpdateCategory(Article article)
        {
            var post = dbContext.Entry(article);
            post.State = EntityState.Modified;
            dbContext.SaveChanges();

        }
        public List<Category> GetCategories()
        {
            return dbContext.Categories.ToList();
          
        }

    }
}
