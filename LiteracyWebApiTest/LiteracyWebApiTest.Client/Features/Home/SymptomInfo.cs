namespace LiteracyWebApiTest.Client.Features.Home
{
    public class SymptomInfo
    {
        public string SymptomTrackerCode { get; set; } = string.Empty;
        public string Keyword { get; set; } = string.Empty;
        public DateTime RecordDate { get; set; }
        public decimal Value { get; set; }
        public string Unit { get; set; } = string.Empty;
    }
}
