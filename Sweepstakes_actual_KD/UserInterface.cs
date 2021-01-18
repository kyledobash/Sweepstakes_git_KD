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
    }
}
