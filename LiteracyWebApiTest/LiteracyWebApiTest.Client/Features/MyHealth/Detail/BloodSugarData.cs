namespace LiteracyWebApiTest.Client.Features.MyHealth.Detail
{
    public class BloodSugarData
    {
        public double TotalPage { get; set; }
        public int TotalCount { get; set; }
        public decimal AvgBloodSugar { get; set; }
        public decimal MinBloodSugar { get; set; }
        public decimal MaxBloodSugar { get; set; }
        public List<BloodSugarByDate> Data { get; set; } = new();
    }

    public class BloodSugarByDate
    {
        public string Date { get; set; }
        public decimal MorningBeforeMeal { get; set; }
        public string MorningBeforeMealNote { get; set; } = string.Empty;
        public decimal MorningAfterMeal { get; set; }
        public string MorningAfterMealNote { get; set; } = string.Empty;
        public decimal LunchBeforeMeal { get; set; }
        public string LunchBeforeMealNote { get; set; } = string.Empty;
        public decimal LunchAfterMeal { get; set; }
        public string LunchAfterMealNote { get; set; } = string.Empty;
        public decimal DinnerBeforeMeal { get; set; }
        public string DinnerBeforeMealNote { get; set; } = string.Empty;
        public decimal DinnerAfterMeal { get; set; }
        public string DinnerAfterMealNote { get; set; } = string.Empty;
        public decimal BeforeBedtime { get; set; }
        public string BeforeBedtimeNote { get; set; } = string.Empty;
    }
}
