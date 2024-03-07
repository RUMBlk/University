using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace OOP16
{
    internal class Complex
    {
        private double x;
        private double y;

        public Complex(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Complex(string str)
        {
            string pattern = @"([-+]?\d*\.?\d+)([-+]?\d*\.?\d+)i";
            Match match = Regex.Match(str, pattern);
            if (match.Success && match.Groups.Count == 3)
            {
                x = Convert.ToDouble(match.Groups[1].Value);
                y = Convert.ToDouble(match.Groups[2].Value);
            }
        }

        public Complex(Complex complex)
        {
            x = complex.x;
            y = complex.y;
        }


        public void X(double x) { this.x = x; }
        public double X() { return this.x; }
        public void Y(double y) {  this.y = y; }
        public double Y() { return this.y; }

        public string Get()
        {
            string s = String.Empty;
            if(y >= 0)
            {
                s = String.Format("{0}+{1}i", x, y);
            }
            else
            {
                s = String.Format("{0}{1}i", x, y);
            }
            return s;
        }

        public static Complex operator +(Complex a, Complex b) { return new Complex(a.X() + b.X(), a.Y() + b.Y()); }
        public static Complex operator -(Complex a, Complex b) { return new Complex(a.X() - b.X(), a.Y() - b.Y()); }
        public static Complex operator *(Complex a, Complex b) { return new Complex(a.X() * b.X() - a.Y() * b.Y(), a.X()*b.Y() + b.X() * a.Y()); }
        public static Complex operator /(Complex a, Complex b) 
        {
            return new Complex(
                (a.X() * b.X() + a.Y() * b.Y()) / Math.Pow(b.X(), 2) + Math.Pow(b.Y(), 2),
                (a.Y() * b.X() - a.X() * b.Y()) / Math.Pow(b.X(), 2) + Math.Pow(b.Y(), 2)
            );
        }
        public double Modulo()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
        public Complex Pow(int power)
        {
            Complex pow = new Complex(this);
            for (int i = 1; i < power; i++)
            {
                pow = pow * this;
            }
            return pow;
        }
    }
}
