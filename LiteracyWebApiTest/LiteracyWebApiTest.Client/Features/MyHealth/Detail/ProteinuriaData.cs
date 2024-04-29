namespace LiteracyWebApiTest.Client.Features.MyHealth.Detail
{
    public class ProteinuriaData
    {
        public double TotalPage { get; set; }
        public int TotalCount { get; set; }
        public List<ProteinuriaByDate> Data { get; set; } = new();
    }

    public class ProteinuriaByDate
    {
        public string Date { get; set; } = string.Empty;
        public string SemiQuantitative { get; set; } = string.Empty;
        public string Proteinuria { get; set; } = string.Empty;
        public string Albuminuria { get; set; } = string.Empty;
    }
}
