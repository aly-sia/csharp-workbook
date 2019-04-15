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
                Console.WriteLine("It's a tie!");
            }
            if (hand1 == "rock")
            {
                if (hand2 == "scissors");
            {
            Console.WriteLine( "Hand one wins!");
            }
            Console.WriteLine("Hand two wins!");
            }

            if (hand1 == "paper")
            {
                if (hand1 == "rock");
            {
            Console.WriteLine("Hand one wins");
            }
            if (hand2 == "scissors");
            {
            Console.WriteLine("Hand two wins");
            }

            if (hand1 == "scissors")
            {
                if (hand2 == "paper");
            {
            Console.WriteLine("Hand one wins!");
            }
            Console.WriteLine("Hand two wins!");
            }
        }
                
          Console.ReadLine();     
        }
    }
}
