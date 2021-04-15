namespace Inputs.Readers
{
    public class XandY_Reader
    {
        string[] lista_Leitura;

        public XandY_Reader(string linha_Lida)
        {
            this.lista_Leitura = linha_Lida.Split(' ');
        }

        public void LerOutraLinha(string linha_Lida)
        {
            this.lista_Leitura = linha_Lida.Split(' ');
        }

        double RetornarDoubleDaListaLida(int idNumero)
        {
            if (idNumero >= lista_Leitura.Length)
                return 0;

            return double.Parse(lista_Leitura[idNumero]);
        }

        public double LerX()
        {
            return RetornarDoubleDaListaLida(0);
        }

        public double LerY()
        {
            return RetornarDoubleDaListaLida(1);
        }

        public double LerX(string linhaDesejada)
        {
            LerOutraLinha(linhaDesejada);
            return RetornarDoubleDaListaLida(0);
        }

        public double LerY(string linhaDesejada)
        {
            LerOutraLinha(linhaDesejada);
            return RetornarDoubleDaListaLida(1);
        }
    }
}