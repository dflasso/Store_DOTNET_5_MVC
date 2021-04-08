using System;


namespace G10COMERCIALIZADORA_DOTNET.Models
{
    public class UserApp
    {
        public UserApp()
        {

        }

        public UserApp(int userAppId, string userNicname, string userPassword, DateTime createAt, DateTime modifiedAt, string userName, string userLastname, string userEmail, string userPhone, int userType, string userNumDocument, string disability, int homeAddressId)
        {
            UserAppId = userAppId;
            this.userNicname = userNicname;
            this.userPassword = userPassword;
            CreateAt = createAt;
            ModifiedAt = modifiedAt;
            this.userName = userName;
            this.userLastname = userLastname;
            this.userEmail = userEmail;
            this.userPhone = userPhone;
            this.userType = userType;
            this.userNumDocument = userNumDocument;
            Disability = disability;
            HomeAddressId = homeAddressId;
        }

        public UserApp( string userNicname, string userPassword, DateTime createAt, DateTime modifiedAt, string userName, string userLastname, string userEmail, string userPhone, int userType, string userNumDocument, string disability, int homeAddressId)
        {
            this.userNicname = userNicname;
            this.userPassword = userPassword;
            CreateAt = createAt;
            ModifiedAt = modifiedAt;
            this.userName = userName;
            this.userLastname = userLastname;
            this.userEmail = userEmail;
            this.userPhone = userPhone;
            this.userType = userType;
            this.userNumDocument = userNumDocument;
            Disability = disability;
            HomeAddressId = homeAddressId;
        }

        public int UserAppId { get; set; }
        public string userNicname {get; set;}
        public string userPassword {get; set;}
        public DateTime CreateAt {get; set;}
        public DateTime ModifiedAt {get; set;}
        public string userName {get; set;}
        public string userLastname {get; set;}
        public string userEmail {get; set;}
        public string userPhone {get; set;}
        public int userType {get; set;}
        public string userNumDocument {get; set;}
        public string Disability {get; set;}
        public int HomeAddressId {get; set;}

        
    }
}
