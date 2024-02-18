using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Sol1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {
        [HttpPost("api/hello")]
        public IActionResult Get([FromBody] NameRequest request)
        {
            if(request == null || string.IsNullOrEmpty(request.Name))
            {
                return BadRequest("Invalid Json format. 'name' property is required.");
            }

            var response = new HelloResponse { Str = $"Hello {request.Name} nice to meet you" };
            return Ok(response);
        }
    }
}
