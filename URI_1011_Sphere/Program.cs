using System;
using Geometry3D;

namespace Exercicio_Geometria
{
    class Program
    {
        static void Main(string[] args)
        {
            double raioLido;

            raioLido = InputSystem.ReadDoubleNumber();

            Sphere sphere = new Sphere(raioLido);

            Console.WriteLine(sphere.DebugVolume());

            Console.ReadKey();
        }
    } 
}
