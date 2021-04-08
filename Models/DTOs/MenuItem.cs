using System.Collections.Generic;

namespace G10COMERCIALIZADORA_DOTNET.Models
{
    public class MenuItem
    {
        
        public string Page {get; set;}
        public string Controller {get; set;}
        public string NameMenu { get; set;}
        public bool IsPrincipalMenu {get; set;}
        public List<MenuItem> SubMenu {get; set;}
    }
}