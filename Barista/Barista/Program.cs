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

        public string _originrigin 
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
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


    }

}
