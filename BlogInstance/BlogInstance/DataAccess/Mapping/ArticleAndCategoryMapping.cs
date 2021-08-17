using BlogInstance.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogInstance.DataAccess.Mapping
{
    public class ArticleAndCategoryMapping : IEntityTypeConfiguration<ArticleAndCategory>
    {
        public void Configure(EntityTypeBuilder<ArticleAndCategory> builder)
        {
            

            builder.HasKey(ac => new { ac.ArticleID, ac.CategoryID });
            
            builder.HasOne(ac => ac.Article)
                .WithMany(b => b.ArticleAndCategories)
                .HasForeignKey(ac => ac.ArticleID);
            
            builder.HasOne(ac => ac.Category)
                .WithMany(c => c.ArticleAndCategories)
                .HasForeignKey(ac => ac.CategoryID);
        }
    }
}
