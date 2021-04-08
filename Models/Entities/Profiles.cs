using System;

namespace G10COMERCIALIZADORA_DOTNET.Models
{
    public class Profile
    {
        public Profile()
        {
        }

        public Int32 ProfileId {get; set;}
        public string ProfileName {get; set;}
        public string ProfileKeyword { get; set;}
        public Boolean IsEnable {get; set;}

        public Profile(int profileId, string profileName, string profileKeyword, bool isEnable)
        {
            ProfileId = profileId;
            ProfileName = profileName;
            ProfileKeyword = profileKeyword;
            IsEnable = isEnable;
        }
    }
}