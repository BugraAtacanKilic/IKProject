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
    public class RolTypeConfiguration : IEntityTypeConfiguration<RolType>
    {
        public void Configure(EntityTypeBuilder<RolType> builder)
        {
            builder.HasKey(a => a.ID);
            builder.Property(a => a.ID).UseIdentityColumn();

            builder.Property(a => a.Name).HasMaxLength(150).IsRequired();
        }
    }
}
