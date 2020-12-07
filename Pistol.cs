using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Pistol : SmallArms
    {
        public Pistol(double flightRange, double power, double weight, int year) : base(flightRange, power, weight, year)
        {
            Description = "Pistol " + this.Year + " року";
            this.MaxWeight = 5;
        }

        public override double Cost()
        {
            return 800 - (DateTime.Today.Year - this.Year);
        }
        
    }
}
