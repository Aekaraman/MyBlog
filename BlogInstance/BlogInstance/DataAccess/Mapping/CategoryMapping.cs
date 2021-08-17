using System;
using BlogInstance.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogInstance.DataAccess.Mapping
{
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryID);
            builder.Property(c => c.CategoryID).ValueGeneratedOnAdd();
            builder.Property(c => c.CategoryName).IsRequired();
            builder.Property(c => c.CategoryName).HasMaxLength(50);
            builder.Property(c => c.CategoryDescription).HasMaxLength(500);
            builder.Property(c => c.CreatedByName).IsRequired();
            builder.Property(c => c.CreatedByName).HasMaxLength(50);
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.IsActive);
            builder.Property(c => c.IsDeleted);

            builder.ToTable("Categories");

            builder.HasData(new Category
            {
                CategoryID = 1,
                CategoryName="C#",
                CategoryDescription="C# Programlama Dili ile İlgili En Güncel Bilgiler ",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
            },
            new Category
            {
                CategoryID = 2,
                CategoryName = "JavaScript",
                CategoryDescription = "JavaScript Programlama Dili ile İlgili En Güncel Bilgiler ",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
            }
            ) ;

        }
    }
}
