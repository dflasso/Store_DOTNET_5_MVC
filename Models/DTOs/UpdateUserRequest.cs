namespace G10COMERCIALIZADORA_DOTNET.Models
{
    public class UpdateUserRequest
    {
        public int keyUser {get; set;}
        public string imgUser {get; set;}
        public string name {get; set;}
        public string lastname {get; set;}
        public string numDocument {get; set;}
        public int type {get; set;}
        public string nickname {get; set;}
        public string emailUser {get; set;}
        public string phone {get; set;}
        public string city {get; set;}
        public int keyHomeAddress {get; set;}
        public string mainStreet {get; set;}
        public string secondaryStreet {get; set;}
        public string numHome {get; set;}
        public int profileSelected {get; set;}
    }
}