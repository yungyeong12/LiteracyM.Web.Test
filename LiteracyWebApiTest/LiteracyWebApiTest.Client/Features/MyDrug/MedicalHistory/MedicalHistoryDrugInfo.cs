namespace LiteracyWebApiTest.Client.Features.MyDrug.MedicalHistory
{
    public class MedicalHistoryDrugInfo
    {
        public List<MedicalHistoryDrug> OrderHistoryDrugs { get; set; } = new();
        public List<OrderHistoryPharmacy> OrderHistoryPharmacies { get; set; } = new();
    }

    public class MedicalHistoryDrug
    {
        public string DrugCode { get; set; } = string.Empty;
        public string DispensingStartDate { get; set; } = string.Empty;
        public string DispensingEndDate { get; set; } = string.Empty;
        public string DrugName { get; set; } = string.Empty;
        public int TotalDosingDays { get; set; }
        public string Content { get; set; } = string.Empty;
        public int DailyDosesNumber { get; set; }
        public string EffectSummary { get; set; } = string.Empty;
        public string ImageUri { get; set; } = string.Empty;
    }

    public class OrderHistoryPharmacy
    {
        public string HospitalPharmacyName { get; set; } = string.Empty;
        public string TreatStartDate { get; set; } = string.Empty;
        public string TreatType { get; set; } = string.Empty;
    }
}
