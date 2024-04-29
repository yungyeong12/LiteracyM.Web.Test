using LiteracyWebApiTest.Client.Features.HealthYoutube;

namespace LiteracyWebApiTest.Client.Features.Home
{
    public class BasicInfo
    {
        public TodayLiteracyInfo ToDayLiteracy { get; set; } = new();
        public List<Contents> YoutubeRecomendations { get; set; } = [];
    }

    public class TodayLiteracyInfo
    {
        public string Title { get; set; } = string.Empty;
        public string AlarmCount { get; set; } = string.Empty;
    }
}
