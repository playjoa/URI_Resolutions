using System;
using System.Collections.Generic;

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

    public static class LeitorDeNumeros
    {
        public static List<int> DevolverLista(string leitura)
        {
            List<int> listaNumerosLidos = new List<int>();
            string[] listaStringDeNumeros = leitura.Split(' ');
            int idNumeroAtual = 0;

            foreach(string numeroString in listaStringDeNumeros)
            {
                listaNumerosLidos.Add(RetornarIntDeListaString(listaStringDeNumeros, idNumeroAtual));
                idNumeroAtual++;
            }

            return listaNumerosLidos;
        }

        static int RetornarIntDeListaString(string[] leitura, int idNumero)
        {
            if (idNumero >= leitura.Length)
                return 0;

            return Convert.ToInt32(leitura[idNumero]);
        }
    }
}