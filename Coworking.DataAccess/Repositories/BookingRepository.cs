using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using Coworking.DataContracts;
using Coworking.DataContracts.Entities;
using Coworking.DataContracts.Repositories;

namespace Coworking.DataAccess.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        //CRUD --> CREATE READ UPDATE DELETE

        private readonly ICoworkingDBContext _coworkingDBContext;

        public BookingRepository(ICoworkingDBContext coworkingDBContext)
        {
            _coworkingDBContext = coworkingDBContext;
        }

        public async Task<BookingEntity> Update(int idEntity, BookingEntity updateEnt)
        {

            var entity = await Get(idEntity);

            entity.RentWorkSpace = updateEnt.RentWorkSpace;

            _coworkingDBContext.Bookings.Update(entity);

            await _coworkingDBContext.SaveChangesAsync();

            return entity;
        }

        public async Task<BookingEntity> Update(BookingEntity entity)
        {

            var updateEntity = _coworkingDBContext.Bookings.Update(entity);

            await _coworkingDBContext.SaveChangesAsync();

            return updateEntity.Entity;
        }

        public async Task<BookingEntity> Add(BookingEntity entity)
        {

            await _coworkingDBContext.Bookings.AddAsync(entity);

            await _coworkingDBContext.SaveChangesAsync();

            return entity;
        }

        public async Task<BookingEntity> Get(int idEntity)
        {

            var result = await _coworkingDBContext.Bookings
                .Include(x => x.Office).FirstOrDefaultAsync(x => x.Id == idEntity);

            return result;

        }

        public Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BookingEntity>> GetAll()
        {
            // return _coworkingDBContext.Bookings.Select(x => x);
            var list = await _coworkingDBContext.Bookings.ToListAsync();
            return list;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _coworkingDBContext.Bookings.SingleAsync(x => x.Id == id);

            _coworkingDBContext.Bookings.Remove(entity);

            await _coworkingDBContext.SaveChangesAsync();

        }
    }
}
