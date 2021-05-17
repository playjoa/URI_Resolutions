using System;

namespace Inputs
{
    public class IntNumberReader
    {
        string[] individualNumbersRead;

        public IntNumberReader(string linha_Lida)
        {
            this.individualNumbersRead = linha_Lida.Split(' ');
        }

        int ReturnIntFromNumbersRead(int idNumber)
        {
            if (idNumber >= individualNumbersRead.Length || idNumber < 0)
                return 0;

            return Convert.ToInt32(individualNumbersRead[idNumber]);
        }

        public int Read_Number(int numberToRead)
        {
            return ReturnIntFromNumbersRead(numberToRead);
        }
    }
}