using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {

            Console.WriteLine("Enter hand 1:");
            string hand1 = Console.ReadLine().ToLower();
            Random random = new Random();
            int randomNumber = random.Next(0,3);

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }
        
        public static string CompareHands(string hand1, string hand2)
        {
            if (hand1 == hand2)
            { 
                return "It's a tie!";
            }
            if (hand1 == "0")
            {
                if (hand2 == "3");
            {
            return "Hand one wins!";
            }
            return "Hand two wins!";
            }

            if (hand1 == "2")
            {
                if (hand1 == "1");
            {
            return "Hand one wins";
            }
            if (hand2 == "3");
            {
            return "Hand two wins";
            }

            if (hand1 == "3")
            {
                if (hand2 == "2");
            {
            return "Hand one wins!";
            }
            return "Hand two wins!";
            }
        }
                
          Console.ReadLine();     
        }
    }
}
