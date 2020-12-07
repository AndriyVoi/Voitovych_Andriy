using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    abstract class ModificationDecorator : SmallArms
    {
        public SmallArms smallArms;

        protected ModificationDecorator():base()
        {

        }
        public double WeightModification { get; set; }
        public abstract override double Cost();

        public abstract override String GetDescription();
        public override string ToString()
        {
            return this.GetDescription() + ":" + this.Cost() + "$";
        }
    }
}
