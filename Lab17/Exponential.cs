using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Exponential: Series
    {
        public Exponential(double a1, double a2)
        {
            this.a1 = a1;
            this.a2 = a2;
        }
        public override double get_at(int n)
        {
            double r = a2 / a1;
            return a1 * Math.Pow(r, n - 1);
        }
        public override double sum(int n)
        {
            double r = a2 / a1;
            return (a1 * (Math.Pow(r, n)-1))/(r-1);
        }
    }
}
