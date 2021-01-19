using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_actual_KD
{
    public class Contestant
    {
        // member variables
        public string firstName;
        public string lastName;
        public string address;
        public int registrationNumber;

        // constructor
        public Contestant(int registrationnumber)
        {
            this.firstName = UserInterface.GetUserInputFor("Please enter your first name");
            this.lastName = UserInterface.GetUserInputFor("Please enter your last name");
            this.address = UserInterface.GetUserInputFor("Please enter your address");
            this.registrationNumber = registrationnumber;
        }

        // member methods

    }
}
