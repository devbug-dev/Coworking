
using System.Collections.Generic;

using System.Threading.Tasks;
using Coworking.AppContracts.Services;
using Coworking.Api.Mappers;
using Coworking.Api.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Coworking.Api.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    public class OfficesController : ControllerBase
    {
        private readonly IOfficeService _officeService;

        public OfficesController(IOfficeService officeService)
        {
            officeService = _officeService;
        }

        /// <summary>
        /// Get Office
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [Produces("application/json", Type = typeof(OfficeModel))]
        public async Task<IActionResult> Get(int id)
        {
            var office = await _officeService.GetOffice(id);

            return Ok(office);
        }

        /// <summary>
        /// Get all Office
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces("application/json", Type = typeof(List<AdminModel>))]
        public async Task<IActionResult> GetAll()
        {
            var office = await _officeService.GetAllOffices();

            return Ok(office);
        }

        /// <summary>
        /// Add a new Office
        /// </summary>
        /// <param name="office"></param>
        /// <returns>Admin</returns>
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [ProducesResponseType(401)]
        [Produces("application/json", Type = typeof(OfficeModel))]
        [HttpPost]
        public async Task<IActionResult> AddOffice([FromBody]OfficeModel office)
        {
            var name = await _officeService.AddOffice(OfficeMapper.Map(office));

            return Ok(name);
        }

        /// <summary>
        /// Borra un Office
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [Produces("application/json", Type = typeof(bool))]
        public async Task<IActionResult> DeleteAdmin(int id)
        {
            await _officeService.DeleteOffice(id);

            return Ok();
        }

        /// <summary>
        /// Actualiza un Office
        /// </summary>
        /// <param name="office"></param>
        /// <returns></returns>
        [HttpPut]
        [Produces("application/json", Type = typeof(OfficeModel))]
        public async Task<IActionResult> UpdateAdmin([FromBody]OfficeModel office)
        {
            var name = await _officeService.UpdateOffice(OfficeMapper.Map(office));

            return Ok(name);
        }

    }
}