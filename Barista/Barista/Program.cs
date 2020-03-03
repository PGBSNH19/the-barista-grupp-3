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
        }
    }


    interface IBarista
    {
        IBarista Brew();
        IBarista AddWater();
        IBarista AddBeans();
        IBarista AddToCup(int volume);
        IBarista CheckBeans();
        IBarista GrindBeans(int WeightGram, string brand);
        
    }


    class Barista : IBarista
    {
        public IBarista AddBeans()
        {
            throw new NotImplementedException();
        }

        public IBarista AddToCup(int volume)
        {
            throw new NotImplementedException();
        }

        public IBarista AddWater()
        {
            throw new NotImplementedException();
        }

        public IBarista Brew()
        {
            throw new NotImplementedException();
        }

        public IBarista CheckBeans()
        {
            throw new NotImplementedException();
        }

        public IBarista GrindBeans(int weightGram, string brand)
        {
            throw new NotImplementedException();
        }
    }


    class CoffieMaker
    {
        private double _temp;

        public double Temp
        {
            get { return _temp; }
            set { _temp = value; }
        }
        private int _waterAmount;

        public int WaterAmount
        {
            get { return _waterAmount; }
            set { _waterAmount = value; }
        }
        private int _timeSeconds;

        public int TimeSeconds
        {
            get { return _timeSeconds; }
            set { _timeSeconds = value; }
        }
        private string _manufacturer;

      

    }
    class Bean
    {
        private string _origin;

        public string Origin 
        {
            get { return _origin; }
            set { _origin = value; }
        }
        private int _weight;

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        private int _roast;

        public int Roast
        {
            get { return _roast; }
            set { _roast = value; }
        }
        private bool _isGrinded;

        public bool IsGrinded
        {
            get { return _isGrinded; }
            set { _isGrinded = value; }
        }

        private string _brand;

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

    }

    class CoffieGrinder
    {

    }

}
