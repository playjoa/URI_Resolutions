public class Car
{
    private int velocidadeAtual;
    public Car(int velocidadeAtual)
    {
        this.velocidadeAtual = velocidadeAtual;
    }

    public int VelocidadeAtual { get => velocidadeAtual; set => velocidadeAtual = value; }
}