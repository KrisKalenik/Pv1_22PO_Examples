using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Events
{
    delegate void Premium(Driver driver, int speed, ref string msg);
    delegate void Penalty(Driver driver, int speed, ref string msg);

    internal class Gai
    {
        const int SPEED_BORDER = 60;
        public static event Premium OnPremium;
        public static event Penalty OnPenalty;

        public static void MeasureSpeed(Driver driver, int speed,
            ref string msg)
        {
            if (speed <= SPEED_BORDER && OnPremium != null)
                OnPremium(driver, speed, ref msg);
            else if (OnPenalty != null)
                OnPenalty(driver, speed, ref msg);
        }
    }
}
