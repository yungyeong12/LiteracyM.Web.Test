namespace LiteracyWebApiTest.Client.Features.MyPage
{
    public class EditPatientProfile
    {
        public string GivenName { get; set; } = string.Empty;
        public string NickName { get; set; } = string.Empty;
        public string BirthDate { get; set; } = string.Empty;
        public string PregnantDueDate { get; set; } = string.Empty;
        public bool IsSecession { get; set; }
        public bool IsMarketingAgree { get; set; }
    }
}
