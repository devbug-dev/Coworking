using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Coworking.DataContracts.Entities;

namespace Coworking.DataContracts
{
    public interface ICoworkingDBContext
    {
        DbSet<UserEntity> Users { get; set; }
        DbSet<AdminEntity> Admins { get; set; }
        DbSet<BookingEntity> Bookings { get; set; }
        DbSet<OfficeEntity> Offices { get; set; }
        DbSet<Offices2RoomsEntity> Offices2Rooms { get; set; }
        DbSet<Room2ServicesEntity> Room2Services { get; set; }
        DbSet<RoomEntity> Rooms { get; set; }
        DbSet<ServiceEntity> Services { get; set; }



        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DatabaseFacade Database { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        void RemoveRange(IEnumerable<object> entities);
        EntityEntry Update(object entity);

    }
}

