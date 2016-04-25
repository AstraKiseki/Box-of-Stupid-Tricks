using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddsAndEnds
{
    public class OddsAndEnds
    {
        public static void Close()
        {
            Console.ReadKey();
            Console.WriteLine("Would you like to run another calculation? (y/n)"); // for good practice
            string userValue = Console.ReadLine();
            userValue = userValue.ToLower();
            if (userValue == "y")
            {
                Environment.Exit(0);
            }
            if (userValue == "n")
            {
                Console.WriteLine("Well we need something to do then!");
            }
            else
            {
                Console.WriteLine("Please enter a valid answer.");
            }
        }
    }
}