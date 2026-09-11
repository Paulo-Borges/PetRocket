using Microsoft.AspNetCore.Mvc;
using PetRocket.Application.UseCases.Pet.Register;
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
            var useCase = new RegisterPetUseCase();
            var response = useCase.Execute(request);

            return Created(string.Empty, response);
        }
    }
}
