using Coworking.Api.ViewModels;
using Coworking.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.Mappers
{
    public static class ServiceMapper
    {

        public static Service Map(ServiceModel model)
        {

            return new Service()
            {
                Active = model.Active,
                Id = model.Id,
                Name = model.Name,
                Price = model.Price
            };

        }

    }
}
