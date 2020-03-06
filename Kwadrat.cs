using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioButtonApp
{
    class Kwadrat : Prostokat
    {
        

        public Kwadrat(double bok1)
        {
            Bok1 = bok1;
            Bok2 = bok1;
        }

        public override double LiczPole()
        {
            return Math.Pow(Bok1, 2);
        }
    }
}
