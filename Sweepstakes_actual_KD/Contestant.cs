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
        public Contestant(string firstname, string lastname, string address, int registrationnumber)
        {
            this.firstName = firstname;
            this.lastName = lastname;
            this.address = address;
            this.registrationNumber = registrationnumber;
        }

        // member methods

    }
}
