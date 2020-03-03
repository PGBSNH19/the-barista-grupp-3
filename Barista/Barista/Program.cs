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
            var barista = new Barista();
            var coffeeMaker = new CoffeeMaker();
            var bean = new Bean();
            var cup = new Cup();
            var smallEspresso=new Espresso().AddWater( smallEspresso, 5).
        }
    }


    interface IEspresso
    {
        void Brew();
        void AddWater(Espresso e, int amount);
        void AddBeans(Espresso e, int amount,string sort);
        void AddToCup(int volume);
        void GrindBeans(string cupVolume, string brand);
        
    }


    class Espresso :IEspresso
    {

        public int WaterAmount;
        public int BeanAMount;
        public string Sort;

        public void AddBeans(Espresso e, int amount, string sort)
        {
            e.BeanAMount = amount;
            e.Sort = sort;
            
        }

        public void AddToCup(int volume)
        {
            throw new NotImplementedException();
        }

        public void AddWater(Espresso e, int amount)
        {
            e.WaterAmount = amount;
        }

        public void Brew()
        {
            throw new NotImplementedException();
        }

        public void GrindBeans(string cupVolume, string brand)
        {
            throw new NotImplementedException();
        }
    }


    class CoffeeMaker
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

    class Cup
    {
        private int _volumeInCl;

        public int VolumeInCl
        {
            get { return _volumeInCl; }
            set { _volumeInCl = value; }
        }
        private bool _isTakeAway;

        public bool IsTakeAway
        {
            get { return _isTakeAway; }
            set { _isTakeAway = value; }
        }


    }

}
