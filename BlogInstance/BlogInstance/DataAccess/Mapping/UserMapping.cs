using System;
using System.Text;
using BlogInstance.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogInstance.DataAccess.Mapping
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        
        void IEntityTypeConfiguration<User>.Configure(EntityTypeBuilder<User> builder)
        {
            //builder.ToTable("User");
            //builder.HasMany(a => a.)
            //    .WithOne()
            //    .HasForeignKey();
            builder.HasKey(u => u.UserID);
            builder.Property(u => u.UserID).ValueGeneratedOnAdd();
            builder.Property(u => u.UserEmail).IsRequired();
            builder.Property(u => u.UserEmail).HasMaxLength(50);
            builder.HasIndex(u => u.UserEmail).IsUnique();
            builder.Property(u => u.UserName).IsRequired();
            builder.Property(u => u.UserName).HasMaxLength(20);
            builder.HasIndex(u => u.UserName).IsUnique();
            builder.Property(u => u.UserFirstName).HasMaxLength(30);
            builder.Property(u => u.UserFirstName).IsRequired();
            builder.Property(u => u.UserLastName).HasMaxLength(50);
            builder.Property(u => u.UserLastName).IsRequired();
            builder.Property(u => u.UserPassword).IsRequired();
            builder.Property(u => u.UserPassword).HasColumnType("VARBINARY(500)");
            
            builder.Property(u => u.UserDescription).HasMaxLength(500);
            //builder.Property(u => u.CreatedByName).IsRequired();
            builder.Property(u => u.CreatedByName).HasMaxLength(50);
            builder.Property(u => u.CreatedDate).IsRequired();
            builder.Property(u => u.IsActive).IsRequired();
            //builder.Property(u => u.IsDeleted).IsRequired();

            builder.HasOne<Role>(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId);

            builder.ToTable("Users");

            builder.HasData(new User
            {
                UserID = 1,
                RoleId = 1,
                UserFirstName = "Emre",
                UserLastName = "Karaman",
                UserName = "aekaraman",
                UserEmail = "aekaramanofficial@gmail.com",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedDate=DateTime.Now,
                UserDescription="İlk admin Kullanıcı",
                UserPassword=  Encoding.ASCII.GetBytes("f1b3c1b4c0335e6906ee0dcf96d0b617")
                

            }) ;

        }
    }
}
