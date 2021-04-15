using System;

public class ComputadorDeBordo
{
    private int distanciaPercorrida;
    private double gasolinaGasta;

    public ComputadorDeBordo(int distanciaPercorrida, double gasolinaGasta)
    {
        this.distanciaPercorrida = distanciaPercorrida;
        this.gasolinaGasta = gasolinaGasta;
    }

    public double ConsumoAtual()
    {
        return distanciaPercorrida / gasolinaGasta;
    }

    public void DebugConsumo()
    {
        Console.WriteLine(ConsumoAtual().ToString("0.000") + " km/l");
    }
}