using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class AssaultRifle : SmallArms
    {

        public AssaultRifle(double flightRange, double power, double weight, int year) : base(flightRange, power, weight, year)
        {
            Description = "AssaultRifle " + this.Year + " року";
            this.MaxWeight = 10;
        }

        public override double Cost()
        {
            return  1200 - (DateTime.Today.Year - this.Year);
        }
    }
}
