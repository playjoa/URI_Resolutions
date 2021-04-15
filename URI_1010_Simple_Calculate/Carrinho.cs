using System;
using System.Collections.Generic;

namespace LojaSystem.Caixa
{
    public class Carrinho
    {
        List<ProdutoNoCarrinho> produtosCarrinho;

        public Carrinho()
        {
            List<ProdutoNoCarrinho> produtosCarrinho = new List<ProdutoNoCarrinho>();
        }

        public void ReceberProduto(ProdutoNoCarrinho novoProduto)
        {
            produtosCarrinho.Add(novoProduto);
        }

        public void RemoverProdutoDoCarrinho(ProdutoNoCarrinho novoProduto)
        {
            try
            {
                produtosCarrinho.Remove(novoProduto);
            }
            catch { Console.WriteLine("Produto ja removido!"); }
        }

        public void ReceberListaProdutos(List<ProdutoNoCarrinho> produtosCarrinho)
        {
            this.produtosCarrinho = produtosCarrinho;
        }

        public double ValorTotalCarrinho()
        {
            double totalValor = 0;

            for (int i = 0; i < produtosCarrinho.Count; i++)
            {
                totalValor += produtosCarrinho[i].PrecoTotalProdutoCarrinho();
            }

            return totalValor;
        }

        public void ListarTotalAPagar()
        {
            Console.WriteLine("VALOR A PAGAR: R$ " + ValorTotalCarrinho().ToString("0.00"));
        }
    }
}