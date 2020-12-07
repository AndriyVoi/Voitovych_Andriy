using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class FacadeSmallArmsMaker
    {
        public SmallArms smallArms;
        List<SmallArms> arsenal;

        public FacadeSmallArmsMaker()
        {
            arsenal = new List<SmallArms>();
        }

        public bool ChooseSmallArms()
        {
            //Console.Clear();
            Console.WriteLine("Оберіть зброю: \n 1-AutomaticRifle\n 2-Pistol\n 3-AssaultRifle\n Інше -Вихід");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1: {
                            EnterСharacteristics(out double flightRange, out double power, out double weight, out int year);
                            smallArms = new AutomaticRifle(flightRange, power, weight, year); return true;
                    }
                case 2: {
                            EnterСharacteristics(out double flightRange, out double power, out double weight, out int year);
                            smallArms = new Pistol(flightRange, power, weight, year); return true;
                    }
                case 3: {
                            EnterСharacteristics(out double flightRange, out double power, out double weight, out int year);
                            smallArms = new AssaultRifle(flightRange, power, weight, year); return true; 
                        }
                default: { smallArms = null; return false; }
            }
        }
        public void EnterСharacteristics(out double flightRange, out double power, out double weight, out int year)
        {
            Console.WriteLine("Введіть дальність польоту: ");
            flightRange = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть силу ураження: ");
            power = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть вагу: ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть рік випуску: ");
            year = Convert.ToInt32(Console.ReadLine());
        }
        public void AddSmallArm()
        {
            if(this.smallArms!=null)
            {
                this.arsenal.Add(this.smallArms);
            }
            
        }
        public string MaxPrice()
        {
            //var maxPrice = arsenal.Max<SmallArms>(a => a.Cost());
            var maxPrice = arsenal.Aggregate((i, j) => i.Cost() > j.Cost() ? i : j);
            return maxPrice.ToString();
        }
            public void ChooseModification()
        {
            if(smallArms!=null)
            {
                bool flag = true;
                while(flag)
                {
                    try
                    {
                        //Console.Clear();
                        Console.WriteLine("Оберіть модифікацію: \n 1-Sight\n 2-Silencer\n 3-NightVisionDevice\n Інше -Вихід");
                        int choose = Convert.ToInt32(Console.ReadLine());
                        switch (choose)
                        {
                            case 1: { AddSight(); break; }
                            case 2: { AddSilencer(); break; }
                            case 3: { AddNightVisionDevice(); break; }
                            default: return; 
                        }
                        Console.Clear();
                        Console.WriteLine("Бажажти додати ще модифікацію?: \n 1-Так\n  Інше -Ні");
                        string temp = Console.ReadLine();
                        if (temp != "1")
                        {
                            flag = false;
                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            
        }
        public void AddSight()
        {
            smallArms = new Sight(smallArms);
        }
        public void AddSilencer()
        {
            smallArms = new Silencer(smallArms);
        }

        public void AddNightVisionDevice()
        {
            smallArms = new NightVisionDevice(smallArms);
        }

        public void Print()
        {
            if (arsenal != null)
            {
                Console.Clear();
                Console.WriteLine("\n\nВаша зброя додана: ");
                Console.WriteLine(arsenal[arsenal.Count- 1].ToString());
            }
            else
            {
                Console.Clear();
            }
        }
    }
}
