using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    abstract class SmallArms
    {
        String description = "Unknown Small Arms";
        double weight;

        public SmallArms(double flightRange, double power, double weight, int year)
        {
            FlightRange = flightRange;
            Power = power;
            Weight = weight;
            Year = year;
        }

        protected SmallArms()
        {
        }
        public double MaxWeight { get; set; } = 99999;
        public string Description { set { description = value; } }
        public double FlightRange { get; set; }
        public double Power { get; set; }
        public double Weight 
        { 
            get
            {
                return weight;
            }
            set 
            {
                if(value>MaxWeight)
                {
                    throw new Exception("Перевищено максимальну вагу");
                }
                else
                {
                    this.weight = value;
                }
            } 
        }
        public int Year { get; set; }
        public abstract double Cost();
        public virtual String GetDescription()
        {
            return description;
        }
        public override string ToString()
        {
            return this.GetDescription() +":" + this.Cost() + "$";
        }
    }
}
