namespace LiteracyWebApiTest.Client.Features.MyHealth.Detail
{
    public class WeightData
    {
        public double TotalPage { get; set; }
        public int TotalCount { get; set; }
        public double BmiAvg { get; set; }
        public string Form { get; set; } = string.Empty;
        public double AvgWeight { get; set; }
        public List<WeightWithBmi> Data { get; set; } = new();
    }

    public class WeightWithBmi
    {
        public string Date { get; set; } = string.Empty;
        public double Weight { get; set; }
        public double Bmi { get; set; }
        public string Compare { get; set; } = string.Empty;
    }
}