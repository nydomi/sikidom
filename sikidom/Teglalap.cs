using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sikidom
{
    internal class Teglalap
    {
        double aOldal;
        double bOldal;

        public double AOldal
        {
            get => aOldal;
            set 
            {
                if (value<=0)
                {
                    throw new ArgumentOutOfRangeException($"Az A oldal {value} értéke nem megfelelő!");
                }
                else
                {
                    aOldal = value;
                }
            } 
        }
        public double BOldal
        {
            get => bOldal;
            set 
            {
                if (value<=0)
                {
                    throw new ArgumentOutOfRangeException($"A B oldal {value} értéke nem megfelelő!");
                }
                else
                {
                    bOldal = value;
                }
            } 
        }

        public double Kerulet()
        {
            return 2 * (aOldal + bOldal);
        }
        public double Terulet()
        {
            return aOldal * bOldal;
        }
    }
}
