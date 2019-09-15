using System.Threading.Tasks;
using Coworking.DataContracts.Entities;

namespace Coworking.DataContracts.Repositories
{
    public interface IServicesRepository : IRepository<ServiceEntity>
    {
        Task<ServiceEntity> Update(ServiceEntity entity);
    }
}
