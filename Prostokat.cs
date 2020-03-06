using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioButtonApp
{
    class Prostokat : IAmFlatFigure
    {

        protected double Bok1;
        protected double Bok2;

        public Prostokat(double bok1, double bok2)
        {
            this.Bok1 = bok1;
            this.Bok2 = bok2;
        }

        public Prostokat()
        { }

        public virtual double LiczObwod()
        {
            return 2*(this.Bok1 + this.Bok2);
        }

        public virtual double LiczPole()
        {
            return this.Bok1 * this.Bok2;
        }
    }
}