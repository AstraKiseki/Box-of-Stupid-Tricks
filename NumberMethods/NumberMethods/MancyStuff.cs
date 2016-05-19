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

        public static string SpellArray(string spell)
        {
            string[] letters = spell.Split();

            for (int i = 0; i < letters.Length; i++)
            {
                string currentLetter = letters[i];
                for (int j = 0; j < currentLetter.Length; j++)
                {
                    if (currentLetter == "a")
                    { }
                    if (currentLetter == "b")
                    { }
                    if (currentLetter == "c")
                    { }
                    if (currentLetter == "d")
                    { }
                    if (currentLetter == "e")
                    { }
                    if (currentLetter == "f")
                    { }
                    if (currentLetter == "g")
                    { }
                    if (currentLetter == "h")
                    { }
                    if (currentLetter == "i")
                    { }
                }
            }
            
        }
    }
}
