
using System;

namespace Inputs
{
    public static class InputSystem
    {
        public static int ReadIntNumber()
        {
            string inputString = Console.ReadLine();
            return Convert.ToInt32(inputString);
        }

        public static string ReadLine()
        {
            return Console.ReadLine();
        }

        public static double ReadDoubleNumber()
        {
            string inputString = Console.ReadLine();
            return double.Parse(inputString);
        }
    }

    public class LeitorDePontos
    {
        private string leituraCodigo;

        public LeitorDePontos(string leituraCodigo)
        {
            this.leituraCodigo = leituraCodigo;
        }

        public double LerPontoA()
        {
            return Convert.ToDouble(RetornarPonto(leituraCodigo, 0));
        }

        public double LerPontoB()
        {
            return Convert.ToDouble(RetornarPonto(leituraCodigo, 1));
        }

        public double LerPontoC()
        {
            return Convert.ToDouble(RetornarPonto(leituraCodigo, 2));
        }

        static string RetornarPonto(string leituraCodigo, int idPonto)
        {
            string[] leitura = leituraCodigo.Split(' ');

            if (idPonto >= leitura.Length)
                return "0";

            return leitura[idPonto];
        }
    }
}