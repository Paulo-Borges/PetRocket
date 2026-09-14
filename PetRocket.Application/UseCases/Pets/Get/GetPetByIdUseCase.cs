using PetRocket.Communication.Enums;
using PetRocket.Communication.Requests;
using PetRocket.Communication.Responses;

namespace PetRocket.Application.UseCases.Pets.GetById
{
    public class GetPetByIdUseCase
    {
        public ResponsePetJson Execute(int id)
        {
            return new ResponsePetJson
            {
                Id = id,
                //Name = request.Name,
                Name = "Sutão",
                //Type = request.Type,
                Type = PetType.Cat,
                //Birthday = request.Birthday
                Birthday = new DateTime(year: 2023, month: 1, day: 1)
            };
        }
    }
}
