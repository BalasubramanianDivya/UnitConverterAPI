using Microsoft.AspNetCore.Mvc;
using Unit_Converter_API.Models;
using Unit_Converter_API.Services;

namespace Unit_Converter_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UnitConverter_Controller : ControllerBase
    {
        private readonly UnitConversion_Service _service;

        public UnitConverter_Controller(UnitConversion_Service service)
        {
            _service = service;
        }

        [HttpPost("convert")]
        public IActionResult Convert(
            [FromBody] Conversion_Request request)
        {
            try
            {
                double result = _service.Convert(
                    request.Category,
                    request.FromUnit,
                    request.ToUnit,
                    request.Value);

                var response = new Conversion_Response
                {
                    OGValue = request.Value,
                    FromUnit = request.FromUnit,
                    ToUnit = request.ToUnit,
                    ConvertedValue = result
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}