using System;

namespace LojaSystem
{
    public static class Scanner
    {
        public static int LerCodigoProduto(string leituraCodigo)
        {
            return Convert.ToInt32(RetornarValorLeitura(leituraCodigo, 0));
        }

        public static int LerQtdProduto(string leituraCodigo)
        {
            return Convert.ToInt32(RetornarValorLeitura(leituraCodigo, 1));
        }

        public static double LerPrecoProduto(string leituraCodigo)
        {
            return Convert.ToDouble(RetornarValorLeitura(leituraCodigo, 2));
        }

        static string RetornarValorLeitura(string leituraCodigo, int idLeitura)
        {
            string[] leitura = leituraCodigo.Split(' ');

            if (idLeitura >= leitura.Length)
                return "0";

            return leitura[idLeitura];
        }
    }
}