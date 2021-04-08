namespace G10COMERCIALIZADORA_DOTNET.Models
{
    public class NewProfileRequest
    {
        public int Key { get; set; }
        public string ProfileName {get; set;}
        public string[] PermissonsSelected {get; set;}
    }
}