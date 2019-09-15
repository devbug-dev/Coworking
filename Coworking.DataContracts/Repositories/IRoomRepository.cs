using System.Threading.Tasks;
using Coworking.DataContracts.Entities;

namespace Coworking.DataContracts.Repositories
{
    public interface IRoomRepository : IRepository<RoomEntity>
    {
        Task<RoomEntity> Update(RoomEntity entity);
    }
}
