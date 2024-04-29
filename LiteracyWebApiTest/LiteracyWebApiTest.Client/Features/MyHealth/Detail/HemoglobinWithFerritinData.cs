namespace LiteracyWebApiTest.Client.Features.MyHealth.Detail
{
    public class HemoglobinWithFerritinData
    {
        public double TotalPage { get; set; }
        public int TotalCount { get; set; }
        public List<HemoglobinWithFerritinByDate> Data { get; set; } = new();
    }

    public class HemoglobinWithFerritinByDate
    {
        public string Date { get; set; } = string.Empty;
        public string Hemoglobin { get; set; } = string.Empty;
        public string Ferritin { get; set; } = string.Empty;
    }
}
