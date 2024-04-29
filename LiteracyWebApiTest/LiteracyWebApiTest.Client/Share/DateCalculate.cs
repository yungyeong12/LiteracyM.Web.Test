namespace LiteracyWebApiTest.Client.Share
{
    public class DateCalculate
    {
        public static DateTime CalculatePreviousMonthDate(int monthsToSubtract)
        {
            var currentDate = DateTime.Now;
            var resultDate = currentDate.AddMonths(-monthsToSubtract);

            return resultDate;
        }
    }
}
