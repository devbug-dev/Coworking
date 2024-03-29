﻿using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Coworking.AppContracts.Services;

using Coworking.Business.Models;
using Coworking.DataAccess.Mappers;
using Coworking.DataContracts.Repositories;

namespace Coworking.Application.Services
{
    public class UserService : IUserService
    {


        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public async Task<User> AddUser(User user)
        {
            var addedEntity = await _userRepository.Add(UserMapper.Map(user));

            return UserMapper.Map(addedEntity);
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            var admins = await _userRepository.GetAll();

            return admins.Select(UserMapper.Map);
        }

        public async Task<User> GetUser(int id)
        {
            var entidad = await _userRepository.Get(id);

            return UserMapper.Map(entidad);
        }

        public async Task DeleteUser(int id)
        {
            await _userRepository.DeleteAsync(id);
        }

        public async Task<User> UpdateUser(User user)
        {
            var updated = await _userRepository.Update(UserMapper.Map(user));

            return UserMapper.Map(updated);
        }


    }
}
