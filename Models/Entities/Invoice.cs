using System;

namespace G10COMERCIALIZADORA_DOTNET.Models
{
    public class Invoice
    {
        public Invoice()
        {
        }

        public int InvoiceId {get; set;}
        public string AuthorizatitonSRI {get; set;}
        public string InvoiceNum {get; set;}
        public double Discount {get; set;}
        public double Tip {get; set;}
        public DateTime CreateAt {get; set;}
        public int SequentialSellerId {get; set;}
        public int CustomerId {get; set;}
        public int CompanyId {get; set;}
        public int PaymentId {get; set;}

        public Invoice(int invoiceId, string authorizatitonSRI, string invoiceNum, double discount, double tip, DateTime createAt, int sequentialSellerId, int customerId, int companyId, int paymentId)
        {
            InvoiceId = invoiceId;
            AuthorizatitonSRI = authorizatitonSRI;
            InvoiceNum = invoiceNum;
            Discount = discount;
            Tip = tip;
            CreateAt = createAt;
            SequentialSellerId = sequentialSellerId;
            CustomerId = customerId;
            CompanyId = companyId;
            PaymentId = paymentId;
        }
    }
}
