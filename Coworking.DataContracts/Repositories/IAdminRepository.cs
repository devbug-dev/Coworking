using System.Threading.Tasks;
using Coworking.DataContracts.Entities;

namespace Coworking.DataContracts.Repositories
{
    public interface IAdminRepository : IRepository<AdminEntity>
    {
        Task<AdminEntity> Update(AdminEntity entity);
    }

}