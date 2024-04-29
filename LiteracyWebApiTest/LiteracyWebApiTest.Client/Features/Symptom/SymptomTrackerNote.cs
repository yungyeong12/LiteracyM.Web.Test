namespace LiteracyWebApiTest.Client.Features.Symptom
{
    public class SymptomTrackerNote
    {
        public string Id { get; set; } = string.Empty;
        public string SymptomTrackerCode { get; set; } = string.Empty;
        public string Keyword { get; set; } = string.Empty;
        public DateTime RecordDate { get; set; }
        public decimal Value { get; set; }
        public bool IsBookmark { get; set; }
        public string Unit { get; set; } = string.Empty;
    }
}
