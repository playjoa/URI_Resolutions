using System;

namespace Geometria
{
    public class Triangulo : ObjetoGeometrico
    {
        private double baseTriangulo;
        private double alturaTriangulo;

        public Triangulo(double baseTriangulo, double alturaTriangulo)
        {
            nomeObjeto = "TRIANGULO";

            this.baseTriangulo = baseTriangulo;
            this.alturaTriangulo = alturaTriangulo;
        }

        public override double CalcularArea()
        {
            return (baseTriangulo * alturaTriangulo) / 2;
        }
    }
}