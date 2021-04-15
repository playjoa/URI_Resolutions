using System;

namespace Geometria
{
    public class Retangulo : ObjetoGeometrico
    {
        private double baseRetangulo, alturaRetangulo;

        public Retangulo(double baseRetangulo, double alturaRetangulo)
        {
            nomeObjeto = "RETANGULO";

            this.baseRetangulo = baseRetangulo;
            this.alturaRetangulo = alturaRetangulo;
        }

        public override double CalcularArea()
        {
            return baseRetangulo * alturaRetangulo;
        }
    }
}