namespace LiteracyWebApiTest.Client.Features.MyHealth
{
    public class HealthData
    {
        public string LabKind { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public string Unit { get; set; } = string.Empty;
        public string LabDate { get; set; } = string.Empty;
        public bool IsLiteracy { get; set; }
        public byte JudgementDivision { get; set; }
    }
}
