namespace LiteracyWebApiTest.Client.Features.Home
{
    public class DrugInfo
    {
        public int IsTakingTotalCountAsync { get; set; }
        public int ThisYearDrugTotalCountAsync { get; set; }
        public List<MedicalHistory> MedicalHistoryList { get; set; } = [];
    }

    public class MedicalHistory
    {
        public string HospitalPharmacyName { get; set; } = string.Empty;
        public string TreatStartDate { get; set; } = string.Empty;
        public string TreatType { get; set; } = string.Empty;
    }
}
