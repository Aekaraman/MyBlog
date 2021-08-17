using BlogInstance.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogInstance.DataAccess.Mapping
{
    public class UserAndCategoryMapping :IEntityTypeConfiguration<UserAndCategory>
    {
        public void Configure(EntityTypeBuilder<UserAndCategory> builder)
        {
            builder.HasKey(bc => new { bc.UserID, bc.CategoryID });
           
            builder.HasOne(bc => bc.User)
              .WithMany(b => b.UserAndCategories)
              .HasForeignKey(bc => bc.UserID);
            
            builder.HasOne(bc => bc.Category)
                .WithMany(c => c.UserAndCategories)
                .HasForeignKey(bc => bc.CategoryID);

        }
    }
}
