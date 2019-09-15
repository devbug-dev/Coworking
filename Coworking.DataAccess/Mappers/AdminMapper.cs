using Coworking.Business.Models;
using Coworking.DataContracts.Entities;

namespace Coworking.DataAccess.Mappers
{
    public class AdminMapper
    {
        public static AdminEntity Map(Admin dto)
        {
            return new AdminEntity()
            {
                Email = dto.Email,
                Id = dto.Id,
                Name = dto.Name,
                Phone = dto.Phone
            };
        }

        public static Admin Map(AdminEntity entity)
        {
            return new Admin()
            {
                Email = entity.Email,
                Id = entity.Id,
                Name = entity.Name,
                Phone = entity.Phone
            };
        }
    }
}