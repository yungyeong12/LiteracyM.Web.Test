using System.Dynamic;

namespace LiteracyWebApiTest.Client.Features.TodayLiteracy
{
    public class TodayLiteracyData
    {
        public List<Literacy> Data { get; set; }
    }

    public class Literacy
    {
        public string LiteracyDate { get; set; } = string.Empty;
        public DateTime NotificationDate { get; set; }

        public string Type { get; set; } = string.Empty;
        public string TypeName { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public int Id { get; set; }
        public int LiteracyId { get; set; }
        public bool IsChecked { get; set; }
        public ExpandoObject Detail { get; set; } = new();
    }

    public class Drug
    {
        public int PatientDrugId { get; set; }
        public string DrugName { get; set; } = string.Empty;
        public string DrugImageUrl { get; set; } = string.Empty;
        public string HospitalPharmacyName { get; set; } = string.Empty;
        public string TreatDate { get; set; } = string.Empty;
    
    }
}
