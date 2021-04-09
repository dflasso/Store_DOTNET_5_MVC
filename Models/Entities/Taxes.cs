namespace G10COMERCIALIZADORA_DOTNET.Models
{
    public class Tax
    {
        public Tax()
        {
        }

        public int TaxId {get; set;}
        public string TaxType {get; set;}
        public double TaxPercentaje {get; set;}
        public string TaxCode {get; set;}
        public string TaxDescription {get; set;}

        public Tax(int taxId, string taxType, double taxPercentaje, string taxCode, string taxDescription)
        {
            TaxId = taxId;
            TaxType = taxType;
            TaxPercentaje = taxPercentaje;
            TaxCode = taxCode;
            TaxDescription = taxDescription;
        }
    }
}