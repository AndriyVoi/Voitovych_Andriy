using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*SmallArms pistol = new Pistol();
            Console.WriteLine(pistol.ToString());

            SmallArms automaticWithNight = new AutomaticRifle();

            automaticWithNight = new NightVisionDevice(automaticWithNight);
            Console.WriteLine(automaticWithNight.ToString());*/
            FacadeSmallArmsMaker smallArmsMaker = new FacadeSmallArmsMaker();
            bool flag = true;
            while (flag)
            {
                flag=smallArmsMaker.ChooseSmallArms();
                smallArmsMaker.ChooseModification();
                smallArmsMaker.AddSmallArm();
                smallArmsMaker.Print();
            }
            Console.Clear();
            Console.WriteLine("Найдорожчий комплект зброї:\n"+smallArmsMaker.MaxPrice());
            Console.ReadKey();
        }
    }
}
