
using System;
using System.Collections.Generic;
using Inputs;
using LojaSystem.Caixa;

public class Program
{
    public static void Main(string[] args)
    {
        Carrinho carrinhoComprasAtual = new Carrinho();
        
        List<ProdutoNoCarrinho> produtosCarrinho = LerCodigosParaOCarrinho(2);

        carrinhoComprasAtual.ReceberListaProdutos(produtosCarrinho);
        carrinhoComprasAtual.ListarTotalAPagar();

        Console.ReadKey();
    }

    public static List<ProdutoNoCarrinho> LerCodigosParaOCarrinho(int qtdProdutosParaLer)
    {
        List<ProdutoNoCarrinho> produtosCarrinho = new List<ProdutoNoCarrinho>();

        for (int i = 0; i < qtdProdutosParaLer; i++)
        {
            string leituraCodigoBarras = InputSystem.ReadLine();

            ProdutoNoCarrinho produtoSendoLido = new ProdutoNoCarrinho(leituraCodigoBarras);

            produtosCarrinho.Add(produtoSendoLido);
        }

        return produtosCarrinho;
    }
}

