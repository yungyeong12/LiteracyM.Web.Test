using LiteracyWebApiTest.Client.Features.HealthYoutube;

namespace LiteracyWebApiTest.Client.Features.MyHealth
{
    public class LiteracyInfo
    {
        public string LiteracyName { get; set; } = string.Empty;
        public string LiteracyContent { get; set; } = string.Empty;

        public List<Contents> YoutubeContentList { get; set; } = new();
    }
}
