namespace LiteracyWebApiTest.Client.Features.MyDrug.Taking
{
    public class DrugInfoDetail
    {
        public int Id { get; set; }
        public string DrugName { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;
        public string EffectSummary { get; set; } = string.Empty;
        public string MedicationInformation { get; set; } = string.Empty;
        public string DrugIngredientName { get; set; } = string.Empty;
        public string IdentificationMark { get; set; } = string.Empty;    
        public string Storage { get; set; } = string.Empty;
        public string DrugImageUrl { get; set; } = string.Empty;
    }
}
