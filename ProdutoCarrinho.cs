
namespace LojaSystem.Caixa
{
    public class ProdutoNoCarrinho
    {
        private int idProduto;
        private int qtdProdutoCarrinho;
        private double precoProduto;

        public ProdutoNoCarrinho(string leituraCodigo)
        {
            this.idProduto = ProductScanner.LerCodigoProduto(leituraCodigo);
            this.qtdProdutoCarrinho = ProductScanner.LerQtdProduto(leituraCodigo);
            this.precoProduto = ProductScanner.LerPrecoProduto(leituraCodigo);
        }

        public double PrecoTotalProdutoCarrinho()
        {
            return qtdProdutoCarrinho * precoProduto;
        }
    }
}