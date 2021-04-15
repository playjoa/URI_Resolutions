using System;

namespace Geometria
{
    public class Quadrado : ObjetoGeometrico
    {
        private double ladoQuadrado;

        public Quadrado(double ladoQuadrado)
        {
            nomeObjeto = "QUADRADO";

            this.ladoQuadrado = ladoQuadrado;
        }

        public override double CalcularArea()
        {
            return Math.Pow(ladoQuadrado, 2);
        }
    }
}