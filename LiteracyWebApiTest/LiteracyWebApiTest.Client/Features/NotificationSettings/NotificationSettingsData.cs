namespace LiteracyWebApiTest.Client.Features.NotificationSettings
{
    public class NotificationSettingsData
    {
        public ReminderSetting ReminderSettings { get; set; }
        public bool IsTodayLiteracyReminder { get; set; }
    }

    public class ReminderSetting
    {
        public string AfterWakingUp { get; set; } = string.Empty;
        public string Morning { get; set; } = string.Empty;
        public string Lunch { get; set; } = string.Empty;
        public string Dinner { get; set; } = string.Empty;
        public string BeforeBedTime { get; set; } = string.Empty;
    }
}
