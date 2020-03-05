using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Barista
{
    class Program
    {
        static void Main(string[] args)
        {

            var smallEspresso = new Beverage()
                .AddBean(new Bean { AmountInG = 5, BeanType = "Arabica" })
                .AddWater(new Water { Amount = 10, Temperature = 89 })
                .Validate(x => x.Temperature < 90)
                .AddIngredient(new ChocolateSyrup { AmountInCl = 5 })
                .ToBeverage();

            Console.WriteLine(smallEspresso._chocolatesyrup);
            Console.ReadKey();
        }
    }


    interface IBeverage
    {
        IBeverage AddWater(Water water);
        IBeverage AddBean(Bean bean);
        IBeverage AddToCup();
        IBeverage Validate(Func<Water, bool> waterQuery);
        IBeverage AddIngredient(IIngredient ingredient);
        Beverage ToBeverage();
    }

    interface IIngredient
    {
        int AmountInCl { get; set; }
    }


    class Beverage :IBeverage
    {
        public Water _water { get; set; }
        public Bean _bean { get; set; }
        public IIngredient _milk { get; set; }
        public IIngredient _milkfoam { get; set; }
        public IIngredient _chocolatesyrup { get; set; }

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
            if (_bean != null)
            {
                throw new Exception("Bean already exists");
            }
            _bean = bean;
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
            return this;
        }

        public void HeatWater(Water water)
        {
            for (int i = water.Temperature; i < 93; i++)
            {
                Thread.Sleep(500);
                water.Temperature++;
                Console.WriteLine($"tempratur {i}");
            }
        }

        public Beverage ToBeverage()
        {
            return this;
        }

        public IBeverage AddIngredient(IIngredient ingredient)
        {
            switch (ingredient.GetType().ToString())
            {
                case "Barista.Milk":
                    _milk = ingredient;
                    break;
                case "Barista.MilkFoam":
                    _milkfoam = ingredient;
                    break;
                case "Barista.ChocolateSyrup":
                    _chocolatesyrup = ingredient;
                    break;
                default:
                    Console.WriteLine(ingredient.GetType().ToString());
                    break;
            }
            return this;
        }

        public IBeverage AddMilkFoam(MilkFoam milkFoam)
        {
            throw new NotImplementedException();
        }

        public IBeverage AddChocolateSyrup(ChocolateSyrup chocolateSyrup)
        {
            throw new NotImplementedException();
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

    class Milk : IIngredient
    {
        public int AmountInCl { get; set; }
    }

    class MilkFoam : IIngredient
    {
        public int AmountInCl { get; set; }
    }

    class ChocolateSyrup : IIngredient
    {
        public int AmountInCl { get; set; }

        public override string ToString()
        {
            return $"{AmountInCl} cl Chocolate Syrup";
        }
    }

}
