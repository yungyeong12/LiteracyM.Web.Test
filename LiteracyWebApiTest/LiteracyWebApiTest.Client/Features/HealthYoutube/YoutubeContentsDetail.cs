namespace LiteracyWebApiTest.Client.Features.HealthYoutube
{
    public class YoutubeContentsDetail
    {
        public YoutubeContentsInfo YoutubeCategoryContent { get; set; } = new();
        public List<Recommendation> Recommendations { get; set;} = new();
    }

    public class YoutubeContentsInfo
    {
        public string Code { get; set; } = string.Empty;
        public string ParentClassification { get; set; } = string.Empty;
        public string Classification { get; set; } = string.Empty;
        public string VideoCode { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Introduction { get; set; } = string.Empty;
        public byte? Accuracy { get; set; }
        public byte? UnderstandingDegree { get; set; }
        public string VideoId { get; set; } = string.Empty;
        public VideoInfomation VideoInfo { get; set; } = new();
    }

    public class VideoInfomation
    {
        public string Title { get; set; } = string.Empty;
        public string PublishedAt { get; set; } = string.Empty;
        public string Thumbnail { get; set; } = string.Empty;
        public string ViewCount { get; set; } = string.Empty;
        public string PlayTime { get; set; } = string.Empty;
        public List<Chapter> Chapters { get; set; } = new();
    }
    public class Chapter
    {
        public string ChapterName { get; set; } = string.Empty;
        public string ChapterTime { get; set; } = string.Empty;
    }
    public class Recommendation
    {
        public string Code { get; set; } = string.Empty;
        public string ParentCode { get; set; } = string.Empty;
        public string ParentClassification { get; set; } = string.Empty;
        public string Classification { get; set; } = string.Empty;
        public string VideoCode { get; set; } = string.Empty;
        public string Thumbnail { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Introduction { get; set; } = string.Empty;
        public byte? Accuracy { get; set; }
        public byte? UnderstandingDegree { get; set; }
        public string VideoId { get; set; } = string.Empty;
    }
}
