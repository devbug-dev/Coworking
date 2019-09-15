using Coworking.Api.ViewModels;
using Coworking.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.Mappers
{
    public static class UserMapper
    {

        public static User Map(UserModel model)
        {

            return new User()
            {
                Active = model.Active,
                CreateDate = model.CreateDate,
                Email = model.Email,
                Id = model.Id,
                Name = model.Name,
                Surname = model.Surname
            };

        }

    }
}
