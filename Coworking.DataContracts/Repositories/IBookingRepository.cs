using System.Threading.Tasks;
using Coworking.DataContracts.Entities;

namespace Coworking.DataContracts.Repositories
{
    public interface IBookingRepository : IRepository<BookingEntity>
    {
        Task<BookingEntity> Update(BookingEntity entity);
    }
}
