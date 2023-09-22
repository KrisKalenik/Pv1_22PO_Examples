using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Events
{
    internal class Clerk
    {
        public Clerk()
        {
            Gai.OnPenalty += Gai_Penalty;
            Gai.OnPremium += Gai_Premium;
        }

        void Gai_Penalty(Driver driver, int speed, ref string msg)
        {
            msg += $"Finr the Driver {driver.Name}" +
                $" for Speeding {speed} \"km/h\" [Clerk]\n";
        }

        void Gai_Premium(Driver driver, int speed, ref string msg)
        {
            msg += $"Reward the Driver {driver.Name}" +
                $" for Speeding {speed} \"km/h\" [Clerk]\n";
        }
    }
}
