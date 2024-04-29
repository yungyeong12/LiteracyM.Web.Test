namespace LiteracyWebApiTest.Client.Features.Home
{
    public class HealthInfo
    {
        public List<HealthDataInfo> HealthData { get; set; } = [];
        public List<WeekCheckInfo> WeekCheck { get; set; } = [];
        public bool IsAuthentication { get; set; }
        public string AuthenticationType { get; set; } = string.Empty;
    }

    public class HealthDataInfo
    {
        public string LabKind { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public string Unit { get; set; } = string.Empty;
        public string LabDate { get; set; } = string.Empty;
        public bool IsLiteracy { get; set; }
        public int JudgementDivision { get; set; }
    }

    public class WeekCheckInfo
    {
        public string Day { get; set; } = string.Empty;
        public DayOfWeek DayOfWeek { get; set; }
        public bool IsBloodSugar { get; set; }
        public bool IsBloodPress { get; set; }
    }
}
