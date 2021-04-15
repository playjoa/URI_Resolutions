using System;
using Inputs;
using Geometria;

namespace URI_1012_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor_A, valor_B, valor_C;

            LeitorDePontos leituraPontos = new LeitorDePontos(InputSystem.ReadLine());

            valor_A = leituraPontos.LerPontoA();
            valor_B = leituraPontos.LerPontoB();
            valor_C = leituraPontos.LerPontoC();

            ObjetoGeometrico triangulo = new Triangulo(valor_A, valor_C);
            ObjetoGeometrico circulo = new Circulo(valor_C);
            ObjetoGeometrico trapezio = new Trapezio(valor_A, valor_B, valor_C);
            ObjetoGeometrico quadrado = new Quadrado(valor_B);
            ObjetoGeometrico retangulo = new Retangulo(valor_A, valor_B);

            triangulo.DebugArea();
            circulo.DebugArea();
            trapezio.DebugArea();
            quadrado.DebugArea();
            retangulo.DebugArea();

            Console.ReadKey();
        }        
    }
}
