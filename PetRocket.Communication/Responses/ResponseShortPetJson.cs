using PetRocket.Communication.Enums;

namespace PetRocket.Communication.Responses
{
    public class ResponseShortPetJson
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public PetType Type { get; set; }
    }
}
