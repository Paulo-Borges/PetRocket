using PetRocket.Communication.Requests;
using PetRocket.Communication.Responses;

namespace PetRocket.Application.UseCases.Pet.Register
{
    public class RegisterPetUseCase
    {
        public ResponseRegisterPetJson Execute(RequestRegisterPetJson request)
        {
            return new ResponseRegisterPetJson
            {
                Id = 7,
                Name = request.Name
            };
        }
    }
}
