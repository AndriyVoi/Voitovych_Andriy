using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Sight : ModificationDecorator
    {
        public Sight(SmallArms smallArms)
        {
            this.MaxWeight=smallArms.MaxWeight;
            WeightModification = 2.5;
            this.smallArms = smallArms;
            this.Weight = this.smallArms.Weight + WeightModification;
        }
        public override double Cost()
        {
            return smallArms.Cost() + 0.35;
        }

        public override string GetDescription()
        {
            return smallArms.GetDescription() + ", Sight";
        }
    }
}
