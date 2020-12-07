using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class NightVisionDevice : ModificationDecorator
    {
        public NightVisionDevice(SmallArms smallArms)
        {
            this.MaxWeight = smallArms.MaxWeight;
            WeightModification = 3;
            this.smallArms = smallArms;
            this.Weight = this.smallArms.Weight + WeightModification;
        }
        public override double Cost()
        {
            return smallArms.Cost() + 0.5;
        }

        public override string GetDescription()
        {
            return smallArms.GetDescription() + ", NightVisionDevice";
        }
        
    }
}
