
using Coworking.Api.ViewModels;
using Coworking.Business.Models;
using System;


namespace Coworking.Api.Mappers
{
    public static class AdminMapper
    {

        public static Admin Map(AdminModel model)
        {

            return new Admin()
            {
                Email = model.Email,
                HireDate = DateTime.Now,
                Name = model.Name,
                Phone = model.Phone
            };

        }

    }
}
