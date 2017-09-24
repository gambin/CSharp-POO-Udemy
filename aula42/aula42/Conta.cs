using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula42
{
    class Conta
    {
        public int numero { get; set; }
        public string titular { get; set; }
        public double saldo { get; set; }
        public double limiteDeSaque { get; set; }

        public Conta(int numero, string titular, double saldo, double limiteDeSaque)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = 0.0;
            this.limiteDeSaque = limiteDeSaque;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (saldo < valor)
            {
                throw new Exception("Não há saldo suficiente! Operação cancelada");
            }

            if (valor > limiteDeSaque)
            {
                throw new Exception("Valor é superior ao limite diário! Operação cancelada");
            }
            saldo -= valor;
        }
    }
}
