using System;
using Inputs;
using Money;

namespace URI_1021_Banknotes_and_Coins
{
    class Program
    {
        static void Main(string[] args)
        {
           double valor_ParaResgatar = InputSystem.ReadDoubleNumber();

           CaixaRegistradora caixa = new CaixaRegistradora();

           caixa.ResgatarDinheiro(valor_ParaResgatar);

           Console.ReadKey();
        }
    }
}