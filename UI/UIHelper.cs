using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgifyAPI.UI
{
    public static class UIHelper
    {
        public static void ReturnToMenu()
        {
            Console.WriteLine("Press any key to return to the main menu");
            Console.ReadLine();
        }
    }
}
