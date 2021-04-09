namespace G10COMERCIALIZADORA_DOTNET.Models
{
    public class Product
    {
        public Product()
        {
        }

        public int ProductId {get; set;}
        public string ProductName {get; set;}
        public string ProductDescription {get; set;}
        public string ProductCodeAuxiliar {get; set;}
        public string ProductSize {get; set;}
        public string ProductPresentation {get; set;}
        public string ProductImg {get; set;}
        public double ProductCoast {get; set;}
        public double ProductPrice {get; set;}
        public int ProductStock {get; set;}
        public int CategoryId {get; set;}
        public int BrandId {get; set;}
        public int ProvaiderId {get; set;}

        public Product(int productId, string productName, string productDescription, string productCodeAuxiliar, string productSize, string productPresentation, string productImg, double productCoast, double productPrice, int productStock, int categoryId, int brandId, int provaiderId)
        {
            ProductId = productId;
            ProductName = productName;
            ProductDescription = productDescription;
            ProductCodeAuxiliar = productCodeAuxiliar;
            ProductSize = productSize;
            ProductPresentation = productPresentation;
            ProductImg = productImg;
            ProductCoast = productCoast;
            ProductPrice = productPrice;
            ProductStock = productStock;
            CategoryId = categoryId;
            BrandId = brandId;
            ProvaiderId = provaiderId;
        }
    }
}