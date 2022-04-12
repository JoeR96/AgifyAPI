using AgifyAPI.Domain;
using System;

namespace AgifyAPI.UI
{
    public static class GetRemainingTimeUntilApiReset
    {
        public static void GetTime(bool returnToMenu = true)
        {
            var remainingTime = DateTimeCoordinator.GetRemainingTime();
            Console.Write($"There are {remainingTime.Hours} Hours, {remainingTime.Minutes} Minutes and {remainingTime.Seconds} Seconds left before your daily API call count is reset");
            if(returnToMenu)
            {
                UIHelper.ReturnToMenu();
            }
        }
    }
}
