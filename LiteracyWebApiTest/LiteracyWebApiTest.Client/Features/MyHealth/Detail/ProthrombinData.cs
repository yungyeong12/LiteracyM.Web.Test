namespace LiteracyWebApiTest.Client.Features.MyHealth.Detail
{
    public class ProthrombinData
    {
        public double TotalPage { get; set; }
        public int TotalCount { get; set; }
        public List<ProthrombinByDate> Data { get; set; } = new();
    }

    public class ProthrombinByDate
    {
        public string Date { get; set; } = string.Empty;
        public string INR { get; set; } = string.Empty;
    }
}
