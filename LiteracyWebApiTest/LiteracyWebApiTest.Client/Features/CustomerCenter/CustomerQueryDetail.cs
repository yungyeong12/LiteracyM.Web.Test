namespace LiteracyWebApiTest.Client.Features.CustomerCenter
{
    public class CustomerQueryDetail
    {
        public string Date { get; set; } = "";
        public string Title { get; set; } = "";
        public string Content { get; set; } = "";
        public bool IsReply { get; set; }
        public string gReplyDate { get; set; } = "";
        public string Reply { get; set; } = "";
    }
}
