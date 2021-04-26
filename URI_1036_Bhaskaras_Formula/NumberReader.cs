namespace Input.NumberReader
{
    public class NumberReader
    {
        string[] individualNumbersRead;

        public NumberReader(string linha_Lida)
        {
            this.individualNumbersRead = linha_Lida.Split(' ');
        }

        double ReturnIntFromNumbersRead(int idNumber)
        {
            if (idNumber >= individualNumbersRead.Length)
                return 0;

            return double.Parse(individualNumbersRead[idNumber]);
        }

        public double Read_A()
        {
            return ReturnIntFromNumbersRead(0);
        }

        public double Read_B()
        {
            return ReturnIntFromNumbersRead(1);
        }

        public double Read_C()
        {
            return ReturnIntFromNumbersRead(2);
        }
    }
}