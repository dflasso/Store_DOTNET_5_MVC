using System.Collections.Generic;

namespace G10COMERCIALIZADORA_DOTNET.Models
{
    public class States
    {
        public States()
        {

        }

        public States(int statesId, string keyword, string description)
        {
            StatesId = statesId;
            Keyword = keyword;
            Description = description;
        }

        public States(string keyword, string description)
        {
            Keyword = keyword;
            Description = description;           
        }

        public int StatesId { get; set; }
        public string Keyword { get; set; }
        public string Description { get; set; }
        public List<StatesOfUser> StatesOfUser { get; set; }
    }
}