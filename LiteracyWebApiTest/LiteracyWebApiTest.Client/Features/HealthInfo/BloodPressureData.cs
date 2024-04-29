namespace LiteracyWebApiTest.Client.Features.HealthInfo
{
    public class BloodPressureData
    {
        public DateTime InputDateTime { get; set; }
        public byte BloodPressureDayDivision { get; set; }
        public int? Systolic { get; set; }
        public int? Diastolic { get; set; }
        public byte? PulseRate { get; set; }
    }
}
