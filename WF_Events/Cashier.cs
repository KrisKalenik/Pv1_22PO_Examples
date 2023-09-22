using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WF_Events
{
    internal class Cashier
    {
        public Cashier()
        {
            Gai.OnPenalty += Gai_Penalty;
            Gai.OnPremium += Gai_Premium;
        }

        void Gai_Penalty(Driver driver, int speed, ref string msg)
        {
            msg += $"Collecting a Fine from Driver {driver.Name}" +
                $" for Speed {speed} \"km/h\" [Cashier]\n";
        }

        void Gai_Premium(Driver driver, int speed, ref string msg)
        {
            msg += $"Awarding a Bonus to Driver {driver.Name}" +
                $" for Speed {speed} \"km/h\" [Cashier]\n";
        }
    }
}
