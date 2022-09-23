using IKProject.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.DAL.Concrete.Context.EntityTypeConfiguration
{
    class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(a => a.ID);

            builder.Property(a => a.ID).UseIdentityColumn();

            builder.Property(a => a.CreatedDate).IsRequired();
            
            builder.Property(a => a.Name).HasMaxLength(20).IsRequired();

            builder.Property(a => a.Surname).HasMaxLength(20).IsRequired();

            builder.Property(a => a.TC).HasMaxLength(12).IsRequired();
            builder.HasIndex(a => a.TC).IsUnique();

            builder.HasIndex(a => a.Mail).IsUnique();
            builder.Property(a => a.BirthDate).IsRequired();           

            builder.Property(a => a.Title).HasMaxLength(30).IsRequired();

            builder.Property(a => a.StartDate).IsRequired();

            builder.Property(a => a.PhoneNumber).HasMaxLength(13).IsRequired();

            builder.Property(a => a.Adress).HasMaxLength(250);

            

            
            

            builder.HasOne(a => a.Company)
                .WithMany(a => a.Users)
                .HasForeignKey(a => a.CompanyID);


            builder.HasOne(a => a.Department)
               .WithMany(a => a.Users)
               .HasForeignKey(a => a.DepartmentID);

            builder.HasOne(a => a.RolType)
               .WithMany(a => a.Users)
               .HasForeignKey(a => a.RolTypeID);



        }
    }
}
