using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Fix04a
{
    class Funcionario
    {
        public int cpf { get; private set; }
        public string nome { get; private set;  }
        public double salario { get; private set; }

        public Funcionario(int cpf, string nome, double salario)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.salario = salario;
        }

        public override string ToString()
        {
            // return base.ToString();
            return cpf + ", " + nome + ", " + salario.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void aumentaSalario(double vAum)
        {
            salario = salario + salario * vAum / 100;
        }
    }
}
