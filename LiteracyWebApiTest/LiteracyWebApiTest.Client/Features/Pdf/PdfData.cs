using LiteracyWebApiTest.Client.Features.MyHealth;

namespace LiteracyWebApiTest.Client.Features.Pdf
{
    public class PdfData
    {
        public Medication MyMedication { get; set; }
        public List<HealthData> HealthData { get; set; }
        public bool IsAuthentication { get; set; }
        public string AuthenticationType { get; set; } = string.Empty;
    }

    public class Medication
    {
        public string DrugName { get; set; } = string.Empty;
        public string HospitalName { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public string ImageUri { get; set; } = string.Empty;
    }
}
