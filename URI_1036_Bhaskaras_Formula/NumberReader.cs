namespace Input.NumberReader
{
    public class NumberReader
    {
        string[] individualNumbersRead;

        public NumberReader(string linha_Lida)
        {
            this.individualNumbersRead = linha_Lida.Split(' ');
        }

        double ReturnFromNumbersRead(int idNumber)
        {
            if (idNumber >= individualNumbersRead.Length)
                return 0;

            return double.Parse(individualNumbersRead[idNumber]);
        }

        public double Read_A()
        {
            return ReturnFromNumbersRead(0);
        }

        public double Read_B()
        {
            return ReturnFromNumbersRead(1);
        }

        public double Read_C()
        {
            return ReturnFromNumbersRead(2);
        }
    }
}
