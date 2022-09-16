using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Stock_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ErrorController : ControllerBase
    {
        [ApiExplorerSettings(IgnoreApi = true)]
        [Route("ErrorRoute")]
        public IActionResult Error()
        { 
            return Ok("error is occured in the code");
        }
    }
}
