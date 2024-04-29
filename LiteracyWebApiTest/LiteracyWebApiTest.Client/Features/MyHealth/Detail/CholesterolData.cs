namespace LiteracyWebApiTest.Client.Features.MyHealth.Detail
{
    public class CholesterolData
    {
        public double TotalPage { get; set; }
        public int TotalCount { get; set; }
        public List<CholesterolByDate> Data { get; set; } = new();
    }

    public class CholesterolByDate
    {
        public string Date { get; set; } = string.Empty;
        public string TotalCholesterol { get; set; } = string.Empty;
        public string LDLCholesterol { get; set; } = string.Empty;
        public string HDLCholesterol { get; set; } = string.Empty;
        public string Triglyceride { get; set; } = string.Empty;
    }
}
