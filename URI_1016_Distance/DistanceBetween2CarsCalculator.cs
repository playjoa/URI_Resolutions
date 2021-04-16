using System;

public class DistanceBetween2CarsCalculator
{
    private Car carroMaisRapido, carroMaisLento;
    private int distanciaParaUltrapassar;

    public DistanceBetween2CarsCalculator(Car carroMaisRapido, Car carroMaisLento)
    {
        this.carroMaisRapido = carroMaisRapido;
        this.carroMaisLento = carroMaisLento;
    }

    public void CalcularTempoUltrapassagem(int distanciaParaUltrapassar)
    {
        this.distanciaParaUltrapassar = distanciaParaUltrapassar;

        CalcularTempoParaUltrapassasr();
    }


    void CalcularTempoParaUltrapassasr()
    {
        if (carroMaisLento.VelocidadeAtual == carroMaisRapido.VelocidadeAtual)
        {
            Console.WriteLine("Carros com mesmas velocidades");
            return;
        }

        double tempoCalculado = (distanciaParaUltrapassar) / ((carroMaisRapido.VelocidadeAtual / 60f) - (carroMaisLento.VelocidadeAtual / 60f));

        DebugTempoParaUltrapassar(tempoCalculado);
    }

    void DebugTempoParaUltrapassar(double qtdMinutos)
    {
        Console.WriteLine(qtdMinutos.ToString("0") + " minutos");
    }
}