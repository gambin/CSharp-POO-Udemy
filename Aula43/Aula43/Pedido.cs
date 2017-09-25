using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula43
{
    class Pedido
    {
        public int codigo { get; set; }
        public DateTime data { get; set; }
        public List<ItemPedido> itens { get; set; }

        public Pedido(int codigo, DateTime data)
        {
            this.codigo = codigo;
            this.data = data;
            this.itens = new List<ItemPedido>();
        }

        public double ValorTotal()
        {
            double soma = 0;
            for (int i = 0; i < itens.Count; i++)
            {
                soma += itens[0].SubTotal();
            }
            return soma;
        }

        public override string ToString()
        {
            // return base.ToString();
            string s = "Pedido: " + codigo + ", data: " + data.ToString("dd/MM/yyyy") + "\n" + "Itens: " + "\n";
            for (int i = 0; i < itens.Count; i++)
            {
                s += itens[i] + "\n";
            }
            s += "Total do Pedido: " + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
            return s;
        }
    }
}
