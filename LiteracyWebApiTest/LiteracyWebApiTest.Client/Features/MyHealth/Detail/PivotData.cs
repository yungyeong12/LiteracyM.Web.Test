namespace LiteracyWebApiTest.Client.Features.MyHealth.Detail
{
    public class PivotData
    {
        public decimal Minimum { get; set; }
        public decimal Maximum { get; set; }
        public string GraphType { get; set; } = string.Empty;
        public List<DataInfo> GraphTypeData { get; set; } = [];
    }

    public class DataInfo
    {
        public string Type { get; set; } = string.Empty;
        public List<Values> Data { get; set; } = [];
    }

    public class Values
    {
        public string Date { get; set; } = string.Empty;
        public decimal Value { get; set; }
    }
}
