using System;
using System.Collections.Generic;

namespace G10COMERCIALIZADORA_DOTNET.Models
{
    public class DataPagePrivate
    {
        public Boolean hasPermisson {get; set;}
        public string TittlePage {get; set;}
        public string TittleHeader {get; set;}
        public List<MenuItem> menu {get; set;}    
    }
}