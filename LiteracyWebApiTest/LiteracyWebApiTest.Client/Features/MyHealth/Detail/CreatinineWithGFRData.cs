namespace LiteracyWebApiTest.Client.Features.MyHealth.Detail
{
    public class CreatinineWithGFRData
    {
        public double TotalPage { get; set; }
        public int TotalCount { get; set; }
        public List<CreatinineWithGFRByDate> Data { get; set; } = new();
    }

    public class CreatinineWithGFRByDate
    {
        public string Date { get; set; } = string.Empty;
        public string Creatinine { get; set; } = string.Empty;
        public string GFR { get; set; } = string.Empty;
    }
}
