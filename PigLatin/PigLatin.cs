using System;

namespace PigLatin
{
    class Program
    {
        public static void Main()
         {
    {
            Console.WriteLine("Enter a word to be translated to pig Latin");
			string word = Console.ReadLine();
			char[] vowel = { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' };
			int currentLetter;
			 foreach (string word in vowel.Split(' '))
			 {
				string firstLetter = word.Substring(0, 1);
				string restWord = word.Substring(1, word.Length -1);
				Console.WriteLine(restWord + firstLetter + "ay");

            if (currentLetter == -1)
            {
                word = restWord + firstLetter + "ay";
            }
            else
            {
                word = word + "way";
            }
        }

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
			return word;

        }
                  
        }
    }
}
