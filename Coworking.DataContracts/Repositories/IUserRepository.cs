using System.Threading.Tasks;
using Coworking.DataContracts.Entities;

namespace Coworking.DataContracts.Repositories
{
    public interface IUserRepository : IRepository<UserEntity>
    {
        Task<UserEntity> Update(UserEntity entity);
    }
}
