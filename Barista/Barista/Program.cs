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
            var espresso = new Beverage()
                .AddIngredient(new Bean { Amount = 5, BeanType = "Arabica" })
                .AddIngredient(new Water { Amount = 10, Temperature = 85})
                .ValidateTemperature(x => x.Temperature < 90)
                .ToBeverage();

            var latte = new Beverage()
                .AddIngredient(new Bean { Amount = 5, BeanType = "Arabica" })
                .AddIngredient(new Water { Amount = 10, Temperature = 89 })
                .ValidateTemperature(x => x.Temperature < 90)
                .AddIngredient(new Milk { Amount = 2 })
                .ToBeverage();

            Console.ReadLine();
        }
    }

    class Beverage
    {
        public Water WaterUsed { get; set; }
        public Bean BeansUsed { get; set; }
        public IIngredient MilkUsed { get; set; }

        public Beverage AddIngredient(IIngredient ingredient)
        {
            switch (ingredient.GetType().ToString())
            {
                case "Barista.Water":
                    WaterUsed = (Water)ingredient;
                    break;
                case "Barista.Bean":
                    BeansUsed = (Bean)ingredient;
                    break;
                case "Barista.Milk":
                    MilkUsed = ingredient;
                    break;
                default:
                    throw new NotImplementedException();
            }

            return this;
        }

        public Beverage ValidateTemperature(Func<Water, bool> waterQuery)
        {
            if (waterQuery.Invoke(WaterUsed))
            {
                HeatWater();
            }
            return this;
        }

        // Heats the waterUsed to 95 degrees and prints it.
        private void HeatWater()
        {
            for (int i = WaterUsed.Temperature; i < 96; i++)
            {
                Thread.Sleep(300);
                WaterUsed.Temperature++;
                Console.WriteLine($"Temperature: {i}c.");
            }
            Console.WriteLine();
        }

        private string GetBeverageType()
        {
            string drinkType = "";

            // Espresso.
            if (WaterUsed != null &&
                BeansUsed != null &&
                MilkUsed == null)
            {
                drinkType = "espresso";
            }

            // Latte.
            else if (WaterUsed != null &&
                BeansUsed != null &&
                 MilkUsed != null)
            {
                drinkType = "latte";
            }

            return drinkType;
        }

        public Beverage ToBeverage()
        {
            string drinkType = GetBeverageType();

            switch (drinkType)
            {
                case "espresso":
                    Console.WriteLine($"Your {drinkType} was made with {BeansUsed.Amount}g {BeansUsed.BeanType} beans and {WaterUsed.Amount}cl water!");
                    break;
                case "latte":
                    Console.WriteLine($"Your {drinkType} was made with {BeansUsed.Amount}g {BeansUsed.BeanType} beans, {WaterUsed.Amount}cl water and {MilkUsed.Amount}cl of milk!");
                    break;
            }

            Console.WriteLine();
            return this;
        }
    }

    interface IIngredient
    {
        int Amount { get; set; }
    }

    class Bean : IIngredient
    {
        public string BeanType { get; set; }
        public int Amount { get; set; }
    }

    class Water : IIngredient
    {
        public int Amount { get; set; }
        public int Temperature { get; set; }
    }

    class Milk : IIngredient
    {
        public int Amount { get; set; }
    }
}
