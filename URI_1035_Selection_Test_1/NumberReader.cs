using System;

namespace Input.Numbers
{
    public class NumberReader
    {
        string[] individualNumbersRead;

        public NumberReader(string linha_Lida)
        {
            this.individualNumbersRead = linha_Lida.Split(' ');
        }

        int ReturnIntFromNumbersRead(int idNumber)
        {
            if (idNumber >= individualNumbersRead.Length)
                return 0;

            return Convert.ToInt32(individualNumbersRead[idNumber]);
        }

        public int Read_A()
        {
            return ReturnIntFromNumbersRead(0);
        }

        public int Read_B()
        {
            return ReturnIntFromNumbersRead(1);
        }

        public int Read_C()
        {
            return ReturnIntFromNumbersRead(2);
        }

        public int Read_D()
        {
            return ReturnIntFromNumbersRead(3);
        }
    }
}