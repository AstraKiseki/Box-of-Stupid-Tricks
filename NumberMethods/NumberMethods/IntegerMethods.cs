using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberMethods
{
    public class IntegerMethods
    {
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
        // thing I learned today, Counter is already an used word in System.Reflection.
        static int Counting()
        {
            int x = 1;
            return ++x;
        }
    }
}
