using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyDoctor.Business.Services;
using MyDoctor.Data.Repositories;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyDoctor.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalsController : ControllerBase
    {
        private readonly HospitalService _hospitalService;

        public HospitalsController(HospitalService hospitalService)
        {
            _hospitalService = hospitalService;
        }

        [HttpGet("Get-Hospitals")]
        public async Task<IActionResult> GetHospitalsDtosAsync()
        {
            try
            {
                var hospitalsDtos = await _hospitalService.GetHospitalsDtosAsync();
                return Ok(hospitalsDtos);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message.ToString() });
            }
        }
    }
}
