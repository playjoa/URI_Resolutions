using System;

namespace Navegation
{
    public class Trip
    {
        private int horas_Trip;
        private int velocidadeMedia_Trip;

        public Trip(int horas_Trip, int velocidadeMedia_Trip)
        {
            this.horas_Trip = horas_Trip;
            this.velocidadeMedia_Trip = velocidadeMedia_Trip;
        }

        public int Horas_Trip { get => horas_Trip; }
        public int VelocidadeMedia_Trip { get => velocidadeMedia_Trip; }

        public double DistanciaTrip()
        {
            return velocidadeMedia_Trip * horas_Trip;
        }
    }
}