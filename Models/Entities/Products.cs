namespace G10COMERCIALIZADORA_DOTNET.Models
{
    public class Product
    {
        public int ProductId;
        public string ProductName {get; set;}
        public string ProductDescription {get; set;}
        public string ProductCodeAuxiliar {get; set;}
        public string ProductSize {get; set;}
        public string ProductPresentation {get; set;}
        public string ProductImg {get; set;}
        public double ProductCoast {get; set;}
        public double ProductPrice {get; set;}
        public int ProductStock {get; set;}
    }
}