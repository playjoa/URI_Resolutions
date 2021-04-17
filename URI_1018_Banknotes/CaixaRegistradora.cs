using System;
using System.Collections.Generic;

namespace Money.CashRegister
{
    public class CaixaRegistradora
    {
        private Dictionary<int, NotaReal> notasDisponiveis;
        private int[] valoresPossiveis = NotasPossiveis.valoresNotas;

        public CaixaRegistradora()
        {
            CriarNotas();
        }

        public void ResgatarDinheiro(int qtdParaResgatar)
        {
            int resto = qtdParaResgatar;

            Console.WriteLine(qtdParaResgatar);

            for (int i = valoresPossiveis.Length - 1; i >= 0; i--)
            {
                int valorAtual = valoresPossiveis[i];
                NotaReal notaAtual = notasDisponiveis[valorAtual];

                notaAtual.ReceberQtd(resto / valorAtual);
                resto %= valoresPossiveis[i];
            }
        }

        void PrintarTransferencia()
        {
            for (int i = valoresPossiveis.Length - 1; i >= 0; i--)
            {
                int valorAtual = valoresPossiveis[i];

                notasDisponiveis[valorAtual].PrintarNota();
            }
        }

        void CriarNotas()
        {
            notasDisponiveis = new Dictionary<int, NotaReal>();
            valoresPossiveis = NotasPossiveis.valoresNotas;

            foreach (int valorAtual in valoresPossiveis)
            {
                notasDisponiveis.Add(valorAtual, new NotaReal(valorAtual));
            }
        }
    }
}