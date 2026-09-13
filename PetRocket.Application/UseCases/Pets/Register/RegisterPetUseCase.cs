using PetRocket.Communication.Requests;
using PetRocket.Communication.Responses;

namespace PetRocket.Application.UseCases.Pets.Register
{
    public class RegisterPetUseCase
    {
        public ResponseRegisterPetJson Execute(RequestPetJson request)
        {
            return new ResponseRegisterPetJson
            {
                Id = 7,
                Name = request.Name
            };
        }
    }
}
