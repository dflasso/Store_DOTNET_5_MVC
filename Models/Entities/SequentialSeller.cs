namespace G10COMERCIALIZADORA_DOTNET.Models
{
    public class SequentialSeller
    {
        public SequentialSeller()
        {
        }

        public int SequentialSellerId {get; set;}
        public string SequentialSellerNum {get; set;}
        public string InvoiceNum {get; set;}
        public int SequentialId {get; set;}
        public int SellerId { get; set; }

        public SequentialSeller(int sequentialSellerId, string sequentialSellerNum, string invoiceNum, int sequentialId, int sellerId)
        {
            SequentialSellerId = sequentialSellerId;
            SequentialSellerNum = sequentialSellerNum;
            InvoiceNum = invoiceNum;
            SequentialId = sequentialId;
            SellerId = sellerId;
        }
    }
}
