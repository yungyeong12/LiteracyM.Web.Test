namespace LiteracyWebApiTest.Client.Features.Symptom
{
    public class SymptomByKeyword
    {
        public string Code { get; set; } = string.Empty;
        public bool IsUserRegister { get; set; }
        public string PatientId { get; set; } = string.Empty;
        public string SnomedCTCode { get; set; } = string.Empty;
        public string SymptomCategoryCode { get; set; } = string.Empty;
        public string Keyword { get; set; } = string.Empty;
        public string SimilarWord { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Unit { get; set; } = string.Empty;
    }
}
