using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Linear: Series
    {
        public Linear(double a1, double a2)
        {
            this.a1 = a1;
            this.a2 = a2;
        }

        public override double get_at(int n)
        {
            double d = a2 - a1;
            return a1+(n-1)*d;
        }
        public override double sum(int n)
        {
            double d = a2 - a1;
            return ((double)n / 2) * (2 * a1 + (n - 1) * d);
        }
    }
}
