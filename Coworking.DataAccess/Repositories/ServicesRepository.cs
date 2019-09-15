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
    public class ServicesRepository : IServicesRepository
    {
        //CRUD --> CREATE READ UPDATE DELETE

        private readonly ICoworkingDBContext _coworkingDBContext;

        public ServicesRepository(ICoworkingDBContext coworkingDBContext)
        {
            _coworkingDBContext = coworkingDBContext;
        }

        public async Task<ServiceEntity> Update(int idEntity, ServiceEntity updateEnt)
        {

            var entity = await Get(idEntity);

            entity.Name = updateEnt.Name;

            _coworkingDBContext.Services.Update(entity);

            await _coworkingDBContext.SaveChangesAsync();

            return entity;
        }

        public async Task<ServiceEntity> Update(ServiceEntity entity)
        {

            var updateEntity = _coworkingDBContext.Services.Update(entity);

            await _coworkingDBContext.SaveChangesAsync();

            return updateEntity.Entity;
        }

        public async Task<ServiceEntity> Add(ServiceEntity entity)
        {

            await _coworkingDBContext.Services.AddAsync(entity);

            await _coworkingDBContext.SaveChangesAsync();

            return entity;
        }

        public async Task<ServiceEntity> Get(int idEntity)
        {

            var result = await _coworkingDBContext.Services.FirstOrDefaultAsync(x => x.Id == idEntity);

            return result;

        }

        public Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ServiceEntity>> GetAll()
        {
            // return _coworkingDBContext.Services.Select(x => x);
            var list = await _coworkingDBContext.Services.ToListAsync();
            return list;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _coworkingDBContext.Services.SingleAsync(x => x.Id == id);

            _coworkingDBContext.Services.Remove(entity);

            await _coworkingDBContext.SaveChangesAsync();

        }
    }
}
