using System.Globalization;

namespace LiteracyWebApiTest.Client.Features.MyDrug.MedicalHistory
{
    public class MedicalHistoryInfo
    {
        public int TotalCount { get; set; }
        public int TotalPage { get; set; }
        public List<PrescriptionDrug> Data { get; set; }

        public class PrescriptionDrug
        {
            public int Id { get; set; }
            public string TreatDate { get; set; } = string.Empty;
            public string TreatType { get; set; } = string.Empty;
            public string HospitalName { get; set; } = string.Empty;
            public int NumberOfVisits { get; set; }
            public int NumberOfPrescriptions { get; set; }
            public int NumberOfDosing { get; set; }
        }

        public List<IGrouping<string, PrescriptionDrug>> GroupDataListByMonth()
        {
            var groupedDataList = Data
            .GroupBy(item => DateTime.ParseExact(item.TreatDate, "yyyy-MM-dd", CultureInfo.InvariantCulture).ToString("yyyy-MM"))
            .ToList();

            return groupedDataList;
        }
    }
}
