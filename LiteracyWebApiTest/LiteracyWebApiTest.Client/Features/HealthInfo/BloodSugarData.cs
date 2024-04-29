namespace LiteracyWebApiTest.Client.Features.HealthInfo
{
    public class BloodSugarData
    {
        public DateTime InputDateTime { get; set; }
        public byte BloodSugarDayDivisions { get; set; }
        public int? BloodSugar { get; set; }
        public string Note { get; set; } = string.Empty;
    }
}
