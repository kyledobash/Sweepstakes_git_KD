using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_actual_KD
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        // member methods
        Queue <Sweepstakes> queue;

        // constructor
        public SweepstakesQueueManager()
        {
            queue = new Queue<Sweepstakes>();
        }

        // member variables
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            return queue.Dequeue(); // REVIEW THIS
        }
    }
}
