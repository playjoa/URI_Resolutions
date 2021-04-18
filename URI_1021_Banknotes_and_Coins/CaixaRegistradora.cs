using System;
using System.Collections.Generic;
using Money.Cash;
using Money.Coins;

namespace Money
{
    public class CaixaRegistradora
    {
        private Dictionary<int, NotaReal> notasDisponiveis;
        private Dictionary<int, MoedaCentavo> moedasDisponiveis;
        private int[] valoresNotasPossiveis = NotasPossiveis.valoresNotas;
        private int[] valoresMoedasPossiveis = MoedasPossiveis.valoresMoedas;

        public CaixaRegistradora()
        {
            CriarNotas_Moedas();
        }

        public void ResgatarDinheiro(double qtdParaResgatar)
        {
            double resto = qtdParaResgatar;

            resto = ResgatarNotas(qtdParaResgatar);
            
            ResgatarMoedas(resto);
        }

        double ResgatarNotas(double qtdNotas)
        {
            Console.WriteLine("NOTAS:");

            for (int i = valoresNotasPossiveis.Length - 1; i >= 0; i--)
            {
                int valorAtual = valoresNotasPossiveis[i];
                NotaReal notaAtual = notasDisponiveis[valorAtual];

                notaAtual.ReceberQtd((int)qtdNotas / valorAtual);
                qtdNotas %= valoresNotasPossiveis[i];
            }

            return qtdNotas;
        }

        void ResgatarMoedas(double qtdMoedasRestantes)
        {
            Console.WriteLine("MOEDAS:");

            qtdMoedasRestantes = (int)(qtdMoedasRestantes*100);

            for (int i = valoresMoedasPossiveis.Length - 1; i >= 0; i--)
            {
                 int valorAtual = valoresMoedasPossiveis[i];
                MoedaCentavo moedaAtual = moedasDisponiveis[valorAtual];

                moedaAtual.ReceberQtd((int)qtdMoedasRestantes / valorAtual);
                qtdMoedasRestantes %= valoresMoedasPossiveis[i];
            }
        }

        void PrintarTransferencia()
        {
            for (int i = valoresNotasPossiveis.Length - 1; i >= 0; i--)
            {
                int valorAtual = valoresNotasPossiveis[i];

                notasDisponiveis[valorAtual].PrintarNota();
            }
        }

        void CriarNotas_Moedas()
        {
            notasDisponiveis = new Dictionary<int, NotaReal>();
            moedasDisponiveis = new Dictionary<int, MoedaCentavo>();

            foreach (int notaAtual in valoresNotasPossiveis)
                notasDisponiveis.Add(notaAtual, new NotaReal(notaAtual));

            foreach (int moedaAtual in valoresMoedasPossiveis)
                moedasDisponiveis.Add(moedaAtual, new MoedaCentavo(moedaAtual));
        }
    }
}
