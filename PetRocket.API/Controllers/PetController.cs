using Microsoft.AspNetCore.Mvc;
using PetRocket.Communication.Requests;
using PetRocket.Communication.Responses;

namespace PetRocket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterPetJson), StatusCodes.Status201Created)]
        public IActionResult Register([FromBody] RequestRegisterPetJson request)
        {
            return Created();
        }
    }
}
