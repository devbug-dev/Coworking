using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Coworking.DataContracts.Entities;

namespace Coworking.DataAccess.EntityConfig
{
    public class AdminEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<AdminEntity> entityBuilder)
        {

            entityBuilder.ToTable("Admins");

            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();

            //entityBuilder.HasOne(x => x.Office).WithOne(x => x.Admin);

        }


    }
}
