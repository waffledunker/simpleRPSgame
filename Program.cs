using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int userA = 0; // user A score
            int userB = 0; // user B score
            int i = 0;  // iterator to 100
            Random r = new Random();
            int choice;  // random number holder 
            int tie = 0;  // tie counter
            do
            {
                choice = r.Next(0, 3);  // choice of user B
                                        //because user A is always paper
                                        // rock = 0 , paper = 1, scissors = 2;

                switch (choice)
                {
                    case 0:
                        userA += 1;
                        break;

                    case 1:
                        tie += 1;
                        break;

                    case 2:
                        userB += 1;
                        break;

                    default:
                        Console.WriteLine("Error");
                        break;
                        
                }
                i++;

            } while (i < 100);

            Console.WriteLine("Player A's wins {0:D} of {1:D} games", userA, i);
            Console.WriteLine("Player B's wins {0:D} of {1:D} games", userB, i);
            Console.WriteLine("Tie: {0:D} of {1:D} games", tie, i);  // final outputs
            Console.WriteLine("Press Enter to Exit.");
            Console.ReadLine();
        }
    }
}
