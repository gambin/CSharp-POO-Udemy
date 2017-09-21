using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula39
{
    class Triangulo : Figura
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public Triangulo(double a, double b, double c, string cor) : base(cor)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
