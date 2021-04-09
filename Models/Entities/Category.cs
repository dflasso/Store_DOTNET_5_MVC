namespace G10COMERCIALIZADORA_DOTNET.Models
{
    public class Category
    {
        public Category()
        {
        }

        public int CategoryId {get; set;}
        public string CategoryName {get; set;}
        public string CategoryDescription {get; set;}

        public Category(int categoryId, string categoryName, string categoryDescription)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
            CategoryDescription = categoryDescription;
            
        }
    }
}