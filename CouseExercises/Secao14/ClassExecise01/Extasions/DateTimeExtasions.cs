using System;
using System.Globalization;
namespace ClassExercise01
{

    public static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("f2", CultureInfo.InvariantCulture) + "hours";
            }
            else
            {
                return duration.TotalDays.ToString("f2", CultureInfo.InvariantCulture) + "days";
            }
        }
    }
}
