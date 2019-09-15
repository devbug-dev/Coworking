using System.Collections.Generic;
using System.Threading.Tasks;

using Coworking.Api.Mappers;
using Coworking.Api.ViewModels;
using Coworking.AppContracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace Coworking.Api.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    public class ServiceController : Controller
    {
        private readonly IServicesService _servicesService;

        public ServiceController(IServicesService servicesService)
        {
            _servicesService = servicesService;
        }

        /// <summary>
        /// Get service
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [Produces("application/json", Type = typeof(ServiceModel))]
        public async Task<IActionResult> Get(int id)
        {
            var service = await _servicesService.GetService(id);

            return Ok(service);
        }

        /// <summary>
        /// Get all services
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces("application/json", Type = typeof(List<ServiceModel>))]
        public async Task<IActionResult> GetAll()
        {
            var service = await _servicesService.GetAllServices();

            return Ok(service);
        }

        /// <summary>
        /// Add a new service
        /// </summary>
        /// <param name="service"></param>
        /// <returns>Admin</returns>
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(401)]
        [Produces("application/json", Type = typeof(ServiceModel))]
        [HttpPost]
        public async Task<IActionResult> AddAdmin([FromBody]ServiceModel service)
        {
            var name = await _servicesService.AddService(ServiceMapper.Map(service));

            return Ok(name);
        }

        /// <summary>
        /// Borra un service
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [Produces("application/json", Type = typeof(bool))]
        public async Task<IActionResult> DeleteAdmin(int id)
        {
            await _servicesService.DeleteService(id);

            return Ok();
        }

        /// <summary>
        /// Actualiza un service
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        [HttpPut]
        [Produces("application/json", Type = typeof(ServiceModel))]
        public async Task<IActionResult> UpdateAdmin([FromBody]ServiceModel service)
        {
            var name = await _servicesService.UpdateService(ServiceMapper.Map(service));

            return Ok(name);
        }

    }
}