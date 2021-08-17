using BlogInstance.DataAccess.Entities;
using BlogInstance.DataAccess.Mapping;
using Microsoft.EntityFrameworkCore;

namespace BlogInstance.DataAccess
{
    public class BlogDbContext: DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
           

        }

       
        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Role> Roles { get; set; }
        public  DbSet<ArticleAndCategory> ArticleAndCategories { get; set; }
        public DbSet<UserAndCategory> UserAndCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration(new UserMapping());
            modelBuilder.ApplyConfiguration(new CategoryMapping());
            modelBuilder.ApplyConfiguration(new ArticleMapping());
            modelBuilder.ApplyConfiguration(new RoleMapping());
            modelBuilder.ApplyConfiguration(new ArticleAndCategoryMapping());
            modelBuilder.ApplyConfiguration(new UserAndCategoryMapping());

            //base.OnModelCreating(modelBuilder);

        }




    }
}
