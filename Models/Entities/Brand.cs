namespace G10COMERCIALIZADORA_DOTNET.Models
{
    public class Brand
    {
        public Brand()
        {
        }

        public int BrandId {get; set;}
        public string BrandName {get; set;}
        public string BrandCompany {get; set;}
        public string BrandDescription {get; set;}

        public Brand(int brandId, string brandName, string brandCompany, string brandDescription)
        {
            BrandId = brandId;
            BrandName = brandName;
            BrandCompany = brandCompany;
            BrandDescription = brandDescription;
        }
    }
}