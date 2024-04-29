namespace LiteracyWebApiTest.Client.Features.MyHealth.Detail
{
    public class LiverFunctionData
    {
        public double TotalPage { get; set; }
        public int TotalCount { get; set; }
        public List<LiverFunctionByDate> Data { get; set; } = new();
    }

    public class LiverFunctionByDate
    {
        public string Date { get; set; } = string.Empty;
        public string AST { get; set; } = string.Empty;
        public string ALT { get; set; } = string.Empty;
        public string rGT { get; set; } = string.Empty;
    }
}
