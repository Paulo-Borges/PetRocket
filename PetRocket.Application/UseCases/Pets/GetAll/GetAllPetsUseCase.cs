using PetRocket.Communication.Enums;
using PetRocket.Communication.Responses;
using System.Xml.Linq;

namespace PetRocket.Application.UseCases.Pets.GetAll
{
    public class GetAllPetsUseCase
    {
        public ResponseAllPetJson Execute()
        {
            return new ResponseAllPetJson
            {
                //Pets = new List<ResponseShortPetJson>
                //{
                //    new ResponseShortPetJson
                    
                //        {
                //               Id = 1,
                //               Name = "Charlie",
                //               Type = PetType.Dog
                //        }
                    
                //}
                
            };
        }
    }
}
