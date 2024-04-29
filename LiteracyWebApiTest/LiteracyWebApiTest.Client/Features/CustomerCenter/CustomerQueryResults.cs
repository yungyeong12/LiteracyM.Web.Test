namespace LiteracyWebApiTest.Client.Features.CustomerCenter
{
    public class CustomerQueryResults
    {
        public List<CustomerQueryData> Data { get; set; }
        public int TotalCount { get; set; }
        public double TotalPage { get; set; }
    }

    public class CustomerQueryData
    {
        public int Id { get; set; }
        public string Date { get; set; } = "";
        public string Title { get; set; } = "";
        public bool IsReply { get; set; }
    }
}
