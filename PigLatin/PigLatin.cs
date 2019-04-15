using System;

namespace PigLatin
{
    class Program
    {
        public static void Main()
         {
            Console.WriteLine("Enter a word to be translated to pig Latin");
			string word = Console.ReadLine();
			string firstLetter = word.Substring(0, 1);
			string restWord = word.Substring(1);
			Console.WriteLine(restWord + firstLetter + "ay");
			char[] vowel = { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' };
			for (int i = 0; i < vowel.Length; i++)
			{
				//some code????
			}

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }
        
        public static string TranslateWord(string word)
        {
            // your code goes here
            return word;
        }
    }
}
