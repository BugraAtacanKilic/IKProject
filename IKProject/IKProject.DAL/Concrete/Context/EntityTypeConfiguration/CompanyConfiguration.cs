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
    class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(a => a.ID);
            builder.Property(a => a.ID).UseIdentityColumn();

            builder.Property(a => a.Name).HasMaxLength(100).IsRequired();

            builder.Property(a => a.MailTag).HasMaxLength(50).IsRequired();
            builder.HasIndex(a => a.MailTag).IsUnique();

            builder.Property(a => a.LogoPath).IsRequired();

            builder.Property(a => a.Description).HasMaxLength(300).IsRequired();

            builder.Property(a => a.Adress).HasMaxLength(250).IsRequired();

            builder.Property(a => a.Phone).HasMaxLength(13).IsRequired();

            builder.Property(a => a.CreatedDate).IsRequired();

            builder.Property(a => a.ModifiedDate).IsRequired();


          
           
        }
    }
}
