namespace LiteracyWebApiTest.Client.Features.MyHealth.Detail
{
    public class BloodPressureData
    {
        public double TotalPage { get; set; }
        public int TotalCount { get; set; }
        public double AvgSystolic { get; set; }
        public double AvgDiastolic { get; set; }
        public int AvgPulse { get; set; }
        public List<BloodPressureByDate> Data { get; set; } = new();
    }

    public class BloodPressureByDate
    {
        public string Date { get; set; } = string.Empty;
        public string DayPartType { get; set; } = string.Empty;
        public string Systolic { get; set; } = string.Empty;
        public string Diastolic { get; set; } = string.Empty;
        public int Pulse { get; set; }
    }
}
