using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_actual_KD
{
    public interface ISweepstakesManager
    {
        // properties

        // methods
        void InsertSweepStakes(Sweepstakes sweepstakes);

        Sweepstakes GetSweepstakes();
    }
}
