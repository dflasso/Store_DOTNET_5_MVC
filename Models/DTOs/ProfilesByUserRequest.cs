using System;

namespace G10COMERCIALIZADORA_DOTNET.Models
{
    public class ProfilesByUserRequest
    {
        public string Label {get; set;} 
        public Boolean SelectedProfile {get; set;}
        public string Key {get; set;}
    }
}