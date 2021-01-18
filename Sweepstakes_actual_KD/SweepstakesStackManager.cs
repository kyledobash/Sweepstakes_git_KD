using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_actual_KD
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        // member variables
        Stack<Sweepstakes> stack;

        // constructor


        // member methods
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            //how can I do this?
        }
    }
}
