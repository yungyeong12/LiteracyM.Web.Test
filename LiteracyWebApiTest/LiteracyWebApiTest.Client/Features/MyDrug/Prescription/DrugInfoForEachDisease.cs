namespace LiteracyWebApiTest.Client.Features.MyDrug.Prescription
{
    public class DrugInfoForEachDisease
    {
        public string KpicAtcDepthName { get; set; } = string.Empty;
        public IEnumerable<DrugDetail> DrugDetails { get; set; }
    }

    public class DrugDetail
    {
        public string KpicDrugCode { get; set; } = string.Empty;
        public string PrescriptionDrugName { get; set; } = string.Empty;
        public IEnumerable<int> Months { get; set; }
    }
}
