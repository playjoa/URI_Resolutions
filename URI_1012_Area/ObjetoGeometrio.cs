using System;

namespace Geometria
{
    public abstract class ObjetoGeometrico
    {
        protected string nomeObjeto;
        public abstract double CalcularArea();
        public virtual string ListarArea()
        {
            return CalcularArea().ToString("0.000");
        }
        public virtual void DebugArea()
        {
            Console.WriteLine(nomeObjeto + ": " + ListarArea());
        }
    }
}