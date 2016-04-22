using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberMethods
{
    public class IntegerMethods
    {
       // For when you need a number from the user.  Do note that if it's something as simple as a counter, it'll be just like x++; that's all.
        static int GetIntegerFromUser(string prompt)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(prompt);
                    string input = Console.ReadLine();
                    int x = int.Parse(input);
                    return x;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter an integer.");
                }
            }
        }
    }
}
