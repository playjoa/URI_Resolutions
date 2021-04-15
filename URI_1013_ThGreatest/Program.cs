using System;
using Inputs;
using System.Collections.Generic;

namespace URI_1013_ThGreatest
{
    class Program
    {
        static void Main(string[] args)
        {
            string leituraLinha = InputSystem.ReadLine();

            ListaNumeros listaDeNumeros = new ListaNumeros(LeitorDeNumeros.DevolverLista(leituraLinha));
            
            listaDeNumeros.DebugMaiorLista();

            Console.ReadKey();
        }

        public class ListaNumeros
        {
            private List<int> listaNumeros;
            public ListaNumeros(List<int> listaNumeros)
            {
                this.listaNumeros = listaNumeros;

                listaNumeros.Sort();
            }

            public int MaiorDaLista()
            {
                int idMaiorNumero = listaNumeros.Count - 1;

                return listaNumeros[idMaiorNumero];
            }

            public int MenorDaLista()
            {
                const int idPrimeiroDaLista = 0;
                return listaNumeros[idPrimeiroDaLista];
            }

            public void DebugMaiorLista()
            {
                Console.WriteLine(MaiorDaLista() + " eh o maior");
            }
        }
    }
}
