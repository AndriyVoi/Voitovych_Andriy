using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Silencer : ModificationDecorator
    {
        public Silencer(SmallArms smallArms)
        {
            this.MaxWeight = smallArms.MaxWeight;
            WeightModification = 2;
            this.smallArms = smallArms;
            this.Weight = this.smallArms.Weight + WeightModification;
        }
        public override double Cost()
        {
            return smallArms.Cost() + 0.2;
        }

        public override string GetDescription()
        {
            return smallArms.GetDescription() + ", Silencer";
        }
        
    }
}
