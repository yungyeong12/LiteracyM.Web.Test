namespace LiteracyWebApiTest.Client.Features.MyHealth.Detail
{
    public class PSAData
    {
        public double TotalPage { get; set; }
        public int TotalCount { get; set; }
        public List<PSAByDate> Data { get; set; } = new();
    }

    public class PSAByDate
    {
        public string Date { get; set; } = string.Empty;
        public string PSA { get; set; } = string.Empty;
    }
}
