using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterMethods
{
    public class LetterMethods
    {
        static string QuoteAnswer = "This is for practice!";

        // This trick was used in quote hangman and the inspiration for the whole repo.
        static string maskString(string input)
        {
            string[] words = QuoteAnswer.Split(' ');
            string DisplayWord = "";

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                for (int j = 0; j < currentWord.Length; j++)
                {
                    DisplayWord += "-";
                }
                DisplayWord += " ";
            }
            DisplayWord = DisplayWord.TrimEnd();
            return DisplayWord;
        }

        public static bool IsThereA(string guessLetter) // Credit to DRapp for this
        {
            if (usedLetters.Contains(guessLetter) == false)
            {
                int maxlength = QuoteAnswer.Length;
                bool anyMatch = false;
                for (int i = 0; i < QuoteAnswer.Length; i++)
                {
                    if (QuoteAnswer.Substring(i, 1).Equals(guessLetter))
                    {
                        anyMatch = true;
                        DisplayWord = DisplayWord.Substring(0, i) + guessLetter + DisplayWord.Substring(i + 1);
                    }
                }
                usedLetters.Add(guessLetter);
                return anyMatch;

            }
            if (usedLetters.Contains(guessLetter))
            {
                Console.WriteLine("Oh!  You have already used:");
                usedLetters.ForEach(item => Console.Write(item + " "));
                Console.WriteLine(" ");
            }
            return true;
        }
    }
}
    }
}
