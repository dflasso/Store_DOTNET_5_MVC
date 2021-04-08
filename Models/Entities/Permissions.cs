namespace G10COMERCIALIZADORA_DOTNET.Models
{
    public class Permissions
    {
        public Permissions()
        {
        }

        public int PermissionsId {get; set;}
        public string Page {get; set;}
        public string Controller {get; set;}
        public string NameMenu { get; set;}
        public string TittlePage {get; set;}
        public string TittleHeader {get; set;}
        public string Keyword {get; set;}
        public string Description {get; set;}
        public int PatternPermissonId {get; set;}

        public Permissions(int permissionsId, string page, string controller, string nameMenu, string tittlePage, string tittleHeader, string keyword, string description, int patternPermissonId)
        {
            PermissionsId = permissionsId;
            Page = page;
            Controller = controller;
            NameMenu = nameMenu;
            TittlePage = tittlePage;
            TittleHeader = tittleHeader;
            Keyword = keyword;
            Description = description;
            PatternPermissonId = patternPermissonId;
        }

         public Permissions(int permissionsId)
        {
            PermissionsId = permissionsId;
        }
    }
}