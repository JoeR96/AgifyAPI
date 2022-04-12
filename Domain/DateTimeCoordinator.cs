using System;

namespace AgifyAPI.Domain
{
    public static class DateTimeCoordinator
    {
        public static TimeSpan GetRemainingTime()
        {
            var now = DateTime.Now;
            var tomorrow = DateTime.Today.AddDays(1);
            var remaining =  tomorrow - now;
            return remaining;                 
        }
    }
}
