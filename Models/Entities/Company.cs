namespace G10COMERCIALIZADORA_DOTNET.Models
{
    public class Company
    {
        public Company()
        {
        }

        public int CompanyId {get; set;}
        public string CompanyRUC {get; set;}
        public string CompanyBusinessName {get; set;}
        public string CompanyCommerceName {get; set;}
        public string CompanyAddress {get; set;}
        public string CompanyPhone {get; set;}
        public string CompanyLogo {get; set;}
        public string CompanyEmail {get; set;}

        public Company(int companyId, string companyRUC, string companyBusinessName, string companyCommerceName, string companyAddress, string companyPhone, string companyLogo, string companyEmail)
        {
            CompanyId = companyId;
            CompanyRUC = companyRUC;
            CompanyBusinessName = companyBusinessName;
            CompanyCommerceName = companyCommerceName;
            CompanyAddress = companyAddress;
            CompanyPhone = companyPhone;
            CompanyLogo = companyLogo;
            CompanyEmail = companyEmail;
        }
    }
}