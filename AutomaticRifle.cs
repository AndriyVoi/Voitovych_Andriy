using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class AutomaticRifle:SmallArms
    {
        public AutomaticRifle(double flightRange, double power, double weight, int year) : base(flightRange, power, weight, year)
        {
            Description = "AutomaticRifle " + this.Year + " року";
            this.MaxWeight = 7;
        }
        public override double Cost()
        {
            return 1000-(DateTime.Today.Year-this.Year);
        }

        


    }
}
