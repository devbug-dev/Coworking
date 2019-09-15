using Coworking.Business.Models;
using Coworking.DataContracts.Entities;

namespace Coworking.DataAccess.Mappers
{
    public static class ServiceMapper
    {

        public static ServiceEntity Map(Service dto)
        {
            return new ServiceEntity()
            {
                Active = dto.Active,
                Id = dto.Id,
                Name = dto.Name,
                Price = dto.Price
            };
        }

        public static Service Map(ServiceEntity entity)
        {
            return new Service()
            {
                Price = entity.Price,
                Name = entity.Name,
                Id = entity.Id,
                Active = entity.Active
            };
        }

    }
}
