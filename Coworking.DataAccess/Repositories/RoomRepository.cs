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
    public class RoomRepository : IRoomRepository
    {
        //CRUD --> CREATE READ UPDATE DELETE

        private readonly ICoworkingDBContext _coworkingDBContext;

        public RoomRepository(ICoworkingDBContext coworkingDBContext)
        {
            _coworkingDBContext = coworkingDBContext;
        }

        public async Task<RoomEntity> Update(int idEntity, RoomEntity updateEnt)
        {

            var entity = await Get(idEntity);

            entity.Name = updateEnt.Name;

            _coworkingDBContext.Rooms.Update(entity);

            await _coworkingDBContext.SaveChangesAsync();

            return entity;
        }

        public async Task<RoomEntity> Update(RoomEntity entity)
        {

            var updateEntity = _coworkingDBContext.Rooms.Update(entity);

            await _coworkingDBContext.SaveChangesAsync();

            return updateEntity.Entity;
        }

        public async Task<RoomEntity> Add(RoomEntity entity)
        {

            await _coworkingDBContext.Rooms.AddAsync(entity);

            await _coworkingDBContext.SaveChangesAsync();

            return entity;
        }

        public async Task<RoomEntity> Get(int idEntity)
        {

            var result = await _coworkingDBContext.Rooms.FirstOrDefaultAsync(x => x.Id == idEntity);

            return result;

        }

        public Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RoomEntity>> GetAll()
        {
            // return _coworkingDBContext.Rooms.Select(x => x);
            var list = await _coworkingDBContext.Rooms.ToListAsync();
            return list;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _coworkingDBContext.Rooms.SingleAsync(x => x.Id == id);

            _coworkingDBContext.Rooms.Remove(entity);

            await _coworkingDBContext.SaveChangesAsync();

        }
    }
}
