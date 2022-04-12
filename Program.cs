using AgifyAPI.UI;
using System;

namespace AgifyAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
           try
            {
                bool showMenu = true;
                var menu = new Menu();

                while (showMenu)
                {
                    showMenu = menu.MainMenu();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }    
    } 
}
