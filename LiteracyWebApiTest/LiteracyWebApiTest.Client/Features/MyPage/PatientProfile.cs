using System.ComponentModel.DataAnnotations;

namespace LiteracyWebApiTest.Client.Features.MyPage
{
    public class PatientProfile
    {
        public string KoreanName { get; set; } = "";
        public string Email { get; set; } = "";
        public string NickName { get; set; } = "";
        public string Gender { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public string BirthDate { get; set; } = "";
        public string PregnantDueDate { get; set; } = "";
        public string Provider { get; set; } = "";
        public string RequestDate { get; set; } = "";
        public string RequestType { get; set; } = "";
    }
}
