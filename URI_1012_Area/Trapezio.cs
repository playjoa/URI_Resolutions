namespace Geometria
{
    public class Trapezio : ObjetoGeometrico
    {
        private double baseMaiorTrapezio, baseMenorTrapezio, alturaTrapezio;

        public Trapezio(double baseMaiorTrapezio, double baseMenorTrapezio, double alturaTrapezio)
        {
            nomeObjeto = "TRAPEZIO";

            this.baseMaiorTrapezio = baseMaiorTrapezio;
            this.baseMenorTrapezio = baseMenorTrapezio;
            this.alturaTrapezio = alturaTrapezio;
        }

        public override double CalcularArea()
        {
            return (baseMaiorTrapezio + baseMenorTrapezio) * alturaTrapezio / 2;
        }
    }
}