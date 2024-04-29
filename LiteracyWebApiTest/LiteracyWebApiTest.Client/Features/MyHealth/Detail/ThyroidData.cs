namespace LiteracyWebApiTest.Client.Features.MyHealth.Detail
{
    public class ThyroidData
    {
        public double TotalPage { get; set; }
        public int TotalCount { get; set; }
        public List<ThyroidByDate> Data { get; set; } = new();
    }

    public class ThyroidByDate
    {
        public string Date { get; set; } = string.Empty;
        public string ThyroidT3 { get; set; } = string.Empty;
        public string ThyroidT4 { get; set; } = string.Empty;
        public string Triglyceride { get; set; } = string.Empty;
    }
}
