namespace G10COMERCIALIZADORA_DOTNET.Models
{
    public class UpdateCredentialsRequest
    {
        public string nickname {get; set;}
        public string currentPass {get; set;}
        public string newPass {get; set;}
        public string confirmNewPass {get; set;}
    }
}