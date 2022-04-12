using AgifyAPI.Domain;
using AgifyAPI.Models;
using System;

namespace AgifyAPI.UI
{
    public static class GetAverageAgeInput
    {
        public static void AverageAgeOfNameInCountry()
        {
            try
            {
                ValidateRemainingApiCalls();


                var name = InputName();
                var country = InputCountryCode();

                AverageAgeOfNameInCountryRequestModel request = new AverageAgeOfNameInCountryRequestModel
                {
                    Name = name,
                    Country = country
                };

                AverageAgeResponseModel _ = AgeCoordinator.GetAverageAge(request).Result;

                Console.WriteLine($"For the name {_.Name}, there is an average age of {_.Age}");
                GetRemainingApiCallCount.GetRemainingApiCalls(false);
                GetRemainingTimeUntilApiReset.GetTime(false);
                Console.WriteLine("");
                UIHelper.ReturnToMenu();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private static void ValidateRemainingApiCalls()
        {
            if (CallCountCoordinator.CallsRemaining == 0)
            {
                Console.WriteLine("You have run out of API calls for the day");
                GetRemainingTimeUntilApiReset.GetTime(false);
                Console.ReadLine();
                return;
            }
        }

        private static string InputCountryCode()
        {
            Console.WriteLine("2) Please enter a country code");
            var country = Console.ReadLine();
            if (country.Length != 2)
            {
                Console.WriteLine("Please enter a country code that is 2 Characters and adheres to the ISO 3166-1 alpha-2 format");
                Console.WriteLine("Press any key to continue");
                Console.ReadLine();
                return InputCountryCode();
            }

            return country;
        }

        private static string InputName()
        {
            Console.WriteLine("1) Please enter a name");
            return Console.ReadLine();       
        }
    }

   
}
