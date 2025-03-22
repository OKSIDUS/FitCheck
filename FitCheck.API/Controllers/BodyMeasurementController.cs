using FitCheck.BAL.Dtos;
using FitCheck.BAL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FitCheck.API.Controllers
{
    [ApiController]
    [Route("api/")]
    public class BodyMeasurementController : Controller
    {
        private readonly IBodyMeasurementService _bodyMeasurementService;
        private readonly ILogger<BodyMeasurementController> _logger;

        public BodyMeasurementController(IBodyMeasurementService bodyMeasurementService, ILogger<BodyMeasurementController> logger)
        {
            _bodyMeasurementService = bodyMeasurementService;
            _logger = logger;
        }

        [HttpPost("create-body-measurement")]
        public async Task<IActionResult> CreateBodyMeasurement([FromBody] CreateBodyMeasurementDto bodyMeasurementDto)
        {
            try
            {
                if (bodyMeasurementDto is null)
                {
                    return BadRequest("Body measurement is null");
                }

                var result  = await _bodyMeasurementService.CreateBodyMeasurementAsync(bodyMeasurementDto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Creating new body measurement with error, {ex.Message}, Inner exception: {ex.InnerException}");
            }
        }
    }
}
