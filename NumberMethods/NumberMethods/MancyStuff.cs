using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberMethods
{
    class MancyStuff
    {
        /*
        Objective: http://www.d20pfsrd.com/feats/general-feats/arithmancy  Make a calculator for this.
        Needs to take in a string, 
        turn its letters into an array, 
        turn them into numbers, 
        add them all together, 
        convert that into a string to see how many characters are in it,
        if it is equal to 1, then you have the digital root.
        If it isn't, convert that string back into an array
        and repeat
        */

        public string spell = Console.ReadLine();

        public static void SpellArray(string spell)
        {
            spell = spell.ToLower();
            string[] letters = spell.Split();
            List<int> rootList = new List<int>();
            int digitalRoot = 0;
            digitalRoot = rootList.Sum();
            string rootCheck = digitalRoot.ToString();
            string[] rootNumbers = rootCheck.Split();

            if (rootNumbers.Length != 0)
                for (int i = 0; i < letters.Length; i++)
            {
                string currentLetter = letters[i];
                for (int j = 0; j < currentLetter.Length; j++)
                {
                    if (currentLetter == "a" || currentLetter == "s" || currentLetter == "j")
                    {
                        rootList.Add(1);
                    }
                    if (currentLetter == "b" || currentLetter == "k" || currentLetter == "t")
                    {
                        rootList.Add(2);
                    }
                    if (currentLetter == "c" || currentLetter == "l" || currentLetter == "u")
                    {
                        rootList.Add(3);
                    }
                    if (currentLetter == "d" || currentLetter == "m" || currentLetter == "v")
                    {
                        rootList.Add(4);
                    }
                    if (currentLetter == "e" || currentLetter == "n" || currentLetter == "w")
                    {
                        rootList.Add(5);
                    }
                    if (currentLetter == "f" || currentLetter == "o" || currentLetter == "x")
                    {
                        rootList.Add(6);
                    }
                    if (currentLetter == "g" || currentLetter == "p" || currentLetter == "y")
                    {
                        rootList.Add(7);
                    }
                    if (currentLetter == "h" || currentLetter == "q" || currentLetter == "z")
                    {
                        rootList.Add(8);
                    }
                    if (currentLetter == "i" || currentLetter == "r")
                    {
                        rootList.Add(9);
                    }
                    else
                    {
                        rootList.Add(0);
                    }
                }
            }
            Console.WriteLine("So the digital root of the spell" + spell + "is" + digitalRoot + ".");
        }
    }
}
