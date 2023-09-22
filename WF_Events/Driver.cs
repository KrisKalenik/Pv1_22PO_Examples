using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Events
{
    internal class Driver
    {
        public string Name { get; set; }

        public Driver(string name)
        {
            Name = name;
            Gai.OnPenalty += Gai_Penalty;
            Gai.OnPremium += Gai_Premium;
        }

        void Gai_Penalty(Driver driver, int speed, ref string msg)
        {
            if (driver == this)
                msg += $"Grateful for the Fine! Driver {Name}\n";
        }

        void Gai_Premium(Driver driver, int speed, ref string msg)
        {
            if (driver == this)
                msg += $"Thank You for the Bonus! Driver {Name}\n";
        }
    }
}
