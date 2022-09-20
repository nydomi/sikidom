using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace sikidom
{
     internal class Kor
    {
        double sugar;
        double atmero;

        public double Sugar 
        {
            get => sugar;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException($"{value} érték nem megengedett a kör sugarának");
                }
                else
                {
                    sugar = value;
                }
            }
        }
        public double Atmero { get => 2*sugar; }

        public Kor(double sugar)
        {
            Sugar = sugar;
        }

        public double Kerulet()
        {
            return sugar * 2 * Math.PI;
        }
        public double Terulet()
        {
            return Math.Pow(sugar,2) * Math.PI; 
        }
    }
}
