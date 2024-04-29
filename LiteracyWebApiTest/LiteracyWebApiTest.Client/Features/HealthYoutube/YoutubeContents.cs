namespace LiteracyWebApiTest.Client.Features.HealthYoutube
{
    public class YoutubeContents
    {
        public int TotalCount { get; set; }
        public double TotalPage { get; set; }
        public List<Contents> Data { get; set; } = new();
    }

    public class Contents
    {
        public string Code { get; set; } = string.Empty;
        public string Classification { get; set; } = string.Empty;
        public string VideoCode { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string Thumbnail { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Introduction { get; set; } = string.Empty;
        public int? Accuracy { get; set; }
        public int? UnderstandingDegree { get; set; }
        public string VideoId { get; set; } = string.Empty;
    }
}
