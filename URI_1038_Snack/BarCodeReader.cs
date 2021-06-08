using System;

namespace Barcodes
{
    public class BarCodeReader
    {
        private string[] _individualNumbersRead;

        public BarCodeReader(string lineRead)
        {
            this._individualNumbersRead = lineRead.Split(' ');
        }

        int ReturnIntFromNumbersRead(int idNumber)
        {
            if (idNumber >= _individualNumbersRead.Length)
                return 0;

            return Convert.ToInt32(_individualNumbersRead[idNumber]);
        }

        public int ReadNumberInBarCode(int numberIndex)
        {
            return ReturnIntFromNumbersRead(numberIndex);
        }
    }
}