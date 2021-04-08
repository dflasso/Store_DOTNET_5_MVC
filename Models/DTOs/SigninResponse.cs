namespace G10COMERCIALIZADORA_DOTNET.Models
{
    public class SignInResponse
    {
        public string UserNicname {get; set;}
        public string UserName {get; set;}
        public string UserLastname {get; set;}
        public string UserEmail {get; set;}
        public string UserNumDocument {get; set;}
        public string UserTypeDescription { get; set;}
        public string StateOfUserDescription { get; set; }
        public string ViewName {get; set;}
        public bool IsAuth { get; set;}
        public bool hasTempPassword {get; set;}
        public string Error {get; set;}
    }
}