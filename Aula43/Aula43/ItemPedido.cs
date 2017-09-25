using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula43
{
    class ItemPedido
    {
        public int quantidade { get; set; }
        public double porcentagemDesconto { get; set; }
        public Produto produto { get; set; }
        public Pedido pedido { get; set; }

        public ItemPedido(int quantidade, double porcentagemDesconto, Produto produto, Pedido pedido)
        {
            this.quantidade = quantidade;
            this.porcentagemDesconto = porcentagemDesconto;
            this.produto = produto;
            this.pedido = pedido;
        }

        public override string ToString()
        {
            return produto.descricao + ", preço: " + produto.preco.ToString("F2", CultureInfo.InvariantCulture) + ", Qte: " + quantidade + ", Desconto: " + porcentagemDesconto.ToString("F2", CultureInfo.InvariantCulture) + "%, Subtotal: " + SubTotal().ToString("F2", CultureInfo.InvariantCulture); 

        }

        public double SubTotal()
        {
            double desconto = produto.preco * (porcentagemDesconto / 100);
            return (produto.preco - desconto) * quantidade;
        }
    }
}
