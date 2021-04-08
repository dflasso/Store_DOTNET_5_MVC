using System.Collections.Generic;

namespace G10COMERCIALIZADORA_DOTNET.Models
{
    public class HomeAddress
    {
        public int HomeAddressId { get; set; }
        public string Neighborhood { get; set; }
        public string SecondaryStreet { get; set; }
        public string PrimaryStreet { get; set; }
        public string NumHome { get; set; }
        public string City { get; set; }
        public List<UserApp> users ;


        public HomeAddress()
        {

        }

        public HomeAddress(int homeAddressId, string neighborhood, string secondaryStreet, string primaryStreet, string numHome, string city)
        {
            HomeAddressId = homeAddressId;
            Neighborhood = neighborhood;
            SecondaryStreet = secondaryStreet;
            PrimaryStreet = primaryStreet;
            NumHome = numHome;
            City = city;
        }

        public HomeAddress(string neighborhood, string secondaryStreet, string primaryStreet, string numHome, string city)
        {
            Neighborhood = neighborhood;
            SecondaryStreet = secondaryStreet;
            PrimaryStreet = primaryStreet;
            NumHome = numHome;
            City = city;
        }
    }

}