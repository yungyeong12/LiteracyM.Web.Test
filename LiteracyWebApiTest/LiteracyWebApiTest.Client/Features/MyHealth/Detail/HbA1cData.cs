namespace LiteracyWebApiTest.Client.Features.MyHealth.Detail
{
    public class HbA1cData
    {
        public List<HbA1cByDate> Data { get; set; }
        public int TotalCount { get; set; }
        public double TotalPage { get; set; }
    }

    public class HbA1cByDate
    {
        public string Date { get; set; } = string.Empty;
        public string HbA1c { get; set; } = string.Empty;
    }
}
