using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_actual_KD
{
    public class Sweepstakes
    {
        // member variables
        public Dictionary<int, Contestant> contestants;
        public string name;

        // constructor
        public Sweepstakes(string name)
        {
            this.name = name;
            contestants = new Dictionary<int, Contestant>();
        }

        // member methods
        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.registrationNumber, contestant);
        }

        public Contestant PickWinner()
        {
            Random winner = new Random();

            int winnerID = winner.Next(0, contestants.Count);
            return contestants[winnerID];
        }
    }
}
