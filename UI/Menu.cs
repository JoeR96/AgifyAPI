using System;

namespace AgifyAPI.UI
{
    public class Menu
    {     
        public bool MainMenu()
        {
            PrintMenu();

            switch (Console.ReadLine())
            {
                case "1":
                    GetAverageAgeInput.AverageAgeOfNameInCountry();
                    return true;
                case "2":
                    GetRemainingApiCallCount.GetRemainingApiCalls();
                    return true;
                case "3":
                    GetRemainingTimeUntilApiReset.GetTime();
                    return true;
                default:
                    return true;
            }
        }

        private void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Find average name of an age in a country");
            Console.WriteLine("2) Show remaining API calls");
            Console.WriteLine("3) Show remaining time until call count reset");
            Console.WriteLine("4) Exit");
            Console.Write("\r\nSelect an option: ");
        }
    }
}
