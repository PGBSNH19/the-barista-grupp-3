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
            var smallEspresso = new Espresso().AddBean(2,"asd").AddWater(6);
        }
    }


    interface IEspresso
    {
        void Brew();
        IEspresso AddWater(int amount);
        IEspresso AddBean(int amount,string sort);
        void AddToCup(int volume);
        
    }


    class Espresso :IEspresso
    {
            
        public int WaterAmount;
        public int BeanAMount;
        public string Sort;

        public IEspresso AddBean(int amount, string sort)
        {
            //här hämtar vi ur en lista med bönor

            BeanAMount = amount;
            Sort = sort;

            return this;
        }

        public void AddToCup(int volume)
        {
            throw new NotImplementedException();
        }

        public IEspresso AddWater(int amount)
        {
            WaterAmount = amount;
            return this;
        }

        public void Brew()
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
        public Bean(string beanType)
        {
            BeanType = beanType;
        }
        public string BeanType { get; set; }
        public int AmountInG { get; set; }

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
