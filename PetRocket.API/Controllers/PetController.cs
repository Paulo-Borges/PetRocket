using Microsoft.AspNetCore.Mvc;
using PetRocket.Application.UseCases.Pets.GetAll;
using PetRocket.Application.UseCases.Pets.GetById;
using PetRocket.Application.UseCases.Pets.Register;
using PetRocket.Application.UseCases.Pets.Update;
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
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult Register([FromBody] RequestPetJson request)
        {
            var useCase = new RegisterPetUseCase();
            var response = useCase.Execute(request);

            return Created(string.Empty, response);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult Update([FromRoute] int id, [FromBody] RequestPetJson request)
        {
            var useCase = new UpdatePetUseCase();
            useCase.Execute(id, request);

            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseAllPetJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAll()
        {
            var useCase = new GetAllPetsUseCase();

            var response = useCase.Execute();

            if(response.Pets.Any())
            {
                return Ok(response);
            }
            return NoContent();
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponsePetJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            var useCase = new GetPetByIdUseCase();

            var response = useCase.Execute(id);


            return Ok(response);
        }


    }
}
