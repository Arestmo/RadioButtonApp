using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioButtonApp
{
    class Kwadrat
    {
        private double Bok;

        public Kwadrat(double bok)
        {
            this.Bok = bok;
        }

        public double Pole()
        {
            return Math.Pow(this.Bok, 2);
        }

        public double Obwod()
        {
            return this.Bok + this.Bok;
        }
    }
}
