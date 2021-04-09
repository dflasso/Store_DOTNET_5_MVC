namespace G10COMERCIALIZADORA_DOTNET.Models
{
    public class Payment
    {
        public Payment()
        {
        }

        public int PaymentId {get; set;}
        public string PaymentType {get; set;}
        public string PaymentDescription {get; set;}

        public Payment(int paymentId, string paymentType, string paymentDescription)
        {
            PaymentId = paymentId;
            PaymentType = paymentType;
            PaymentDescription = paymentDescription;
        }
    }
}