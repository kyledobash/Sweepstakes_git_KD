using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_actual_KD
{
    public class Simulation
    {
        // member variables
        MarketingFirm marketingFirm;

        // constructor
        public Simulation()
        {
            CreateMarketingFirmWithManager();
        }

        // member methods
        public void CreateMarketingFirmWithManager()
        {
            marketingFirm = new MarketingFirm(ManagerFactory());
        }

        public ISweepstakesManager ManagerFactory()
        {
            string managerType = UserInterface.GetUserInputFor("Type 'stack' for stack manager\nType 'queue' for queue manager");           
            switch (managerType.ToLower())
            {
                case "stack":
                    return new SweepstakesStackManager();
                case "queue":
                    return new SweepstakesQueueManager();
                default:
                    throw new Exception("Invalid input");
            }
        }
    }
}
