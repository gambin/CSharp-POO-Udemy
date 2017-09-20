using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Fixacao01
{
    class Conta
    {
        private int numero;
        public string nome { get; private set; }
        public double valor { get; private set; }
        public string testeValor;

        public Conta(string nome, int numero, double valor)
        {
            this.nome = nome;
            this.numero = numero;
            this.valor = valor;
        }
        public Conta(string nome, int numero)
        {
            this.nome = nome;
            this.numero = numero;
            
        }
        public Conta(string tValor)
        {
            this.testeValor = tValor;
        }

        public override string ToString()
        {
            // return base.ToString();
            return "Conta " + this.numero + ", Titular: " + this.nome + ", Saldo:$ " + this.valor.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void realizaDeposito(double deposito)
        {
            this.valor += deposito;
        }
        public void realizaSaque(double saque)
        {
            this.valor -= (saque + 5);
        }
    }



}
