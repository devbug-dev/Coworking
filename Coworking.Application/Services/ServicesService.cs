using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Coworking.AppContracts.Services;

using Coworking.Business.Models;
using Coworking.DataAccess.Mappers;
using Coworking.DataContracts.Repositories;

namespace Coworking.Application.Services
{
    public class ServicesService : IServicesService
    {

        private readonly IServicesRepository _servicesRepository;

        public ServicesService(IServicesRepository servicesRepository)
        {
            _servicesRepository = servicesRepository;
        }


        public async Task<Service> AddService(Service service)
        {
            var addedEntity = await _servicesRepository.Add(ServiceMapper.Map(service));

            return ServiceMapper.Map(addedEntity);
        }

        public async Task<IEnumerable<Service>> GetAllServices()
        {
            var admins = await _servicesRepository.GetAll();

            return admins.Select(ServiceMapper.Map);
        }

        public async Task<Service> GetService(int id)
        {
            var entidad = await _servicesRepository.Get(id);

            return ServiceMapper.Map(entidad);
        }

        public async Task DeleteService(int id)
        {
            await _servicesRepository.DeleteAsync(id);
        }

        public async Task<Service> UpdateService(Service service)
        {
            var updated = await _servicesRepository.Update(ServiceMapper.Map(service));

            return ServiceMapper.Map(updated);
        }
    }
}
