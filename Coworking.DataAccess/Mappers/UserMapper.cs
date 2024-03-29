﻿using Coworking.Business.Models;
using Coworking.DataContracts.Entities;

namespace Coworking.DataAccess.Mappers
{
    public static class UserMapper
    {

        public static UserEntity Map(User dto)
        {
            return new UserEntity()
            {
                Active = dto.Active,
                CreateDate = dto.CreateDate,
                Email = dto.Email,
                Id = dto.Id,
                Name = dto.Name,
                Surname = dto.Surname
            };
        }

        public static User Map(UserEntity entity)
        {
            return new User()
            {
                Surname = entity.Surname,
                Name = entity.Name,
                Id = entity.Id,
                Email = entity.Email,
                CreateDate = entity.CreateDate,
                Active = entity.Active
            };
        }

    }
}
