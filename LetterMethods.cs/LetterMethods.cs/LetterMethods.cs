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
    }
}
