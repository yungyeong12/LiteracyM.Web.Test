namespace LiteracyWebApiTest.Client.Features.MyHealth.Detail
{
    public class ExamItemUnitsModel
    {
        public int Id { get; set; }
        public string KoreanName { get; set; }
        public string EnglishName { get; set; }
        public string MapName { get; set; }
        public IEnumerable<ExamItemUnitModel> Units { get; set; }
    }

    public class ExamItemUnitModel
    {
        public int ExamItemId { get; set; }
        public int Id { get; set; }
        public string GeneralUnit { get; set; }
        public string SIUnit { get; set; }
        public decimal? RateToGeneralUnit { get; set; }
        public decimal? RateToSIUnit { get; set; }
        public string RecordDivisions { get; set; }
        public decimal? GeneralNormalLowerBoundValueF { get; set; }
        public decimal? GeneralNormalLowerBoundValueM { get; set; }
        public decimal? GeneralNormalUpperBoundValueF { get; set; }
        public decimal? GeneralNormalUpperBoundValueM { get; set; }
        public decimal? SINormalLowerBoundValueF { get; set; }
        public decimal? SINormalLowerBoundValueM { get; set; }
        public decimal? SINormalUpperBoundValueF { get; set; }
        public decimal? SINormalUpperBoundValueM { get; set; }
        public string LabResultReference { get; set; }
    }

    public enum RecordDivisions
    {
        선택되지않음 = 0,
        건강검진결과 = 1,
        사진촬영 = 2,
        직접입력 = 4
    }
}
