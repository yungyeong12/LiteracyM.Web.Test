namespace LiteracyWebApiTest.Client.Features.CustomerCenter
{
    public class AddCustomerQuery
    {
        public int InquiryTypeId { get; set; }
        public string Title { get; set; } = "";
        public string Content { get; set; } = "";
    }
}
