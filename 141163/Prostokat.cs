using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141163
{
    class Prostokat
    {
        private double bok1;
        private double bok2;

        public Prostokat(double bok1, double bok2)
        {
            this.bok1 = bok1;
            this.bok2 = bok2;
        }

        public double Pole()
        {
            return bok1 * bok2;
        }

        public double Obwod()
        {
            return 2 * bok1 + 2 * bok2;
        }
    }
}
