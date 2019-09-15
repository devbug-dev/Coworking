using Coworking.DataContracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Coworking.DataAccess.EntityConfig
{
    public class UserEntityConfig
    {

        public static void SetEntityBuilder(EntityTypeBuilder<UserEntity> entityBuilder)
        {

            entityBuilder.ToTable("Users");

            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.Id).IsRequired();

        }


    }
}
