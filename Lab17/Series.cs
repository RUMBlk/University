using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    abstract class Series
    {
        protected double a1;
        protected double a2;

        public abstract double get_at(int n);
        public abstract double sum(int n);
    }
}
