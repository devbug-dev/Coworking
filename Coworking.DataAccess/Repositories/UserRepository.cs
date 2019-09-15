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
    public class UserRepository : IUserRepository
    {
        //CRUD --> CREATE READ UPDATE DELETE

        private readonly ICoworkingDBContext _coworkingDBContext;

        public UserRepository(ICoworkingDBContext coworkingDBContext)
        {
            _coworkingDBContext = coworkingDBContext;
        }

        public async Task<UserEntity> Update(int idEntity, UserEntity updateEnt)
        {

            var entity = await Get(idEntity);

            entity.Name = updateEnt.Name;

            _coworkingDBContext.Users.Update(entity);

            await _coworkingDBContext.SaveChangesAsync();

            return entity;
        }

        public async Task<UserEntity> Update(UserEntity entity)
        {

            var updateEntity = _coworkingDBContext.Users.Update(entity);

            await _coworkingDBContext.SaveChangesAsync();

            return updateEntity.Entity;
        }

        public async Task<UserEntity> Add(UserEntity entity)
        {

            await _coworkingDBContext.Users.AddAsync(entity);

            await _coworkingDBContext.SaveChangesAsync();

            return entity;
        }

        public async Task<UserEntity> Get(int idEntity)
        {

            var result = await _coworkingDBContext.Users.FirstOrDefaultAsync(x => x.Id == idEntity);

            return result;

        }

        public Task<bool> Exist(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UserEntity>> GetAll()
        {
            // return _coworkingDBContext.Users.Select(x => x);
            var list = await _coworkingDBContext.Users.ToListAsync();
            return list;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _coworkingDBContext.Users.SingleAsync(x => x.Id == id);

            _coworkingDBContext.Users.Remove(entity);

            await _coworkingDBContext.SaveChangesAsync();

        }
    }
}
