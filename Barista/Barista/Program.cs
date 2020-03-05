using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barista
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var smallEspresso = new Espresso()
                .AddBean(new Bean { AmountInG = 5, BeanType = "Arabica" })
                .AddWater(new Water { Amount = 10, Temperature = 91 })
                .Validate(x => x.Temperature <= 90);
            Console.WriteLine(smallEspresso);
            Console.ReadKey();
        }
    }


    interface IBeverage
    {
        IBeverage AddWater(Water water);
        IBeverage AddBean(Bean bean);
        IBeverage AddToCup();
        IBeverage Validate(Func<Water, bool> waterQuery);
        string GetBean();
    }


    class Espresso :IBeverage
    {
        public Water _water { get; set; }
        public Bean _bean { get; set; }


        public IBeverage AddWater(Water water)
        {
            if (_water != null)
            {
                throw new Exception("water already exists");
            }
            _water = water;

            return this;
        }

        public IBeverage AddBean(Bean bean)
        {
            if (_bean == null)
            {
                _bean = bean;
            }

            return this;
        }

        public IBeverage AddToCup()
        {
            return this;
        }

        public string GetBean()
        {
            return _bean.BeanType;
        }

        public IBeverage Validate(Func<Water, bool> waterQuery)
        {
            if (waterQuery.Invoke(_water))
            {
                HeatWater(_water);
            }
            else { Console.WriteLine("utanför"); }
            return this;
        }

        public void HeatWater(Water water)
        {

        }

        public override string ToString()
        {
            return ($"Din espresso är gjord av : {_bean.AmountInG}g {_bean.BeanType}-bönor " +
                $"och {_water.Amount}cl av {_water.Temperature} grader varmt vatten.");
        }
    }

     class Bean
    {
        public string BeanType { get; set; }
        public int AmountInG { get; set; }

    }

    class Water
    {
        public int Amount { get; set; }
        public int Temperature { get; set; }
    }
}
