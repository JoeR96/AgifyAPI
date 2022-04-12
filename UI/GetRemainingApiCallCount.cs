using AgifyAPI.Domain;
using System;

namespace AgifyAPI.UI
{
    public static class GetRemainingApiCallCount
    {
        public static void GetRemainingApiCalls(bool returnToMenu = true)
        {
            var remaining = CallCountCoordinator.CallsRemaining;
            Console.WriteLine($"You have {remaining} API Calls remaining today");
            if(returnToMenu)
            {
                UIHelper.ReturnToMenu();
            }
        }
    }
}
