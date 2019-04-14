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

            Console.WriteLine("Welcome To RPS game!");
            String[] weapons = {"Rock", "Paper", "Scissors"};
            int UserScore = 0;
            int CompScore = 0;
            int Tie = 0;
            int selection;
            Random r = new Random();
            Console.WriteLine("How many rounds would you like to play? Ex. Write '10' for 10.\n Write '0' to exit.");
            int loop = Convert.ToInt16(Console.ReadLine());
            if(loop == 0)
            {
                Console.WriteLine("Goodbye!");
                System.Threading.Thread.Sleep(1000);
                Environment.Exit(0);
                
            }
            else
            {
                do
                {
                    Console.WriteLine("Pick your weapon of choice for this round.\n(ex. 0--->Rock\n 1--->Paper\n 2--->Scissors\n");
                    selection = Convert.ToInt16(Console.ReadLine());
                    int r2 = Convert.ToInt16(r.Next(0, 3));
                    if (selection == 0)
                    {
                        switch (r2)
                        {

                            case 0:
                                Console.WriteLine("Computer selected: {0:S}", weapons[0]);
                                Console.WriteLine("Tied.");
                                Tie += 1;
                                break;

                            case 1:
                                Console.WriteLine("Computer selected: {0:S}", weapons[1]);
                                Console.WriteLine("Computer Wins!");
                                CompScore += 1;
                                break;

                            case 2:
                                Console.WriteLine("Computer selected: {0:S}", weapons[2]);
                                Console.WriteLine("User Wins!");
                                UserScore += 1;
                                break;

                            default:
                                Console.WriteLine("Something went wrong!");
                                break;

                        }
                       
                    }
                    else if (selection == 1)
                    {
                        switch (r2)
                        {
                            case 0:
                                Console.WriteLine("Computer selected: {0:S}", weapons[0]);
                                Console.WriteLine("User Wins!");
                                UserScore += 1;
                                break;

                            case 1:
                                Console.WriteLine("Computer selected: {0:S}", weapons[1]);
                                Console.WriteLine("Tied.");
                                Tie += 1;
                                break;

                            case 2:
                                Console.WriteLine("Computer selected: {0:S}", weapons[2]);
                                Console.WriteLine("Computer Wins!");
                                CompScore += 1;
                                break;

                            default:
                                Console.WriteLine("Something went wrong!");
                                break;
                        }
                    }
                    else if (selection == 2)
                    {
                        switch (r2)
                        {
                            case 0:
                                Console.WriteLine("Computer selected: {0:S}", weapons[0]);
                                Console.WriteLine("Computer Wins!");
                                CompScore += 1;
                                break;

                            case 1:
                                Console.WriteLine("Computer selected: {0:S}", weapons[1]);
                                Console.WriteLine("User Wins!");
                                UserScore += 1;
                                break;

                            case 2:
                                Console.WriteLine("Computer selected: {0:S}", weapons[2]);
                                Console.WriteLine("Tied.");
                                Tie += 1;
                                break;

                            default:
                                Console.WriteLine("Something went wrong!");
                                break;

                        }
                    }

                    loop--;
                } while (loop > 0);

                Console.WriteLine("Game Has Ended! \n The resulst are:");
                Console.WriteLine("Computer win count: {0:D} \n User win count {1:D}\n Tied Rounds: {2:D}", CompScore, UserScore, Tie);
                Console.WriteLine("Press Enter to exit.");
                Console.ReadLine();
            }


            
          
        }
    }
}
