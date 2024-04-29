namespace LiteracyWebApiTest.Client.Features.MyDrug.Taking
{
    public class DrugInfo
    {
        public string PrescriptionDrugName { get; set; } = string.Empty;
        public int Id { get; set; }
        public bool IsTaking { get; set; }
        public byte DrugReminder { get; set; }
        public string Content { get; set; } = string.Empty;
        public double DailyDosesNumber { get; set; }
        public string EffectSummary { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string DispensingDate { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;
    }
}
