using System;

namespace Geometria
{
    public class Circulo : ObjetoGeometrico
    {
        private const double piNumber = 3.14159;

        private double raioCirculo;

        public Circulo(double raioCirculo)
        {
            nomeObjeto = "CIRCULO";

            this.raioCirculo = raioCirculo;
        }

        public override double CalcularArea()
        {
            return piNumber * Math.Pow(raioCirculo, 2);
        }
    }
}