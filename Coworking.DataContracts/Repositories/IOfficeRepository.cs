using System.Threading.Tasks;
using Coworking.DataContracts.Entities;

namespace Coworking.DataContracts.Repositories
{
    public interface IOfficeRepository : IRepository<OfficeEntity>
    {
        Task<OfficeEntity> Update(OfficeEntity entity);
    }
}
