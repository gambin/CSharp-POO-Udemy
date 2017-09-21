using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula39
{
    abstract class Figura
    {
        public string cor { get; private set; }

        public Figura(string cor)
        {
            this.cor = cor;
        }
        public abstract double area();

        public override string ToString()
        {
            // return base.ToString();
            return area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
