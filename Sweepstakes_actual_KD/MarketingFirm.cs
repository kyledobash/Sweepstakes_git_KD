using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_actual_KD
{
    public class MarketingFirm
    {
        // member variables
        ISweepstakesManager _manager;

        // constructor
        public MarketingFirm(ISweepstakesManager manager)
        {
            _manager = manager;
        }

        // member methods
        public void CreateSweepstake()
        {
            _manager.InsertSweepstakes(new Sweepstakes(UserInterface.GetUserInputFor("Please enter Sweepstakes name")));
        }

        //          CreateSweepstake is utilizing dependency injection to ensure versatility when adding/instantiating
        //      a new Sweepstake object. This way, the Sweepstakes manager can consist of either a
        //      stack OR queue. This is done by assigning the _manager variable to the ISweepstakesManager (interface) type,
        //      rather than specifically the SweepstakesStackManager class or the SweepstakesQueueManager class.
    }
}
