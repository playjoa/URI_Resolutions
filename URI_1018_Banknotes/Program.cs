using System;
using Money.CashRegister;
using Inputs;

namespace URI_1018_Banknotes
{
    class Program
    {
        static void Main(string[] args)
        {
            CaixaRegistradora caixa = new CaixaRegistradora();

            int qtdParaResgatar = InputSystem.ReadIntNumber();

            caixa.ResgatarDinheiro(qtdParaResgatar);

            Console.ReadKey();
        }
    }
}
