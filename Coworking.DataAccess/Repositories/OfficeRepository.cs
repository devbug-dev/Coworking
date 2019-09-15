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
    public class OfficeRepository : IOfficeRepository
    {
        //CRUD --> CREATE READ UPDATE DELETE

        private readonly ICoworkingDBContext _coworkingDBContext;

        public OfficeRepository(ICoworkingDBContext coworkingDBContext)
        {
            _coworkingDBContext = coworkingDBContext;
        }

        public async Task<OfficeEntity> Update(int idEntity, OfficeEntity updateEnt)
        {

            var entity = await Get(idEntity);

            entity.Name = updateEnt.Name;

            _coworkingDBContext.Offices.Update(entity);

            await _coworkingDBContext.SaveChangesAsync();

            return entity;
        }

        public async Task<OfficeEntity> Update(OfficeEntity entity)
        {

            var updateEntity = _coworkingDBContext.Offices.Update(entity);

            await _coworkingDBContext.SaveChangesAsync();

            return updateEntity.Entity;
        }

        public async Task<OfficeEntity> Add(OfficeEntity entity)
        {

            await _coworkingDBContext.Offices.AddAsync(entity);

            await _coworkingDBContext.SaveChangesAsync();

            return entity;
        }

        public async Task<OfficeEntity> Get(int idEntity)
        {

            var result = await _coworkingDBContext.Offices.FirstOrDefaultAsync(x => x.Id == idEntity);

            return result;

        }

        public Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<OfficeEntity>> GetAll()
        {
            // return _coworkingDBContext.Offices.Select(x => x);
            var list = await _coworkingDBContext.Offices.ToListAsync();
            return list;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _coworkingDBContext.Offices.SingleAsync(x => x.Id == id);

            _coworkingDBContext.Offices.Remove(entity);

            await _coworkingDBContext.SaveChangesAsync();

        }
    }
}
