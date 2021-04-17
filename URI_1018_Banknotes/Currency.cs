using System;

namespace Money
{
    public static class NotasPossiveis
    {
        public static int[] valoresNotas = new int[] { 1, 2, 5, 10, 20, 50, 100 };
    }

    public class NotaReal : Nota
    {
        public NotaReal(int valorNota)
        {
            this.valorNota = valorNota;
        }

        public void ReceberQtd(int qtdNota)
        {
            this.qtdNota = qtdNota;
            PrintarNota();
        }
    }

    public abstract class Nota
    {
        protected int valorNota, qtdNota;

        public void PrintarNota()
        {
            Console.WriteLine(qtdNota + " nota(s) de R$ " + valorNota.ToString("0.00").Replace('.', ','));
        }
    }
}