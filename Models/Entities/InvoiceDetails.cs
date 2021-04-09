using System;

namespace G10COMERCIALIZADORA_DOTNET.Models
{
    public class InvoiceDetail
    {
        public int InvoiceDetailId {get; set;}
        public double Amount {get; set;}
        public int TaxIVAId {get; set;}
        public double TaxIVAPorcentaje {get; set;}
        public int TaxICEId {get; set;}
        public int TaxICEPorcentaje {get; set;}
        public double Discount {get; set;}
        public int InvoiceId {get; set;}
        public int ProductId {get; set;}
    }
}