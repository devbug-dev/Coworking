using Microsoft.EntityFrameworkCore;

using Coworking.DataContracts;
using Coworking.DataContracts.Entities;
using Coworking.DataAccess.EntityConfig;

namespace Coworking.DataAccess
{
    public class CoworkingDBContext : DbContext, ICoworkingDBContext
    {

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<AdminEntity> Admins { get; set; }
        public DbSet<BookingEntity> Bookings { get; set; }
        public DbSet<OfficeEntity> Offices { get; set; }
        public DbSet<Offices2RoomsEntity> Offices2Rooms { get; set; }
        public DbSet<Room2ServicesEntity> Room2Services { get; set; }
        public DbSet<RoomEntity> Rooms { get; set; }
        public DbSet<ServiceEntity> Services { get; set; }


        public CoworkingDBContext(DbContextOptions<CoworkingDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            AdminEntityConfig.SetEntityBuilder(builder.Entity<AdminEntity>());
            BookingEntityConfig.SetEntityBuilder(builder.Entity<BookingEntity>());
            Office2RoomEntityConfig.SetEntityBuilder(builder.Entity<Offices2RoomsEntity>());
            OfficeEntityConfig.SetEntityBuilder(builder.Entity<OfficeEntity>());
            Room2ServiceEntityConfig.SetEntityBuilder(builder.Entity<Room2ServicesEntity>());
            AdminEntityConfig.SetEntityBuilder(builder.Entity<AdminEntity>());
            RoomEntityConfig.SetEntityBuilder(builder.Entity<RoomEntity>());
            ServiceEntityConfig.SetEntityBuilder(builder.Entity<ServiceEntity>());
            UserEntityConfig.SetEntityBuilder(builder.Entity<UserEntity>());

            base.OnModelCreating(builder);

        }

    }
}
