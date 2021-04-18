using System;

namespace Money.Coins
{
    public static class MoedasPossiveis
    {
        public static int[] valoresMoedas = new int[] { 1, 5, 10, 25, 50, 100 };
    }

    public class MoedaCentavo : Moeda
    {
        public MoedaCentavo(int valorMoeda)
        {
            this.valorMoeda = valorMoeda;
        }

        public void ReceberQtd(int qtdMoedas)
        {
            this.qtdMoedas = qtdMoedas;
            PrintarMoeda();
        }
    }

    public abstract class Moeda
    {
        protected int qtdMoedas;
        protected float valorMoeda;

        public void PrintarMoeda()
        {
            Console.WriteLine(qtdMoedas + " moeda(s) de R$ " + (valorMoeda / 100).ToString("0.00"));
        }
    }
}