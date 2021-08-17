using System;
using BlogInstance.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogInstance.DataAccess.Mapping
{
    public class RoleMapping : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(r => r.RoleId);
            builder.Property(r => r.RoleId).ValueGeneratedOnAdd();
            builder.Property(r => r.RoleName).IsRequired();
            builder.Property(r => r.RoleName).HasMaxLength(30);
            builder.Property(r => r.RoleDescription).IsRequired();
            builder.Property(r => r.RoleDescription).HasMaxLength(250);
            builder.Property(r => r.CreatedByName).IsRequired();
            builder.Property(r => r.CreatedByName).HasMaxLength(50);
            builder.Property(r => r.CreatedDate).IsRequired();
            builder.Property(r => r.IsActive).IsRequired();
            builder.Property(r => r.IsDeleted).IsRequired();

            builder.ToTable("Roles");
            //böyle bir veri var mı?
            builder.HasData(new Role
            {
                RoleId = 1,
                RoleName = "Admin",
                RoleDescription = "Admin Rolü, Tüm Haklara Sahiptir.",
                IsActive = true,
                IsDeleted=false,
                CreatedByName="InitialCreate",
                CreatedDate=DateTime.Now,        
                ModifiedDate= DateTime.Now,


            });
            

        }
    }
}
