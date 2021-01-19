using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_actual_KD
{
    public static class UserInterface
    {
        // member variables

        // constructor

        // member methods
        public static string GetUserInputFor(string promptForUser)
        {
            Console.WriteLine(promptForUser);
            string userInput = Console.ReadLine();
            return userInput;
        }
        public static void CongratulateWinner(Sweepstakes contest, Contestant winner)
        {
            Console.WriteLine("Congratulations " + winner.firstName + " " + winner.lastName + " you've won " + contest.Name + "!");
        }
        public static void NotifyAllOfWinner(Sweepstakes contest, Contestant winner)
        {
            Console.WriteLine(winner.firstName + " " + winner.lastName + " has won " + contest.Name + "!");
        }
    }
}
