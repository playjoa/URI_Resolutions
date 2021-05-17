using System;
using Inputs;
using OrderSystem;

namespace URI_2702_Hard_Choice
{
    class Program
    {
        static void Main(string[] args)
        {
            IntNumberReader qtdDeComidas = new IntNumberReader(InputSystem.ReadLine);
            IntNumberReader qtdDePedidos = new IntNumberReader(InputSystem.ReadLine);

            Item chickenItem = new Item(qtdDeComidas.Read_Number(0));
            Item beefItem = new Item(qtdDeComidas.Read_Number(1));
            Item pastaItem = new Item(qtdDeComidas.Read_Number(2));

            ItemOrder chickenOrder = new ItemOrder(chickenItem, qtdDePedidos.Read_Number(0));
            ItemOrder beefOrder = new ItemOrder(beefItem, qtdDePedidos.Read_Number(1));
            ItemOrder pastanOrder = new ItemOrder(pastaItem, qtdDePedidos.Read_Number(2));

            Order planeOrder = new Order();

            planeOrder.AddItemOrder(chickenOrder);
            planeOrder.AddItemOrder(beefOrder);
            planeOrder.AddItemOrder(pastanOrder);

            planeOrder.PrintTotalWithNoMeal();

            Console.ReadKey();
        }
    }
}
